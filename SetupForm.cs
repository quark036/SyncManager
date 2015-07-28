using System;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Xml;

namespace SyncManager
{
    public partial class SetupForm : Form
    {
        private bool isClassC; //if its not class c, its class b
        //for right now, just implement class c
        private int speakerReadyStartIP;
        private int speakerReadyEndIP;
        private int breakoutStartIP;
        private int breakoutEndIP;
        public Comp[] compInfo;
        private bool firstTime;

        public SetupForm()
        {
            InitializeComponent();
            firstTime = false;
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            string filePath = @"c:\cshow\extras\syncManagerConfig.xml";
            if (!File.Exists(filePath))
            {
                firstTime = true;
                StreamWriter sw = File.CreateText(filePath);
                sw.WriteLine("<configs>");

                sw.Write("<importFilePath>");
                sw.WriteLine("</importFilePath>");

                sw.Write("<lowestIP>");
                sw.WriteLine("</lowestIP>");

                sw.Write("<numSRComps>");
                sw.WriteLine("</numSRComps>");

                sw.Write("<numBOComps>");
                sw.WriteLine("</numBOComps>");

                sw.Write("<ipScheme>");
                sw.WriteLine("</ipScheme>");

                sw.Write("<screenSize>");
                sw.WriteLine("</screenSize>");


                sw.WriteLine("<divisions>");

                sw.Write("<startSRLow>");
                sw.WriteLine("</startSRLow>");

                sw.Write("<endSRLow>");
                sw.WriteLine("</endSRLow>");

                sw.Write("<startSRHigh>");
                sw.WriteLine("</startSRHigh>");

                sw.Write("<endSRHigh>");
                sw.WriteLine("</endSRHigh>");

                sw.Write("<startBOLow>");
                sw.WriteLine("</startBOLow>");

                sw.Write("<endBOLow>");
                sw.WriteLine("</endBOLow>");

                sw.Write("<startBOHigh>");
                sw.WriteLine("</startBOHigh>");

                sw.Write("<endBOHigh>");
                sw.WriteLine("</endBOHigh>");
                
                sw.WriteLine("</divisions>");
                

                sw.WriteLine("<modifiers>");

                sw.WriteLine("<speakerReady>");

                sw.WriteLine("<up>");
                sw.Write("<inclusions>");
                sw.WriteLine("</inclusions>");
                sw.Write("<exclusions>");
                sw.WriteLine("</exclusions>");
                sw.WriteLine("</up>");

                sw.WriteLine("<down>");
                sw.Write("<inclusions>");
                sw.WriteLine("</inclusions>");
                sw.Write("<exclusions>");
                sw.WriteLine("</exclusions>");
                sw.WriteLine("</down>");

                sw.WriteLine("<highUp>");
                sw.Write("<inclusions>");
                sw.WriteLine("</inclusions>");
                sw.Write("<exclusions>");
                sw.WriteLine("</exclusions>");
                sw.WriteLine("</highUp>");

                sw.WriteLine("<highDown>");
                sw.Write("<inclusions>");
                sw.WriteLine("</inclusions>");
                sw.Write("<exclusions>");
                sw.WriteLine("</exclusions>");
                sw.WriteLine("</highDown>");

                sw.WriteLine("<lowUp>");
                sw.Write("<inclusions>");
                sw.WriteLine("</inclusions>");
                sw.Write("<exclusions>");
                sw.WriteLine("</exclusions>");
                sw.WriteLine("</lowUp>");

                sw.WriteLine("<lowDown>");
                sw.Write("<inclusions>");
                sw.WriteLine("</inclusions>");
                sw.Write("<exclusions>");
                sw.WriteLine("</exclusions>");
                sw.WriteLine("</lowDown>");

                sw.WriteLine("</speakerReady>");

                sw.WriteLine("<breakout>");

                sw.WriteLine("<up>");
                sw.Write("<inclusions>");
                sw.WriteLine("</inclusions>");
                sw.Write("<exclusions>");
                sw.WriteLine("</exclusions>");
                sw.WriteLine("</up>");

                sw.WriteLine("<down>");
                sw.Write("<inclusions>");
                sw.WriteLine("</inclusions>");
                sw.Write("<exclusions>");
                sw.WriteLine("</exclusions>");
                sw.WriteLine("</down>");

                sw.WriteLine("<highUp>");
                sw.Write("<inclusions>");
                sw.WriteLine("</inclusions>");
                sw.Write("<exclusions>");
                sw.WriteLine("</exclusions>");
                sw.WriteLine("</highUp>");

                sw.WriteLine("<highDown>");
                sw.Write("<inclusions>");
                sw.WriteLine("</inclusions>");
                sw.Write("<exclusions>");
                sw.WriteLine("</exclusions>");
                sw.WriteLine("</highDown>");

                sw.WriteLine("<lowUp>");
                sw.Write("<inclusions>");
                sw.WriteLine("</inclusions>");
                sw.Write("<exclusions>");
                sw.WriteLine("</exclusions>");
                sw.WriteLine("</lowUp>");

                sw.WriteLine("<lowDown>");
                sw.Write("<inclusions>");
                sw.WriteLine("</inclusions>");
                sw.Write("<exclusions>");
                sw.WriteLine("</exclusions>");
                sw.WriteLine("</lowDown>");

                sw.WriteLine("</breakout>");

                sw.WriteLine("</modifiers>");

                sw.WriteLine("</configs>");

                sw.Close();
            }
        }

        public class Comp
        {
            public int ip;
            public string roomName;

            public Comp(int ip, string roomName)
            {
                this.ip = ip;
                this.roomName = roomName;
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            importFileDialog.Title = "Choose file to read from";
            if(importFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileToRead = new FileInfo(importFileDialog.FileName);
                StreamReader reader = new StreamReader(File.OpenRead(fileToRead.FullName));
                string line;
                string[] vals;
                ArrayList comps = new ArrayList();
                if(fileToRead.Exists)
                {
                    while(!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        vals = line.Split(',');
                        comps.Add(new Comp(Convert.ToInt16(vals[1]), vals[0]));
                        
                    }
                    compInfo = new Comp[comps.Count];
                    comps.CopyTo(compInfo);
                }
            }
            ConfigForm cfg = new ConfigForm(this);
            if (firstTime)
                cfg.firstTimeSetup();
            else
                cfg.setupFromFile();
            cfg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void launch()
        {
            SyncForm speakerReadySync = new SyncForm(this, 1, isClassC);
            speakerReadySync.Show();
            SyncForm breakoutSync = new SyncForm(this, 2, isClassC);
            breakoutSync.Show();
            Hide();
        }

        public void quit()
        {
            Close();
        }
    }
}
