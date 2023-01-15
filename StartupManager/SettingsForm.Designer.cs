namespace StartupManager
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.SettingsGroup = new System.Windows.Forms.GroupBox();
            this.TaskbarModeCheckBox = new System.Windows.Forms.CheckBox();
            this.StartUpCheckBox = new System.Windows.Forms.CheckBox();
            this.OpenLogBTN = new System.Windows.Forms.Button();
            this.SettingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsGroup
            // 
            this.SettingsGroup.Controls.Add(this.TaskbarModeCheckBox);
            this.SettingsGroup.Controls.Add(this.StartUpCheckBox);
            this.SettingsGroup.Location = new System.Drawing.Point(12, 2);
            this.SettingsGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsGroup.Name = "SettingsGroup";
            this.SettingsGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsGroup.Size = new System.Drawing.Size(277, 74);
            this.SettingsGroup.TabIndex = 0;
            this.SettingsGroup.TabStop = false;
            this.SettingsGroup.Text = "Settings";
            // 
            // TaskbarModeCheckBox
            // 
            this.TaskbarModeCheckBox.AutoSize = true;
            this.TaskbarModeCheckBox.Location = new System.Drawing.Point(6, 46);
            this.TaskbarModeCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskbarModeCheckBox.Name = "TaskbarModeCheckBox";
            this.TaskbarModeCheckBox.Size = new System.Drawing.Size(161, 20);
            this.TaskbarModeCheckBox.TabIndex = 1;
            this.TaskbarModeCheckBox.Text = "Start in Taskbar Mode";
            this.TaskbarModeCheckBox.UseVisualStyleBackColor = true;
            this.TaskbarModeCheckBox.CheckedChanged += new System.EventHandler(this.TaskbarModeCheckBox_CheckedChanged);
            // 
            // StartUpCheckBox
            // 
            this.StartUpCheckBox.AutoSize = true;
            this.StartUpCheckBox.Location = new System.Drawing.Point(5, 22);
            this.StartUpCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartUpCheckBox.Name = "StartUpCheckBox";
            this.StartUpCheckBox.Size = new System.Drawing.Size(185, 20);
            this.StartUpCheckBox.TabIndex = 0;
            this.StartUpCheckBox.Text = "Start when Windows boots";
            this.StartUpCheckBox.UseVisualStyleBackColor = true;
            this.StartUpCheckBox.CheckedChanged += new System.EventHandler(this.StartUpCheckBox_CheckedChanged);
            // 
            // OpenLogBTN
            // 
            this.OpenLogBTN.Location = new System.Drawing.Point(12, 88);
            this.OpenLogBTN.Name = "OpenLogBTN";
            this.OpenLogBTN.Size = new System.Drawing.Size(277, 26);
            this.OpenLogBTN.TabIndex = 1;
            this.OpenLogBTN.Text = "Open log file location";
            this.OpenLogBTN.UseVisualStyleBackColor = true;
            this.OpenLogBTN.Click += new System.EventHandler(this.OpenLogBTN_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(301, 128);
            this.Controls.Add(this.OpenLogBTN);
            this.Controls.Add(this.SettingsGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.SettingsGroup.ResumeLayout(false);
            this.SettingsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SettingsGroup;
        private System.Windows.Forms.CheckBox StartUpCheckBox;
        private System.Windows.Forms.CheckBox TaskbarModeCheckBox;
        private System.Windows.Forms.Button OpenLogBTN;
    }
}