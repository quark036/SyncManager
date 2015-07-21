using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncManager
{
    public partial class ClientComputer : UserControl
    {

        public bool[] syncingTypesActive; //0:up|1:down|2:highup|3:highdown|4:lowup|5:lowdown
        public SyncForm parentForm;
        public int ip;

        public ClientComputer(SyncForm myParent, int myIP)
        {
            InitializeComponent();
            parentForm = myParent;
            syncingTypesActive = new bool[6];
            ip = myIP;
        }

        private void ClientComputer_Load(object sender, EventArgs e)
        {
            ipAddress.Text = ip.ToString();
        }

        public ClientComputer()
        {
            InitializeComponent();
        }

        public void setIP(int _ip)
        {
            ipAddress.Text = _ip.ToString();
            ip = _ip;
        }

        public Label getClockByChannel(int channel)
        {
            if (channel == 0)
                return upSyncTime;
            else if (channel == 1)
                return downSyncTime;
            else if (channel == 2)
                return hiUpSyncTime;
            else if (channel == 3)
                return hiDnSyncTime;
            else if (channel == 4)
                return loUpSyncTime;
            else
                return loDnSyncTime;
        }

        public void updateLastPing()
        {
            string minute = DateTime.Now.Minute.ToString();
            if (minute.Length == 1)
                minute = "0" + minute;
            lastPinged.Text = DateTime.Now.Hour.ToString() + ":" + minute;
            BackColor = Color.Empty;
        }

        public void hide(int channel)
        {
            if (channel == 2)
            {
                highUpSyncChk.Visible = false;
                hiUpSyncTime.Visible = false;
            }
            else if (channel == 3)
            {
                highDownSyncChk.Visible = false;
                hiDnSyncTime.Visible = false;
            }
            else if (channel == 4)
            {
                lowUpSyncChk.Visible = false;
                loUpSyncTime.Visible = false;
            }
            else if (channel == 5)
            {
                lowDownSyncChk.Visible = false;
                loDnSyncTime.Visible = false;
            }

        }

        public void highlight(int channel)
        {
            if(channel==0)
            {
                if (upSyncChk.Checked)
                    upSyncTime.BackColor = Color.Cyan;
                else
                    upSyncTime.BackColor = Color.Empty;
            }
            if (channel == 1)
            {
                if (downSyncChk.Checked)
                    downSyncTime.BackColor = Color.Cyan;
                else
                    downSyncTime.BackColor = Color.Empty;
            }
            if (channel == 2)
            {
                if (highUpSyncChk.Checked)
                    hiUpSyncTime.BackColor = Color.Cyan;
                else
                    hiUpSyncTime.BackColor = Color.Empty;
            }
            if (channel == 3)
            {
                if (highDownSyncChk.Checked)
                    hiDnSyncTime.BackColor = Color.Cyan;
                else
                    hiDnSyncTime.BackColor = Color.Empty;
            }
            if (channel == 4)
            {
                if (lowUpSyncChk.Checked)
                    loUpSyncTime.BackColor = Color.Cyan;
                else
                    loUpSyncTime.BackColor = Color.Empty;
            }
            if (channel == 5)
            {
                if (lowDownSyncChk.Checked)
                    loDnSyncTime.BackColor = Color.Cyan;
                else
                    loDnSyncTime.BackColor = Color.Empty;
            }
        }

        private void upSync_CheckedChanged(object sender, EventArgs e)
        {
            syncingTypesActive[0] = upSyncChk.Checked;
        }
        private void downSync_CheckedChanged(object sender, EventArgs e)
        {
            syncingTypesActive[1] = downSyncChk.Checked;
        }
        private void highUpSync_CheckedChanged(object sender, EventArgs e)
        {
            syncingTypesActive[2] = highUpSyncChk.Checked;
        }
        private void highDownSync_CheckedChanged(object sender, EventArgs e)
        {
            syncingTypesActive[3] = highDownSyncChk.Checked;
        }
        private void lowUpSync_CheckedChanged(object sender, EventArgs e)
        {
            syncingTypesActive[4] = lowUpSyncChk.Checked;
        }
        private void lowDownSync_CheckedChanged(object sender, EventArgs e)
        {
            syncingTypesActive[5] = lowDownSyncChk.Checked;
        }

        public void setUpSyncChk(bool value)
        {
            upSyncChk.Checked = value;
        }
        public void setDownSyncChk(bool value)
        {
            downSyncChk.Checked = value;
        }
        public void setHiUpSyncChk(bool value)
        {
            highUpSyncChk.Checked = value;
        }
        public void setHiDownSyncChk(bool value)
        {
            highDownSyncChk.Checked = value;
        }
        public void setLoUpSyncChk(bool value)
        {
            lowUpSyncChk.Checked = value;
        }
        public void setLoDownSyncChk(bool value)
        {
            lowDownSyncChk.Checked = value;
        }

        private void ipAddress_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                syncingTypesActive[i] = false;
            }
            upSyncChk.Checked = false;
            downSyncChk.Checked = false;
            highUpSyncChk.Checked = false;
            highDownSyncChk.Checked = false;
            lowUpSyncChk.Checked = false;
            lowDownSyncChk.Checked = false;
        }
    }
}
