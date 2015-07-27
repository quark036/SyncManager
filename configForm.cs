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
            XmlDocument doc = new XmlDocument();
            doc.Load(@"c:\cshow\extras\syncManagerConfig.xml");

            importFilePathTxt.Text = doc.SelectSingleNode("/configs/importFilePath").InnerText;
            int[] bounds = findBounds();
            
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
