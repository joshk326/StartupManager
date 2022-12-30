
namespace StartupManager
{
    partial class AddProcessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProcessForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcessPathtxt = new System.Windows.Forms.TextBox();
            this.SelectProcessPath = new System.Windows.Forms.Button();
            this.AddNewBTN = new System.Windows.Forms.Button();
            this.ProcessNametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DelayUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIle path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Startup delay:";
            // 
            // ProcessPathtxt
            // 
            this.ProcessPathtxt.AllowDrop = true;
            this.ProcessPathtxt.Location = new System.Drawing.Point(93, 11);
            this.ProcessPathtxt.Margin = new System.Windows.Forms.Padding(4);
            this.ProcessPathtxt.Name = "ProcessPathtxt";
            this.ProcessPathtxt.Size = new System.Drawing.Size(285, 22);
            this.ProcessPathtxt.TabIndex = 3;
            // 
            // SelectProcessPath
            // 
            this.SelectProcessPath.Location = new System.Drawing.Point(388, 9);
            this.SelectProcessPath.Margin = new System.Windows.Forms.Padding(4);
            this.SelectProcessPath.Name = "SelectProcessPath";
            this.SelectProcessPath.Size = new System.Drawing.Size(40, 28);
            this.SelectProcessPath.TabIndex = 4;
            this.SelectProcessPath.Text = "...";
            this.SelectProcessPath.UseVisualStyleBackColor = true;
            this.SelectProcessPath.Click += new System.EventHandler(this.SelectProcessPath_Click);
            // 
            // AddNewBTN
            // 
            this.AddNewBTN.Location = new System.Drawing.Point(20, 123);
            this.AddNewBTN.Margin = new System.Windows.Forms.Padding(4);
            this.AddNewBTN.Name = "AddNewBTN";
            this.AddNewBTN.Size = new System.Drawing.Size(408, 28);
            this.AddNewBTN.TabIndex = 7;
            this.AddNewBTN.Text = "Add";
            this.AddNewBTN.UseVisualStyleBackColor = true;
            this.AddNewBTN.Click += new System.EventHandler(this.AddNewBTN_Click);
            // 
            // ProcessNametxt
            // 
            this.ProcessNametxt.Location = new System.Drawing.Point(75, 43);
            this.ProcessNametxt.Margin = new System.Windows.Forms.Padding(4);
            this.ProcessNametxt.Name = "ProcessNametxt";
            this.ProcessNametxt.Size = new System.Drawing.Size(352, 22);
            this.ProcessNametxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "*Delay determines when the application starts";
            // 
            // DelayUpDown
            // 
            this.DelayUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DelayUpDown.Location = new System.Drawing.Point(121, 76);
            this.DelayUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.DelayUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.DelayUpDown.Name = "DelayUpDown";
            this.DelayUpDown.Size = new System.Drawing.Size(259, 22);
            this.DelayUpDown.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "s";
            // 
            // AddProcessForm
            // 
            this.AcceptButton = this.AddNewBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 166);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DelayUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProcessNametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddNewBTN);
            this.Controls.Add(this.SelectProcessPath);
            this.Controls.Add(this.ProcessPathtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProcessForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new process";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.DelayUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProcessPathtxt;
        private System.Windows.Forms.Button SelectProcessPath;
        private System.Windows.Forms.Button AddNewBTN;
        private System.Windows.Forms.TextBox ProcessNametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DelayUpDown;
        private System.Windows.Forms.Label label5;
    }
}