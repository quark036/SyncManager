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
    public partial class LoHiForm : Form
    {
        private SyncForm parentForm;
        private bool success;
        private int lowBottomBound;
        private int lowTopBound;
        private int highBottomBound;
        private int highTopBound;

        public LoHiForm(SyncForm myParent)
        {
            InitializeComponent();
            parentForm = myParent;
            int[] vals = parentForm.getHiLoBounds();
            lowIPStart.Text = vals[0].ToString();
            lowIPEnd.Text = vals[1].ToString();
            highIPStart.Text = vals[2].ToString();
            highIPEnd.Text = vals[3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                lowBottomBound = Convert.ToInt16(lowIPStart.Text);
                lowTopBound = Convert.ToInt16(lowIPEnd.Text);
                highBottomBound = Convert.ToInt16(highIPStart.Text);
                highTopBound = Convert.ToInt16(highIPEnd.Text);
                success = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Valid Bounds");
                success = false;
            }
            if(success)
            {
                parentForm.adjustHiLoBounds(lowBottomBound, lowTopBound, highBottomBound, highTopBound);
                Close();
            }
        }
    }
}
