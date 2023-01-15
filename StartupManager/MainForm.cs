using StartupManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StartupManager
{
    public partial class MainForm : Form
    {
        private bool isStartup = Properties.Settings.Default.isStartUpEnabled;
        private static string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\StartupManager";
        private static string fileName = "startup.dat";
        public string absPath = Path.Combine(dirPath, fileName);

        public MainForm()
        {
            InitializeComponent();
            if (Debugger.IsAttached)
            {
                Settings.Default.Reset();
            }

        }

        private void CreateProcessContext_Click(object sender, EventArgs e)
        {
            AddProcessForm addnew = new AddProcessForm(this);
            addnew.Show();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1) {
                MessageBox.Show("Application is already running");
                Environment.Exit(0);
            }

            if (!File.Exists(absPath))
            {
                FileStream fs;
                Directory.CreateDirectory(dirPath);
                fs = File.Create(absPath);
                fs.Close();
                statusStripStatus.Text = "data file created";
            }
            
            Functions.ReadFile(dataGridView1, absPath);

            if (Properties.Settings.Default.firstStartUp) {
                Properties.Settings.Default.firstStartUp = false;
                Properties.Settings.Default.taskbarMode = true;
                Properties.Settings.Default.isStartUpEnabled = true;
                Properties.Settings.Default.Save();
                
                this.WindowState = FormWindowState.Normal;
                Functions.AddToStartUp();
               
                MessageBox.Show("Thank you for using Startup Manager!\nThe program will start in taskbar mode from now on.\nThis can be changed in the setings", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                if (Properties.Settings.Default.taskbarMode)
                {
                    this.Hide();
                    this.WindowState = FormWindowState.Minimized;
                }
                else
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                }
                
                if (isStartup)
                {
                    int delay = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        delay += Convert.ToInt32(dataGridView1.Rows[i].Cells["delayCol"].Value);
                        statusStripStatus.Text = "starting process " + dataGridView1.Rows[i].Cells["nameCol"].Value.ToString();
                    }
                    Functions.StartProcesses(dataGridView1);
                    Thread.Sleep((delay + 1) * 1000);
                }
            }
        }

        private void DeleteProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            Functions.SaveFile(dataGridView1, absPath);
            if (dataGridView1.RowCount == 0)
            {
                editToolStripMenuItem.Visible = false;
                deleteProcessToolStripMenuItem.Visible = false;
                singleProcessStartMenuItem.Visible = false;
                toolStripSeparator3.Visible = false;
            }
        }
       
        private void Main_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Task save =  Task.Run(() => Functions.SaveFile(dataGridView1, absPath));
            save.Wait();
            Environment.Exit(0);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm EF = new EditForm();
            EF.CurrentRow = dataGridView1.CurrentRow;
            EF.Show();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(this.Width - 40, this.Height - 80);
            dataGridView1.Columns[0].Width = Convert.ToInt32(dataGridView1.Size.Width * 0.14);
            dataGridView1.Columns[1].Width = Convert.ToInt32(dataGridView1.Size.Width * 0.31);
            dataGridView1.Columns[2].Width = Convert.ToInt32(dataGridView1.Size.Width * 0.5491);

        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Startup Manager\nVersion: 1.0.0.0", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();

            settings.Show();
        }

        private void ShowApplicationTaskItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ExitTaskItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void DgvContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                editToolStripMenuItem.Visible = true;
                deleteProcessToolStripMenuItem.Visible = true;
                singleProcessStartMenuItem.Visible = true;
                toolStripSeparator3.Visible = true;
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProcessForm addnew = new AddProcessForm(this);
            addnew.Show();
        }

        private void StartAllProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int delay = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    delay += Convert.ToInt32(dataGridView1.Rows[i].Cells["delayCol"].Value);
                    statusStripStatus.ForeColor = Color.Gray;
                    statusStripStatus.Text = "Starting " + dataGridView1[0, i].Value;
                }
                Functions.StartProcesses(dataGridView1);
                Thread.Sleep((delay + 1) * 1000);
            }
            else
            {
                statusStripStatus.ForeColor = Color.Red;
                statusStripStatus.Text = "No processes to start";
            }
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SingleProcessStartMenuItem_Click(object sender, EventArgs e)
        {
            Functions.SingleProcessStart(dataGridView1.CurrentRow);
            statusStripStatus.Text = "starting process " + dataGridView1.CurrentRow.Cells["nameCol"].Value.ToString();
        }
    }
}
