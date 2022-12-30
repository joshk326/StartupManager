using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
    }
}
