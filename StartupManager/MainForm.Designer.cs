
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
            this.DgvContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TaskTrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleProcessStartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAllProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ToolBarStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolBarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsDropDown,
            this.HelpDropDown});
            this.ToolBarStrip.Location = new System.Drawing.Point(12, 0);
            this.ToolBarStrip.Name = "ToolBarStrip";
            this.ToolBarStrip.Size = new System.Drawing.Size(345, 22);
            this.ToolBarStrip.SizingGrip = false;
            this.ToolBarStrip.TabIndex = 0;
            // 
            // DgvContextMenu
            // 
            this.DgvContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DgvContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripSeparator2,
            this.newProcessToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteProcessToolStripMenuItem,
            this.toolStripSeparator3,
            this.singleProcessStartMenuItem});
            this.DgvContextMenu.Name = "contextMenuStrip1";
            this.DgvContextMenu.Size = new System.Drawing.Size(167, 146);
            this.DgvContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.DgvContextMenu_Opening);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // deleteProcessToolStripMenuItem
            // 
            this.deleteProcessToolStripMenuItem.Image = global::StartupManager.Properties.Resources.appbar_delete;
            this.deleteProcessToolStripMenuItem.Name = "deleteProcessToolStripMenuItem";
            this.deleteProcessToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.deleteProcessToolStripMenuItem.Text = "Remove";
            this.deleteProcessToolStripMenuItem.Visible = false;
            this.deleteProcessToolStripMenuItem.Click += new System.EventHandler(this.DeleteProcessToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(163, 6);
            this.toolStripSeparator3.Visible = false;
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
            this.dataGridView1.ColumnHeadersHeight = 29;
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
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(345, 438);
            this.dataGridView1.TabIndex = 1;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.MinimumWidth = 6;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            this.nameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameCol.Width = 110;
            // 
            // delayCol
            // 
            this.delayCol.HeaderText = "Delay";
            this.delayCol.MinimumWidth = 6;
            this.delayCol.Name = "delayCol";
            this.delayCol.ReadOnly = true;
            this.delayCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delayCol.Width = 50;
            // 
            // pathCol
            // 
            this.pathCol.HeaderText = "Path";
            this.pathCol.MinimumWidth = 6;
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
            this.TaskTrayContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TaskTrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.TaskTrayContextMenu.Name = "TaskTrayContextMenu";
            this.TaskTrayContextMenu.Size = new System.Drawing.Size(200, 62);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel,
            this.statusStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(369, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(52, 20);
            this.statusStripLabel.Text = "Status:";
            // 
            // statusStripStatus
            // 
            this.statusStripStatus.ForeColor = System.Drawing.Color.Gray;
            this.statusStripStatus.LinkColor = System.Drawing.SystemColors.Control;
            this.statusStripStatus.Name = "statusStripStatus";
            this.statusStripStatus.Size = new System.Drawing.Size(43, 20);
            this.statusStripStatus.Text = "idle...";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::StartupManager.Properties.Resources.appbar_refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // newProcessToolStripMenuItem
            // 
            this.newProcessToolStripMenuItem.Image = global::StartupManager.Properties.Resources.appbar_add;
            this.newProcessToolStripMenuItem.Name = "newProcessToolStripMenuItem";
            this.newProcessToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.newProcessToolStripMenuItem.Text = "Add";
            this.newProcessToolStripMenuItem.Click += new System.EventHandler(this.CreateProcessContext_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::StartupManager.Properties.Resources.appbar_edit_box;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Visible = false;
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // singleProcessStartMenuItem
            // 
            this.singleProcessStartMenuItem.Image = global::StartupManager.Properties.Resources.appbar_camera_flash;
            this.singleProcessStartMenuItem.Name = "singleProcessStartMenuItem";
            this.singleProcessStartMenuItem.Size = new System.Drawing.Size(166, 26);
            this.singleProcessStartMenuItem.Text = "Start Process";
            this.singleProcessStartMenuItem.Visible = false;
            this.singleProcessStartMenuItem.Click += new System.EventHandler(this.SingleProcessStartMenuItem_Click);
            // 
            // optionsDropDown
            // 
            this.optionsDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.startAllProcessesToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem1});
            this.optionsDropDown.Image = global::StartupManager.Properties.Resources.appbar_list;
            this.optionsDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optionsDropDown.Name = "optionsDropDown";
            this.optionsDropDown.Size = new System.Drawing.Size(93, 20);
            this.optionsDropDown.Text = "Options";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::StartupManager.Properties.Resources.appbar_add;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.addToolStripMenuItem.Text = "Add New Process";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // startAllProcessesToolStripMenuItem
            // 
            this.startAllProcessesToolStripMenuItem.Image = global::StartupManager.Properties.Resources.appbar_camera_flash;
            this.startAllProcessesToolStripMenuItem.Name = "startAllProcessesToolStripMenuItem";
            this.startAllProcessesToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.startAllProcessesToolStripMenuItem.Text = "Run All";
            this.startAllProcessesToolStripMenuItem.Click += new System.EventHandler(this.StartAllProcessesToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(204, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::StartupManager.Properties.Resources.appbar_close;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(207, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // HelpDropDown
            // 
            this.HelpDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem,
            this.SettingsMenuItem});
            this.HelpDropDown.Image = global::StartupManager.Properties.Resources.appbar_book_perspective_help;
            this.HelpDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpDropDown.Name = "HelpDropDown";
            this.HelpDropDown.Size = new System.Drawing.Size(71, 20);
            this.HelpDropDown.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Image = global::StartupManager.Properties.Resources.appbar_information_circle;
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(143, 26);
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Image = global::StartupManager.Properties.Resources.appbar_settings;
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(143, 26);
            this.SettingsMenuItem.Text = "Settings";
            this.SettingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // showApplicationToolStripMenuItem
            // 
            this.showApplicationToolStripMenuItem.Image = global::StartupManager.Properties.Resources.appbar_arrow_expand;
            this.showApplicationToolStripMenuItem.Name = "showApplicationToolStripMenuItem";
            this.showApplicationToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.showApplicationToolStripMenuItem.Text = "Show Application";
            this.showApplicationToolStripMenuItem.Click += new System.EventHandler(this.ShowApplicationTaskItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::StartupManager.Properties.Resources.appbar_close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitTaskItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathCol;
        private System.Windows.Forms.ToolStripDropDownButton HelpDropDown;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.NotifyIcon TaskTrayIcon;
        private System.Windows.Forms.ContextMenuStrip TaskTrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem showApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusStripStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem singleProcessStartMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton optionsDropDown;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startAllProcessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

