using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SyncManager
{
    public partial class ConfigForm : Form
    {
        public SetupForm parentForm;
        public SyncForm speakerReadyForm;
        public SyncForm breakoutForm;
        public SyncForm zoneForm;

        public ConfigForm(SetupForm myParent)
        {
            InitializeComponent();
            parentForm = myParent;
        }

        private void configForm_Load(object sender, EventArgs e)
        {
            Show();
        }

        public void setupFromFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"c:\cshow\extras\syncManagerConfig.xml");
            
            numSRCompsTxt.Text = doc.SelectSingleNode("/configs/numSRComps").InnerText;
            numBOCompsTxt.Text = doc.SelectSingleNode("/configs/numBOComps").InnerText;
            screenTxt.Text = doc.SelectSingleNode("/configs/screenSize").InnerText;
            lowSRStartTxt.Text = doc.SelectSingleNode("/configs/divisions/startSRLow").InnerText;
            lowSREndTxt.Text = doc.SelectSingleNode("/configs/divisions/endSRLow").InnerText;
            highSRStartTxt.Text = doc.SelectSingleNode("/configs/divisions/startSRHigh").InnerText;
            highSREndTxt.Text = doc.SelectSingleNode("/configs/divisions/endSRHigh").InnerText;
            lowBOStartTxt.Text = doc.SelectSingleNode("/configs/divisions/startBOLow").InnerText;
            lowBOEndTxt.Text = doc.SelectSingleNode("/configs/divisions/endBOLow").InnerText;
            highBOStartTxt.Text = doc.SelectSingleNode("/configs/divisions/startBOHigh").InnerText;
            highBOEndTxt.Text = doc.SelectSingleNode("/configs/divisions/endBOHigh").InnerText;
            doc.Save(@"c:\cshow\extras\syncManagerConfig.xml");
        }

        public void firstTimeSetup()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"c:\cshow\extras\syncManagerConfig.xml");
            int[] bounds = findBounds();
            doc.SelectSingleNode("/configs/numSRComps").InnerText = (bounds[1] - bounds[0] + 1).ToString();
            doc.SelectSingleNode("/configs/numBOComps").InnerText = (bounds[3] - bounds[2] + 1).ToString();
            doc.SelectSingleNode("/configs/divisions/startSRLow").InnerText = bounds[0].ToString();
            doc.SelectSingleNode("/configs/divisions/endSRLow").InnerText = ((bounds[0] + bounds[1])/2).ToString();
            doc.SelectSingleNode("/configs/divisions/startSRHigh").InnerText = (((bounds[0] + bounds[1]) / 2) + 1).ToString();
            doc.SelectSingleNode("/configs/divisions/endSRHigh").InnerText = bounds[1].ToString();
            doc.SelectSingleNode("/configs/divisions/startBOLow").InnerText = bounds[2].ToString();
            doc.SelectSingleNode("/configs/divisions/endBOLow").InnerText = ((bounds[2] + bounds[3]) / 2).ToString();
            doc.SelectSingleNode("/configs/divisions/startBOHigh").InnerText = (((bounds[2] + bounds[3]) / 2) + 1).ToString();
            doc.SelectSingleNode("/configs/divisions/endBOHigh").InnerText = bounds[3].ToString();
            doc.Save(@"c:\cshow\extras\syncManagerConfig.xml");

            setupFromFile();
        }

        private int[] findBounds()
        {
            int[] retvals = new int[4];
            if (parentForm.isClassC)
            {
                int i = 0;
                while (parentForm.compInfo[i].ip / 100 == 1) i++;
                retvals[0] = parentForm.compInfo[0].ip;
                retvals[1] = parentForm.compInfo[i - 1].ip;
                retvals[2] = parentForm.compInfo[i].ip;
                retvals[3] = parentForm.compInfo[parentForm.compInfo.Length - 1].ip;
            }
            else
            {
                retvals[0] = parentForm.speakerCompInfo[0].ip;
                retvals[1] = parentForm.speakerCompInfo[parentForm.speakerCompInfo.Length - 1].ip;
                retvals[2] = parentForm.breakoutCompInfo[0].ip;
                retvals[3] = parentForm.breakoutCompInfo[parentForm.breakoutCompInfo.Length - 1].ip;
            }
            return retvals;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            parentForm.Close();
            Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"c:\cshow\extras\syncManagerConfig.xml");
            int[] bounds = findBounds();
            doc.SelectSingleNode("/configs/numSRComps").InnerText = numSRCompsTxt.Text;
            doc.SelectSingleNode("/configs/numBOComps").InnerText = numBOCompsTxt.Text;
            doc.SelectSingleNode("/configs/divisions/startSRLow").InnerText = lowSRStartTxt.Text;
            doc.SelectSingleNode("/configs/divisions/endSRLow").InnerText = lowSREndTxt.Text;
            doc.SelectSingleNode("/configs/divisions/startSRHigh").InnerText = highSRStartTxt.Text;
            doc.SelectSingleNode("/configs/divisions/endSRHigh").InnerText = highSREndTxt.Text;
            doc.SelectSingleNode("/configs/divisions/startBOLow").InnerText = lowBOStartTxt.Text;
            doc.SelectSingleNode("/configs/divisions/endBOLow").InnerText = lowBOEndTxt.Text;
            doc.SelectSingleNode("/configs/divisions/startBOHigh").InnerText = highBOStartTxt.Text;
            doc.SelectSingleNode("/configs/divisions/endBOHigh").InnerText = highBOEndTxt.Text;
            doc.SelectSingleNode("/configs/screenSize").InnerText = screenTxt.Text;
            doc.Save(@"c:\cshow\extras\syncManagerConfig.xml");
            parentForm.launch();
            Close();
        }
        
    }
}
