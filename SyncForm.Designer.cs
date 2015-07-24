using System;

namespace SyncManager
{
    partial class SyncForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.upLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.compPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.upChk = new System.Windows.Forms.CheckBox();
            this.downChk = new System.Windows.Forms.CheckBox();
            this.downLbl = new System.Windows.Forms.Label();
            this.hiUpChk = new System.Windows.Forms.CheckBox();
            this.hiUpLbl = new System.Windows.Forms.Label();
            this.hiDnChk = new System.Windows.Forms.CheckBox();
            this.hiDnLbl = new System.Windows.Forms.Label();
            this.loUpChk = new System.Windows.Forms.CheckBox();
            this.loUpLbl = new System.Windows.Forms.Label();
            this.loDnChk = new System.Windows.Forms.CheckBox();
            this.loDnLbl = new System.Windows.Forms.Label();
            this.modifierBtn = new System.Windows.Forms.Button();
            this.updateLoHiBtn = new System.Windows.Forms.Button();
            this.upSyncWorker = new System.ComponentModel.BackgroundWorker();
            this.downSyncWorker = new System.ComponentModel.BackgroundWorker();
            this.hiUpSyncWorker = new System.ComponentModel.BackgroundWorker();
            this.hiDownSyncWorker = new System.ComponentModel.BackgroundWorker();
            this.lowUpSyncWorker = new System.ComponentModel.BackgroundWorker();
            this.lowDownSyncWorker = new System.ComponentModel.BackgroundWorker();
            this.connectionWorker = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numLoDnComps = new System.Windows.Forms.Label();
            this.numLoUpComps = new System.Windows.Forms.Label();
            this.numHiDnComps = new System.Windows.Forms.Label();
            this.numHiUpComps = new System.Windows.Forms.Label();
            this.numDownComps = new System.Windows.Forms.Label();
            this.numUpComps = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.clientComputer1 = new SyncManager.ClientComputer();
            this.labelTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // upLbl
            // 
            this.upLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upLbl.AutoSize = true;
            this.upLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.upLbl.Location = new System.Drawing.Point(85, 0);
            this.upLbl.Name = "upLbl";
            this.upLbl.Size = new System.Drawing.Size(47, 24);
            this.upLbl.TabIndex = 18;
            this.upLbl.Text = "UP";
            this.upLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.upLbl.Click += new System.EventHandler(this.upAllSwitch_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "IP";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label10.Location = new System.Drawing.Point(38, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Room";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.quitButton.Location = new System.Drawing.Point(124, 93);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(108, 26);
            this.quitButton.TabIndex = 60;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // compPanel
            // 
            this.compPanel.AutoScroll = true;
            this.compPanel.Location = new System.Drawing.Point(13, 166);
            this.compPanel.Name = "compPanel";
            this.compPanel.Size = new System.Drawing.Size(482, 651);
            this.compPanel.TabIndex = 62;
            // 
            // upChk
            // 
            this.upChk.AutoSize = true;
            this.upChk.Location = new System.Drawing.Point(91, 9);
            this.upChk.Name = "upChk";
            this.upChk.Size = new System.Drawing.Size(15, 14);
            this.upChk.TabIndex = 64;
            this.upChk.UseVisualStyleBackColor = true;
            this.upChk.CheckedChanged += new System.EventHandler(this.upChk_CheckedChanged);
            // 
            // downChk
            // 
            this.downChk.AutoSize = true;
            this.downChk.Location = new System.Drawing.Point(208, 9);
            this.downChk.Name = "downChk";
            this.downChk.Size = new System.Drawing.Size(15, 14);
            this.downChk.TabIndex = 73;
            this.downChk.UseVisualStyleBackColor = true;
            this.downChk.CheckedChanged += new System.EventHandler(this.downChk_CheckedChanged);
            // 
            // downLbl
            // 
            this.downLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downLbl.AutoSize = true;
            this.downLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.downLbl.Location = new System.Drawing.Point(138, 0);
            this.downLbl.Name = "downLbl";
            this.downLbl.Size = new System.Drawing.Size(54, 24);
            this.downLbl.TabIndex = 72;
            this.downLbl.Text = "DOWN";
            this.downLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.downLbl.Click += new System.EventHandler(this.downAllSwitch_Click);
            // 
            // hiUpChk
            // 
            this.hiUpChk.AutoSize = true;
            this.hiUpChk.Location = new System.Drawing.Point(91, 27);
            this.hiUpChk.Name = "hiUpChk";
            this.hiUpChk.Size = new System.Drawing.Size(15, 14);
            this.hiUpChk.TabIndex = 76;
            this.hiUpChk.UseVisualStyleBackColor = true;
            this.hiUpChk.CheckedChanged += new System.EventHandler(this.hiUpChk_CheckedChanged);
            // 
            // hiUpLbl
            // 
            this.hiUpLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hiUpLbl.AutoSize = true;
            this.hiUpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.hiUpLbl.Location = new System.Drawing.Point(198, 0);
            this.hiUpLbl.Name = "hiUpLbl";
            this.hiUpLbl.Size = new System.Drawing.Size(54, 24);
            this.hiUpLbl.TabIndex = 75;
            this.hiUpLbl.Text = "HI UP";
            this.hiUpLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hiUpLbl.Click += new System.EventHandler(this.highUpAllSwitch_Click);
            // 
            // hiDnChk
            // 
            this.hiDnChk.AutoSize = true;
            this.hiDnChk.Location = new System.Drawing.Point(208, 27);
            this.hiDnChk.Name = "hiDnChk";
            this.hiDnChk.Size = new System.Drawing.Size(15, 14);
            this.hiDnChk.TabIndex = 79;
            this.hiDnChk.UseVisualStyleBackColor = true;
            this.hiDnChk.CheckedChanged += new System.EventHandler(this.hiDnChk_CheckedChanged);
            // 
            // hiDnLbl
            // 
            this.hiDnLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hiDnLbl.AutoSize = true;
            this.hiDnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.hiDnLbl.Location = new System.Drawing.Point(258, 0);
            this.hiDnLbl.Name = "hiDnLbl";
            this.hiDnLbl.Size = new System.Drawing.Size(54, 24);
            this.hiDnLbl.TabIndex = 78;
            this.hiDnLbl.Text = "HI DN";
            this.hiDnLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hiDnLbl.Click += new System.EventHandler(this.highDownAllSwitch_Click);
            // 
            // loUpChk
            // 
            this.loUpChk.AutoSize = true;
            this.loUpChk.Location = new System.Drawing.Point(91, 45);
            this.loUpChk.Name = "loUpChk";
            this.loUpChk.Size = new System.Drawing.Size(15, 14);
            this.loUpChk.TabIndex = 82;
            this.loUpChk.UseVisualStyleBackColor = true;
            this.loUpChk.CheckedChanged += new System.EventHandler(this.loUpChk_CheckedChanged);
            // 
            // loUpLbl
            // 
            this.loUpLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loUpLbl.AutoSize = true;
            this.loUpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.loUpLbl.Location = new System.Drawing.Point(318, 0);
            this.loUpLbl.Name = "loUpLbl";
            this.loUpLbl.Size = new System.Drawing.Size(54, 24);
            this.loUpLbl.TabIndex = 81;
            this.loUpLbl.Text = "LO UP";
            this.loUpLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loUpLbl.Click += new System.EventHandler(this.lowUpAllSwitch_Click);
            // 
            // loDnChk
            // 
            this.loDnChk.AutoSize = true;
            this.loDnChk.Location = new System.Drawing.Point(208, 45);
            this.loDnChk.Name = "loDnChk";
            this.loDnChk.Size = new System.Drawing.Size(15, 14);
            this.loDnChk.TabIndex = 85;
            this.loDnChk.UseVisualStyleBackColor = true;
            this.loDnChk.CheckedChanged += new System.EventHandler(this.loDnChk_CheckedChanged);
            // 
            // loDnLbl
            // 
            this.loDnLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loDnLbl.AutoSize = true;
            this.loDnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.loDnLbl.Location = new System.Drawing.Point(378, 0);
            this.loDnLbl.Name = "loDnLbl";
            this.loDnLbl.Size = new System.Drawing.Size(54, 24);
            this.loDnLbl.TabIndex = 84;
            this.loDnLbl.Text = "LO DN";
            this.loDnLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loDnLbl.Click += new System.EventHandler(this.lowDownAllSwitch_Click);
            // 
            // modifierBtn
            // 
            this.modifierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.modifierBtn.Location = new System.Drawing.Point(10, 65);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.Size = new System.Drawing.Size(108, 22);
            this.modifierBtn.TabIndex = 111;
            this.modifierBtn.Text = "Change Modifiers";
            this.modifierBtn.UseVisualStyleBackColor = true;
            this.modifierBtn.Click += new System.EventHandler(this.modifierBtn_Click);
            // 
            // updateLoHiBtn
            // 
            this.updateLoHiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.updateLoHiBtn.Location = new System.Drawing.Point(10, 93);
            this.updateLoHiBtn.Name = "updateLoHiBtn";
            this.updateLoHiBtn.Size = new System.Drawing.Size(110, 26);
            this.updateLoHiBtn.TabIndex = 113;
            this.updateLoHiBtn.Text = "Change Low/High";
            this.updateLoHiBtn.UseVisualStyleBackColor = true;
            this.updateLoHiBtn.Click += new System.EventHandler(this.updateLoHiBtn_Click);
            // 
            // upSyncWorker
            // 
            this.upSyncWorker.WorkerReportsProgress = true;
            this.upSyncWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.syncWorker_DoWork);
            this.upSyncWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.syncWorker_ProgressChanged);
            // 
            // downSyncWorker
            // 
            this.downSyncWorker.WorkerReportsProgress = true;
            this.downSyncWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.syncWorker_DoWork);
            this.downSyncWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.syncWorker_ProgressChanged);
            // 
            // hiUpSyncWorker
            // 
            this.hiUpSyncWorker.WorkerReportsProgress = true;
            this.hiUpSyncWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.syncWorker_DoWork);
            this.hiUpSyncWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.syncWorker_ProgressChanged);
            // 
            // hiDownSyncWorker
            // 
            this.hiDownSyncWorker.WorkerReportsProgress = true;
            this.hiDownSyncWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.syncWorker_DoWork);
            this.hiDownSyncWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.syncWorker_ProgressChanged);
            // 
            // lowUpSyncWorker
            // 
            this.lowUpSyncWorker.WorkerReportsProgress = true;
            this.lowUpSyncWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.syncWorker_DoWork);
            this.lowUpSyncWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.syncWorker_ProgressChanged);
            // 
            // lowDownSyncWorker
            // 
            this.lowDownSyncWorker.WorkerReportsProgress = true;
            this.lowDownSyncWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.syncWorker_DoWork);
            this.lowDownSyncWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.syncWorker_ProgressChanged);
            // 
            // connectionWorker
            // 
            this.connectionWorker.WorkerReportsProgress = true;
            this.connectionWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.connectionWorker_DoWork);
            this.connectionWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.connectionWorker_ProgressChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(59, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 120;
            this.label5.Text = "Up";
            this.label5.Click += new System.EventHandler(this.upAllSwitch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(152, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 121;
            this.label6.Text = "DOWN";
            this.label6.Click += new System.EventHandler(this.downAllSwitch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(46, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 122;
            this.label8.Text = "HI UP";
            this.label8.Click += new System.EventHandler(this.highUpAllSwitch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(153, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 123;
            this.label11.Text = "HI DN";
            this.label11.Click += new System.EventHandler(this.highDownAllSwitch_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(40, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 124;
            this.label12.Text = "LO UP";
            this.label12.Click += new System.EventHandler(this.lowUpAllSwitch_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(154, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 125;
            this.label13.Text = "LO DN";
            this.label13.Click += new System.EventHandler(this.lowDownAllSwitch_Click);
            // 
            // numLoDnComps
            // 
            this.numLoDnComps.AutoSize = true;
            this.numLoDnComps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.numLoDnComps.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numLoDnComps.Location = new System.Drawing.Point(129, 48);
            this.numLoDnComps.Name = "numLoDnComps";
            this.numLoDnComps.Size = new System.Drawing.Size(19, 13);
            this.numLoDnComps.TabIndex = 119;
            this.numLoDnComps.Text = "(0)";
            // 
            // numLoUpComps
            // 
            this.numLoUpComps.AutoSize = true;
            this.numLoUpComps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.numLoUpComps.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numLoUpComps.Location = new System.Drawing.Point(16, 45);
            this.numLoUpComps.Name = "numLoUpComps";
            this.numLoUpComps.Size = new System.Drawing.Size(19, 13);
            this.numLoUpComps.TabIndex = 118;
            this.numLoUpComps.Text = "(0)";
            // 
            // numHiDnComps
            // 
            this.numHiDnComps.AutoSize = true;
            this.numHiDnComps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.numHiDnComps.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numHiDnComps.Location = new System.Drawing.Point(129, 30);
            this.numHiDnComps.Name = "numHiDnComps";
            this.numHiDnComps.Size = new System.Drawing.Size(19, 13);
            this.numHiDnComps.TabIndex = 117;
            this.numHiDnComps.Text = "(0)";
            // 
            // numHiUpComps
            // 
            this.numHiUpComps.AutoSize = true;
            this.numHiUpComps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.numHiUpComps.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numHiUpComps.Location = new System.Drawing.Point(16, 28);
            this.numHiUpComps.Name = "numHiUpComps";
            this.numHiUpComps.Size = new System.Drawing.Size(19, 13);
            this.numHiUpComps.TabIndex = 116;
            this.numHiUpComps.Text = "(0)";
            // 
            // numDownComps
            // 
            this.numDownComps.AutoSize = true;
            this.numDownComps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.numDownComps.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numDownComps.Location = new System.Drawing.Point(129, 9);
            this.numDownComps.Name = "numDownComps";
            this.numDownComps.Size = new System.Drawing.Size(19, 13);
            this.numDownComps.TabIndex = 115;
            this.numDownComps.Text = "(0)";
            // 
            // numUpComps
            // 
            this.numUpComps.AutoSize = true;
            this.numUpComps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.numUpComps.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numUpComps.Location = new System.Drawing.Point(16, 9);
            this.numUpComps.Name = "numUpComps";
            this.numUpComps.Size = new System.Drawing.Size(19, 13);
            this.numUpComps.TabIndex = 114;
            this.numUpComps.Text = "(0)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 127;
            this.button1.Text = "View Config";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelTable
            // 
            this.labelTable.ColumnCount = 9;
            this.labelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.labelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.labelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.labelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.labelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.labelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.labelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.labelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.labelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.labelTable.Controls.Add(this.loDnLbl, 7, 0);
            this.labelTable.Controls.Add(this.loUpLbl, 6, 0);
            this.labelTable.Controls.Add(this.hiDnLbl, 5, 0);
            this.labelTable.Controls.Add(this.hiUpLbl, 4, 0);
            this.labelTable.Controls.Add(this.downLbl, 3, 0);
            this.labelTable.Controls.Add(this.upLbl, 2, 0);
            this.labelTable.Controls.Add(this.label10, 1, 0);
            this.labelTable.Controls.Add(this.label9, 0, 0);
            this.labelTable.Controls.Add(this.label1, 8, 0);
            this.labelTable.Location = new System.Drawing.Point(13, 136);
            this.labelTable.Name = "labelTable";
            this.labelTable.RowCount = 1;
            this.labelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.labelTable.Size = new System.Drawing.Size(482, 24);
            this.labelTable.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 85;
            this.label1.Text = "Pinged";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientComputer1
            // 
            this.clientComputer1.Location = new System.Drawing.Point(0, 0);
            this.clientComputer1.Name = "clientComputer1";
            this.clientComputer1.Size = new System.Drawing.Size(1031, 27);
            this.clientComputer1.TabIndex = 0;
            // 
            // SyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 829);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numLoDnComps);
            this.Controls.Add(this.numLoUpComps);
            this.Controls.Add(this.numHiDnComps);
            this.Controls.Add(this.numHiUpComps);
            this.Controls.Add(this.numDownComps);
            this.Controls.Add(this.numUpComps);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.updateLoHiBtn);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.loDnChk);
            this.Controls.Add(this.loUpChk);
            this.Controls.Add(this.hiDnChk);
            this.Controls.Add(this.hiUpChk);
            this.Controls.Add(this.downChk);
            this.Controls.Add(this.upChk);
            this.Controls.Add(this.compPanel);
            this.Name = "SyncForm";
            this.Text = "SyncForm";
            this.Load += new System.EventHandler(this.SyncForm_Load);
            this.labelTable.ResumeLayout(false);
            this.labelTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label upLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.FlowLayoutPanel compPanel;
        private System.Windows.Forms.CheckBox upChk;
        private System.Windows.Forms.CheckBox downChk;
        private System.Windows.Forms.Label downLbl;
        private System.Windows.Forms.CheckBox hiUpChk;
        private System.Windows.Forms.Label hiUpLbl;
        private System.Windows.Forms.CheckBox hiDnChk;
        private System.Windows.Forms.Label hiDnLbl;
        private System.Windows.Forms.CheckBox loUpChk;
        private System.Windows.Forms.Label loUpLbl;
        private System.Windows.Forms.CheckBox loDnChk;
        private System.Windows.Forms.Label loDnLbl;
        private ClientComputer clientComputer1;
        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.Button updateLoHiBtn;
        private System.ComponentModel.BackgroundWorker upSyncWorker;
        private System.ComponentModel.BackgroundWorker downSyncWorker;
        private System.ComponentModel.BackgroundWorker hiUpSyncWorker;
        private System.ComponentModel.BackgroundWorker hiDownSyncWorker;
        private System.ComponentModel.BackgroundWorker lowUpSyncWorker;
        private System.ComponentModel.BackgroundWorker lowDownSyncWorker;
        private System.ComponentModel.BackgroundWorker connectionWorker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label numLoDnComps;
        private System.Windows.Forms.Label numLoUpComps;
        private System.Windows.Forms.Label numHiDnComps;
        private System.Windows.Forms.Label numHiUpComps;
        private System.Windows.Forms.Label numDownComps;
        private System.Windows.Forms.Label numUpComps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel labelTable;
        private System.Windows.Forms.Label label1;
    }
}