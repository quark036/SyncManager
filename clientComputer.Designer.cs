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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lastPinged = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipAddress
            // 
            this.ipAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ipAddress.AutoSize = true;
            this.ipAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ipAddress.Location = new System.Drawing.Point(3, 0);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(25, 21);
            this.ipAddress.TabIndex = 0;
            this.ipAddress.Text = "263";
            this.ipAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ipAddress.Click += new System.EventHandler(this.ipAddress_Click);
            // 
            // roomName
            // 
            this.roomName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.roomName.AutoSize = true;
            this.roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.roomName.Location = new System.Drawing.Point(38, 0);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(40, 21);
            this.roomName.TabIndex = 1;
            this.roomName.Text = "BR103";
            this.roomName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomName.Click += new System.EventHandler(this.ipAddress_Click);
            // 
            // upSyncChk
            // 
            this.upSyncChk.AutoSize = true;
            this.upSyncChk.Location = new System.Drawing.Point(84, 3);
            this.upSyncChk.Name = "upSyncChk";
            this.upSyncChk.Size = new System.Drawing.Size(53, 15);
            this.upSyncChk.TabIndex = 2;
            this.upSyncChk.Text = "00:00";
            this.upSyncChk.UseVisualStyleBackColor = true;
            this.upSyncChk.CheckedChanged += new System.EventHandler(this.upSync_CheckedChanged);
            // 
            // downSyncChk
            // 
            this.downSyncChk.AutoSize = true;
            this.downSyncChk.Location = new System.Drawing.Point(144, 3);
            this.downSyncChk.Name = "downSyncChk";
            this.downSyncChk.Size = new System.Drawing.Size(53, 15);
            this.downSyncChk.TabIndex = 4;
            this.downSyncChk.Text = "00:00";
            this.downSyncChk.UseVisualStyleBackColor = true;
            this.downSyncChk.CheckedChanged += new System.EventHandler(this.downSync_CheckedChanged);
            // 
            // highUpSyncChk
            // 
            this.highUpSyncChk.AutoSize = true;
            this.highUpSyncChk.Location = new System.Drawing.Point(204, 3);
            this.highUpSyncChk.Name = "highUpSyncChk";
            this.highUpSyncChk.Size = new System.Drawing.Size(53, 15);
            this.highUpSyncChk.TabIndex = 5;
            this.highUpSyncChk.Text = "00:00";
            this.highUpSyncChk.UseVisualStyleBackColor = true;
            this.highUpSyncChk.CheckedChanged += new System.EventHandler(this.highUpSync_CheckedChanged);
            // 
            // highDownSyncChk
            // 
            this.highDownSyncChk.AutoSize = true;
            this.highDownSyncChk.Location = new System.Drawing.Point(264, 3);
            this.highDownSyncChk.Name = "highDownSyncChk";
            this.highDownSyncChk.Size = new System.Drawing.Size(53, 15);
            this.highDownSyncChk.TabIndex = 6;
            this.highDownSyncChk.Text = "00:00";
            this.highDownSyncChk.UseVisualStyleBackColor = true;
            this.highDownSyncChk.CheckedChanged += new System.EventHandler(this.highDownSync_CheckedChanged);
            // 
            // lowUpSyncChk
            // 
            this.lowUpSyncChk.AutoSize = true;
            this.lowUpSyncChk.Location = new System.Drawing.Point(384, 3);
            this.lowUpSyncChk.Name = "lowUpSyncChk";
            this.lowUpSyncChk.Size = new System.Drawing.Size(53, 15);
            this.lowUpSyncChk.TabIndex = 7;
            this.lowUpSyncChk.Text = "00:00";
            this.lowUpSyncChk.UseVisualStyleBackColor = true;
            this.lowUpSyncChk.CheckedChanged += new System.EventHandler(this.lowUpSync_CheckedChanged);
            // 
            // lowDownSyncChk
            // 
            this.lowDownSyncChk.AutoSize = true;
            this.lowDownSyncChk.Location = new System.Drawing.Point(324, 3);
            this.lowDownSyncChk.Name = "lowDownSyncChk";
            this.lowDownSyncChk.Size = new System.Drawing.Size(53, 15);
            this.lowDownSyncChk.TabIndex = 8;
            this.lowDownSyncChk.Text = "00:00";
            this.lowDownSyncChk.UseVisualStyleBackColor = true;
            this.lowDownSyncChk.CheckedChanged += new System.EventHandler(this.lowDownSync_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.ipAddress, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lowUpSyncChk, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lowDownSyncChk, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.roomName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.upSyncChk, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.highDownSyncChk, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.downSyncChk, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.highUpSyncChk, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lastPinged, 8, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(483, 21);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // lastPinged
            // 
            this.lastPinged.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lastPinged.AutoSize = true;
            this.lastPinged.Location = new System.Drawing.Point(444, 0);
            this.lastPinged.Name = "lastPinged";
            this.lastPinged.Size = new System.Drawing.Size(34, 21);
            this.lastPinged.TabIndex = 9;
            this.lastPinged.Text = "00:00";
            this.lastPinged.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClientComputer";
            this.Size = new System.Drawing.Size(482, 19);
            this.Load += new System.EventHandler(this.ClientComputer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lastPinged;
    }
}
