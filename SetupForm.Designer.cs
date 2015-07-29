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
            this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.importBtn = new System.Windows.Forms.Button();
            this.importFilePathTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.ipSchemeTxt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // importFileDialog
            // 
            this.importFileDialog.FileName = "Import File";
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(389, 36);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(75, 23);
            this.importBtn.TabIndex = 12;
            this.importBtn.Text = "Browse";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // importFilePathTxt
            // 
            this.importFilePathTxt.Location = new System.Drawing.Point(179, 38);
            this.importFilePathTxt.Name = "importFilePathTxt";
            this.importFilePathTxt.Size = new System.Drawing.Size(204, 20);
            this.importFilePathTxt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose File to Import";
            // 
            // continueBtn
            // 
            this.continueBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.continueBtn.Location = new System.Drawing.Point(248, 77);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(75, 23);
            this.continueBtn.TabIndex = 14;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(167, 77);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 35;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ipSchemeTxt
            // 
            this.ipSchemeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ipSchemeTxt.FormattingEnabled = true;
            this.ipSchemeTxt.Items.AddRange(new object[] {
            "Class C",
            "Class B"});
            this.ipSchemeTxt.Location = new System.Drawing.Point(179, 4);
            this.ipSchemeTxt.Name = "ipSchemeTxt";
            this.ipSchemeTxt.Size = new System.Drawing.Size(76, 28);
            this.ipSchemeTxt.TabIndex = 37;
            this.ipSchemeTxt.Text = "Class C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(86, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "IP Scheme";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 112);
            this.Controls.Add(this.ipSchemeTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.importFilePathTxt);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.label2);
            this.Name = "SetupForm";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog importFileDialog;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.TextBox importFilePathTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox ipSchemeTxt;
        private System.Windows.Forms.Label label6;
    }
}