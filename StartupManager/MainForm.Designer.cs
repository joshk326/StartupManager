
namespace StartupManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolBarStrip = new System.Windows.Forms.StatusStrip();
            this.CreateToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.ManualStartToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.HelpDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DgvContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NameEdit = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DelayEdit = new System.Windows.Forms.ToolStripTextBox();
            this.pathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PathEdit = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TaskTrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolBarStrip.SuspendLayout();
            this.DgvContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TaskTrayContextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBarStrip
            // 
            this.ToolBarStrip.AutoSize = false;
            this.ToolBarStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolBarStrip.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStrip,
            this.ManualStartToolStrip,
            this.toolStripStatusLabel1,
            this.HelpDropDown});
            this.ToolBarStrip.Location = new System.Drawing.Point(12, 0);
            this.ToolBarStrip.Name = "ToolBarStrip";
            this.ToolBarStrip.Size = new System.Drawing.Size(345, 22);
            this.ToolBarStrip.SizingGrip = false;
            this.ToolBarStrip.TabIndex = 0;
            // 
            // CreateToolStrip
            // 
            this.CreateToolStrip.Name = "CreateToolStrip";
            this.CreateToolStrip.Size = new System.Drawing.Size(77, 17);
            this.CreateToolStrip.Text = "Add Process";
            this.CreateToolStrip.Click += new System.EventHandler(this.CreateToolStrip_Click);
            // 
            // ManualStartToolStrip
            // 
            this.ManualStartToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ManualStartToolStrip.Name = "ManualStartToolStrip";
            this.ManualStartToolStrip.Size = new System.Drawing.Size(75, 17);
            this.ManualStartToolStrip.Text = "Manual Start";
            this.ManualStartToolStrip.Click += new System.EventHandler(this.ManualStartToolStrip_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // HelpDropDown
            // 
            this.HelpDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem,
            this.SettingsMenuItem,
            this.toolStripSeparator4,
            this.closeApplicationToolStripMenuItem});
            this.HelpDropDown.Image = ((System.Drawing.Image)(resources.GetObject("HelpDropDown.Image")));
            this.HelpDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpDropDown.Name = "HelpDropDown";
            this.HelpDropDown.Size = new System.Drawing.Size(46, 20);
            this.HelpDropDown.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(169, 22);
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(169, 22);
            this.SettingsMenuItem.Text = "Settings";
            this.SettingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(166, 6);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.CloseApplicationToolStripMenuItem_Click);
            // 
            // DgvContextMenu
            // 
            this.DgvContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripSeparator2,
            this.newProcessToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteProcessToolStripMenuItem});
            this.DgvContextMenu.Name = "contextMenuStrip1";
            this.DgvContextMenu.Size = new System.Drawing.Size(118, 98);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(114, 6);
            // 
            // newProcessToolStripMenuItem
            // 
            this.newProcessToolStripMenuItem.Name = "newProcessToolStripMenuItem";
            this.newProcessToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.newProcessToolStripMenuItem.Text = "Add";
            this.newProcessToolStripMenuItem.Click += new System.EventHandler(this.CreateProcessContext_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.NameEdit,
            this.toolStripMenuItem2,
            this.DelayEdit,
            this.pathToolStripMenuItem,
            this.PathEdit,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            this.editToolStripMenuItem.MouseHover += new System.EventHandler(this.EditToolStripMenuItem_MouseHover);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem1.Text = "Name:";
            // 
            // NameEdit
            // 
            this.NameEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameEdit.Name = "NameEdit";
            this.NameEdit.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem2.Text = "Delay:";
            // 
            // DelayEdit
            // 
            this.DelayEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DelayEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DelayEdit.Name = "DelayEdit";
            this.DelayEdit.Size = new System.Drawing.Size(100, 23);
            // 
            // pathToolStripMenuItem
            // 
            this.pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            this.pathToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.pathToolStripMenuItem.Text = "Path:";
            // 
            // PathEdit
            // 
            this.PathEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PathEdit.Name = "PathEdit";
            this.PathEdit.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // deleteProcessToolStripMenuItem
            // 
            this.deleteProcessToolStripMenuItem.Name = "deleteProcessToolStripMenuItem";
            this.deleteProcessToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deleteProcessToolStripMenuItem.Text = "Remove";
            this.deleteProcessToolStripMenuItem.Click += new System.EventHandler(this.DeleteProcessToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCol,
            this.delayCol,
            this.pathCol});
            this.dataGridView1.ContextMenuStrip = this.DgvContextMenu;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(345, 438);
            this.dataGridView1.TabIndex = 1;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            this.nameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameCol.Width = 110;
            // 
            // delayCol
            // 
            this.delayCol.HeaderText = "Delay";
            this.delayCol.Name = "delayCol";
            this.delayCol.ReadOnly = true;
            this.delayCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delayCol.Width = 50;
            // 
            // pathCol
            // 
            this.pathCol.HeaderText = "Path";
            this.pathCol.Name = "pathCol";
            this.pathCol.ReadOnly = true;
            this.pathCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pathCol.Width = 184;
            // 
            // TaskTrayIcon
            // 
            this.TaskTrayIcon.ContextMenuStrip = this.TaskTrayContextMenu;
            this.TaskTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TaskTrayIcon.Icon")));
            this.TaskTrayIcon.Text = "Startup Manager";
            this.TaskTrayIcon.Visible = true;
            // 
            // TaskTrayContextMenu
            // 
            this.TaskTrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.TaskTrayContextMenu.Name = "TaskTrayContextMenu";
            this.TaskTrayContextMenu.Size = new System.Drawing.Size(168, 54);
            // 
            // showApplicationToolStripMenuItem
            // 
            this.showApplicationToolStripMenuItem.Name = "showApplicationToolStripMenuItem";
            this.showApplicationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.showApplicationToolStripMenuItem.Text = "Show Application";
            this.showApplicationToolStripMenuItem.Click += new System.EventHandler(this.ShowApplicationTaskItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitTaskItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel,
            this.statusStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(369, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(42, 17);
            this.statusStripLabel.Text = "Status:";
            // 
            // statusStripStatus
            // 
            this.statusStripStatus.ForeColor = System.Drawing.Color.Gray;
            this.statusStripStatus.LinkColor = System.Drawing.SystemColors.Control;
            this.statusStripStatus.Name = "statusStripStatus";
            this.statusStripStatus.Size = new System.Drawing.Size(35, 17);
            this.statusStripStatus.Text = "idle...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 491);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ToolBarStrip);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startup Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Closing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ToolBarStrip.ResumeLayout(false);
            this.ToolBarStrip.PerformLayout();
            this.DgvContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TaskTrayContextMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ToolBarStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip DgvContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel CreateToolStrip;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ManualStartToolStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox NameEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox DelayEdit;
        private System.Windows.Forms.ToolStripMenuItem pathToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox PathEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathCol;
        private System.Windows.Forms.ToolStripDropDownButton HelpDropDown;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NotifyIcon TaskTrayIcon;
        private System.Windows.Forms.ContextMenuStrip TaskTrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem showApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusStripStatus;
    }
}

