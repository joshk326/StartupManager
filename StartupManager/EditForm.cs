using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartupManager
{
    public partial class EditForm : Form
    {
        MainForm MF = new MainForm();
        public DataGridViewRow CurrentRow;
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            ProcessNametxt.Text = CurrentRow.Cells["nameCol"].Value.ToString();
            ProcessPathtxt.Text = CurrentRow.Cells["pathCol"].Value.ToString();
            DelayUpDown.Value = Convert.ToInt32(CurrentRow.Cells["delayCol"].Value);
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            CurrentRow.SetValues(ProcessNametxt.Text, DelayUpDown.Value.ToString(), ProcessPathtxt.Text);
            MF.dataGridView1.Refresh();
            Functions.SaveFile(MF.dataGridView1, "startup.dat");
            this.Close();
        }

        private void SelectProcessPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ProcessPathtxt.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
