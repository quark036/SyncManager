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
            this.lastPinged = new System.Windows.Forms.Label();
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
            this.ipAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ipAddress.Location = new System.Drawing.Point(3, 0);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(25, 13);
            this.ipAddress.TabIndex = 0;
            this.ipAddress.Text = "100";
            this.ipAddress.Click += new System.EventHandler(this.ipAddress_Click);
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.roomName.Location = new System.Drawing.Point(45, 0);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(40, 13);
            this.roomName.TabIndex = 1;
            this.roomName.Text = "BR103";
            this.roomName.Click += new System.EventHandler(this.ipAddress_Click);
            // 
            // upSyncChk
            // 
            this.upSyncChk.AutoSize = true;
            this.upSyncChk.Location = new System.Drawing.Point(150, 1);
            this.upSyncChk.Name = "upSyncChk";
            this.upSyncChk.Size = new System.Drawing.Size(15, 14);
            this.upSyncChk.TabIndex = 2;
            this.upSyncChk.UseVisualStyleBackColor = true;
            this.upSyncChk.CheckedChanged += new System.EventHandler(this.upSync_CheckedChanged);
            // 
            // lastPinged
            // 
            this.lastPinged.AutoSize = true;
            this.lastPinged.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lastPinged.Location = new System.Drawing.Point(973, 1);
            this.lastPinged.Name = "lastPinged";
            this.lastPinged.Size = new System.Drawing.Size(34, 13);
            this.lastPinged.TabIndex = 3;
            this.lastPinged.Text = "00:00";
            // 
            // downSyncChk
            // 
            this.downSyncChk.AutoSize = true;
            this.downSyncChk.Location = new System.Drawing.Point(290, 1);
            this.downSyncChk.Name = "downSyncChk";
            this.downSyncChk.Size = new System.Drawing.Size(15, 14);
            this.downSyncChk.TabIndex = 4;
            this.downSyncChk.UseVisualStyleBackColor = true;
            this.downSyncChk.CheckedChanged += new System.EventHandler(this.downSync_CheckedChanged);
            // 
            // highUpSyncChk
            // 
            this.highUpSyncChk.AutoSize = true;
            this.highUpSyncChk.Location = new System.Drawing.Point(430, 1);
            this.highUpSyncChk.Name = "highUpSyncChk";
            this.highUpSyncChk.Size = new System.Drawing.Size(15, 14);
            this.highUpSyncChk.TabIndex = 5;
            this.highUpSyncChk.UseVisualStyleBackColor = true;
            this.highUpSyncChk.CheckedChanged += new System.EventHandler(this.highUpSync_CheckedChanged);
            // 
            // highDownSyncChk
            // 
            this.highDownSyncChk.AutoSize = true;
            this.highDownSyncChk.Location = new System.Drawing.Point(570, 1);
            this.highDownSyncChk.Name = "highDownSyncChk";
            this.highDownSyncChk.Size = new System.Drawing.Size(15, 14);
            this.highDownSyncChk.TabIndex = 6;
            this.highDownSyncChk.UseVisualStyleBackColor = true;
            this.highDownSyncChk.CheckedChanged += new System.EventHandler(this.highDownSync_CheckedChanged);
            // 
            // lowUpSyncChk
            // 
            this.lowUpSyncChk.AutoSize = true;
            this.lowUpSyncChk.Location = new System.Drawing.Point(710, 1);
            this.lowUpSyncChk.Name = "lowUpSyncChk";
            this.lowUpSyncChk.Size = new System.Drawing.Size(15, 14);
            this.lowUpSyncChk.TabIndex = 7;
            this.lowUpSyncChk.UseVisualStyleBackColor = true;
            this.lowUpSyncChk.CheckedChanged += new System.EventHandler(this.lowUpSync_CheckedChanged);
            // 
            // lowDownSyncChk
            // 
            this.lowDownSyncChk.AutoSize = true;
            this.lowDownSyncChk.Location = new System.Drawing.Point(850, 1);
            this.lowDownSyncChk.Name = "lowDownSyncChk";
            this.lowDownSyncChk.Size = new System.Drawing.Size(15, 14);
            this.lowDownSyncChk.TabIndex = 8;
            this.lowDownSyncChk.UseVisualStyleBackColor = true;
            this.lowDownSyncChk.CheckedChanged += new System.EventHandler(this.lowDownSync_CheckedChanged);
            // 
            // upSyncTime
            // 
            this.upSyncTime.AutoSize = true;
            this.upSyncTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.upSyncTime.Location = new System.Drawing.Point(171, 1);
            this.upSyncTime.Name = "upSyncTime";
            this.upSyncTime.Size = new System.Drawing.Size(34, 13);
            this.upSyncTime.TabIndex = 9;
            this.upSyncTime.Text = "00:00";
            // 
            // downSyncTime
            // 
            this.downSyncTime.AutoSize = true;
            this.downSyncTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.downSyncTime.Location = new System.Drawing.Point(311, 1);
            this.downSyncTime.Name = "downSyncTime";
            this.downSyncTime.Size = new System.Drawing.Size(34, 13);
            this.downSyncTime.TabIndex = 10;
            this.downSyncTime.Text = "00:00";
            // 
            // hiUpSyncTime
            // 
            this.hiUpSyncTime.AutoSize = true;
            this.hiUpSyncTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.hiUpSyncTime.Location = new System.Drawing.Point(451, 1);
            this.hiUpSyncTime.Name = "hiUpSyncTime";
            this.hiUpSyncTime.Size = new System.Drawing.Size(34, 13);
            this.hiUpSyncTime.TabIndex = 11;
            this.hiUpSyncTime.Text = "00:00";
            // 
            // hiDnSyncTime
            // 
            this.hiDnSyncTime.AutoSize = true;
            this.hiDnSyncTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.hiDnSyncTime.Location = new System.Drawing.Point(591, 1);
            this.hiDnSyncTime.Name = "hiDnSyncTime";
            this.hiDnSyncTime.Size = new System.Drawing.Size(34, 13);
            this.hiDnSyncTime.TabIndex = 12;
            this.hiDnSyncTime.Text = "00:00";
            // 
            // loUpSyncTime
            // 
            this.loUpSyncTime.AutoSize = true;
            this.loUpSyncTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.loUpSyncTime.Location = new System.Drawing.Point(731, 1);
            this.loUpSyncTime.Name = "loUpSyncTime";
            this.loUpSyncTime.Size = new System.Drawing.Size(34, 13);
            this.loUpSyncTime.TabIndex = 13;
            this.loUpSyncTime.Text = "00:00";
            // 
            // loDnSyncTime
            // 
            this.loDnSyncTime.AutoSize = true;
            this.loDnSyncTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.loDnSyncTime.Location = new System.Drawing.Point(871, 1);
            this.loDnSyncTime.Name = "loDnSyncTime";
            this.loDnSyncTime.Size = new System.Drawing.Size(34, 13);
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
            this.Controls.Add(this.lastPinged);
            this.Controls.Add(this.upSyncChk);
            this.Controls.Add(this.roomName);
            this.Controls.Add(this.ipAddress);
            this.Name = "ClientComputer";
            this.Size = new System.Drawing.Size(1031, 14);
            this.Load += new System.EventHandler(this.ClientComputer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipAddress;
        private System.Windows.Forms.Label roomName;
        private System.Windows.Forms.CheckBox upSyncChk;
        private System.Windows.Forms.Label lastPinged;
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
