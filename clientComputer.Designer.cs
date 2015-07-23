namespace SyncManager
{
    partial class ClientComputer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipAddress = new System.Windows.Forms.Label();
            this.roomName = new System.Windows.Forms.Label();
            this.upSyncChk = new System.Windows.Forms.CheckBox();
            this.downSyncChk = new System.Windows.Forms.CheckBox();
            this.highUpSyncChk = new System.Windows.Forms.CheckBox();
            this.highDownSyncChk = new System.Windows.Forms.CheckBox();
            this.lowUpSyncChk = new System.Windows.Forms.CheckBox();
            this.lowDownSyncChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ipAddress
            // 
            this.ipAddress.AutoSize = true;
            this.ipAddress.Dock = System.Windows.Forms.DockStyle.Left;
            this.ipAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ipAddress.Location = new System.Drawing.Point(0, 0);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(25, 13);
            this.ipAddress.TabIndex = 0;
            this.ipAddress.Text = "263";
            this.ipAddress.Click += new System.EventHandler(this.ipAddress_Click);
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.Dock = System.Windows.Forms.DockStyle.Left;
            this.roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.roomName.Location = new System.Drawing.Point(25, 0);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(40, 13);
            this.roomName.TabIndex = 1;
            this.roomName.Text = "BR103";
            this.roomName.Click += new System.EventHandler(this.ipAddress_Click);
            // 
            // upSyncChk
            // 
            this.upSyncChk.AutoSize = true;
            this.upSyncChk.Dock = System.Windows.Forms.DockStyle.Left;
            this.upSyncChk.Location = new System.Drawing.Point(65, 0);
            this.upSyncChk.Name = "upSyncChk";
            this.upSyncChk.Size = new System.Drawing.Size(53, 18);
            this.upSyncChk.TabIndex = 2;
            this.upSyncChk.Text = "00:00";
            this.upSyncChk.UseVisualStyleBackColor = true;
            this.upSyncChk.CheckedChanged += new System.EventHandler(this.upSync_CheckedChanged);
            // 
            // downSyncChk
            // 
            this.downSyncChk.AutoSize = true;
            this.downSyncChk.Dock = System.Windows.Forms.DockStyle.Left;
            this.downSyncChk.Location = new System.Drawing.Point(118, 0);
            this.downSyncChk.Name = "downSyncChk";
            this.downSyncChk.Size = new System.Drawing.Size(53, 18);
            this.downSyncChk.TabIndex = 4;
            this.downSyncChk.Text = "00:00";
            this.downSyncChk.UseVisualStyleBackColor = true;
            this.downSyncChk.CheckedChanged += new System.EventHandler(this.downSync_CheckedChanged);
            // 
            // highUpSyncChk
            // 
            this.highUpSyncChk.AutoSize = true;
            this.highUpSyncChk.Dock = System.Windows.Forms.DockStyle.Left;
            this.highUpSyncChk.Location = new System.Drawing.Point(171, 0);
            this.highUpSyncChk.Name = "highUpSyncChk";
            this.highUpSyncChk.Size = new System.Drawing.Size(53, 18);
            this.highUpSyncChk.TabIndex = 5;
            this.highUpSyncChk.Text = "00:00";
            this.highUpSyncChk.UseVisualStyleBackColor = true;
            this.highUpSyncChk.CheckedChanged += new System.EventHandler(this.highUpSync_CheckedChanged);
            // 
            // highDownSyncChk
            // 
            this.highDownSyncChk.AutoSize = true;
            this.highDownSyncChk.Dock = System.Windows.Forms.DockStyle.Left;
            this.highDownSyncChk.Location = new System.Drawing.Point(224, 0);
            this.highDownSyncChk.Name = "highDownSyncChk";
            this.highDownSyncChk.Size = new System.Drawing.Size(53, 18);
            this.highDownSyncChk.TabIndex = 6;
            this.highDownSyncChk.Text = "00:00";
            this.highDownSyncChk.UseVisualStyleBackColor = true;
            this.highDownSyncChk.CheckedChanged += new System.EventHandler(this.highDownSync_CheckedChanged);
            // 
            // lowUpSyncChk
            // 
            this.lowUpSyncChk.AutoSize = true;
            this.lowUpSyncChk.Dock = System.Windows.Forms.DockStyle.Left;
            this.lowUpSyncChk.Location = new System.Drawing.Point(277, 0);
            this.lowUpSyncChk.Name = "lowUpSyncChk";
            this.lowUpSyncChk.Size = new System.Drawing.Size(53, 18);
            this.lowUpSyncChk.TabIndex = 7;
            this.lowUpSyncChk.Text = "00:00";
            this.lowUpSyncChk.UseVisualStyleBackColor = true;
            this.lowUpSyncChk.CheckedChanged += new System.EventHandler(this.lowUpSync_CheckedChanged);
            // 
            // lowDownSyncChk
            // 
            this.lowDownSyncChk.AutoSize = true;
            this.lowDownSyncChk.Dock = System.Windows.Forms.DockStyle.Left;
            this.lowDownSyncChk.Location = new System.Drawing.Point(330, 0);
            this.lowDownSyncChk.Name = "lowDownSyncChk";
            this.lowDownSyncChk.Size = new System.Drawing.Size(53, 18);
            this.lowDownSyncChk.TabIndex = 8;
            this.lowDownSyncChk.Text = "00:00";
            this.lowDownSyncChk.UseVisualStyleBackColor = true;
            this.lowDownSyncChk.CheckedChanged += new System.EventHandler(this.lowDownSync_CheckedChanged);
            // 
            // ClientComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lowDownSyncChk);
            this.Controls.Add(this.lowUpSyncChk);
            this.Controls.Add(this.highDownSyncChk);
            this.Controls.Add(this.highUpSyncChk);
            this.Controls.Add(this.downSyncChk);
            this.Controls.Add(this.upSyncChk);
            this.Controls.Add(this.roomName);
            this.Controls.Add(this.ipAddress);
            this.Name = "ClientComputer";
            this.Size = new System.Drawing.Size(407, 18);
            this.Load += new System.EventHandler(this.ClientComputer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipAddress;
        private System.Windows.Forms.Label roomName;
        private System.Windows.Forms.CheckBox upSyncChk;
        private System.Windows.Forms.CheckBox downSyncChk;
        private System.Windows.Forms.CheckBox highUpSyncChk;
        private System.Windows.Forms.CheckBox highDownSyncChk;
        private System.Windows.Forms.CheckBox lowUpSyncChk;
        private System.Windows.Forms.CheckBox lowDownSyncChk;
    }
}
