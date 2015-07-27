namespace SyncManager
{
    partial class SetupForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.ipScheme = new System.Windows.Forms.ComboBox();
            this.speakerReadyIPStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.speakerReadyIPEnd = new System.Windows.Forms.TextBox();
            this.breakoutIPEnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.breakoutIPStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.importBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Speaker Ready IP Addresses:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose IP Scheme:";
            // 
            // ipScheme
            // 
            this.ipScheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ipScheme.FormattingEnabled = true;
            this.ipScheme.Items.AddRange(new object[] {
            "Class B",
            "Class C"});
            this.ipScheme.Location = new System.Drawing.Point(172, 21);
            this.ipScheme.Name = "ipScheme";
            this.ipScheme.Size = new System.Drawing.Size(91, 28);
            this.ipScheme.TabIndex = 2;
            this.ipScheme.Text = "Class C";
            // 
            // speakerReadyIPStart
            // 
            this.speakerReadyIPStart.Location = new System.Drawing.Point(283, 79);
            this.speakerReadyIPStart.Name = "speakerReadyIPStart";
            this.speakerReadyIPStart.Size = new System.Drawing.Size(100, 20);
            this.speakerReadyIPStart.TabIndex = 3;
            this.speakerReadyIPStart.Text = "101";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(389, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "to";
            // 
            // speakerReadyIPEnd
            // 
            this.speakerReadyIPEnd.Location = new System.Drawing.Point(418, 79);
            this.speakerReadyIPEnd.Name = "speakerReadyIPEnd";
            this.speakerReadyIPEnd.Size = new System.Drawing.Size(100, 20);
            this.speakerReadyIPEnd.TabIndex = 5;
            this.speakerReadyIPEnd.Text = "104";
            // 
            // breakoutIPEnd
            // 
            this.breakoutIPEnd.Location = new System.Drawing.Point(373, 122);
            this.breakoutIPEnd.Name = "breakoutIPEnd";
            this.breakoutIPEnd.Size = new System.Drawing.Size(100, 20);
            this.breakoutIPEnd.TabIndex = 9;
            this.breakoutIPEnd.Text = "204";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(344, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "to";
            // 
            // breakoutIPStart
            // 
            this.breakoutIPStart.Location = new System.Drawing.Point(238, 122);
            this.breakoutIPStart.Name = "breakoutIPStart";
            this.breakoutIPStart.Size = new System.Drawing.Size(100, 20);
            this.breakoutIPStart.TabIndex = 7;
            this.breakoutIPStart.Text = "201";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Enter Breakout IP Addresses:";
            // 
            // continueButton
            // 
            this.continueButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.continueButton.Location = new System.Drawing.Point(253, 181);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(114, 26);
            this.continueButton.TabIndex = 10;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // importFileDialog
            // 
            this.importFileDialog.FileName = "Import File";
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(480, 33);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(75, 23);
            this.importBtn.TabIndex = 12;
            this.importBtn.Text = "Import";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 234);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.breakoutIPEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.breakoutIPStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.speakerReadyIPEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.speakerReadyIPStart);
            this.Controls.Add(this.ipScheme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetupForm";
            this.Text = "Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ipScheme;
        private System.Windows.Forms.TextBox speakerReadyIPStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox speakerReadyIPEnd;
        private System.Windows.Forms.TextBox breakoutIPEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox breakoutIPStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog importFileDialog;
        private System.Windows.Forms.Button importBtn;
    }
}