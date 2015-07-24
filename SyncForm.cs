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
        
        private int[] ipBounds; //speaker ready start, end, breakout start, end
        public int numComps;
        public ClientComputer[] clientComps;
        private SetupForm myParent;
        private bool[] runningSyncs;
        public int type;
        private int lowBottomBound;
        private int lowTopBound;
        private int highBottomBound;
        private int highTopBound;
        public string[] inclusions;//0:up|1:down|2:highup|3:highdown|4:lowup|5:lowdown
        public string[] exclusions;
        public string baseIP = "192.168.2.";
        public static System.Media.SoundPlayer alertPlayer = new System.Media.SoundPlayer("c:\\Cshow\\extras\\alertSound.wav");
        public string univFilter = "~$;.DS_;thumbs.db;slidethumbnail.jpg;";
        public bool[] channelIsUsingUnivFilter;
        public int[] numCompsActiveByType;
        public int lowestIP;
        public bool ipScheme; //true=c, false=b
        public bool[] switchType;

        //this is all threading stuff
        //type: 1=speaker ready, 2=breakout
        public SyncForm( int [] bounds, SetupForm parentForm, int myType, bool myIpScheme )
        {
            InitializeComponent();
            ipScheme = myIpScheme;
            ipBounds = bounds;
            type = myType;
            inclusions = new string[6];
            exclusions = new string[6];
            numCompsActiveByType = new int[6];
            for (int i = 0; i < 6; i++)
                exclusions[i] = univFilter;
            if (type == 1)
            {
                numComps = Math.Abs(ipBounds[1] - ipBounds[0])+1;
                lowBottomBound = ipBounds[0];
                lowTopBound = (ipBounds[0] + ipBounds[1]) / 2;
                highBottomBound = lowTopBound + 1;
                highTopBound = ipBounds[1];
                Text = "Speaker Ready";
            }
            else
            {
                numComps = Math.Abs(ipBounds[3] - ipBounds[2])+1;
                lowBottomBound = ipBounds[2];
                lowTopBound = (ipBounds[2] + ipBounds[3]) / 2;
                highBottomBound = lowTopBound + 1;
                highTopBound = ipBounds[3];
                Text = "Breakout";
            }
            clientComps = new ClientComputer[numComps];
            myParent = parentForm;
            runningSyncs = new bool[6];
            switchType = new bool[6];
            channelIsUsingUnivFilter = new bool[6];
            for (int i = 0; i < 6; i++)
            {
                channelIsUsingUnivFilter[i] = true;
                numCompsActiveByType[i] = 0;
                switchType[i] = false;
            }
            lowestIP = lowBottomBound;
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
                    //cc.hide(2);
                    //cc.hide(3);
                }
                else
                {
                    //cc.hide(4);
                    //cc.hide(5);
                }

                
            }

            upSyncWorker.RunWorkerAsync(0);
            downSyncWorker.RunWorkerAsync(1);
            hiUpSyncWorker.RunWorkerAsync(2);
            hiDownSyncWorker.RunWorkerAsync(3);
            lowUpSyncWorker.RunWorkerAsync(4);
            lowDownSyncWorker.RunWorkerAsync(5);

            connectionWorker.RunWorkerAsync();
            updateLabelCollapse();
            Show();
            compPanel.Focus();
        }

        public class ProgressVals
        {
            public int channel;
            public int curComp;
            public bool success;
        }

        private void syncWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ClientComputer curComp;
            int channel = (int)e.Argument;
            string typeStr = "BO";
            if (type == 1)
                typeStr = "SR";
            int curIP;
            string argStr;
            ProgressVals progVals = new ProgressVals();
            BackgroundWorker worker = (BackgroundWorker)sender;
            int topBound = numComps;
            int botBound = 0;
            CheckBox shouldSync = null;
            string fileName;
            string fileLocStr = "";
            if (channel == 0)
            {
                shouldSync = upChk;
                fileLocStr = typeStr + "_UP\\";
            }
            else if (channel == 1)
            {
                shouldSync = downChk;
                fileLocStr = typeStr + "_DN\\";
            }
            else if (channel == 2)
            {
                shouldSync = hiUpChk;
                botBound = highBottomBound - lowBottomBound;
                fileLocStr = typeStr + "_UP_HI\\";
            }
            else if (channel == 3)
            {
                shouldSync = hiDnChk;
                botBound = highBottomBound - lowBottomBound;
                fileLocStr = typeStr + "_DN_HI\\";
            }
            else if (channel == 4)
            {
                shouldSync = loUpChk;
                topBound = highTopBound - lowTopBound;
                fileLocStr = typeStr + "_UP_LO\\";
            }
            else if(channel == 5)
            {
                shouldSync = loDnChk;
                topBound = highTopBound - lowTopBound;
                fileLocStr = typeStr + "_DN_LO\\";
            }
            int i = botBound;
            int a = i;
            while (true)
            {
                while (shouldSync.Checked)
                {
                    if(channel == 2)
                        botBound = highBottomBound - lowBottomBound;
                    else if (channel == 3)
                        botBound = highBottomBound - lowBottomBound;
                    else if (channel == 4)
                        topBound = highTopBound - lowTopBound;
                    else if (channel == 5)
                        topBound = highTopBound - lowTopBound;
                    a = i;
                    if (channel % 2 == 1)
                    {
                        if (channel == 3)
                            a = topBound - (i - 1);
                        else
                            a = topBound - (i + 1);
                    }
                    curComp = clientComps[a];
                    if (curComp.syncingTypesActive[channel])
                    {
                        curIP = curComp.ip;
                        if (checkCon(baseIP + curIP))
                        {
                            argStr = "/1\"C:\\Cshow\" /2\"\\\\" + baseIP + $"{curIP}\\Cshow\" /L+\"C:\\FNSYNC\\{curIP}." + typeStr + "\" /O:1 /F+ /U- /E:" + exclusions[channel] + " /I:" + inclusions[channel] + " /AQ /S-30";
                            curComp.getClockByChannel(channel).BackColor = Color.Green;
                            fileName = "C:\\FNSYNC\\" + fileLocStr + "File-N-SyncPlus.exe";
                            Process syncProc = Process.Start(fileName, argStr);
                            syncProc.WaitForExit();
                            curComp.getClockByChannel(channel).BackColor = Color.Empty;
                            progVals.channel = channel;
                            progVals.curComp = a;
                            progVals.success = true;
                            worker.ReportProgress(0, progVals);
                        }
                        else
                        {
                            curComp.getClockByChannel(channel).BackColor = Color.Red;
                            alertPlayer.Play();
                            progVals.channel = channel;
                            progVals.curComp = a;
                            progVals.success = false;
                            worker.ReportProgress(0, progVals);
                        }
                    }
                    i = ++i % topBound;
                    if(i==0)
                        i += botBound;
                }
                if(!shouldSync.Checked)
                    Thread.Sleep(100);
            }
        }

        private void syncWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressVals progVals = (ProgressVals)e.UserState;
            if (progVals.success)
            {
                CheckBox clock = clientComps[progVals.curComp].getClockByChannel(progVals.channel);
                clock.BackColor = Color.Empty;
                string minute = DateTime.Now.Minute.ToString();
                if (minute.Length == 1)
                    minute = "0" + minute;
                clock.Text = DateTime.Now.Hour.ToString() + ":" + minute;
            }
        }

        public class ConnectionProgress
        {
            public bool success;
            public int compNumber;
        }

        private void connectionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            int i = 0;
            int curIP;
            ConnectionProgress conProg = new ConnectionProgress();
            while (true)
            {
                curIP = clientComps[i].ip;
                conProg.success = checkCon(baseIP + curIP);
                conProg.compNumber = i;
                worker.ReportProgress(0, conProg);
                i = ++i % numComps;
            }
        }

        private bool checkCon(string ipToCheck)
        {
            Ping testPing = new Ping();
            PingReply lastReply;
            lastReply = testPing.Send(ipToCheck);
            if (lastReply.Status != IPStatus.Success)
            {
                lastReply = testPing.Send(ipToCheck);
                if (lastReply.Status != IPStatus.Success)
                {
                    lastReply = testPing.Send(ipToCheck);
                    if (lastReply.Status != IPStatus.Success)
                    {
                        return false;
                    }
                    else
                        return true;
                }
                else
                    return true;
            }
            else
                return true;
        }

        private void connectionWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ConnectionProgress conProg = (ConnectionProgress)e.UserState;
            if (conProg.success)
                clientComps[conProg.compNumber].updateLastPing();
            else
                clientComps[conProg.compNumber].BackColor = Color.Orange;
        }

        public int[] getHiLoBounds()
        {
            int[] temp = new int[4];
            temp[0] = lowBottomBound;
            temp[1] = lowTopBound;
            temp[2] = highBottomBound;
            temp[3] = highTopBound;
            return temp;
        }

        public void updateLabelCollapse()
        {
            ClientComputer cc;
            for (int i = 0; i < numComps; i++)
            {
                cc = clientComps[i];
                for (int j = 0; j < 6; j++)
                {
                    if (runningSyncs[j])
                        cc.show(j);
                    else
                        cc.hide(j);
                }
            }
            for (int i = 0; i < 6; i++)
            {
                if (runningSyncs[i])
                    labelTable.ColumnStyles[i+2].Width = 60;
                else
                    labelTable.ColumnStyles[i+2].Width = 0;
            }
        }
        
        public void adjustHiLoBounds(int lowIPStart, int lowIPEnd, int highIPStart, int highIPEnd)
        {
            lowBottomBound = lowIPStart;
            lowTopBound = lowIPEnd;
            highBottomBound = highIPStart;
            highTopBound = highIPEnd;
            ClientComputer cc;
            for (int j = 0; j < numComps; j++)
            {
                cc = clientComps[j];
                if (lowBottomBound + j <= lowTopBound)
                {
                    cc.conceal(2);
                    cc.conceal(3);
                    cc.reveal(4);
                    cc.reveal(5);
                }
                else if (j >= highBottomBound)
                {
                    cc.reveal(2);
                    cc.reveal(3);
                    cc.conceal(4);
                    cc.conceal(5);
                }
                else
                {
                    cc.conceal(2);
                    cc.conceal(3);
                    cc.conceal(4);
                    cc.conceal(5);
                }
            }
            compPanel.Focus();

        }

        private void updateLoHiBtn_Click(object sender, EventArgs e)
        {
            LoHiForm updateForm = new LoHiForm(this);
            updateForm.Show();
        }
        

        //this is stuff underlaying the ui
        private void quitButton_Click(object sender, EventArgs e)
        {
            myParent.Close();
        }

        public void makeScrollable()
        {
            compPanel.Focus();
        }

        private void upChk_CheckedChanged(object sender, EventArgs e)
        {
            if (upChk.Checked)
            {
                upLbl.BackColor = Color.Cyan;
                runningSyncs[0] = true;
            }
            else
            {
                upLbl.BackColor = Color.Empty;
                runningSyncs[0] = false;
            }
            updateLabelCollapse();
            compPanel.Focus();
        }
        private void downChk_CheckedChanged(object sender, EventArgs e)
        {
            if (downChk.Checked)
            {
                downLbl.BackColor = Color.Cyan;
                runningSyncs[1] = true;
            }
            else
            {
                downLbl.BackColor = Color.Empty;
                runningSyncs[1] = false;
            }
            updateLabelCollapse();
            compPanel.Focus();
        }
        private void hiUpChk_CheckedChanged(object sender, EventArgs e)
        {
            if (hiUpChk.Checked)
            {
                hiUpLbl.BackColor = Color.Cyan;
                runningSyncs[2] = true;
            }
            else
            {
                hiUpLbl.BackColor = Color.Empty;
                runningSyncs[2] = false;
            }
            updateLabelCollapse();
            compPanel.Focus();
        }
        private void hiDnChk_CheckedChanged(object sender, EventArgs e)
        {
            if (hiDnChk.Checked)
            {
                hiDnLbl.BackColor = Color.Cyan;
                runningSyncs[3] = true;
            }
            else
            {
                hiDnLbl.BackColor = Color.Empty;
                runningSyncs[3] = false;
            }
            updateLabelCollapse();
            compPanel.Focus();
        }
        private void loUpChk_CheckedChanged(object sender, EventArgs e)
        {
            if (loUpChk.Checked)
            {
                loUpLbl.BackColor = Color.Cyan;
                runningSyncs[4] = true;
            }
            else
            {
                loUpLbl.BackColor = Color.Empty;
                runningSyncs[4] = false;
            }
            updateLabelCollapse();
            compPanel.Focus();
        }
        private void loDnChk_CheckedChanged(object sender, EventArgs e)
        {
            if (loDnChk.Checked)
            {
                loDnLbl.BackColor = Color.Cyan;
                runningSyncs[5] = true;
            }
            else
            {
                loDnLbl.BackColor = Color.Empty;
                runningSyncs[5] = false;
            }
            updateLabelCollapse();
            compPanel.Focus();
        }

        private void modifierBtn_Click(object sender, EventArgs e)
        {
            ModifierManager modMan = new ModifierManager(this);
            modMan.Show();
        }

        private void upAllSwitch_Click(object sender, EventArgs e)
        {
            if (!switchType[0])
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[0] = true;
                    clientComps[i].setUpSyncChk(true);
                }
                switchType[0] = true;
            }
            else
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[0] = false;
                    clientComps[i].setUpSyncChk(false);
                }
                switchType[0] = false;
            }
            compPanel.Focus();
        }
        private void downAllSwitch_Click(object sender, EventArgs e)
        {
            if (!switchType[1])
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[1] = true;
                    clientComps[i].setDownSyncChk(true);
                }
                switchType[1] = true;
            }
            else
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[1] = false;
                    clientComps[i].setDownSyncChk(false);
                }
                switchType[1] = false;
            }
            compPanel.Focus();
        }
        private void highUpAllSwitch_Click(object sender, EventArgs e)
        {
            if (!switchType[2])
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[2] = true;
                    clientComps[i].setHiUpSyncChk(true);
                }
                switchType[2] = true;
            }
            else
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[2] = false;
                    clientComps[i].setHiUpSyncChk(false);
                }
                switchType[2] = false;
            }
            compPanel.Focus();
        }
        private void highDownAllSwitch_Click(object sender, EventArgs e)
        {
            if (!switchType[3])
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[3] = true;
                    clientComps[i].setHiDownSyncChk(true);
                }
                switchType[3] = true;
            }
            else
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[3] = false;
                    clientComps[i].setHiDownSyncChk(false);
                }
                switchType[3] = false;
            }
            compPanel.Focus();
        }
        private void lowUpAllSwitch_Click(object sender, EventArgs e)
        {
            if (!switchType[4])
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[4] = true;
                    clientComps[i].setLoUpSyncChk(true);
                }
                switchType[4] = true;
            }
            else
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[4] = false;
                    clientComps[i].setLoUpSyncChk(false);
                }
                switchType[4] = false;
            }
            compPanel.Focus();
        }
        private void lowDownAllSwitch_Click(object sender, EventArgs e)
        {
            if (!switchType[5])
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[5] = true;
                    clientComps[i].setLoDownSyncChk(true);
                }
                switchType[5] = true;
            }
            else
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[i].syncingTypesActive[5] = false;
                    clientComps[i].setLoDownSyncChk(false);
                }
                switchType[5] = false;
            }
            compPanel.Focus();
        }

        public void updateUpNum()
        {
            numUpComps.Text = "(" + numCompsActiveByType[0] + ")";
        }
        public void updateDownNum()
        {
            numDownComps.Text = "(" + numCompsActiveByType[1] + ")";
        }
        public void updateHiUpNum()
        {
            numHiUpComps.Text = "(" + numCompsActiveByType[2] + ")";
        }
        public void updateHiDnNum()
        {
            numHiDnComps.Text = "(" + numCompsActiveByType[3] + ")";
        }
        public void updateLoUpNum()
        {
            numLoUpComps.Text = "(" + numCompsActiveByType[4] + ")";
        }
        public void updateLoDnNum()
        {
            numLoDnComps.Text = "(" + numCompsActiveByType[5] + ")";
        }
    }
}
