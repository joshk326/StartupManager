using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace StartupManager
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isStartUpEnabled == true)
            {
                StartUpCheckBox.Checked = true;
            }

            if (Properties.Settings.Default.taskbarMode == true)
            {
                TaskbarModeCheckBox.Checked = true;
            }

            if (Properties.Settings.Default.startProcesses == true)
            {
                StartProcessesCheckBox.Checked = true;
            }
        }

        private void StartUpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (StartUpCheckBox.Checked == true)
            {
                Properties.Settings.Default.isStartUpEnabled = true;
                Properties.Settings.Default.Save();
                Functions.AddToStartUp();
            }
            else
            {
                Properties.Settings.Default.isStartUpEnabled = false;
                Properties.Settings.Default.Save();
                Functions.RemoveFromStartUp();
            }
        }

        private void TaskbarModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TaskbarModeCheckBox.Checked == true)
            {
                Properties.Settings.Default.taskbarMode = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.taskbarMode = false;
                Properties.Settings.Default.Save();
            }
        }

        private void OpenLogBTN_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "/select," + MainForm.logPath);
        }

        private void StartProcessesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (StartProcessesCheckBox.Checked == true)
            {
                Properties.Settings.Default.startProcesses = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.startProcesses = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
