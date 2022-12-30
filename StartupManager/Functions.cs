using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using IWshRuntimeLibrary;
using System.Windows.Forms;

public class Functions
{
    public static void SaveFile(DataGridView dgv, string file_name)
    {
        FileStream file = System.IO.File.Open(file_name, FileMode.Create);
        using (BinaryWriter bw = new BinaryWriter(file))
        {
            bw.Write(dgv.Columns.Count);
            bw.Write(dgv.Rows.Count);
            foreach (DataGridViewRow dgvR in dgv.Rows)
            {
                for (int j = 0; j < dgv.Columns.Count; ++j)
                {
                    object val = dgvR.Cells[j].Value;
                    if (val == null)
                    {
                        bw.Write(false);
                        bw.Write(false);
                    }
                    else
                    {
                        bw.Write(true);
                        bw.Write(val.ToString());
                    }
                }
            }

        }

        file.Close();

    }
    public static void ReadFile(DataGridView dgv, string file_name)
    {
        try
        {
            FileStream file = System.IO.File.Open(file_name, FileMode.Open);

            dgv.Rows.Clear();
            using (BinaryReader bw = new BinaryReader(file))
            {
                int n = bw.ReadInt32();
                int m = bw.ReadInt32();
                for (int i = 0; i < m; ++i)
                {
                    dgv.Rows.Add();
                    for (int j = 0; j < n; ++j)
                    {
                        if (bw.ReadBoolean())
                        {
                            dgv.Rows[i].Cells[j].Value = bw.ReadString();
                        }
                        else bw.ReadBoolean();
                    }
                }

            }

            file.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    public static void AddRow(DataGridView dgv, string Path, string Name, int Delay)
    {
        try
        {
            dgv.Rows.Add(Name, Delay, Path);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }  
    public static void StartProcesses(DataGridView dgv)
    {
        dgv.Sort(dgv.Columns["delayCol"], System.ComponentModel.ListSortDirection.Ascending);

        foreach (DataGridViewRow dgvR in dgv.Rows)
        {
            string path = dgvR.Cells["pathCol"].Value.ToString();
            int delay = Convert.ToInt32(dgvR.Cells["delayCol"].Value.ToString());

            var elapsed = Task.Run(async () => {
                Stopwatch sw = Stopwatch.StartNew();
                await Task.Delay(delay*1000);
                System.Diagnostics.Process.Start(@path);
                sw.Stop();
                return sw.ElapsedMilliseconds;
            });

        }

        return;
        
    }   
    public static void AddToStartUp()
    {
        if (!System.IO.File.Exists(@"C:\Users\Josh\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\StartupManager.lnk"))
        {
            string startupLink = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
                + Path.DirectorySeparatorChar + Application.ProductName + ".lnk";
            var shell = new WshShell();
            var shortcut = shell.CreateShortcut(startupLink) as IWshShortcut;
            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.WorkingDirectory = Application.StartupPath;
            //shortcut...
            shortcut.Save();
        }
    }
}