using IWshRuntimeLibrary;
using StartupManager;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Functions
{
    public static void SaveFile(Dictionary<string, string[]> dictionary, string file_name)
    {
        try
        {
            using (FileStream fs = new FileStream(file_name, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, dictionary);
            }
        }
        catch (Exception ex)
        {
            using (StreamWriter sw = System.IO.File.AppendText(MainForm.logPath))
            {
                sw.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    public static Dictionary<string, string[]> ReadFile(string file_name)
    {
        Dictionary<string, string[]> temp = new Dictionary<string, string[]>();

        try
        {
            using (FileStream fs = new FileStream(file_name, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                if (fs.Length > 0)
                {
                    temp = (Dictionary<string, string[]>)formatter.Deserialize(fs);
                }
            }
        }
        catch (Exception ex)
        {
            using (StreamWriter sw = System.IO.File.AppendText(MainForm.logPath))
            {
                sw.WriteLine($"Error: {ex.Message}");
            }
        }

        return temp;
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

    public static void StartProcess(string name, string path, int delay)
    {
        try
        {
            var elapsed = Task.Run(async () =>
            {
                Stopwatch sw = Stopwatch.StartNew();
                await Task.Delay(delay * 1000);
                System.Diagnostics.Process.Start(@path);
                sw.Stop();
                return sw.ElapsedMilliseconds;
            });

            using (StreamWriter sw = System.IO.File.AppendText(MainForm.logPath))
            {
                sw.WriteLine($"Process Name: {name}, Path: {path}, Startup Time: {elapsed.Result} ms");
            }
        }
        catch (Exception ex)
        {
            using (StreamWriter sw = System.IO.File.AppendText(MainForm.logPath))
            {
                sw.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    public static void AddToStartUp()
    {
        string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
        string shortcutPath = Path.Combine(startupPath, "StartupManager.lnk");
        if (!System.IO.File.Exists(@shortcutPath))
        {
            WshShell shell = new WshShell();
            IWshShortcut shortcut = shell.CreateShortcut(shortcutPath);
            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.WorkingDirectory = Application.StartupPath;

            shortcut.Save();
        }
    }
    public static void RemoveFromStartUp()
    {
        string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
        string shortcutPath = Path.Combine(startupPath, "StartupManager.lnk");
        if (System.IO.File.Exists(@shortcutPath))
        {
            System.IO.File.Delete(@shortcutPath);
        }
    }
}