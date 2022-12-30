using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartupManager
{
    public partial class AddProcessForm : Form
    {
        string path;
        readonly MainForm MainForm = new MainForm();
        public AddProcessForm(MainForm f1obj)
        {
            InitializeComponent();
            MainForm = f1obj;
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
                    path = openFileDialog.FileName;
                    ProcessPathtxt.Text = path;
                }
            }
        }

        private void AddNewBTN_Click(object sender, EventArgs e)
        { 
            Functions.AddRow(MainForm.dataGridView1, path, ProcessNametxt.Text, (int)DelayUpDown.Value);
            Functions.SaveFile(MainForm.dataGridView1, "startup.dat");
            this.Close();
        }
    }
}
