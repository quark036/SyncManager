﻿namespace SyncManager
{
    partial class configForm
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
            this.importFilePathTxt = new System.Windows.Forms.TextBox();
            this.startSRTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.endSRTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endBOTxt = new System.Windows.Forms.TextBox();
            this.startBOTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lowSREndTxt = new System.Windows.Forms.TextBox();
            this.lowSRStartTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.highSREndTxt = new System.Windows.Forms.TextBox();
            this.highSRStartTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.highBOEndTxt = new System.Windows.Forms.TextBox();
            this.highBOStartTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lowBOEndTxt = new System.Windows.Forms.TextBox();
            this.lowBOStartTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Import File Path:";
            // 
            // importFilePathTxt
            // 
            this.importFilePathTxt.Location = new System.Drawing.Point(101, 6);
            this.importFilePathTxt.Name = "importFilePathTxt";
            this.importFilePathTxt.Size = new System.Drawing.Size(186, 20);
            this.importFilePathTxt.TabIndex = 1;
            // 
            // startSRTxt
            // 
            this.startSRTxt.Location = new System.Drawing.Point(152, 42);
            this.startSRTxt.Name = "startSRTxt";
            this.startSRTxt.Size = new System.Drawing.Size(42, 20);
            this.startSRTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speaker Ready Computers";
            // 
            // endSRTxt
            // 
            this.endSRTxt.Location = new System.Drawing.Point(229, 42);
            this.endSRTxt.Name = "endSRTxt";
            this.endSRTxt.Size = new System.Drawing.Size(42, 20);
            this.endSRTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(200, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(200, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "-";
            // 
            // endBOTxt
            // 
            this.endBOTxt.Location = new System.Drawing.Point(229, 79);
            this.endBOTxt.Name = "endBOTxt";
            this.endBOTxt.Size = new System.Drawing.Size(42, 20);
            this.endBOTxt.TabIndex = 14;
            // 
            // startBOTxt
            // 
            this.startBOTxt.Location = new System.Drawing.Point(152, 79);
            this.startBOTxt.Name = "startBOTxt";
            this.startBOTxt.Size = new System.Drawing.Size(42, 20);
            this.startBOTxt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Breakout Computers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "IP Scheme";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Class C",
            "Class B"});
            this.comboBox1.Location = new System.Drawing.Point(92, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "Class C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(174, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 31);
            this.label7.TabIndex = 21;
            this.label7.Text = "-";
            // 
            // lowSREndTxt
            // 
            this.lowSREndTxt.Location = new System.Drawing.Point(203, 180);
            this.lowSREndTxt.Name = "lowSREndTxt";
            this.lowSREndTxt.Size = new System.Drawing.Size(42, 20);
            this.lowSREndTxt.TabIndex = 20;
            // 
            // lowSRStartTxt
            // 
            this.lowSRStartTxt.Location = new System.Drawing.Point(126, 180);
            this.lowSRStartTxt.Name = "lowSRStartTxt";
            this.lowSRStartTxt.Size = new System.Drawing.Size(42, 20);
            this.lowSRStartTxt.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Speaker Ready Low";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label9.Location = new System.Drawing.Point(174, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 31);
            this.label9.TabIndex = 25;
            this.label9.Text = "-";
            // 
            // highSREndTxt
            // 
            this.highSREndTxt.Location = new System.Drawing.Point(203, 217);
            this.highSREndTxt.Name = "highSREndTxt";
            this.highSREndTxt.Size = new System.Drawing.Size(42, 20);
            this.highSREndTxt.TabIndex = 24;
            // 
            // highSRStartTxt
            // 
            this.highSRStartTxt.Location = new System.Drawing.Point(126, 217);
            this.highSRStartTxt.Name = "highSRStartTxt";
            this.highSRStartTxt.Size = new System.Drawing.Size(42, 20);
            this.highSRStartTxt.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Speaker Ready High";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label11.Location = new System.Drawing.Point(174, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 31);
            this.label11.TabIndex = 33;
            this.label11.Text = "-";
            // 
            // highBOEndTxt
            // 
            this.highBOEndTxt.Location = new System.Drawing.Point(203, 301);
            this.highBOEndTxt.Name = "highBOEndTxt";
            this.highBOEndTxt.Size = new System.Drawing.Size(42, 20);
            this.highBOEndTxt.TabIndex = 32;
            // 
            // highBOStartTxt
            // 
            this.highBOStartTxt.Location = new System.Drawing.Point(126, 301);
            this.highBOStartTxt.Name = "highBOStartTxt";
            this.highBOStartTxt.Size = new System.Drawing.Size(42, 20);
            this.highBOStartTxt.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Breakout High";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label13.Location = new System.Drawing.Point(174, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 31);
            this.label13.TabIndex = 29;
            this.label13.Text = "-";
            // 
            // lowBOEndTxt
            // 
            this.lowBOEndTxt.Location = new System.Drawing.Point(203, 264);
            this.lowBOEndTxt.Name = "lowBOEndTxt";
            this.lowBOEndTxt.Size = new System.Drawing.Size(42, 20);
            this.lowBOEndTxt.TabIndex = 28;
            // 
            // lowBOStartTxt
            // 
            this.lowBOStartTxt.Location = new System.Drawing.Point(126, 264);
            this.lowBOStartTxt.Name = "lowBOStartTxt";
            this.lowBOStartTxt.Size = new System.Drawing.Size(42, 20);
            this.lowBOStartTxt.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Breakout Low";
            // 
            // updateBtn
            // 
            this.updateBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.updateBtn.Location = new System.Drawing.Point(242, 343);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 35;
            this.updateBtn.Text = "Finish";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(161, 343);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 34;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // configForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 379);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.highBOEndTxt);
            this.Controls.Add(this.highBOStartTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lowBOEndTxt);
            this.Controls.Add(this.lowBOStartTxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.highSREndTxt);
            this.Controls.Add(this.highSRStartTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lowSREndTxt);
            this.Controls.Add(this.lowSRStartTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endBOTxt);
            this.Controls.Add(this.startBOTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endSRTxt);
            this.Controls.Add(this.startSRTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.importFilePathTxt);
            this.Controls.Add(this.label1);
            this.Name = "configForm";
            this.Text = "Configs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox importFilePathTxt;
        private System.Windows.Forms.TextBox startSRTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox endSRTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox endBOTxt;
        private System.Windows.Forms.TextBox startBOTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lowSREndTxt;
        private System.Windows.Forms.TextBox lowSRStartTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox highSREndTxt;
        private System.Windows.Forms.TextBox highSRStartTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox highBOEndTxt;
        private System.Windows.Forms.TextBox highBOStartTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox lowBOEndTxt;
        private System.Windows.Forms.TextBox lowBOStartTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}