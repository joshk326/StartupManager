using StartupManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace StartupManager
{
    public partial class MainForm : Form
    {
        private readonly bool startProcesses = Properties.Settings.Default.startProcesses;
        private static readonly string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\StartupManager";
        private static readonly string fileName = "startup.bin";
        private bool runningAllProcesses = false;
        public string dataFilePath = Path.Combine(dirPath, fileName);
        public Dictionary<string, string[]> processes = new Dictionary<string, string[]>();
        public static string logPath = Path.Combine(dirPath, "log.txt");

        public MainForm()
        {
            InitializeComponent();
            if (Debugger.IsAttached)
            {
                Settings.Default.Reset();
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
            {
                MessageBox.Show("Application is already running");
                Environment.Exit(0);
            }

            if (!File.Exists(dataFilePath))
            {
                FileStream fs;
                Directory.CreateDirectory(dirPath);
                fs = File.Create(dataFilePath);
                fs.Close();
                statusStripStatus.Text = "data file created";
            }

            processes = Functions.ReadFile(dataFilePath);

            if (Properties.Settings.Default.firstStartUp)
            {
                Properties.Settings.Default.firstStartUp = false;
                Properties.Settings.Default.taskbarMode = true;
                Properties.Settings.Default.isStartUpEnabled = true;
                Properties.Settings.Default.startProcesses = true;
                Properties.Settings.Default.Save();

                FileStream fs;
                fs = File.Create(logPath);
                fs.Close();

                this.WindowState = FormWindowState.Normal;
                Functions.AddToStartUp();

                MessageBox.Show("Thank you for using Startup Manager!\nThe program will start in taskbar mode from now on.\nThis can be changed in the setings", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Clear out log file
                if (File.Exists(logPath))
                {
                    File.WriteAllText(logPath, string.Empty);
                }

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

                if (startProcesses && processes.Count > 0)
                {
                    runningAllProcesses = true;
                    Thread worker = new Thread(new ThreadStart(StartAllProcesses));
                    worker.Start();
                }
            }

            // Load processes into datagridview
            foreach (KeyValuePair<string, string[]> item in processes)
            {
                Functions.AddRow(dataGridView1, item.Value[0], item.Key, Convert.ToInt32(item.Value[1]));
            }
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        private void CreateProcessContext_Click(object sender, EventArgs e)
        {
            ProcessForm addnew = new ProcessForm(this, "Add new process", "Add");
            addnew.Show();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void DeleteProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            processes.Remove(row.Cells[0].Value.ToString());
            dataGridView1.Rows.RemoveAt(row.Index);
            Functions.SaveFile(processes, dataFilePath);

            if (dataGridView1.RowCount == 0)
            {
                editToolStripMenuItem.Visible = false;
                deleteProcessToolStripMenuItem.Visible = false;
            }
        }

        private void Main_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Functions.SaveFile(processes, dataFilePath);
            Environment.Exit(0);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessForm addnew = new ProcessForm(this, "Edit", "Save", dataGridView1.CurrentRow);
            addnew.Show();
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
            MessageBox.Show($"Startup Manager\nVersion: {Application.ProductVersion}", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessForm addnew = new ProcessForm(this, "Add new process", "Add");
            addnew.Show();
        }

        private void StartAllProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processes.Count > 0 && !runningAllProcesses)
            {
                runningAllProcesses = true;
                Thread worker = new Thread(new ThreadStart(StartAllProcesses));
                worker.Start();
            }
            else
            {
                statusStripStatus.ForeColor = Color.Red;
                statusStripStatus.Text = runningAllProcesses ? "already running all processes" : "no processes to start";
            }
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void StartAllProcesses()
        {
            foreach (KeyValuePair<string, string[]> item in processes.OrderBy(pair => pair.Value[1]))
            {
                statusStripStatus.ForeColor = Color.Gray;
                statusStripStatus.Text = $"starting {item.Key}...";
                Functions.StartProcess(item.Key, item.Value[0], Convert.ToInt32(item.Value[1]));
            }
            runningAllProcesses = false;
        }
    }
}
