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
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 120);
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
    }
}