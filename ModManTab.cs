using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SyncManager
{
    public partial class ModManTab : UserControl
    {
        public SyncForm parentForm;

        public ModManTab(SyncForm myParent)
        {
            InitializeComponent();
            parentForm = myParent;
        }

        public void setExclusions(string newExclusions)
        {
            exclusionTxt.Text = newExclusions;
        }

        public void setInclusions(string newInclusions)
        {
            inclusionTxt.Text = newInclusions;
        }

        private void monBtn_Click(object sender, EventArgs e)
        {
            exclusionTxt.Text += "\\Monday;";
        }
        private void tueBtn_Click(object sender, EventArgs e)
        {
            exclusionTxt.Text += "\\Tuesday;";
        }
        private void wedBtn_Click(object sender, EventArgs e)
        {
            exclusionTxt.Text += "\\Wednesday;";
        }
        private void thuBtn_Click(object sender, EventArgs e)
        {
            exclusionTxt.Text += "\\Thursday;";
        }
        private void friBtn_Click(object sender, EventArgs e)
        {
            exclusionTxt.Text += "\\Friday;";
        }
        private void satBtn_Click(object sender, EventArgs e)
        {
            exclusionTxt.Text += "\\Saturday;";
        }
        private void sunBtn_Click(object sender, EventArgs e)
        {
            exclusionTxt.Text += "\\Sunday;";
        }
        private void extrasBtn_Click(object sender, EventArgs e)
        {
            exclusionTxt.Text += "\\Extras;";
        }
        private void syncBtn_Click(object sender, EventArgs e)
        {
            exclusionTxt.Text += "\\SYNC;";
        }

        private void useUniversalFilterChk_CheckedChanged(object sender, EventArgs e)
        {
            if (!useUniversalFilterChk.Checked)
                for (int i = 0; i < 6; i++)
                    parentForm.exclusions[i] = parentForm.exclusions[i].Substring(parentForm.univFilter.Length);
            else
                for (int i = 0; i < 6; i++)
                    parentForm.exclusions[i].Insert(0, parentForm.univFilter);
            updateMods();
        }

    }
}
