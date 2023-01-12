namespace StartupManager
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.label5 = new System.Windows.Forms.Label();
            this.DelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ProcessNametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DelayUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "s";
            // 
            // DelayUpDown
            // 
            this.DelayUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DelayUpDown.Location = new System.Drawing.Point(125, 46);
            this.DelayUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.DelayUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.DelayUpDown.Name = "DelayUpDown";
            this.DelayUpDown.Size = new System.Drawing.Size(259, 22);
            this.DelayUpDown.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "*Delay determines when the application starts";
            // 
            // ProcessNametxt
            // 
            this.ProcessNametxt.Location = new System.Drawing.Point(79, 13);
            this.ProcessNametxt.Margin = new System.Windows.Forms.Padding(4);
            this.ProcessNametxt.Name = "ProcessNametxt";
            this.ProcessNametxt.Size = new System.Drawing.Size(352, 22);
            this.ProcessNametxt.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name:";
            // 
            // SaveBTN
            // 
            this.SaveBTN.Location = new System.Drawing.Point(24, 93);
            this.SaveBTN.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(408, 28);
            this.SaveBTN.TabIndex = 17;
            this.SaveBTN.Text = "Save Changes";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Startup delay:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 134);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DelayUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProcessNametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Process";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DelayUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown DelayUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProcessNametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Label label2;
    }
}