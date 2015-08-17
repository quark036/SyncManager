﻿using System;
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
using System.Xml;

namespace SyncManager
{
    //this is the main class/form to do the syncing
    
    //We are sinking!
    //Vat are you sinking about?
    //hahahahahaa
    public partial class SyncForm : Form
    {   
        //lots of global variables
        private int[] ipBounds; //speaker ready start, end, breakout start, end
        public int numComps;
        public Dictionary<int, int> index2ip; //so that it is easy to iterate through the computers, the key is the index, the value is the ip to sync to
        public ClientComputer[] clientComps;
        private SetupForm parentForm;
        private bool[] runningSyncs;
        public int type;
        private int lowBottomBound;
        private int lowTopBound;
        private int highBottomBound;
        private int highTopBound;
        public string[] inclusions;//0:up|1:down|2:highup|3:highdown|4:lowup|5:lowdown
        public string[] exclusions;
        public string baseIP = "192.168.2.";
        public static System.Media.SoundPlayer alertPlayer = new System.Media.SoundPlayer(@"\\127.0.0.1\Cshow\extras\alertSound.wav");
        public string univFilter = "~$;.DS_;thumbs.db;slidethumbnail.jpg;";
        public bool[] channelIsUsingUnivFilter;
        public int[] numCompsActiveByType;
        public int lowestIP;
        public bool ipScheme; //true=c, false=b
        public bool[] switchType;
        public bool isServer;
        public int baseLeft;
        public string serverIP;
        public string cshowHighLoc;
        public string cshowLowLoc;
        SetupForm.Comp[] compInfo;
        
