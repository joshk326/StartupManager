using IWshRuntimeLibrary;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
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
            using (BinaryReader br = new BinaryReader(file))
            {
                while (br.PeekChar() != -1)
                {
                    int n = br.ReadInt32();
                    int m = br.ReadInt32();
                    for (int i = 0; i < m; ++i)
                    {
                        dgv.Rows.Add();
                        for (int j = 0; j < n; ++j)
                        {
                            if (br.ReadBoolean())
                            {
                                dgv.Rows[i].Cells[j].Value = br.ReadString();
                            }
                            else br.ReadBoolean();
                        }
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
    public static void SingleProcessStart(DataGridViewRow CurrentRow)
    {
        string path = CurrentRow.Cells["pathCol"].Value.ToString();
        int delay = Convert.ToInt32(CurrentRow.Cells["delayCol"].Value.ToString());

        var elapsed = Task.Run(async () => {
            Stopwatch sw = Stopwatch.StartNew();
            await Task.Delay(delay * 1000);
            System.Diagnostics.Process.Start(@path);
            sw.Stop();
            return sw.ElapsedMilliseconds;
        });
    }
    public static void AddToStartUp()
    {
        //string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
        string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
        string shortcutPath = Path.Combine(startupPath, "StartupManager.lnk");
        Console.WriteLine(shortcutPath);
        if (!System.IO.File.Exists(@shortcutPath))
        {
            var shell = new WshShell();
            var shortcut = shell.CreateShortcut(shortcutPath) as IWshShortcut;
            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.WorkingDirectory = Application.StartupPath;
            
            shortcut.Save();
        }
    }
    public static void RemoveFromStartUp()
    {
        //string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
        string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
        string shortcutPath = Path.Combine(startupPath, "StartupManager.lnk");
        if (System.IO.File.Exists(@shortcutPath))
        {
            System.IO.File.Delete(@shortcutPath);
        }
    }
}