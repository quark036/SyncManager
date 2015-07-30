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
    //this class holds the modifiers for 1 sync channel
    //so there are 6 of these in a modifier manager
    //only tricky thing is using the universal filter but not displaying it
    public partial class ModManTab : UserControl
    {
        public SyncForm parentForm;
        public ModifierManager owner;
        public int channel;

        public ModManTab(SyncForm myParent, ModifierManager myOwner, int chan)
        {
            InitializeComponent();
            parentForm = myParent;
            owner = myOwner;
            channel = chan;
        }

        //accessors
        public void setExclusions(string newExclusions)
        {
            exclusionTxt.Text = newExclusions;
        }
        public void setInclusions(string newInclusions)
        {
            inclusionTxt.Text = newInclusions;
        }

        //easy buttons to add filters
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

        public void updateUnivFilterChk(bool isChecked)
        {
            useUniversalFilterChk.Checked = isChecked;
        }

        //updates the arrays of modifiers that will need to be saved after modman closes
        public void updateNew()
        {
            owner.newExclusions[channel] += exclusionTxt.Text;
            owner.newInclusions[channel] += inclusionTxt.Text;
        }

        public bool isUsingUnivFilter()
        {
            return useUniversalFilterChk.Checked;
        }

        //copy the settings of the current tab to all of the tabs
        private void copyAllBtn_Click(object sender, EventArgs e)
        {
            string newInclusions = inclusionTxt.Text;
            string newExclusions = exclusionTxt.Text;
            for (int i = 0; i < 6; i++)
            {
                owner.tabs[i].setExclusions(newExclusions);
                owner.tabs[i].setInclusions(newInclusions);
            }
        }

        //more easy buttons
        private void clearExclusionsBtn_Click(object sender, EventArgs e)
        {
            exclusionTxt.Text = "";
        }

        private void clearInclusionsBtn_Click(object sender, EventArgs e)
        {
            inclusionTxt.Text = "";
        }

        private void useUniversalFilterChk_CheckedChanged(object sender, EventArgs e)
        {
            parentForm.channelIsUsingUnivFilter[channel] = useUniversalFilterChk.Checked;
        }
    }
}