        //type: 1=speaker ready, 2=breakout
        public SyncForm(SetupForm myParent, SetupForm.Comp[] myCompInfo, int myType)
        {
            InitializeComponent();


            //sets the bounds of high and low based on the config file
            ipBounds = new int[4];
            XmlDocument doc = new XmlDocument();
            doc.Load(@"\\127.0.0.1\cshow\extras\syncManagerConfig.xml");
            ipBounds[0] = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/startSRLow").InnerText);
            ipBounds[1] = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/endSRHigh").InnerText);
            ipBounds[2] = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/startBOLow").InnerText);
            ipBounds[3] = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/endBOHigh").InnerText);
            ipScheme = doc.SelectSingleNode("/configs/ipScheme").InnerText.Equals("Class C");
            type = myType;

            //takes the modifiers from the config file and updates them
            inclusions = new string[6];
            exclusions = new string[6];
            numCompsActiveByType = new int[6];
            for (int i = 0; i < 6; i++)
                exclusions[i] = univFilter;
            if (type == 1) //speaker ready
            {
                numComps = Math.Abs(ipBounds[1] - ipBounds[0])+1;
                lowBottomBound = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/startSRLow").InnerText);
                lowTopBound = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/endSRLow").InnerText);
                highBottomBound = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/startSRHigh").InnerText);
                highTopBound = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/endSRHigh").InnerText);
                Text = "Speaker Ready";
                inclusions[0] = doc.SelectSingleNode("/configs/modifiers/speakerReady/up/inclusions").InnerText;
                inclusions[1] = doc.SelectSingleNode("/configs/modifiers/speakerReady/down/inclusions").InnerText;
                inclusions[2] = doc.SelectSingleNode("/configs/modifiers/speakerReady/highUp/inclusions").InnerText;
                inclusions[3] = doc.SelectSingleNode("/configs/modifiers/speakerReady/highDown/inclusions").InnerText;
                inclusions[4] = doc.SelectSingleNode("/configs/modifiers/speakerReady/lowUp/inclusions").InnerText;
                inclusions[5] = doc.SelectSingleNode("/configs/modifiers/speakerReady/lowDown/inclusions").InnerText;
                exclusions[0] = doc.SelectSingleNode("/configs/modifiers/speakerReady/up/exclusions").InnerText;
                exclusions[1] = doc.SelectSingleNode("/configs/modifiers/speakerReady/down/exclusions").InnerText;
                exclusions[2] = doc.SelectSingleNode("/configs/modifiers/speakerReady/highUp/exclusions").InnerText;
                exclusions[3] = doc.SelectSingleNode("/configs/modifiers/speakerReady/highDown/exclusions").InnerText;
                exclusions[4] = doc.SelectSingleNode("/configs/modifiers/speakerReady/lowUp/exclusions").InnerText;
                exclusions[5] = doc.SelectSingleNode("/configs/modifiers/speakerReady/lowDown/exclusions").InnerText;
            }
            else if(type==2) //breakout
            {
                numComps = Math.Abs(ipBounds[3] - ipBounds[2])+1;
                lowBottomBound = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/startBOLow").InnerText);
                lowTopBound = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/endBOLow").InnerText);
                highBottomBound = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/startBOHigh").InnerText);
                highTopBound = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/endBOHigh").InnerText);
                Text = "Breakout";
                inclusions[0] = doc.SelectSingleNode("/configs/modifiers/breakout/up/inclusions").InnerText;
                inclusions[1] = doc.SelectSingleNode("/configs/modifiers/breakout/down/inclusions").InnerText;
                inclusions[2] = doc.SelectSingleNode("/configs/modifiers/breakout/highUp/inclusions").InnerText;
                inclusions[3] = doc.SelectSingleNode("/configs/modifiers/breakout/highDown/inclusions").InnerText;
                inclusions[4] = doc.SelectSingleNode("/configs/modifiers/breakout/lowUp/inclusions").InnerText;
                inclusions[5] = doc.SelectSingleNode("/configs/modifiers/breakout/lowDown/inclusions").InnerText;
                exclusions[0] = doc.SelectSingleNode("/configs/modifiers/breakout/up/exclusions").InnerText;
                exclusions[1] = doc.SelectSingleNode("/configs/modifiers/breakout/down/exclusions").InnerText;
                exclusions[2] = doc.SelectSingleNode("/configs/modifiers/breakout/highUp/exclusions").InnerText;
                exclusions[3] = doc.SelectSingleNode("/configs/modifiers/breakout/highDown/exclusions").InnerText;
                exclusions[4] = doc.SelectSingleNode("/configs/modifiers/breakout/lowUp/exclusions").InnerText;
                exclusions[5] = doc.SelectSingleNode("/configs/modifiers/breakout/lowDown/exclusions").InnerText;
            }
            else //zone
            {
                numComps = Math.Abs(ipBounds[3] - ipBounds[2]) + 1;
                lowBottomBound = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/startBOLow").InnerText);
                lowTopBound = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/endBOLow").InnerText);
                highBottomBound = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/startBOHigh").InnerText);
                highTopBound = Convert.ToInt16(doc.SelectSingleNode("/configs/divisions/endBOHigh").InnerText);
                Text = "Zones";
                inclusions[0] = doc.SelectSingleNode("/configs/modifiers/zone/up/inclusions").InnerText;
                inclusions[1] = doc.SelectSingleNode("/configs/modifiers/zone/down/inclusions").InnerText;
                inclusions[2] = doc.SelectSingleNode("/configs/modifiers/zone/highUp/inclusions").InnerText;
                inclusions[3] = doc.SelectSingleNode("/configs/modifiers/zone/highDown/inclusions").InnerText;
                inclusions[4] = doc.SelectSingleNode("/configs/modifiers/zone/lowUp/inclusions").InnerText;
                inclusions[5] = doc.SelectSingleNode("/configs/modifiers/zone/lowDown/inclusions").InnerText;
                exclusions[0] = doc.SelectSingleNode("/configs/modifiers/zone/up/exclusions").InnerText;
                exclusions[1] = doc.SelectSingleNode("/configs/modifiers/zone/down/exclusions").InnerText;
                exclusions[2] = doc.SelectSingleNode("/configs/modifiers/zone/highUp/exclusions").InnerText;
                exclusions[3] = doc.SelectSingleNode("/configs/modifiers/zone/highDown/exclusions").InnerText;
                exclusions[4] = doc.SelectSingleNode("/configs/modifiers/zone/lowUp/exclusions").InnerText;
                exclusions[5] = doc.SelectSingleNode("/configs/modifiers/zone/lowDown/exclusions").InnerText;
            }

            //changes where the windows will appear based on the config screensize
            isServer = doc.SelectSingleNode("/configs/screenSize").InnerText.Equals("Server");
            if (isServer)
                baseLeft = 2220;
            else
                baseLeft = 300;

            //sets the IP scheme based on the config file
            serverIP = baseIP + "50";
            if (!ipScheme)
            {
                baseIP = "172.16.";
                serverIP = baseIP + "150.50";
            }

            //set the current show folder location
            cshowHighLoc = doc.SelectSingleNode("/configs/cshowHighLoc").InnerText;
            cshowLowLoc = doc.SelectSingleNode("/configs/cshowLowLoc").InnerText;
            
            //make sure to save the config file when done (works like closing it)
            doc.Save(@"\\127.0.0.1\cshow\extras\syncManagerConfig.xml");

            //setting up a bunch of empty arrays to be used
            clientComps = new ClientComputer[numComps];
            parentForm = myParent;
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
            SetupForm.Comp[] compInfo = myCompInfo;
        }

