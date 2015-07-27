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
    public partial class configForm : Form
    {
        public SetupForm parentForm;
        private int speakerReadyStartIP;
        private int speakerReadyEndIP;
        private int breakoutStartIP;
        private int breakoutEndIP;

        public configForm(SetupForm myParent)
        {
            InitializeComponent();
            parentForm = myParent;
        }

        private void configForm_Load(object sender, EventArgs e)
        {
            

            
            
            
        }

        private void setupFromFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"c:\cshow\extras\syncManagerConfig.xml");

            importFilePathTxt.Text = doc.SelectSingleNode("/configs/importFilePath").InnerText;
            numSRCompsTxt.Text = doc.SelectSingleNode("/configs/numSRComps").InnerText;
            numBOCompsTxt.Text = doc.SelectSingleNode("/configs/numBOComps").InnerText;
            ipSchemeTxt.Text = doc.SelectSingleNode("/configs/ipScheme").InnerText;
            screenTxt.Text = doc.SelectSingleNode("/configs/screenSize").InnerText;
            lowSRStartTxt.Text = doc.SelectSingleNode("/configs/divisions/startSRLow").InnerText;
            lowSREndTxt.Text = doc.SelectSingleNode("/configs/divisions/endSRLow").InnerText;
            highSRStartTxt.Text = doc.SelectSingleNode("/configs/divisions/startSRHigh").InnerText;
            highSREndTxt.Text = doc.SelectSingleNode("/configs/divisions/endSRHigh").InnerText;
            lowBOStartTxt.Text = doc.SelectSingleNode("/configs/divisions/startBOLow").InnerText;
            lowBOEndTxt.Text = doc.SelectSingleNode("/configs/divisions/endBOLow").InnerText;
            highBOStartTxt.Text = doc.SelectSingleNode("/configs/divisions/startBOHigh").InnerText;
            highBOEndTxt.Text = doc.SelectSingleNode("/configs/divisions/endBOHigh").InnerText;
        }

        private void firstTimeSetup()
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
        }

        private int[] findBounds()
        {
            int[] retvals = new int[4];
            int i = 0;
            while (parentForm.compInfo[i].ip / 100 == 1) i++;
            retvals[0] = parentForm.compInfo[0].ip;
            retvals[1] = parentForm.compInfo[i - 1].ip;
            retvals[2] = parentForm.compInfo[i].ip;
            retvals[3] = parentForm.compInfo[parentForm.compInfo.Length - 1].ip;
            return retvals;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            Close();
        }

        
    }
}
