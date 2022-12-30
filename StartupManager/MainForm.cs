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
        public bool isStartup = Properties.Settings.Default.isStartUpEnabled;

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

        private void CreateToolStrip_Click(object sender, EventArgs e)
        {
            AddProcessForm addnew = new AddProcessForm(this);
            addnew.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.firstStartUp) {
                Properties.Settings.Default.firstStartUp = false;
                Properties.Settings.Default.taskbarMode = true;
                Properties.Settings.Default.isStartUpEnabled = true;
                Properties.Settings.Default.Save();

                Functions.AddToStartUp();
                this.WindowState = FormWindowState.Normal;

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
                
                Functions.ReadFile(dataGridView1, "data.bin");
                if (isStartup)
                {
                    int delay = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        delay += Convert.ToInt32(dataGridView1.Rows[i].Cells["delayCol"].Value);
                    }
                    Functions.StartProcesses(dataGridView1);
                    Thread.Sleep((delay + 1) * 1000);
                    Environment.Exit(0);
                }
            }
        }

        private void DeleteProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            Functions.SaveFile(dataGridView1, "data.bin");
        }
       
        private void Main_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Functions.SaveFile(dataGridView1, "data.bin");
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameEdit.Text = dataGridView1.CurrentRow.Cells["nameCol"].Value.ToString();
            DelayEdit.Text = dataGridView1.CurrentRow.Cells["delayCol"].Value.ToString();
            PathEdit.Text = dataGridView1.CurrentRow.Cells["pathCol"].Value.ToString();
        }

        private void EditToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            NameEdit.Text = dataGridView1.CurrentRow.Cells["nameCol"].Value.ToString();
            DelayEdit.Text = dataGridView1.CurrentRow.Cells["delayCol"].Value.ToString();
            PathEdit.Text = dataGridView1.CurrentRow.Cells["pathCol"].Value.ToString();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.SetValues(NameEdit.Text, DelayEdit.Text, PathEdit.Text);
            Functions.SaveFile(dataGridView1, "data.bin");
        }

        private void ManualStartToolStrip_Click(object sender, EventArgs e)
        {
            int delay = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                delay += Convert.ToInt32(dataGridView1.Rows[i].Cells["delayCol"].Value);
            }
            Functions.StartProcesses(dataGridView1);
            Thread.Sleep((delay+1)*1000);
            Environment.Exit(0);

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

        private void CloseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
