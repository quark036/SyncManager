using System;
using System.Windows.Forms;

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

        public SetupForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            speakerReadyStartIP = Convert.ToInt16(speakerReadyIPStart.Text);
            speakerReadyEndIP = Convert.ToInt16(speakerReadyIPEnd.Text);
            breakoutStartIP = Convert.ToInt16(breakoutIPStart.Text);
            breakoutEndIP = Convert.ToInt16(breakoutIPEnd.Text);
            int[] bounds = { speakerReadyStartIP, speakerReadyEndIP, breakoutStartIP, breakoutEndIP };
            SyncForm speakerReadySync = new SyncForm(bounds, this, 1);
            speakerReadySync.Show();
            SyncForm breakoutSync = new SyncForm(bounds, this, 2);
            breakoutSync.Show();
            Hide();
        }

        public void quit()
        {
            Close();
        }
    }
}
