using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace SyncManager
{
    public partial class SyncForm : Form
    {
        public string univFilter = "~$;.DS_;thumbs.db;slidethumbnail.jpg;";
        private int[] ipBounds { get; set; } //speaker ready start, end, breakout start, end
        public int numComps { get; set; }
        public ClientComputer[] clientComps { get; set; }
        private SetupForm myParent { get; set; }
        private bool[] runningSyncs { get; set; }
        public int type { get; set; }
        private int lowBottomBound { get; set; }
        private int lowTopBound { get; set; }
        private int highBottomBound { get; set; }
        private int highTopBound { get; set; }
        public string[] inclusions { get; set; } //0:up|1:down|2:highup|3:highdown|4:lowup|5:lowdown
        public string[] exclusions { get; set; } //0:up|1:down|2:highup|3:highdown|4:lowup|5:lowdown
        public string baseIP = "192.168.2.";


        //this is all threading stuff
        //type: 1=speaker ready, 2=breakout
        public SyncForm( int [] bounds, SetupForm parentForm, int myType )
        {
            InitializeComponent();
            ipBounds = bounds;
            type = myType;
            inclusions = new string[6];
            exclusions = new string[6];
            for (int i = 0; i < 6; i++)
                exclusions[i] = univFilter;
            if (type == 1)
            {
                numComps = Math.Abs(ipBounds[1] - ipBounds[0]);
                lowBottomBound = ipBounds[0];
                lowTopBound = (ipBounds[0] + ipBounds[1]) / 2;
                highBottomBound = lowTopBound + 1;
                highTopBound = ipBounds[1];
            }
            else
            {
                numComps = Math.Abs(ipBounds[3] - ipBounds[2]);
                lowBottomBound = ipBounds[2];
                lowTopBound = (ipBounds[2] + ipBounds[3]) / 2;
                highBottomBound = lowTopBound + 1;
                highTopBound = ipBounds[3];
                syncTypeLabel.Text = "Breakout";
            }
            clientComps = new ClientComputer[numComps];
            myParent = parentForm;
            runningSyncs = new bool[6];
            lowIPStart.Text = lowBottomBound.ToString();
            lowIPEnd.Text = lowTopBound.ToString();
            highIPStart.Text = highBottomBound.ToString();
            highIPEnd.Text = highTopBound.ToString();
        }
        private void SyncForm_Load(object sender, EventArgs e)
        {
            
            for(int i = 0; i<numComps; i++)
            {
                ClientComputer cc = new ClientComputer(this, lowBottomBound+i);
                clientComps[i] = cc;
                cc.setIP(lowBottomBound + i);
                compPanel.Controls.Add(cc);
                if(lowBottomBound+i<highBottomBound)
                {
                    cc.hide(2);
                    cc.hide(3);
                }
                else
                {
                    cc.hide(4);
                    cc.hide(5);
                }
            }

            upSyncWorker.RunWorkerAsync(0);
            downSyncWorker.RunWorkerAsync(1);
            hiUpSyncWorker.RunWorkerAsync(2);
            hiDownSyncWorker.RunWorkerAsync(3);
            lowUpSyncWorker.RunWorkerAsync(4);
            lowDownSyncWorker.RunWorkerAsync(5);

            connectionWorker.RunWorkerAsync();
            Show();
            
        }

        public class ProgressVals
        {
            public int channel;
            public int curComp;
        }

        private void syncWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ClientComputer curComp;
            int channel = (int)e.Argument;
            string typeStr = "BO";
            int curIP;
            string argStr;
            ProgressVals progVals = new ProgressVals();
            BackgroundWorker worker = (BackgroundWorker)sender;
            int topBound = numComps;
            int botBound = 0;
            CheckBox shouldSync;
            if (channel == 0)
                shouldSync = upChk;
            else if (channel == 1)
                shouldSync = downChk;
            else if (channel == 2)
            {
                shouldSync = hiUpChk;
                topBound = lowTopBound - lowBottomBound;
            }
            else if (channel == 3)
            {
                shouldSync = hiDnChk;
                topBound = lowTopBound - lowBottomBound;
            }
            else if (channel == 4)
            {
                shouldSync = loUpChk;
                botBound = highBottomBound - lowBottomBound;
            }
            else
            {
                shouldSync = loDnChk;
                botBound = highBottomBound - lowBottomBound;
            }
            int i = botBound;
            int a = i;
            while (true)
            {
                while (shouldSync.Checked)
                {
                    a = i;
                    if (channel % 2 == 1)
                        a = clientComps.Length - (i+1);
                    curComp = clientComps[a];
                    if (curComp.syncingTypesActive[channel])
                    {
                        if (type == 1)
                            typeStr = "SR";
                        curIP = curComp.ip;
                        argStr = $"/1\"C:\\Cshow\" /2\"\\\\" + baseIP + $"{curIP}\\Cshow\" /L+\"C:\\FNSYNC\\{curIP}." + typeStr + "\" /O:1 /F+ /U- /E:" + exclusions[channel] + " /I:" + inclusions[channel] + " /AQ /S-30";
                        curComp.getClockByChannel(channel).BackColor = Color.Cyan;
                        Process syncProc = Process.Start("C:\\Program Files (x86)\\File-N-Sync\\File-N-SyncPlus.exe", argStr);
                        syncProc.WaitForExit();
                        progVals.channel = channel;
                        progVals.curComp = i;
                        worker.ReportProgress(0, progVals);
                    }
                    
                    i = ++i % topBound;
                }
                if(!upChk.Checked)
                    Thread.Sleep(100);
            }
        }

        private void syncWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressVals progVals = (ProgressVals)e.UserState;
            Label clock = clientComps[progVals.curComp].getClockByChannel(progVals.channel);
            clock.BackColor = Color.Empty;
            string minute = DateTime.Now.Minute.ToString();
            if (minute.Length == 1)
                minute = "0" + minute;
            clock.Text = DateTime.Now.Hour.ToString() + ":" + minute;
        }

        public class ConnectionProgress
        {
            public bool success;
            public int compNumber;
        }

        private void connectionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            Ping testPing = new Ping();
            int i = 0;
            int curIP;
            PingReply lastReply;
            Process horridSoundProc;
            string typeStr = "BO";
            if (type == 1)
                typeStr = "SR";
            while (true)
            {
                curIP = clientComps[i].ip;
                lastReply = testPing.Send(baseIP + curIP);
                if(lastReply.Status != IPStatus.Success)
                {
                    lastReply = testPing.Send(baseIP + curIP);
                    if (lastReply.Status != IPStatus.Success)
                    {
                        lastReply = testPing.Send(baseIP + curIP);
                        if (lastReply.Status != IPStatus.Success)
                        {
                            clientComps[i].BackColor = Color.Red;
                            worker.ReportProgress(i);
                            horridSoundProc = Process.Start("C:\\Program Files (x86)\\VideoLAN\\VLC\\vlc.exe", $"--volume=300 --play-and-exit --qt-start-minimized _{typeStr}Sound");
                            horridSoundProc.WaitForExit();
                        }
                    }
                }
                i = ++i % numComps;
                Thread.Sleep(500);
            }
        }

        private void connectionWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ConnectionProgress conProg = (ConnectionProgress)e.UserState;
            if (conProg.success)
                clientComps[conProg.compNumber].updateLastPing();
        }


        //this is stuff underlaying the ui
        private void quitButton_Click(object sender, EventArgs e)
        {
            myParent.Close();
        }

        private void upChk_CheckedChanged(object sender, EventArgs e)
        {
            if (upChk.Checked)
            {
                upLbl.BackColor = Color.Cyan;
            }
            else
            {
                upLbl.BackColor = Color.Empty;
            }
        }
        private void downChk_CheckedChanged(object sender, EventArgs e)
        {
            if (downChk.Checked)
            {
                downLbl.BackColor = Color.Cyan;
            }
            else
            {
                downLbl.BackColor = Color.Empty;
            }
        }
        private void hiUpChk_CheckedChanged(object sender, EventArgs e)
        {
            if (hiUpChk.Checked)
            {
                hiUpLbl.BackColor = Color.Cyan;
            }
            else
            {
                hiUpLbl.BackColor = Color.Empty;
            }
        }
        private void hiDnChk_CheckedChanged(object sender, EventArgs e)
        {
            if (hiDnChk.Checked)
            {
                hiDnLbl.BackColor = Color.Cyan;
            }
            else
            {
                hiDnLbl.BackColor = Color.Empty;
            }
        }
        private void loUpChk_CheckedChanged(object sender, EventArgs e)
        {
            if (loUpChk.Checked)
            {
                loUpLbl.BackColor = Color.Cyan;
            }
            else
            {
                loUpLbl.BackColor = Color.Empty;
            }
        }
        private void loDnChk_CheckedChanged(object sender, EventArgs e)
        {
            if (loDnChk.Checked)
            {
                loDnLbl.BackColor = Color.Cyan;
            }
            else
            {
                loDnLbl.BackColor = Color.Empty;
            }
        }

        private void modifierBtn_Click(object sender, EventArgs e)
        {
            ModifierManager modMan = new ModifierManager(this);
            modMan.Show();
        }

        private void upAllSwitch_Click(object sender, EventArgs e)
        {
            if(upAllSwitch.Text.Equals("All On"))
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[0] = true;
                    clientComps[i].setUpSyncChk(true);
                }
                upAllSwitch.Text = "All Off";
            }
            else
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[0] = false;
                    clientComps[i].setUpSyncChk(false);
                }
                upAllSwitch.Text = "All On";
            }
        }
        private void downAllSwitch_Click(object sender, EventArgs e)
        {
            if (downAllSwitch.Text.Equals("All On"))
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[1] = true;
                    clientComps[i].setDownSyncChk(true);
                }
                downAllSwitch.Text = "All Off";
            }
            else
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[1] = false;
                    clientComps[i].setDownSyncChk(false);
                }
                downAllSwitch.Text = "All On";
            }
        }
        private void highUpAllSwitch_Click(object sender, EventArgs e)
        {
            if (highUpAllSwitch.Text.Equals("All On"))
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[2] = true;
                    clientComps[i].setHiUpSyncChk(true);
                }
                highUpAllSwitch.Text = "All Off";
            }
            else
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[2] = false;
                    clientComps[i].setHiUpSyncChk(false);
                }
                highUpAllSwitch.Text = "All On";
            }
        }
        private void highDownAllSwitch_Click(object sender, EventArgs e)
        {
            if (highDownAllSwitch.Text.Equals("All On"))
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[3] = true;
                    clientComps[i].setHiDownSyncChk(true);
                }
                highDownAllSwitch.Text = "All Off";
            }
            else
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[3] = false;
                    clientComps[i].setHiDownSyncChk(false);
                }
                highDownAllSwitch.Text = "All On";
            }
        }
        private void lowUpAllSwitch_Click(object sender, EventArgs e)
        {
            if (lowUpAllSwitch.Text.Equals("All On"))
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[4] = true;
                    clientComps[i].setLoUpSyncChk(true);
                }
                lowUpAllSwitch.Text = "All Off";
            }
            else
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[4] = false;
                    clientComps[i].setLoUpSyncChk(false);
                }
                lowUpAllSwitch.Text = "All On";
            }
        }
        private void lowDownAllSwitch_Click(object sender, EventArgs e)
        {
            if (lowDownAllSwitch.Text.Equals("All On"))
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[5] = true;
                    clientComps[i].setLoDownSyncChk(true);
                }
                lowDownAllSwitch.Text = "All Off";
            }
            else
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[5] = false;
                    clientComps[i].setLoDownSyncChk(false);
                }
                lowDownAllSwitch.Text = "All On";
            }
        }

        private void updateLoHiBtn_Click(object sender, EventArgs e)
        {
            lowBottomBound = Convert.ToInt16(lowIPStart.Text);
            lowTopBound = Convert.ToInt16(lowIPEnd.Text);
            highBottomBound = Convert.ToInt16(highIPStart.Text);
            highTopBound = Convert.ToInt16(highIPEnd.Text);
        }

        
    }
}
