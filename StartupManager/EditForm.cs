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
            DelayUpDown.Value = Convert.ToInt32(CurrentRow.Cells["delayCol"].Value);
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (ProcessNametxt.Text.Trim() != "")
            {
                CurrentRow.SetValues(ProcessNametxt.Text, DelayUpDown.Value.ToString());
                MF.dataGridView1.RefreshEdit();
                Functions.SaveFile(MF.dataGridView1, MF.absPath);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
           
        }
    }
}
