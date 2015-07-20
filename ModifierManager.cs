using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SyncManager
{
    public partial class ModifierManager : Form
    {
        public SyncForm parentForm;
        public ModManTab[] tabs;
        public string[] newInclusions;
        public string[] newExclusions;

        public ModifierManager(SyncForm myParent)
        {
            InitializeComponent();
            parentForm = myParent;
            tabs = new ModManTab[6];
            newInclusions = new string[6];
            newExclusions = new string[6];
        }

        public void updateModsText()
        {
            for(int i = 0; i<6; i++)
            {
                tabs[i].setInclusions(parentForm.inclusions[i]);
                tabs[i].setExclusions(parentForm.inclusions[i]);
                if (parentForm.exclusions[i].Length >= parentForm.univFilter.Length)
                    if (parentForm.exclusions[i].Substring(0, parentForm.univFilter.Length).Equals(parentForm.univFilter))
                        tabs[i].setExclusions(parentForm.exclusions[i].Substring(parentForm.univFilter.Length));
            }
        }

        private void ModifierManager_Load(object sender, EventArgs e)
        {
            if (parentForm.type == 1)
                Text += " - Speaker Ready";
            else
                Text += " - Breakout";

            for (int i = 0; i < 6; i++)
            {
                tabs[i] = new ModManTab(parentForm, this, i);
                tabs[i].updateUnivFilterChk(parentForm.channelIsUsingUnivFilter[i]);
            }
            upTab.Controls.Add(tabs[0]);
            downTab.Controls.Add(tabs[1]);
            hiUpTab.Controls.Add(tabs[2]);
            hiDnTab.Controls.Add(tabs[3]);
            loUpTab.Controls.Add(tabs[4]);
            loDnTab.Controls.Add(tabs[5]);
            updateModsText();
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<6; i++)
            {
                tabs[i].updateNew();
                if (tabs[i].isUsingUnivFilter())
                    newExclusions[i] += parentForm.univFilter;
                parentForm.exclusions[i] = newExclusions[i];
                parentForm.inclusions[i] = newInclusions[i];
            }
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
