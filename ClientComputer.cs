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
    //this represents one of the computers we are going to sync to, whether speaker ready or breakout
    public partial class ClientComputer : UserControl
    {

        public bool[] syncingTypesActive; //0:up|1:down|2:highup|3:highdown|4:lowup|5:lowdown
        public SyncForm parentForm; //have a reference to the syncform that created it, so you can access those variables
        public int ip; //ip to sync to-only the last octet is stored (so I can use it in loops as an int not a string)

        public ClientComputer(SyncForm myParent, int myIP)
        {
            InitializeComponent();
            parentForm = myParent;
            syncingTypesActive = new bool[6];
            ip = myIP;
        }

        //these next ones are pretty self-explanatory
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

        public int getRoomWidth()
        {
            return roomName.Width;
        }

        public void resizeRoom(int width)
        {
            syncTable.ColumnStyles[1].SizeType = SizeType.Absolute;
            syncTable.ColumnStyles[1].Width = width;
        }

        public string getRoomName()
        {
            return roomName.Text;
        }
        

        //slight misnomer, I ended up combining the clock and the checkbox, because I realized
        //I could just use the checkbox.text for the clock, instead of a separate label
        //anyways, it returns the checkbox for that channel
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

        //updates the clock for the last ping, just minute and hour, if you want seconds too, you could add that easily
        //also makes sure you are using 2 digits for the minute, so 12:04 doesnt appear as 12:4
        public void updateLastPing()
        {
            string minute = DateTime.Now.Minute.ToString();
            if (minute.Length == 1)
                minute = "0" + minute;
            lastPinged.Text = DateTime.Now.Hour.ToString() + ":" + minute;
            BackColor = Color.Empty;
        }

        //use this to hide the channel specified, by making it 0 width
        public void hide(int channel)
        {
            syncTable.ColumnStyles[channel + 2].Width = 0;
        }

        //just makes the clock/checkbox visible, which will make the table resize to show that column
        public void show(int channel)
        {
            syncTable.ColumnStyles[channel + 2].Width = 60;
        }
        
        //the reason I have both hide/show and conceal/reveal is for low/high
        //if I just used hide to hide the high computers in the low channel
        //then the table would collapse left and it wouldn't show properly
        //so I conceal the checkbox/clocks, so that you can't see or click on them
        //but they don't go away
        //So you have to be careful, with things like the all-switches, because these checkboxes
        //are still there, just invisible, so you don't want to try do things with them, because
        //you will still hit them if you iterate through the computer list
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

        //see comment above conceal
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

        //when you check or uncheck a box, it changes it in this computer's array of sync types
        //it also tells the parentform to update the number of computers it is displaying for
        //this sync type
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

        //setters so that I can access the checkbox controls, because those are inherently private
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

        //you can click on the ip address or the name of the computer (both call this function)
        //and it will uncheck all of the sync types
        //this is so that you can get it out of all the sync channels so you can unplug it
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
