
namespace StartupManager
{
    partial class ProcessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcessPathtxt = new System.Windows.Forms.TextBox();
            this.SelectProcessPath = new System.Windows.Forms.Button();
            this.FormBtn = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIle path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Startup delay:";
            // 
            // ProcessPathtxt
            // 
            this.ProcessPathtxt.AllowDrop = true;
            this.ProcessPathtxt.Location = new System.Drawing.Point(70, 9);
            this.ProcessPathtxt.Name = "ProcessPathtxt";
            this.ProcessPathtxt.Size = new System.Drawing.Size(215, 20);
            this.ProcessPathtxt.TabIndex = 3;
            // 
            // SelectProcessPath
            // 
            this.SelectProcessPath.Location = new System.Drawing.Point(291, 7);
            this.SelectProcessPath.Name = "SelectProcessPath";
            this.SelectProcessPath.Size = new System.Drawing.Size(30, 23);
            this.SelectProcessPath.TabIndex = 4;
            this.SelectProcessPath.Text = "...";
            this.SelectProcessPath.UseVisualStyleBackColor = true;
            this.SelectProcessPath.Click += new System.EventHandler(this.SelectProcessPath_Click);
            // 
            // FormBtn
            // 
            this.FormBtn.Location = new System.Drawing.Point(15, 100);
            this.FormBtn.Name = "FormBtn";
            this.FormBtn.Size = new System.Drawing.Size(306, 23);
            this.FormBtn.TabIndex = 7;
            this.FormBtn.Text = "__";
            this.FormBtn.UseVisualStyleBackColor = true;
            this.FormBtn.Click += new System.EventHandler(this.FormBtn_Click);
            // 
            // ProcessNametxt
            // 
            this.ProcessNametxt.Location = new System.Drawing.Point(56, 35);
            this.ProcessNametxt.Name = "ProcessNametxt";
            this.ProcessNametxt.Size = new System.Drawing.Size(265, 20);
            this.ProcessNametxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "*Delay determines when the application starts";
            // 
            // DelayUpDown
            // 
            this.DelayUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DelayUpDown.Location = new System.Drawing.Point(91, 62);
            this.DelayUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.DelayUpDown.Name = "DelayUpDown";
            this.DelayUpDown.Size = new System.Drawing.Size(194, 20);
            this.DelayUpDown.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "s";
            // 
            // ProcessForm
            // 
            this.AcceptButton = this.FormBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 135);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DelayUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProcessNametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FormBtn);
            this.Controls.Add(this.SelectProcessPath);
            this.Controls.Add(this.ProcessPathtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ProcessForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DelayUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProcessPathtxt;
        private System.Windows.Forms.Button SelectProcessPath;
        private System.Windows.Forms.Button FormBtn;
        private System.Windows.Forms.TextBox ProcessNametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DelayUpDown;
        private System.Windows.Forms.Label label5;
    }
}