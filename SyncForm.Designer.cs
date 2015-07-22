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
            this.label1 = new System.Windows.Forms.Label();
            this.lowIPStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lowIPEnd = new System.Windows.Forms.TextBox();
            this.highIPEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.highIPStart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.upLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.compPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.upChk = new System.Windows.Forms.CheckBox();
            this.upAllSwitch = new System.Windows.Forms.Button();
            this.downAllSwitch = new System.Windows.Forms.Button();
            this.downChk = new System.Windows.Forms.CheckBox();
            this.downLbl = new System.Windows.Forms.Label();
            this.highUpAllSwitch = new System.Windows.Forms.Button();
            this.hiUpChk = new System.Windows.Forms.CheckBox();
            this.hiUpLbl = new System.Windows.Forms.Label();
            this.highDownAllSwitch = new System.Windows.Forms.Button();
            this.hiDnChk = new System.Windows.Forms.CheckBox();
            this.hiDnLbl = new System.Windows.Forms.Label();
            this.lowUpAllSwitch = new System.Windows.Forms.Button();
            this.loUpChk = new System.Windows.Forms.CheckBox();
            this.loUpLbl = new System.Windows.Forms.Label();
            this.lowDownAllSwitch = new System.Windows.Forms.Button();
            this.loDnChk = new System.Windows.Forms.CheckBox();
            this.loDnLbl = new System.Windows.Forms.Label();
            this.modifierBtn = new System.Windows.Forms.Button();
            this.syncTypeLabel = new System.Windows.Forms.Label();
            this.updateLoHiBtn = new System.Windows.Forms.Button();
            this.upSyncWorker = new System.ComponentModel.BackgroundWorker();
            this.downSyncWorker = new System.ComponentModel.BackgroundWorker();
            this.hiUpSyncWorker = new System.ComponentModel.BackgroundWorker();
            this.hiDownSyncWorker = new System.ComponentModel.BackgroundWorker();
            this.lowUpSyncWorker = new System.ComponentModel.BackgroundWorker();
            this.lowDownSyncWorker = new System.ComponentModel.BackgroundWorker();
            this.connectionWorker = new System.ComponentModel.BackgroundWorker();
            this.numUpComps = new System.Windows.Forms.Label();
            this.numDownComps = new System.Windows.Forms.Label();
            this.numHiUpComps = new System.Windows.Forms.Label();
            this.numHiDnComps = new System.Windows.Forms.Label();
            this.numLoUpComps = new System.Windows.Forms.Label();
            this.numLoDnComps = new System.Windows.Forms.Label();
            this.clientComputer1 = new SyncManager.ClientComputer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Low";
            // 
            // lowIPStart
            // 
            this.lowIPStart.Location = new System.Drawing.Point(94, 43);
            this.lowIPStart.Name = "lowIPStart";
            this.lowIPStart.Size = new System.Drawing.Size(46, 20);
            this.lowIPStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(146, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // lowIPEnd
            // 
            this.lowIPEnd.Location = new System.Drawing.Point(175, 43);
            this.lowIPEnd.Name = "lowIPEnd";
            this.lowIPEnd.Size = new System.Drawing.Size(46, 20);
            this.lowIPEnd.TabIndex = 3;
            // 
            // highIPEnd
            // 
            this.highIPEnd.Location = new System.Drawing.Point(175, 69);
            this.highIPEnd.Name = "highIPEnd";
            this.highIPEnd.Size = new System.Drawing.Size(46, 20);
            this.highIPEnd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(146, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "-";
            // 
            // highIPStart
            // 
            this.highIPStart.Location = new System.Drawing.Point(94, 69);
            this.highIPStart.Name = "highIPStart";
            this.highIPStart.Size = new System.Drawing.Size(46, 20);
            this.highIPStart.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(39, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "High";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Computer";
            // 
            // upLbl
            // 
            this.upLbl.AutoSize = true;
            this.upLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.upLbl.Location = new System.Drawing.Point(151, 120);
            this.upLbl.Name = "upLbl";
            this.upLbl.Size = new System.Drawing.Size(31, 20);
            this.upLbl.TabIndex = 18;
            this.upLbl.Text = "UP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(12, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "IP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(55, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Room";
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.quitButton.Location = new System.Drawing.Point(957, 12);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(87, 24);
            this.quitButton.TabIndex = 60;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label26.Location = new System.Drawing.Point(962, 123);
            this.label26.MaximumSize = new System.Drawing.Size(90, 40);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 40);
            this.label26.TabIndex = 61;
            this.label26.Text = "Last Ping Success";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // compPanel
            // 
            this.compPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compPanel.AutoScroll = true;
            this.compPanel.Location = new System.Drawing.Point(13, 166);
            this.compPanel.Name = "compPanel";
            this.compPanel.Size = new System.Drawing.Size(1031, 621);
            this.compPanel.TabIndex = 62;
            // 
            // upChk
            // 
            this.upChk.AutoSize = true;
            this.upChk.Location = new System.Drawing.Point(155, 143);
            this.upChk.Name = "upChk";
            this.upChk.Size = new System.Drawing.Size(15, 14);
            this.upChk.TabIndex = 64;
            this.upChk.UseVisualStyleBackColor = true;
            this.upChk.CheckedChanged += new System.EventHandler(this.upChk_CheckedChanged);
            // 
            // upAllSwitch
            // 
            this.upAllSwitch.Location = new System.Drawing.Point(176, 140);
            this.upAllSwitch.Name = "upAllSwitch";
            this.upAllSwitch.Size = new System.Drawing.Size(66, 20);
            this.upAllSwitch.TabIndex = 70;
            this.upAllSwitch.Text = "All On";
            this.upAllSwitch.UseVisualStyleBackColor = true;
            this.upAllSwitch.Click += new System.EventHandler(this.upAllSwitch_Click);
            // 
            // downAllSwitch
            // 
            this.downAllSwitch.Location = new System.Drawing.Point(309, 140);
            this.downAllSwitch.Name = "downAllSwitch";
            this.downAllSwitch.Size = new System.Drawing.Size(66, 20);
            this.downAllSwitch.TabIndex = 74;
            this.downAllSwitch.Text = "All On";
            this.downAllSwitch.UseVisualStyleBackColor = true;
            this.downAllSwitch.Click += new System.EventHandler(this.downAllSwitch_Click);
            // 
            // downChk
            // 
            this.downChk.AutoSize = true;
            this.downChk.Location = new System.Drawing.Point(288, 143);
            this.downChk.Name = "downChk";
            this.downChk.Size = new System.Drawing.Size(15, 14);
            this.downChk.TabIndex = 73;
            this.downChk.UseVisualStyleBackColor = true;
            this.downChk.CheckedChanged += new System.EventHandler(this.downChk_CheckedChanged);
            // 
            // downLbl
            // 
            this.downLbl.AutoSize = true;
            this.downLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.downLbl.Location = new System.Drawing.Point(284, 120);
            this.downLbl.Name = "downLbl";
            this.downLbl.Size = new System.Drawing.Size(59, 20);
            this.downLbl.TabIndex = 72;
            this.downLbl.Text = "DOWN";
            // 
            // highUpAllSwitch
            // 
            this.highUpAllSwitch.Location = new System.Drawing.Point(453, 139);
            this.highUpAllSwitch.Name = "highUpAllSwitch";
            this.highUpAllSwitch.Size = new System.Drawing.Size(66, 20);
            this.highUpAllSwitch.TabIndex = 77;
            this.highUpAllSwitch.Text = "All On";
            this.highUpAllSwitch.UseVisualStyleBackColor = true;
            this.highUpAllSwitch.Click += new System.EventHandler(this.highUpAllSwitch_Click);
            // 
            // hiUpChk
            // 
            this.hiUpChk.AutoSize = true;
            this.hiUpChk.Location = new System.Drawing.Point(432, 142);
            this.hiUpChk.Name = "hiUpChk";
            this.hiUpChk.Size = new System.Drawing.Size(15, 14);
            this.hiUpChk.TabIndex = 76;
            this.hiUpChk.UseVisualStyleBackColor = true;
            this.hiUpChk.CheckedChanged += new System.EventHandler(this.hiUpChk_CheckedChanged);
            // 
            // hiUpLbl
            // 
            this.hiUpLbl.AutoSize = true;
            this.hiUpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hiUpLbl.Location = new System.Drawing.Point(428, 120);
            this.hiUpLbl.Name = "hiUpLbl";
            this.hiUpLbl.Size = new System.Drawing.Size(52, 20);
            this.hiUpLbl.TabIndex = 75;
            this.hiUpLbl.Text = "HI UP";
            // 
            // highDownAllSwitch
            // 
            this.highDownAllSwitch.Location = new System.Drawing.Point(595, 140);
            this.highDownAllSwitch.Name = "highDownAllSwitch";
            this.highDownAllSwitch.Size = new System.Drawing.Size(66, 20);
            this.highDownAllSwitch.TabIndex = 80;
            this.highDownAllSwitch.Text = "All On";
            this.highDownAllSwitch.UseVisualStyleBackColor = true;
            this.highDownAllSwitch.Click += new System.EventHandler(this.highDownAllSwitch_Click);
            // 
            // hiDnChk
            // 
            this.hiDnChk.AutoSize = true;
            this.hiDnChk.Location = new System.Drawing.Point(574, 143);
            this.hiDnChk.Name = "hiDnChk";
            this.hiDnChk.Size = new System.Drawing.Size(15, 14);
            this.hiDnChk.TabIndex = 79;
            this.hiDnChk.UseVisualStyleBackColor = true;
            this.hiDnChk.CheckedChanged += new System.EventHandler(this.hiDnChk_CheckedChanged);
            // 
            // hiDnLbl
            // 
            this.hiDnLbl.AutoSize = true;
            this.hiDnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hiDnLbl.Location = new System.Drawing.Point(570, 120);
            this.hiDnLbl.Name = "hiDnLbl";
            this.hiDnLbl.Size = new System.Drawing.Size(53, 20);
            this.hiDnLbl.TabIndex = 78;
            this.hiDnLbl.Text = "HI DN";
            // 
            // lowUpAllSwitch
            // 
            this.lowUpAllSwitch.Location = new System.Drawing.Point(739, 140);
            this.lowUpAllSwitch.Name = "lowUpAllSwitch";
            this.lowUpAllSwitch.Size = new System.Drawing.Size(66, 20);
            this.lowUpAllSwitch.TabIndex = 83;
            this.lowUpAllSwitch.Text = "All On";
            this.lowUpAllSwitch.UseVisualStyleBackColor = true;
            this.lowUpAllSwitch.Click += new System.EventHandler(this.lowUpAllSwitch_Click);
            // 
            // loUpChk
            // 
            this.loUpChk.AutoSize = true;
            this.loUpChk.Location = new System.Drawing.Point(718, 143);
            this.loUpChk.Name = "loUpChk";
            this.loUpChk.Size = new System.Drawing.Size(15, 14);
            this.loUpChk.TabIndex = 82;
            this.loUpChk.UseVisualStyleBackColor = true;
            this.loUpChk.CheckedChanged += new System.EventHandler(this.loUpChk_CheckedChanged);
            // 
            // loUpLbl
            // 
            this.loUpLbl.AutoSize = true;
            this.loUpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loUpLbl.Location = new System.Drawing.Point(712, 120);
            this.loUpLbl.Name = "loUpLbl";
            this.loUpLbl.Size = new System.Drawing.Size(56, 20);
            this.loUpLbl.TabIndex = 81;
            this.loUpLbl.Text = "LO UP";
            // 
            // lowDownAllSwitch
            // 
            this.lowDownAllSwitch.Location = new System.Drawing.Point(882, 140);
            this.lowDownAllSwitch.Name = "lowDownAllSwitch";
            this.lowDownAllSwitch.Size = new System.Drawing.Size(66, 20);
            this.lowDownAllSwitch.TabIndex = 86;
            this.lowDownAllSwitch.Text = "All On";
            this.lowDownAllSwitch.UseVisualStyleBackColor = true;
            this.lowDownAllSwitch.Click += new System.EventHandler(this.lowDownAllSwitch_Click);
            // 
            // loDnChk
            // 
            this.loDnChk.AutoSize = true;
            this.loDnChk.Location = new System.Drawing.Point(861, 143);
            this.loDnChk.Name = "loDnChk";
            this.loDnChk.Size = new System.Drawing.Size(15, 14);
            this.loDnChk.TabIndex = 85;
            this.loDnChk.UseVisualStyleBackColor = true;
            this.loDnChk.CheckedChanged += new System.EventHandler(this.loDnChk_CheckedChanged);
            // 
            // loDnLbl
            // 
            this.loDnLbl.AutoSize = true;
            this.loDnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loDnLbl.Location = new System.Drawing.Point(857, 120);
            this.loDnLbl.Name = "loDnLbl";
            this.loDnLbl.Size = new System.Drawing.Size(57, 20);
            this.loDnLbl.TabIndex = 84;
            this.loDnLbl.Text = "LO DN";
            // 
            // modifierBtn
            // 
            this.modifierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.modifierBtn.Location = new System.Drawing.Point(763, 43);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.Size = new System.Drawing.Size(132, 46);
            this.modifierBtn.TabIndex = 111;
            this.modifierBtn.Text = "Modify Inclusions and Exclusions";
            this.modifierBtn.UseVisualStyleBackColor = true;
            this.modifierBtn.Click += new System.EventHandler(this.modifierBtn_Click);
            // 
            // syncTypeLabel
            // 
            this.syncTypeLabel.AutoSize = true;
            this.syncTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.syncTypeLabel.Location = new System.Drawing.Point(469, 39);
            this.syncTypeLabel.Name = "syncTypeLabel";
            this.syncTypeLabel.Size = new System.Drawing.Size(201, 31);
            this.syncTypeLabel.TabIndex = 112;
            this.syncTypeLabel.Text = "Speaker Ready";
            // 
            // updateLoHiBtn
            // 
            this.updateLoHiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateLoHiBtn.Location = new System.Drawing.Point(227, 53);
            this.updateLoHiBtn.Name = "updateLoHiBtn";
            this.updateLoHiBtn.Size = new System.Drawing.Size(110, 26);
            this.updateLoHiBtn.TabIndex = 113;
            this.updateLoHiBtn.Text = "Update";
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
            // numUpComps
            // 
            this.numUpComps.AutoSize = true;
            this.numUpComps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numUpComps.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numUpComps.Location = new System.Drawing.Point(190, 120);
            this.numUpComps.Name = "numUpComps";
            this.numUpComps.Size = new System.Drawing.Size(28, 20);
            this.numUpComps.TabIndex = 114;
            this.numUpComps.Text = "(0)";
            // 
            // numDownComps
            // 
            this.numDownComps.AutoSize = true;
            this.numDownComps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numDownComps.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numDownComps.Location = new System.Drawing.Point(347, 120);
            this.numDownComps.Name = "numDownComps";
            this.numDownComps.Size = new System.Drawing.Size(28, 20);
            this.numDownComps.TabIndex = 115;
            this.numDownComps.Text = "(0)";
            // 
            // numHiUpComps
            // 
            this.numHiUpComps.AutoSize = true;
            this.numHiUpComps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numHiUpComps.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numHiUpComps.Location = new System.Drawing.Point(486, 120);
            this.numHiUpComps.Name = "numHiUpComps";
            this.numHiUpComps.Size = new System.Drawing.Size(28, 20);
            this.numHiUpComps.TabIndex = 116;
            this.numHiUpComps.Text = "(0)";
            // 
            // numHiDnComps
            // 
            this.numHiDnComps.AutoSize = true;
            this.numHiDnComps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numHiDnComps.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numHiDnComps.Location = new System.Drawing.Point(629, 120);
            this.numHiDnComps.Name = "numHiDnComps";
            this.numHiDnComps.Size = new System.Drawing.Size(28, 20);
            this.numHiDnComps.TabIndex = 117;
            this.numHiDnComps.Text = "(0)";
            // 
            // numLoUpComps
            // 
            this.numLoUpComps.AutoSize = true;
            this.numLoUpComps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numLoUpComps.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numLoUpComps.Location = new System.Drawing.Point(774, 120);
            this.numLoUpComps.Name = "numLoUpComps";
            this.numLoUpComps.Size = new System.Drawing.Size(28, 20);
            this.numLoUpComps.TabIndex = 118;
            this.numLoUpComps.Text = "(0)";
            // 
            // numLoDnComps
            // 
            this.numLoDnComps.AutoSize = true;
            this.numLoDnComps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numLoDnComps.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numLoDnComps.Location = new System.Drawing.Point(920, 120);
            this.numLoDnComps.Name = "numLoDnComps";
            this.numLoDnComps.Size = new System.Drawing.Size(28, 20);
            this.numLoDnComps.TabIndex = 119;
            this.numLoDnComps.Text = "(0)";
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
            this.ClientSize = new System.Drawing.Size(1056, 829);
            this.Controls.Add(this.numLoDnComps);
            this.Controls.Add(this.numLoUpComps);
            this.Controls.Add(this.numHiDnComps);
            this.Controls.Add(this.numHiUpComps);
            this.Controls.Add(this.numDownComps);
            this.Controls.Add(this.numUpComps);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.updateLoHiBtn);
            this.Controls.Add(this.syncTypeLabel);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.lowDownAllSwitch);
            this.Controls.Add(this.loDnChk);
            this.Controls.Add(this.loDnLbl);
            this.Controls.Add(this.lowUpAllSwitch);
            this.Controls.Add(this.loUpChk);
            this.Controls.Add(this.loUpLbl);
            this.Controls.Add(this.highDownAllSwitch);
            this.Controls.Add(this.hiDnChk);
            this.Controls.Add(this.hiDnLbl);
            this.Controls.Add(this.highUpAllSwitch);
            this.Controls.Add(this.hiUpChk);
            this.Controls.Add(this.hiUpLbl);
            this.Controls.Add(this.downAllSwitch);
            this.Controls.Add(this.downChk);
            this.Controls.Add(this.downLbl);
            this.Controls.Add(this.upAllSwitch);
            this.Controls.Add(this.upChk);
            this.Controls.Add(this.compPanel);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.upLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.highIPEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.highIPStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lowIPEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lowIPStart);
            this.Controls.Add(this.label1);
            this.Name = "SyncForm";
            this.Text = "SyncForm";
            this.Load += new System.EventHandler(this.SyncForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lowIPStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lowIPEnd;
        private System.Windows.Forms.TextBox highIPEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox highIPStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label upLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.FlowLayoutPanel compPanel;
        private System.Windows.Forms.CheckBox upChk;
        private System.Windows.Forms.Button upAllSwitch;
        private System.Windows.Forms.Button downAllSwitch;
        private System.Windows.Forms.CheckBox downChk;
        private System.Windows.Forms.Label downLbl;
        private System.Windows.Forms.Button highUpAllSwitch;
        private System.Windows.Forms.CheckBox hiUpChk;
        private System.Windows.Forms.Label hiUpLbl;
        private System.Windows.Forms.Button highDownAllSwitch;
        private System.Windows.Forms.CheckBox hiDnChk;
        private System.Windows.Forms.Label hiDnLbl;
        private System.Windows.Forms.Button lowUpAllSwitch;
        private System.Windows.Forms.CheckBox loUpChk;
        private System.Windows.Forms.Label loUpLbl;
        private System.Windows.Forms.Button lowDownAllSwitch;
        private System.Windows.Forms.CheckBox loDnChk;
        private System.Windows.Forms.Label loDnLbl;
        private ClientComputer clientComputer1;
        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.Label syncTypeLabel;
        private System.Windows.Forms.Button updateLoHiBtn;
        private System.ComponentModel.BackgroundWorker upSyncWorker;
        private System.ComponentModel.BackgroundWorker downSyncWorker;
        private System.ComponentModel.BackgroundWorker hiUpSyncWorker;
        private System.ComponentModel.BackgroundWorker hiDownSyncWorker;
        private System.ComponentModel.BackgroundWorker lowUpSyncWorker;
        private System.ComponentModel.BackgroundWorker lowDownSyncWorker;
        private System.ComponentModel.BackgroundWorker connectionWorker;
        private System.Windows.Forms.Label numUpComps;
        private System.Windows.Forms.Label numDownComps;
        private System.Windows.Forms.Label numHiUpComps;
        private System.Windows.Forms.Label numHiDnComps;
        private System.Windows.Forms.Label numLoUpComps;
        private System.Windows.Forms.Label numLoDnComps;
    }
}