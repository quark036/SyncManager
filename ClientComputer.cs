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

        public void setRoom(string room)
        {
            roomName.Text = room;
        }

        public void conceal(int channel)
        {
            if (channel == 0)
                upSyncChk.Visible = false;
            else if (channel == 1)
                downSyncChk.Visible = false;
            else if (channel == 2)
                highUpSyncChk.Visible = false;
            else if (channel == 3)
                highDownSyncChk.Visible = false;
            else if (channel == 4)
                lowUpSyncChk.Visible = false;
            else if (channel == 5)
                lowDownSyncChk.Visible = false;
        }

        public void reveal(int channel)
        {
            if (channel == 0)
                upSyncChk.Visible = true;
            else if (channel == 1)
                downSyncChk.Visible = true;
            else if (channel == 2)
                highUpSyncChk.Visible = true;
            else if (channel == 3)
                highDownSyncChk.Visible = true;
            else if (channel == 4)
                lowUpSyncChk.Visible = true;
            else if (channel == 5)
                lowDownSyncChk.Visible = true;
        }

        public CheckBox getClockByChannel(int channel)
        {
            if (channel == 0)
                return upSyncChk;
            else if (channel == 1)
                return downSyncChk;
            else if (channel == 2)
                return highUpSyncChk;
            else if (channel == 3)
                return highDownSyncChk;
            else if (channel == 4)
                return lowUpSyncChk;
            else
                return lowDownSyncChk;
        }

        public void updateLastPing()
        {
            string minute = DateTime.Now.Minute.ToString();
            if (minute.Length == 1)
                minute = "0" + minute;
            lastPinged.Text = DateTime.Now.Hour.ToString() + ":" + minute;
            BackColor = Color.Empty;
        }

        public void show(int channel)
        {
            syncTable.ColumnStyles[channel + 2].Width = 60;
        }

        public void hide(int channel)
        {
            syncTable.ColumnStyles[channel + 2].Width = 0;
        }

        public void highlight(int channel)
        {
            if(channel==0)
            {
                if (upSyncChk.Checked)
                    upSyncChk.BackColor = Color.Cyan;
                else
                    upSyncChk.BackColor = Color.Empty;
            }
            if (channel == 1)
            {
                if (downSyncChk.Checked)
                    downSyncChk.BackColor = Color.Cyan;
                else
                    downSyncChk.BackColor = Color.Empty;
            }
            if (channel == 2)
            {
                if (highUpSyncChk.Checked)
                    highUpSyncChk.BackColor = Color.Cyan;
                else
                    highUpSyncChk.BackColor = Color.Empty;
            }
            if (channel == 3)
            {
                if (highDownSyncChk.Checked)
                    highDownSyncChk.BackColor = Color.Cyan;
                else
                    highDownSyncChk.BackColor = Color.Empty;
            }
            if (channel == 4)
            {
                if (lowUpSyncChk.Checked)
                    lowUpSyncChk.BackColor = Color.Cyan;
                else
                    lowUpSyncChk.BackColor = Color.Empty;
            }
            if (channel == 5)
            {
                if (lowDownSyncChk.Checked)
                    lowDownSyncChk.BackColor = Color.Cyan;
                else
                    lowDownSyncChk.BackColor = Color.Empty;
            }
        }

        private void upSync_CheckedChanged(object sender, EventArgs e)
        {
            syncingTypesActive[0] = upSyncChk.Checked;
            if (upSyncChk.Checked)
                parentForm.numCompsActiveByType[0]++;
            else
                parentForm.numCompsActiveByType[0]--;
            parentForm.updateUpNum();
        }
        private void downSync_CheckedChanged(object sender, EventArgs e)
        {
            syncingTypesActive[1] = downSyncChk.Checked;
            if (downSyncChk.Checked)
                parentForm.numCompsActiveByType[1]++;
            else
                parentForm.numCompsActiveByType[1]--;
            parentForm.updateDownNum();
        }
        private void highUpSync_CheckedChanged(object sender, EventArgs e)
        {
            syncingTypesActive[2] = highUpSyncChk.Checked;
            if (highUpSyncChk.Checked)
                parentForm.numCompsActiveByType[2]++;
            else
                parentForm.numCompsActiveByType[2]--;
            parentForm.updateHiUpNum();
        }
        private void highDownSync_CheckedChanged(object sender, EventArgs e)
        {
            syncingTypesActive[3] = highDownSyncChk.Checked;
            if (highDownSyncChk.Checked)
                parentForm.numCompsActiveByType[3]++;
            else
                parentForm.numCompsActiveByType[3]--;
            parentForm.updateHiDnNum();
        }
        private void lowUpSync_CheckedChanged(object sender, EventArgs e)
        {
            syncingTypesActive[4] = lowUpSyncChk.Checked;
            if (lowUpSyncChk.Checked)
                parentForm.numCompsActiveByType[4]++;
            else
                parentForm.numCompsActiveByType[4]--;
            parentForm.updateLoUpNum();
        }
        private void lowDownSync_CheckedChanged(object sender, EventArgs e)
        {
            syncingTypesActive[5] = lowDownSyncChk.Checked;
            if (lowDownSyncChk.Checked)
                parentForm.numCompsActiveByType[5]++;
            else
                parentForm.numCompsActiveByType[5]--;
            parentForm.updateLoDnNum();
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