        //saves the modifiers to the config file (duh)
        public void saveModsToConfig()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"\\127.0.0.1\cshow\extras\syncManagerConfig.xml");

            if (type==1)
            {
                doc.SelectSingleNode("/configs/modifiers/speakerReady/up/inclusions").InnerText = inclusions[0];
                doc.SelectSingleNode("/configs/modifiers/speakerReady/down/inclusions").InnerText = inclusions[1];
                doc.SelectSingleNode("/configs/modifiers/speakerReady/highUp/inclusions").InnerText = inclusions[2];
                doc.SelectSingleNode("/configs/modifiers/speakerReady/highDown/inclusions").InnerText = inclusions[3];
                doc.SelectSingleNode("/configs/modifiers/speakerReady/lowUp/inclusions").InnerText = inclusions[4];
                doc.SelectSingleNode("/configs/modifiers/speakerReady/lowDown/inclusions").InnerText = inclusions[5];
                doc.SelectSingleNode("/configs/modifiers/speakerReady/up/exclusions").InnerText = exclusions[0];
                doc.SelectSingleNode("/configs/modifiers/speakerReady/down/exclusions").InnerText = exclusions[1];
                doc.SelectSingleNode("/configs/modifiers/speakerReady/highUp/exclusions").InnerText = exclusions[2];
                doc.SelectSingleNode("/configs/modifiers/speakerReady/highDown/exclusions").InnerText = exclusions[3];
                doc.SelectSingleNode("/configs/modifiers/speakerReady/lowUp/exclusions").InnerText = exclusions[4];
                doc.SelectSingleNode("/configs/modifiers/speakerReady/lowDown/exclusions").InnerText = exclusions[5];
            }
            else if(type==2)
            {
                doc.SelectSingleNode("/configs/modifiers/breakout/up/inclusions").InnerText = inclusions[0];
                doc.SelectSingleNode("/configs/modifiers/breakout/down/inclusions").InnerText = inclusions[1];
                doc.SelectSingleNode("/configs/modifiers/breakout/highUp/inclusions").InnerText = inclusions[2];
                doc.SelectSingleNode("/configs/modifiers/breakout/highDown/inclusions").InnerText = inclusions[3];
                doc.SelectSingleNode("/configs/modifiers/breakout/lowUp/inclusions").InnerText = inclusions[4];
                doc.SelectSingleNode("/configs/modifiers/breakout/lowDown/inclusions").InnerText = inclusions[5];
                doc.SelectSingleNode("/configs/modifiers/breakout/up/exclusions").InnerText = exclusions[0];
                doc.SelectSingleNode("/configs/modifiers/breakout/down/exclusions").InnerText = exclusions[1];
                doc.SelectSingleNode("/configs/modifiers/breakout/highUp/exclusions").InnerText = exclusions[2];
                doc.SelectSingleNode("/configs/modifiers/breakout/highDown/exclusions").InnerText = exclusions[3];
                doc.SelectSingleNode("/configs/modifiers/breakout/lowUp/exclusions").InnerText = exclusions[4];
                doc.SelectSingleNode("/configs/modifiers/breakout/lowDown/exclusions").InnerText = exclusions[5];
            }
            else
            {
                doc.SelectSingleNode("/configs/modifiers/zone/up/inclusions").InnerText = inclusions[0];
                doc.SelectSingleNode("/configs/modifiers/zone/down/inclusions").InnerText = inclusions[1];
                doc.SelectSingleNode("/configs/modifiers/zone/highUp/inclusions").InnerText = inclusions[2];
                doc.SelectSingleNode("/configs/modifiers/zone/highDown/inclusions").InnerText = inclusions[3];
                doc.SelectSingleNode("/configs/modifiers/zone/lowUp/inclusions").InnerText = inclusions[4];
                doc.SelectSingleNode("/configs/modifiers/zone/lowDown/inclusions").InnerText = inclusions[5];
                doc.SelectSingleNode("/configs/modifiers/zone/up/exclusions").InnerText = exclusions[0];
                doc.SelectSingleNode("/configs/modifiers/zone/down/exclusions").InnerText = exclusions[1];
                doc.SelectSingleNode("/configs/modifiers/zone/highUp/exclusions").InnerText = exclusions[2];
                doc.SelectSingleNode("/configs/modifiers/zone/highDown/exclusions").InnerText = exclusions[3];
                doc.SelectSingleNode("/configs/modifiers/zone/lowUp/exclusions").InnerText = exclusions[4];
                doc.SelectSingleNode("/configs/modifiers/zone/lowDown/exclusions").InnerText = exclusions[5];
            }
            doc.Save(@"\\127.0.0.1\cshow\extras\syncManagerConfig.xml");
        }

        //setting up a bunch of things
        private void SyncForm_Load(object sender, EventArgs e)
        {
            //setting the location based on screensize and type
            if (type == 1)
                Location = new Point(baseLeft, 0);
            else if (type == 2)
                Location = new Point(baseLeft+300, 0);
            else
                Location = new Point(baseLeft+600, 0);

            //building the array of client computers, setting their room names and ips
            for (int i = 0; i<numComps; i++)
            {
                ClientComputer cc = new ClientComputer(this, lowBottomBound+i);
                clientComps[i] = cc;
                if (type == 1)
                {
                    cc.setRoom(parentForm.compInfo[i].roomName);
                    cc.setIP(parentForm.compInfo[i].ip);
                }
                else
                {
                    cc.setRoom(parentForm.breakoutCompInfo[i].roomName);
                    cc.setIP(parentForm.breakoutCompInfo[i].ip);
                }
                compPanel.Controls.Add(cc);

                //hiding low and high checks for high and low computers
                if (lowBottomBound + i <= lowTopBound)
                {
                    cc.conceal(2);
                    cc.conceal(3);
                    cc.reveal(4);
                    cc.reveal(5);
                }
                else if (lowBottomBound + i >= highBottomBound)
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
            //resize this so that all the columns are even
            resizeCompNames();

            //start the workers for each sync type
            upSyncWorker.RunWorkerAsync(0);
            downSyncWorker.RunWorkerAsync(1);
            hiUpSyncWorker.RunWorkerAsync(2);
            hiDownSyncWorker.RunWorkerAsync(3);
            lowUpSyncWorker.RunWorkerAsync(4);
            lowDownSyncWorker.RunWorkerAsync(5);

            //start 2 connection workers to check the connections of all the client computers
            //one goes up the list, the other goes down the list
            connectionWorker.RunWorkerAsync();
            connectionWorker2.RunWorkerAsync();

            //more resizing
            updateLabelCollapse();

            Show();

            //if you don't focus on the comp panel, the user won't be able to scroll
            compPanel.Focus();
        }

        //resizes all the names so that they match the width of the widest one, 
        //so that all the columns are actually in straigh columns
        public void resizeCompNames()
        {
            int widest = 0;
            for (int i = 0; i < numComps; i++)
            {
                if (clientComps[i].getRoomWidth() > widest)
                    widest = clientComps[i].getRoomWidth();
            }
            for (int i = 0; i < numComps; i++)
            {
                clientComps[i].resizeRoom(widest+10);
            }
            labelTable.ColumnStyles[1].SizeType = SizeType.Absolute;
            labelTable.ColumnStyles[1].Width = widest + 10;
        }

        //small class used for the sync workers to report their progress through
        public class ProgressVals
        {
            public int channel;
            public int curComp;
            public bool success;
        }


        //use this same DoWork function for all of the sync types
        private void syncWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //lots of variables needed
                ClientComputer curComp;
                int channel = (int)e.Argument;

                //set for the filename
                string typeStr = "SR";
                if (type == 2)
                    typeStr = "BO";
                else if (type == 3)
                    typeStr = "BO_ZN";

                int curIP;
                string argStr;
                ProgressVals progVals = new ProgressVals();
                BackgroundWorker worker = (BackgroundWorker)sender;
                int topBound = numComps;
                int botBound = 0;
                CheckBox shouldSync = null;
                string fileName;
                string fileLocStr = "";
                string octet3;
                Process syncProc;
                string curCshowLoc = "";

                //sets which checkbox this is looking at, as well as the file location, for each channel
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
                    curCshowLoc = cshowHighLoc;
                }
                else if (channel == 3)
                {
                    shouldSync = hiDnChk;
                    botBound = highBottomBound - lowBottomBound;
                    fileLocStr = typeStr + "_UP_LO\\";
                    curCshowLoc = cshowHighLoc;
                }
                else if (channel == 4)
                {
                    shouldSync = loUpChk;
                    topBound = highTopBound - lowTopBound;
                    fileLocStr = typeStr + "_DN_HI\\";
                    curCshowLoc = cshowLowLoc;
                }
                else if (channel == 5)
                {
                    shouldSync = loDnChk;
                    topBound = highTopBound - lowTopBound;
                    fileLocStr = typeStr + "_DN_LO\\";
                    curCshowLoc = cshowLowLoc;
                }
                int i = botBound;
                int a = i;

                try
                {
                    //run the sync workers constantly, but only sync if the box is checked
                    while (true)
                    {
                        try
                        {
                            while (shouldSync.Checked)
                            {
                                if (type == 1 && channel == 3)
                                { }
                                //set the bounds of what it is syncing so that it will follow high/low bounds
                                //you can't do this outside of the while loop because it would make it impossible to update the hilo bounds
                                if (channel == 2)
                                    botBound = highBottomBound - lowBottomBound;
                                else if (channel == 3)
                                    botBound = highBottomBound - lowBottomBound;
                                else if (channel == 4)
                                    topBound = highTopBound - lowTopBound;
                                else if (channel == 5)
                                    topBound = highTopBound - lowTopBound;

                                //basically, for the down channels, a will be the inverse of i, (by inverse I mean mirrored across array)
                                //so that the down channels will go in the opposite direction
                                a = i;
                                if (channel % 2 == 1)
                                    a = topBound - (i + 1 - botBound);

                                //for mac shows, splitting the straight up and down channels into using the right cshow address for high and low
                                if (channel == 0 || channel == 1)
                                {
                                    if (a < highBottomBound)
                                        curCshowLoc = cshowLowLoc;
                                    else
                                        curCshowLoc = cshowHighLoc;
                                }

                                //now we iterate through the client computers
                                curComp = clientComps[a];

                                try
                                {
                                    //and check if that computer is being synced under this sync type
                                    if (curComp.syncingTypesActive[channel])
                                    {
                                        //sets the IP, based on the ipscheme
                                        curIP = curComp.ip;
                                        octet3 = "";
                                        if (!ipScheme)
                                        {
                                            if (type == 1)
                                                octet3 = "160.";
                                            else
                                                octet3 = "170.";
                                        }

                                        //only runs the sync if it is successful in testing if that computer is connected
                                        if (checkCon(baseIP + octet3 + curIP))
                                        {
                                            //highligh green because we are running this computer and this sync type
                                            curComp.getClockByChannel(channel).BackColor = Color.Green;

                                            //look at FileNSync help to see the command line arguments

                                            //if it is a zone sync
                                            if (type == 3)
                                            {
                                                //first sync the base cshow folder, with no subfolders (F-)
                                                argStr = "/1\"" + curCshowLoc + "\" /2\"\\\\" + baseIP + octet3 + $"{curIP}\\Cshow\" /L+\"C:\\FNSYNC\\{curIP}." + typeStr + "\" /O:1 /F- /U- /E:" + exclusions[channel] + " /I:" + inclusions[channel] + " /AQ /S-30";
                                                fileName = "C:\\FNSYNC\\" + fileLocStr + "File-N-SyncPlus.exe";
                                                syncProc = Process.Start(fileName, argStr);
                                                syncProc.WaitForExit();

                                                //then sync the cshow/sync folder, with subfolders (F+)
                                                argStr = "/1\"" + curCshowLoc + "\\Sync\" /2\"\\\\" + baseIP + octet3 + $"{curIP}\\Cshow\\Sync\" /L+\"C:\\FNSYNC\\{curIP}." + typeStr + "\" /O:1 /F+ /U- /E:" + exclusions[channel] + " /I:" + inclusions[channel] + " /AQ /S-30";
                                                syncProc = Process.Start(fileName, argStr);
                                                syncProc.WaitForExit();

                                                //then sync that room, with subfolders (F+)
                                                argStr = "/1\"" + curCshowLoc + "\\" + curComp.getRoomName() + "\\\" /2\"\\\\" + baseIP + octet3 + $"{curIP}\\Cshow\\" + curComp.getRoomName() + "\\\" /L+\"C:\\FNSYNC\\{curIP}." + typeStr + "\" /O:1 /F+ /U- /E:" + exclusions[channel] + " /I:" + inclusions[channel] + " /AQ /S-30";
                                                syncProc = Process.Start(fileName, argStr);
                                                syncProc.WaitForExit();
                                            }
                                            else //it's not a zone sync
                                            {
                                                //sync everything in cshow with the specified IP
                                                argStr = "/1\"" + curCshowLoc + "\" /2\"\\\\" + baseIP + octet3 + $"{curIP}\\Cshow\" /L+\"C:\\FNSYNC\\{curIP}." + typeStr + "\" /O:1 /F+ /U- /E:" + exclusions[channel] + " /I:" + inclusions[channel] + " /AQ /S-30";
                                                fileName = "C:\\FNSYNC\\" + fileLocStr + "File-N-SyncPlus.exe";
                                                syncProc = Process.Start(fileName, argStr);
                                                syncProc.WaitForExit();
                                            }

                                            //remove highlight and report progress
                                            curComp.getClockByChannel(channel).BackColor = Color.Empty;
                                            progVals.channel = channel;
                                            progVals.curComp = a;
                                            progVals.success = true;
                                            worker.ReportProgress(0, progVals);
                                        }

                                        else //if the computer is not connected
                                        {
                                            //play an alert and report progress
                                            curComp.getClockByChannel(channel).BackColor = Color.Red;
                                            alertPlayer.Play();
                                            progVals.channel = channel;
                                            progVals.curComp = a;
                                            progVals.success = false;
                                            worker.ReportProgress(0, progVals);
                                        }
                                    }
                                    //i will loop around between botBound and topBound
                                    i = ++i % topBound;
                                    if (i == 0)
                                        i += botBound;
                                }
                                catch
                                {
                                    throw;
                                }
                                //if we aren't running this sync, sleep for 100ms, so that you don't run the while loop millions of times
                                if (!shouldSync.Checked)
                                    Thread.Sleep(1000);
                            }
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                catch
                {
                    throw;
                }
            }
            catch
            {
                throw;
            }
        }

        //used to report progress (will update the clock)
        //you can't update the clock from within the async thread, because it will throw an error
        //you have to update it within the thread it was created from
        //I think
        //something like that
        //I just know doing it from the sync thread throws an error like that
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

        //mini class for the connection workers to report progress
        public class ConnectionProgress
        {
            public bool success;
            public int compNumber;
        }

        //main connection worker function
        private void connectionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //runs through all of the computers, checking the connection
                BackgroundWorker worker = (BackgroundWorker)sender;
                int i = 0;
                int curIP;
                string octet3 = "";
                if (!ipScheme)
                {
                    if (type == 1)
                        octet3 = "160.";
                    else
                        octet3 = "170.";
                }
                ConnectionProgress conProg = new ConnectionProgress();
                while (true)
                {
                    curIP = clientComps[i].ip;
                    conProg.success = checkCon(baseIP + octet3 + curIP);
                    conProg.compNumber = i;
                    worker.ReportProgress(0, conProg);
                    i = ++i % numComps;
                }
            }
            catch
            {
                throw;
            }
        }

        //same as the first connection worker, but in the other direction
        private void connectionWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = (BackgroundWorker)sender;
                int i = 0;
                int a = i;
                string octet3 = "";
                if (!ipScheme)
                {
                    if (type == 1)
                        octet3 = "160.";
                    else
                        octet3 = "170.";
                }
                int curIP;
                ConnectionProgress conProg = new ConnectionProgress();
                while (true)
                {
                    a = numComps - 1 - i;
                    curIP = clientComps[a].ip;
                    conProg.success = checkCon(baseIP + octet3 + curIP);
                    conProg.compNumber = a;
                    worker.ReportProgress(0, conProg);
                    i = ++i % numComps;
                }
            }
            catch
            {
                throw;
            }
        }

        //checks to see if the specified ip is there
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

        //again can't change appearance from the async threads
        //used to update the last pinged, when the connection worker says so
        private void connectionWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ConnectionProgress conProg = (ConnectionProgress)e.UserState;
            if (conProg.success)
                clientComps[conProg.compNumber].updateLastPing();
            else
                clientComps[conProg.compNumber].BackColor = Color.Orange;
        }

        //returns the hilo bounds (wut)
        public int[] getHiLoBounds()
        {
            int[] temp = new int[4];
            temp[0] = lowBottomBound;
            temp[1] = lowTopBound;
            temp[2] = highBottomBound;
            temp[3] = highTopBound;
            return temp;
        }

        //updates which columns are hidden and which are open
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
        
        //changes the bounds and the display of them
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
                else if (lowBottomBound + j >= highBottomBound)
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
            parentForm.Close();
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
                    clientComps[numComps - (i + 1)].syncingTypesActive[1] = true;
                    clientComps[numComps - (i + 1)].setDownSyncChk(true);
                }
                switchType[1] = true;
            }
            else
            {
                for (int i = 0; i < numComps; i++)
                {
                    clientComps[numComps - (i + 1)].syncingTypesActive[1] = false;
                    clientComps[numComps - (i + 1)].setDownSyncChk(false);
                }
                switchType[1] = false;
            }
            compPanel.Focus();
        }
        private void highUpAllSwitch_Click(object sender, EventArgs e)
        {
            if (!switchType[2])
            {
                for (int i = highBottomBound - 1; i < highTopBound; i++)
                {
                    clientComps[i].syncingTypesActive[2] = true;
                    clientComps[i].setHiUpSyncChk(true);
                }
                switchType[2] = true;
            }
            else
            {
                for (int i = highBottomBound - 1; i < highTopBound; i++)
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
                for (int i = highTopBound; i > highBottomBound-1; i--)
                {
                    clientComps[i-lowestIP].syncingTypesActive[3] = true;
                    clientComps[i-lowestIP].setHiDownSyncChk(true);
                }
                switchType[3] = true;
            }
            else
            {
                for (int i = highTopBound; i > highBottomBound-1; i--)
                {
                    clientComps[i-lowestIP].syncingTypesActive[3] = false;
                    clientComps[i-lowestIP].setHiDownSyncChk(false);
                }
                switchType[3] = false;
            }
            compPanel.Focus();
        }
        private void lowUpAllSwitch_Click(object sender, EventArgs e)
        {
            if (!switchType[4])
            {
                for (int i = lowBottomBound; i < lowTopBound + 1; i++)
                {
                    clientComps[i - lowBottomBound].syncingTypesActive[4] = true;
                    clientComps[i - lowBottomBound].setLoUpSyncChk(true);
                }
                switchType[4] = true;
            }
            else
            {
                for (int i = lowBottomBound; i < lowTopBound + 1; i++)
                {
                    clientComps[i - lowBottomBound].syncingTypesActive[4] = false;
                    clientComps[i - lowBottomBound].setLoUpSyncChk(false);
                }
                switchType[4] = false;
            }
            compPanel.Focus();
        }
        private void lowDownAllSwitch_Click(object sender, EventArgs e)
        {
            if (!switchType[5])
            {
                for (int i = lowTopBound; i > lowBottomBound-1; i--)
                {
                    clientComps[i-lowestIP].syncingTypesActive[5] = true;
                    clientComps[i - lowestIP].setLoDownSyncChk(true);
                }
                switchType[5] = true;
            }
            else
            {
                for (int i = lowTopBound; i > lowBottomBound; i--)
                {
                    clientComps[i - lowestIP].syncingTypesActive[5] = false;
                    clientComps[i - lowestIP].setLoDownSyncChk(false);
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

        private void openWindowsBtn_Click(object sender, EventArgs e)
        {
            if(!parentForm.speakerReadyWindowOpen)
            {
                parentForm.speakerReadySync = new SyncForm(parentForm,compInfo,1);
                parentForm.speakerReadyWindowOpen = true;
                parentForm.speakerReadySync.Show();
            }
            if(!parentForm.breakoutWindowOpen)
            {
                parentForm.breakoutSync = new SyncForm(parentForm, compInfo 2);
                parentForm.breakoutWindowOpen = true;
                parentForm.breakoutSync.Show();
            }
            if(!parentForm.zoneWindowOpen)
            {
                parentForm.zoneSync = new SyncForm(parentForm, compInfo, 3);
                parentForm.zoneWindowOpen = true;
                parentForm.zoneSync.Show();
            }
            resize();
        }

        //stuff to do with resizing and the open windows button
        private void SyncForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (type == 1)
                parentForm.speakerReadyWindowOpen = false;
            else if (type == 2)
                parentForm.breakoutWindowOpen = false;
            else if (type == 3)
                parentForm.zoneWindowOpen = false;
            if (!parentForm.speakerReadyWindowOpen && !parentForm.breakoutWindowOpen && !parentForm.zoneWindowOpen)
                parentForm.Close();
            resize();
        }

        //more of a relocate than a resize
        //I mean, its called when you resize a form, what it does is relocate the form
        private void resize()
        {
            int srWidth = 0;
            int boWidth = 0;
            Focus();
            if (parentForm.speakerReadyWindowOpen)
                srWidth = parentForm.speakerReadySync.Width;
            if (parentForm.breakoutWindowOpen)
                boWidth = parentForm.breakoutSync.Width;
            parentForm.speakerReadySync.Location = new Point(baseLeft, 0);
            parentForm.breakoutSync.Location = new Point(baseLeft + srWidth, 0);
            parentForm.zoneSync.Location = new Point(baseLeft + srWidth + boWidth);
        }

        //bunch of event handlers that lead to it resizing
        //if you try do it under the resize event handler, it tries to do it
        //before you are done resizing, and continues many times a second
        //and it won't even end up in the right position
        private void SyncForm_Resize(object sender, EventArgs e)
        {
            parentForm.mustResize = true;
        }

        private void SyncForm_MouseUp(object sender, MouseEventArgs e)
        {
            if(parentForm.mustResize)
                resize();
            parentForm.mustResize = false;
        }

        private void SyncForm_MouseLeave(object sender, EventArgs e)
        {
            if (parentForm.mustResize)
                resize();
            parentForm.mustResize = false;
        }

        private void SyncForm_MouseEnter(object sender, EventArgs e)
        {
            if (parentForm.mustResize)
                resize();
            parentForm.mustResize = false;
        }

        private void SyncForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (parentForm.mustResize)
                resize();
            parentForm.mustResize = false;
        }
    }
}
