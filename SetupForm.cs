using System;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Xml;

namespace SyncManager
{
    public partial class SetupForm : Form
    {
        public Comp[] compInfo;
        public Comp[] breakoutCompInfo;
        public Comp[] speakerCompInfo;
        private bool firstTime;
        public bool speakerReadyWindowOpen;
        public bool breakoutWindowOpen;
        public bool zoneWindowOpen;
        public SyncForm speakerReadySync;
        public SyncForm breakoutSync;
        public SyncForm zoneSync;
        public bool mustResize;
        public bool isClassC;

        public SetupForm()
        {
            InitializeComponent();
            firstTime = false;
            mustResize = false;
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

                sw.WriteLine("<zone>");

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

                sw.WriteLine("</zone>");

                sw.WriteLine("</modifiers>");

                sw.WriteLine("</configs>");

                sw.Close();
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(@"c:\cshow\extras\syncManagerConfig.xml");
            if (!doc.SelectSingleNode("/configs/importFilePath").InnerText.Equals(""))
                importFilePathTxt.Text = doc.SelectSingleNode("/configs/importFilePath").InnerText;
            if (!doc.SelectSingleNode("/configs/ipScheme").InnerText.Equals(""))
                ipSchemeTxt.Text = doc.SelectSingleNode("/configs/ipScheme").InnerText;
            doc.Save(@"c:\cshow\extras\syncManagerConfig.xml");
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
                XmlDocument doc = new XmlDocument();
                doc.Load(@"c:\cshow\extras\syncManagerConfig.xml");
                importFilePathTxt.Text = importFileDialog.FileName;
                doc.SelectSingleNode("/configs/importFilePath").InnerText = importFilePathTxt.Text;
                doc.Save(@"c:\cshow\extras\syncManagerConfig.xml");
            }
        }

        public void launch()
        {
            speakerReadySync = new SyncForm(this, 1);
            speakerReadyWindowOpen = true;
            speakerReadySync.Show();
            breakoutSync = new SyncForm(this, 2);
            breakoutWindowOpen = true;
            breakoutSync.Show();
            zoneSync = new SyncForm(this, 3);
            zoneWindowOpen = true;
            zoneSync.Show();
            Hide();
        }

        public void quit()
        {
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            if (ipSchemeTxt.Text.Equals("Class C"))
                isClassC = true;
            else
                isClassC = false;
            XmlDocument doc = new XmlDocument();
            doc.Load(@"c:\cshow\extras\syncManagerConfig.xml");
            FileInfo fileToRead = new FileInfo(doc.SelectSingleNode("/configs/importFilePath").InnerText);
            doc.SelectSingleNode("/configs/ipScheme").InnerText = ipSchemeTxt.Text;
            doc.Save(@"c:\cshow\extras\syncManagerConfig.xml");
            StreamReader reader = new StreamReader(File.OpenRead(fileToRead.FullName));
            string line;
            string[] vals;
            ArrayList comps = new ArrayList();
            if (fileToRead.Exists)
            {
                if (isClassC)
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        vals = line.Split(',');
                        comps.Add(new Comp(Convert.ToInt16(vals[1]), vals[0]));

                    }
                    compInfo = new Comp[comps.Count];
                    comps.CopyTo(compInfo);
                    int i = 0;
                    while (compInfo[i].ip / 100 == 1) i++;
                    breakoutCompInfo = new Comp[compInfo.Length - i];
                    speakerCompInfo = new Comp[i];
                    for (int j = i; j < compInfo.Length; j++)
                        breakoutCompInfo[j - i] = compInfo[j];
                    for (int j = 0; j < i; j++)
                        speakerCompInfo[j] = compInfo[j];
                }
                else
                {
                    int split = 0;
                    while(!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        vals = line.Split(',');
                        if (vals[2].Equals("BO"))
                            split++;
                        comps.Add(new Comp(Convert.ToInt16(vals[1]), vals[0]));
                    }
                    compInfo = new Comp[comps.Count];
                    comps.CopyTo(compInfo);
                    breakoutCompInfo = new Comp[split];
                    speakerCompInfo = new Comp[compInfo.Length - split];
                    for (int j = split; j < compInfo.Length; j++)
                        speakerCompInfo[j - split] = compInfo[j];
                    for (int j = 0; j < split; j++)
                        breakoutCompInfo[j] = compInfo[j];

                }
            }
            ConfigForm cfg = new ConfigForm(this);
            if (firstTime)
                cfg.firstTimeSetup();
            else
                cfg.setupFromFile();
            cfg.Show();
        }
    }
}
