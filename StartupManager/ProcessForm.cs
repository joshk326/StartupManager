using System;
using System.Windows.Forms;

namespace StartupManager
{
    public partial class ProcessForm : Form
    {
        private readonly DataGridViewRow currentRow = null;
        readonly MainForm MainForm = null;

        public ProcessForm(MainForm mainForm, string title, string btnTxt, DataGridViewRow currentRow = null)
        {
            InitializeComponent();
            MainForm = mainForm;
            this.Text = title;
            FormBtn.Text = btnTxt;
            this.currentRow = currentRow;
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

        private void FormBtn_Click(object sender, EventArgs e)
        {
            if (ProcessNametxt.Text.Length > 0 && ProcessPathtxt.Text.Length > 0)
            {
                if (currentRow != null)
                {
                    string originalName = currentRow.Cells[0].Value.ToString();

                    currentRow.SetValues(ProcessNametxt.Text, DelayUpDown.Value.ToString(), ProcessPathtxt.Text);
                    MainForm.dataGridView1.RefreshEdit();

                    if (MainForm.processes.ContainsKey(originalName))
                    {
                        // This should always be true
                        MainForm.processes[originalName] = new string[] { ProcessPathtxt.Text, DelayUpDown.Value.ToString() };
                    }
                    else
                    {
                        MainForm.processes.Add(ProcessNametxt.Text, new string[] { ProcessPathtxt.Text, DelayUpDown.Value.ToString() });
                    }

                    Functions.SaveFile(MainForm.processes, MainForm.dataFilePath);

                    this.Close();
                }
                else
                {
                    if (MainForm.processes.ContainsKey(ProcessNametxt.Text))
                    {
                        MessageBox.Show($"{ProcessNametxt.Text} already exists.");
                    }
                    else
                    {
                        Functions.AddRow(MainForm.dataGridView1, ProcessPathtxt.Text, ProcessNametxt.Text, (int)DelayUpDown.Value);
                        MainForm.processes.Add(ProcessNametxt.Text, new string[] { ProcessPathtxt.Text, DelayUpDown.Value.ToString() });
                        Functions.SaveFile(MainForm.processes, MainForm.dataFilePath);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void ProcessForm_Load(object sender, EventArgs e)
        {
            if (currentRow != null)
            {
                ProcessPathtxt.Text = currentRow.Cells["pathCol"].Value.ToString();
                ProcessNametxt.Text = currentRow.Cells["nameCol"].Value.ToString();
                DelayUpDown.Value = Convert.ToInt32(currentRow.Cells["delayCol"].Value);
            }
        }
    }
}
