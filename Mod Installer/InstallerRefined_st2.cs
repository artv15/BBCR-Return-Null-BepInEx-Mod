using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod_Installer
{
    public partial class InstallerRefined_st2 : Form
    {
        bool installationCompleted = false;

        public InstallerRefined_st2()
        {
            InitializeComponent();
            installLogTextBox.ReadOnly = true;
            installProgressBar.Maximum = 100;
            installProgressBar.Minimum = 0;
            installProgressBar.Value = 0;

            Console.WriteLine("[INSTALLER REFINED] Entered stage 2.");
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            installButton.Enabled = false;
            installLogTextBox.Text += "Installation is in progress...\n";
            installProgressBar.Value = 0;
            if (installationCompleted)
            {
                var stage3Form = new InstallerRefined_st3();
                stage3Form.Show();
                stage3Form.FormClosed += (object sender, FormClosedEventArgs e) =>
                {
                    this.Close();
                };
                this.Hide();
                return;
            }
            Task.Run(async () => //getting it on another thread, because "heavy load"
            {
                Console.WriteLine("[INSTALLER REFINED] Installation started on another thread.");
                installLogTextBox.Invoke(t => t.Text += "Thread Created.\n");

                try
                {
                    if (File.Exists($"{Directory.GetCurrentDirectory()}/BepInEx_x86.zip"))
                    {
                        Console.WriteLine("[INSTALLER REFINED] BepInEx x86 was previosly installed and not cleaned up, somehow. Removing...");
                        File.Delete($"{Directory.GetCurrentDirectory()}/BepInEx_x86.zip");
                    }
                    if (File.Exists($"{Directory.GetCurrentDirectory()}/BepInEx_x64.zip"))
                    {
                        Console.WriteLine("[INSTALLER REFINED] BepInEx x64 was previosly installed and not cleaned up, somehow. Removing...");
                        File.Delete($"{Directory.GetCurrentDirectory()}/BepInEx_x64.zip");
                    }
                    if (Directory.Exists(Program.gameFolderPath + "\\BepInEx"))
                    {
                        if (!Directory.Exists(Program.gameFolderPath + "\\BepInEx\\plugins"))
                        {
                            MessageBox.Show("Now we will start the game and generate all required folders. Click OK to start the game", "Folders not present", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Process.Start(Program.gameFolderPath + "\\BALDI.exe");
                            while (true)
                            {
                                if (Directory.Exists(Program.gameFolderPath + "\\BepInEx\\plugins"))
                                    break;
                                await Task.Delay(1000);
                            }
                        }
                        Console.WriteLine("[INSTALLER REFINED] BepInEx already installed, presuming installation was already completed.");
                        installLogTextBox.Invoke(t => t.Text += "BepInEx is already installed, skipping...\n");
                        installationCompleted = true;
                        installButton.Invoke(t => t.Text = "Continue... (previously installed)");
                        installProgressBar.Invoke(t => t.Value = 100);
                        installButton.Invoke(t => t.Enabled = true);
                        return;
                    }
                    installProgressBar.Invoke(t => t.Value = 10);
                    string resultFileName;
                    if (System.Environment.Is64BitOperatingSystem)
                    {
                        Console.WriteLine("[INSTALLER REFINED] Running under x64");
                        installLogTextBox.Invoke(t => t.Text += "Running under x64 bit system\n");
                        Console.WriteLine("[INSTALLER REFINED] Downloading BepInEx x64");
                        installLogTextBox.Invoke(t => t.Text += "Downloading BepInEx release...\n");
                        installLogTextBox.Invoke(t => t.Text += "This can take some time.\n");

                        installProgressBar.Invoke(t => t.Value = 15);
                        //downloading X64
                        using (var client = new WebClient())
                        {
                            client.DownloadFile("https://github.com/BepInEx/BepInEx/releases/download/v5.4.21/BepInEx_x64_5.4.21.0.zip", "BepInEx_x64.zip");
                            resultFileName = "BepInEx_x64.zip";
                        }
                    }
                    else
                    {
                        Console.WriteLine("[INSTALLER REFINED] Running under x86");
                        installLogTextBox.Invoke(t => t.Text += "Running under x86 bit system\n");
                        installProgressBar.Invoke(t => t.Value = 20);
                        Console.WriteLine("[INSTALLER REFINED] Downloading BepInEx x86");
                        installLogTextBox.Invoke(t => t.Text += "Downloading BepInEx release...\n");
                        installLogTextBox.Invoke(t => t.Text += "This can take some time.\n");

                        //downloading X86
                        using (var client = new WebClient())
                        {
                            client.DownloadFile("https://github.com/BepInEx/BepInEx/releases/download/v5.4.21/BepInEx_x86_5.4.21.0.zip", "BepInEx_x86.zip");
                            resultFileName = "BepInEx_x86.zip";
                        }
                    }
                    Console.WriteLine("[INSTALLER REFINED] Downloaded");
                    installLogTextBox.Invoke(t => t.Text += "Downloaded!\n");
                    installProgressBar.Invoke(t => t.Value = 60);
                    Console.WriteLine("[INSTALLER REFINED] Unzipping...");
                    installLogTextBox.Invoke(t => t.Text += "Unzipping...\n");
                    ZipFile.ExtractToDirectory($"./{resultFileName}", Program.gameFolderPath + "\\");
                    installProgressBar.Invoke(t => t.Value = 80);
                    Console.WriteLine("[INSTALLER REFINED] Cleaning up...");
                    installLogTextBox.Invoke(t => t.Text += "Cleaning up...\n");
                    File.Delete($"./{resultFileName}");
                    Console.WriteLine("[INSTALLER REFINED] Finished...");
                    installLogTextBox.Invoke(t => t.Text += "Finished...\n");
                    if (!Directory.Exists(Program.gameFolderPath + "\\BepInEx\\plugins"))
                    {
                        MessageBox.Show("Now we will start the game and generate all required folders. Click OK to start the game", "Folders not present", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Process.Start(Program.gameFolderPath + "\\BALDI.exe");
                        while (true)
                        {
                            if (Directory.Exists(Program.gameFolderPath + "\\BepInEx\\plugins"))
                                break;
                            await Task.Delay(1000);
                        }
                    }
                    installationCompleted = true;
                    installButton.Invoke(t => t.Text = "Continue...");
                    installProgressBar.Invoke(t => t.Value = 100);
                    installButton.Invoke(t => t.Enabled = true);
                    return;
                }
                catch (Exception ex)
                {
                    installLogTextBox.Invoke(t => t.Text += "Installation failed! Check the console for more info...\n");
                    Console.WriteLine($"[INSTALLER REFINED] An exception occured! Installation failed! Exception: {ex}");
                    installButton.Invoke(t => t.Enabled = true);
                }
            });
        }

        private void installLogTextBox_TextChanged(object sender, EventArgs e)
        {
            installLogTextBox.SelectionStart = installLogTextBox.Text.Length;
            installLogTextBox.ScrollToCaret();
        }
    }
}
