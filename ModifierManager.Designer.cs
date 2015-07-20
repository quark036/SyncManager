namespace SyncManager
{
    partial class ModifierManager
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
            this.modifierTabControl = new System.Windows.Forms.TabControl();
            this.upTab = new System.Windows.Forms.TabPage();
            this.downTab = new System.Windows.Forms.TabPage();
            this.hiUpTab = new System.Windows.Forms.TabPage();
            this.hiDnTab = new System.Windows.Forms.TabPage();
            this.loUpTab = new System.Windows.Forms.TabPage();
            this.loDnTab = new System.Windows.Forms.TabPage();
            this.finishBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.modifierTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // modifierTabControl
            // 
            this.modifierTabControl.Controls.Add(this.upTab);
            this.modifierTabControl.Controls.Add(this.downTab);
            this.modifierTabControl.Controls.Add(this.hiUpTab);
            this.modifierTabControl.Controls.Add(this.hiDnTab);
            this.modifierTabControl.Controls.Add(this.loUpTab);
            this.modifierTabControl.Controls.Add(this.loDnTab);
            this.modifierTabControl.Location = new System.Drawing.Point(13, 13);
            this.modifierTabControl.Name = "modifierTabControl";
            this.modifierTabControl.SelectedIndex = 0;
            this.modifierTabControl.Size = new System.Drawing.Size(774, 232);
            this.modifierTabControl.TabIndex = 0;
            // 
            // upTab
            // 
            this.upTab.Location = new System.Drawing.Point(4, 22);
            this.upTab.Name = "upTab";
            this.upTab.Padding = new System.Windows.Forms.Padding(3);
            this.upTab.Size = new System.Drawing.Size(766, 206);
            this.upTab.TabIndex = 0;
            this.upTab.Text = "UP";
            this.upTab.UseVisualStyleBackColor = true;
            // 
            // downTab
            // 
            this.downTab.Location = new System.Drawing.Point(4, 22);
            this.downTab.Name = "downTab";
            this.downTab.Padding = new System.Windows.Forms.Padding(3);
            this.downTab.Size = new System.Drawing.Size(766, 206);
            this.downTab.TabIndex = 1;
            this.downTab.Text = "DOWN";
            this.downTab.UseVisualStyleBackColor = true;
            // 
            // hiUpTab
            // 
            this.hiUpTab.Location = new System.Drawing.Point(4, 22);
            this.hiUpTab.Name = "hiUpTab";
            this.hiUpTab.Padding = new System.Windows.Forms.Padding(3);
            this.hiUpTab.Size = new System.Drawing.Size(766, 206);
            this.hiUpTab.TabIndex = 2;
            this.hiUpTab.Text = "HIGH UP";
            this.hiUpTab.UseVisualStyleBackColor = true;
            // 
            // hiDnTab
            // 
            this.hiDnTab.Location = new System.Drawing.Point(4, 22);
            this.hiDnTab.Name = "hiDnTab";
            this.hiDnTab.Padding = new System.Windows.Forms.Padding(3);
            this.hiDnTab.Size = new System.Drawing.Size(766, 206);
            this.hiDnTab.TabIndex = 3;
            this.hiDnTab.Text = "HIGH DOWN";
            this.hiDnTab.UseVisualStyleBackColor = true;
            // 
            // loUpTab
            // 
            this.loUpTab.Location = new System.Drawing.Point(4, 22);
            this.loUpTab.Name = "loUpTab";
            this.loUpTab.Padding = new System.Windows.Forms.Padding(3);
            this.loUpTab.Size = new System.Drawing.Size(766, 206);
            this.loUpTab.TabIndex = 4;
            this.loUpTab.Text = "LOW UP";
            this.loUpTab.UseVisualStyleBackColor = true;
            // 
            // loDnTab
            // 
            this.loDnTab.Location = new System.Drawing.Point(4, 22);
            this.loDnTab.Name = "loDnTab";
            this.loDnTab.Padding = new System.Windows.Forms.Padding(3);
            this.loDnTab.Size = new System.Drawing.Size(766, 206);
            this.loDnTab.TabIndex = 5;
            this.loDnTab.Text = "LOW DOWN";
            this.loDnTab.UseVisualStyleBackColor = true;
            // 
            // finishBtn
            // 
            this.finishBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.finishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.finishBtn.Location = new System.Drawing.Point(796, 252);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(79, 25);
            this.finishBtn.TabIndex = 1;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelBtn.Location = new System.Drawing.Point(704, 252);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(79, 25);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ModifierManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 289);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.modifierTabControl);
            this.Name = "ModifierManager";
            this.Text = "Modifier Manager";
            this.Load += new System.EventHandler(this.ModifierManager_Load);
            this.modifierTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl modifierTabControl;
        private System.Windows.Forms.TabPage upTab;
        private System.Windows.Forms.TabPage downTab;
        private System.Windows.Forms.TabPage hiUpTab;
        private System.Windows.Forms.TabPage hiDnTab;
        private System.Windows.Forms.TabPage loUpTab;
        private System.Windows.Forms.TabPage loDnTab;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}