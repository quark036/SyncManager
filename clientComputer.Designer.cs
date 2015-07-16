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
            this.lastUpdated = new System.Windows.Forms.Label();
            this.downSyncChk = new System.Windows.Forms.CheckBox();
            this.highUpSyncChk = new System.Windows.Forms.CheckBox();
            this.highDownSyncChk = new System.Windows.Forms.CheckBox();
            this.lowUpSyncChk = new System.Windows.Forms.CheckBox();
            this.lowDownSyncChk = new System.Windows.Forms.CheckBox();
            this.upSyncTime = new System.Windows.Forms.Label();
            this.downSyncTime = new System.Windows.Forms.Label();
            this.hiUpSyncTime = new System.Windows.Forms.Label();
            this.hiDnSyncTime = new System.Windows.Forms.Label();
            this.loUpSyncTime = new System.Windows.Forms.Label();
            this.loDnSyncTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipAddress
            // 
            this.ipAddress.AutoSize = true;
            this.ipAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ipAddress.Location = new System.Drawing.Point(3, -1);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(45, 25);
            this.ipAddress.TabIndex = 0;
            this.ipAddress.Text = "100";
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.roomName.Location = new System.Drawing.Point(45, -1);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(71, 25);
            this.roomName.TabIndex = 1;
            this.roomName.Text = "BR103";
            // 
            // upSyncChk
            // 
            this.upSyncChk.AutoSize = true;
            this.upSyncChk.Location = new System.Drawing.Point(150, 5);
            this.upSyncChk.Name = "upSyncChk";
            this.upSyncChk.Size = new System.Drawing.Size(15, 14);
            this.upSyncChk.TabIndex = 2;
            this.upSyncChk.UseVisualStyleBackColor = true;
            this.upSyncChk.CheckedChanged += new System.EventHandler(this.upSync_CheckedChanged);
            // 
            // lastUpdated
            // 
            this.lastUpdated.AutoSize = true;
            this.lastUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lastUpdated.Location = new System.Drawing.Point(973, 0);
            this.lastUpdated.Name = "lastUpdated";
            this.lastUpdated.Size = new System.Drawing.Size(55, 24);
            this.lastUpdated.TabIndex = 3;
            this.lastUpdated.Text = "00:00";
            // 
            // downSyncChk
            // 
            this.downSyncChk.AutoSize = true;
            this.downSyncChk.Location = new System.Drawing.Point(290, 5);
            this.downSyncChk.Name = "downSyncChk";
            this.downSyncChk.Size = new System.Drawing.Size(15, 14);
            this.downSyncChk.TabIndex = 4;
            this.downSyncChk.UseVisualStyleBackColor = true;
            this.downSyncChk.CheckedChanged += new System.EventHandler(this.downSync_CheckedChanged);
            // 
            // highUpSyncChk
            // 
            this.highUpSyncChk.AutoSize = true;
            this.highUpSyncChk.Location = new System.Drawing.Point(430, 5);
            this.highUpSyncChk.Name = "highUpSyncChk";
            this.highUpSyncChk.Size = new System.Drawing.Size(15, 14);
            this.highUpSyncChk.TabIndex = 5;
            this.highUpSyncChk.UseVisualStyleBackColor = true;
            this.highUpSyncChk.CheckedChanged += new System.EventHandler(this.highUpSync_CheckedChanged);
            // 
            // highDownSyncChk
            // 
            this.highDownSyncChk.AutoSize = true;
            this.highDownSyncChk.Location = new System.Drawing.Point(570, 5);
            this.highDownSyncChk.Name = "highDownSyncChk";
            this.highDownSyncChk.Size = new System.Drawing.Size(15, 14);
            this.highDownSyncChk.TabIndex = 6;
            this.highDownSyncChk.UseVisualStyleBackColor = true;
            this.highDownSyncChk.CheckedChanged += new System.EventHandler(this.highDownSync_CheckedChanged);
            // 
            // lowUpSyncChk
            // 
            this.lowUpSyncChk.AutoSize = true;
            this.lowUpSyncChk.Location = new System.Drawing.Point(710, 5);
            this.lowUpSyncChk.Name = "lowUpSyncChk";
            this.lowUpSyncChk.Size = new System.Drawing.Size(15, 14);
            this.lowUpSyncChk.TabIndex = 7;
            this.lowUpSyncChk.UseVisualStyleBackColor = true;
            this.lowUpSyncChk.CheckedChanged += new System.EventHandler(this.lowUpSync_CheckedChanged);
            // 
            // lowDownSyncChk
            // 
            this.lowDownSyncChk.AutoSize = true;
            this.lowDownSyncChk.Location = new System.Drawing.Point(850, 5);
            this.lowDownSyncChk.Name = "lowDownSyncChk";
            this.lowDownSyncChk.Size = new System.Drawing.Size(15, 14);
            this.lowDownSyncChk.TabIndex = 8;
            this.lowDownSyncChk.UseVisualStyleBackColor = true;
            this.lowDownSyncChk.CheckedChanged += new System.EventHandler(this.lowDownSync_CheckedChanged);
            // 
            // upSyncTime
            // 
            this.upSyncTime.AutoSize = true;
            this.upSyncTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.upSyncTime.Location = new System.Drawing.Point(171, 0);
            this.upSyncTime.Name = "upSyncTime";
            this.upSyncTime.Size = new System.Drawing.Size(55, 24);
            this.upSyncTime.TabIndex = 9;
            this.upSyncTime.Text = "00:00";
            // 
            // downSyncTime
            // 
            this.downSyncTime.AutoSize = true;
            this.downSyncTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.downSyncTime.Location = new System.Drawing.Point(311, 0);
            this.downSyncTime.Name = "downSyncTime";
            this.downSyncTime.Size = new System.Drawing.Size(55, 24);
            this.downSyncTime.TabIndex = 10;
            this.downSyncTime.Text = "00:00";
            // 
            // hiUpSyncTime
            // 
            this.hiUpSyncTime.AutoSize = true;
            this.hiUpSyncTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.hiUpSyncTime.Location = new System.Drawing.Point(451, 0);
            this.hiUpSyncTime.Name = "hiUpSyncTime";
            this.hiUpSyncTime.Size = new System.Drawing.Size(55, 24);
            this.hiUpSyncTime.TabIndex = 11;
            this.hiUpSyncTime.Text = "00:00";
            // 
            // hiDnSyncTime
            // 
            this.hiDnSyncTime.AutoSize = true;
            this.hiDnSyncTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.hiDnSyncTime.Location = new System.Drawing.Point(591, 0);
            this.hiDnSyncTime.Name = "hiDnSyncTime";
            this.hiDnSyncTime.Size = new System.Drawing.Size(55, 24);
            this.hiDnSyncTime.TabIndex = 12;
            this.hiDnSyncTime.Text = "00:00";
            // 
            // loUpSyncTime
            // 
            this.loUpSyncTime.AutoSize = true;
            this.loUpSyncTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loUpSyncTime.Location = new System.Drawing.Point(731, 0);
            this.loUpSyncTime.Name = "loUpSyncTime";
            this.loUpSyncTime.Size = new System.Drawing.Size(55, 24);
            this.loUpSyncTime.TabIndex = 13;
            this.loUpSyncTime.Text = "00:00";
            // 
            // loDnSyncTime
            // 
            this.loDnSyncTime.AutoSize = true;
            this.loDnSyncTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loDnSyncTime.Location = new System.Drawing.Point(871, 0);
            this.loDnSyncTime.Name = "loDnSyncTime";
            this.loDnSyncTime.Size = new System.Drawing.Size(55, 24);
            this.loDnSyncTime.TabIndex = 14;
            this.loDnSyncTime.Text = "00:00";
            // 
            // ClientComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loDnSyncTime);
            this.Controls.Add(this.loUpSyncTime);
            this.Controls.Add(this.hiDnSyncTime);
            this.Controls.Add(this.hiUpSyncTime);
            this.Controls.Add(this.downSyncTime);
            this.Controls.Add(this.upSyncTime);
            this.Controls.Add(this.lowDownSyncChk);
            this.Controls.Add(this.lowUpSyncChk);
            this.Controls.Add(this.highDownSyncChk);
            this.Controls.Add(this.highUpSyncChk);
            this.Controls.Add(this.downSyncChk);
            this.Controls.Add(this.lastUpdated);
            this.Controls.Add(this.upSyncChk);
            this.Controls.Add(this.roomName);
            this.Controls.Add(this.ipAddress);
            this.Name = "ClientComputer";
            this.Size = new System.Drawing.Size(1031, 27);
            this.Load += new System.EventHandler(this.ClientComputer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipAddress;
        private System.Windows.Forms.Label roomName;
        private System.Windows.Forms.CheckBox upSyncChk;
        private System.Windows.Forms.Label lastUpdated;
        private System.Windows.Forms.CheckBox downSyncChk;
        private System.Windows.Forms.CheckBox highUpSyncChk;
        private System.Windows.Forms.CheckBox highDownSyncChk;
        private System.Windows.Forms.CheckBox lowUpSyncChk;
        private System.Windows.Forms.CheckBox lowDownSyncChk;
        private System.Windows.Forms.Label upSyncTime;
        private System.Windows.Forms.Label downSyncTime;
        private System.Windows.Forms.Label hiUpSyncTime;
        private System.Windows.Forms.Label hiDnSyncTime;
        private System.Windows.Forms.Label loUpSyncTime;
        private System.Windows.Forms.Label loDnSyncTime;
    }
}
