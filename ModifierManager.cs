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
        public SyncForm parentForm { get; set; }

        public ModifierManager(SyncForm myParent)
        {
            InitializeComponent();
            parentForm = myParent;
            updateMods();
        }

        private void updateMods()
        {
            upInclusionTxt.Text = parentForm.inclusions[0];
            downInclusionTxt.Text = parentForm.inclusions[1];
            hiUpInclusionTxt.Text = parentForm.inclusions[2];
            hiDnInclusionTxt.Text = parentForm.inclusions[3];
            loUpInclusionTxt.Text = parentForm.inclusions[4];
            loDnInclusionTxt.Text = parentForm.inclusions[5];

            if (parentForm.exclusions[0].Length >= parentForm.univFilter.Length)
            {
                if (parentForm.exclusions[0].Substring(0, parentForm.univFilter.Length).Equals(parentForm.univFilter))
                {
                    upExclusionTxt.Text = parentForm.exclusions[0].Substring(parentForm.univFilter.Length);
                    downExclusionTxt.Text = parentForm.exclusions[1].Substring(parentForm.univFilter.Length);
                    hiUpExclusionTxt.Text = parentForm.exclusions[2].Substring(parentForm.univFilter.Length);
                    hiDnExclusionTxt.Text = parentForm.exclusions[3].Substring(parentForm.univFilter.Length);
                    loUpExclusionTxt.Text = parentForm.exclusions[4].Substring(parentForm.univFilter.Length);
                    loDnExclusionTxt.Text = parentForm.exclusions[5].Substring(parentForm.univFilter.Length);
                }
            }
            else
            {
                upExclusionTxt.Text = parentForm.exclusions[0];
                downExclusionTxt.Text = parentForm.exclusions[1];
                hiUpExclusionTxt.Text = parentForm.exclusions[2];
                hiDnExclusionTxt.Text = parentForm.exclusions[3];
                loUpExclusionTxt.Text = parentForm.exclusions[4];
                loDnExclusionTxt.Text = parentForm.exclusions[5];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void upSaveBtn_Click(object sender, EventArgs e)
        {
            parentForm.inclusions[0] = upInclusionTxt.Text;
            parentForm.exclusions[0] = upExclusionTxt.Text;
        }
        private void downSaveBtn_Click(object sender, EventArgs e)
        {
            parentForm.inclusions[1] = downInclusionTxt.Text;
            parentForm.exclusions[1] = downExclusionTxt.Text;
        }
        private void hiUpSaveBtn_Click(object sender, EventArgs e)
        {
            parentForm.inclusions[2] = hiUpInclusionTxt.Text;
            parentForm.exclusions[2] = hiUpExclusionTxt.Text;
        }
        private void hiDnSaveBtn_Click(object sender, EventArgs e)
        {
            parentForm.inclusions[3] = hiDnInclusionTxt.Text;
            parentForm.exclusions[3] = hiDnExclusionTxt.Text;
        }
        private void loUpSaveBtn_Click(object sender, EventArgs e)
        {
            parentForm.inclusions[4] = loUpInclusionTxt.Text;
            parentForm.exclusions[4] = loUpExclusionTxt.Text;
        }
        private void loDnSaveBtn_Click(object sender, EventArgs e)
        {
            parentForm.inclusions[5] = loDnInclusionTxt.Text;
            parentForm.exclusions[5] = loDnExclusionTxt.Text;
        }

        private void ModifierManager_Load(object sender, EventArgs e)
        {
            if (parentForm.type == 1)
                Text += " - Speaker Ready";
            else
                Text += " - Breakout";
        }

        private void easyFltrBtn_Click(object sender, EventArgs e)
        {
            Button sentBy = (Button)sender;
            string chan = sentBy.Name.Substring(0, 2);
            int channel; string day;
            if (chan.Equals("up"))
                channel = 0;
            else if (chan.Equals("dn"))
                channel = 1;
            else if (chan.Equals("hu"))
                channel = 2;
            else if (chan.Equals("hd"))
                channel = 3;
            else if (chan.Equals("lu"))
                channel = 4;
            else
                channel = 5;

            if (sentBy.Text.Equals("Sync"))
                parentForm.exclusions[channel] += "\\SYNC;";
            else if (sentBy.Text.Equals("Extras"))
                parentForm.exclusions[channel] += "\\Extras;";
            else
            {
                if (sentBy.Text.Equals("Mon"))
                    day = "\\Monday";
                else if (sentBy.Text.Equals("Tue"))
                    day = "\\Tuesday";
                else if (sentBy.Text.Equals("Wed"))
                    day = "\\Wednesday";
                else if (sentBy.Text.Equals("Thu"))
                    day = "\\Thursday";
                else if (sentBy.Text.Equals("Fri"))
                    day = "\\Friday";
                else if (sentBy.Text.Equals("Sat"))
                    day = "\\Saturday";
                else
                    day = "\\Sunday";
                parentForm.exclusions[channel] += day + ";";
            }
            updateMods();
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
