using System.Diagnostics;
using System.IO.Compression;
using System.Net;
using System.Security.Principal;

namespace Mod_Installer
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog openFileDialog = new FolderBrowserDialog();

        public Form1()
        {
            InitializeComponent();

            if (IsAdministrator())
            {
                MessageBox.Show("Installer is launched with admin permissions. Select the folder again and click install button.", "Admin rights given.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            outputTextBox.ReadOnly = true;
        }

        internal void AddLog(string message)
        {
            outputTextBox.ForeColor = Color.White;
            outputTextBox.Text += message + "\n";
        }

        internal static string GetFinalRedirect(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return url;

            int maxRedirCount = 8;  // prevent infinite loops
            string newUrl = url;
            do
            {
                HttpWebRequest req = null;
                HttpWebResponse resp = null;
                try
                {
                    req = (HttpWebRequest)HttpWebRequest.Create(url);
                    req.Method = "HEAD";
                    req.AllowAutoRedirect = false;
                    resp = (HttpWebResponse)req.GetResponse();
                    switch (resp.StatusCode)
                    {
                        case HttpStatusCode.OK:
                            return newUrl;
                        case HttpStatusCode.Redirect:
                        case HttpStatusCode.MovedPermanently:
                        case HttpStatusCode.RedirectKeepVerb:
                        case HttpStatusCode.RedirectMethod:
                            newUrl = resp.Headers["Location"];
                            if (newUrl == null)
                                return url;

                            if (newUrl.IndexOf("://", System.StringComparison.Ordinal) == -1)
                            {
                                // Doesn't have a URL Schema, meaning it's a relative or absolute URL
                                Uri u = new Uri(new Uri(url), newUrl);
                                newUrl = u.ToString();
                            }
                            break;
                        default:
                            return newUrl;
                    }
                    url = newUrl;
                }
                catch (WebException)
                {
                    // Return the last known good URL
                    return newUrl;
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    if (resp != null)
                        resp.Close();
                }
            } while (maxRedirCount-- > 0);

            return newUrl;
        }

        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static void StartAsAdmin(string fileName)
        {
            fileName = fileName.Replace(".dll", ".exe");
            var proc = new Process
            {
                StartInfo =
                {
                    FileName = fileName,
                    UseShellExecute = true,
                    Verb = "runas"
                }
            };

            proc.Start();
            Application.Exit();
        }

        private void gamefolderOpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                gameFolderTextBox.Text = openFileDialog.SelectedPath;
            }
        }

        private void GameFolderCheck_Click(object sender, EventArgs e)
        {
            if (gameFolderTextBox.Text == "")
            {
                validFolderCheck.Checked = false;
                bepInExInstalledCheck.Checked = false;
                gameLaunchedOnceCheck.Checked = false;
                modHasBeenInstalledCheck.Checked = false;
                MessageBox.Show("No gamefolder path specified! Press \"Open...\" button and select it!", "Oh-oh! Spaghettio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //folder validity check
            if (!File.Exists(gameFolderTextBox.Text + "\\BALDI.exe"))
            {
                validFolderCheck.Checked = false;
                bepInExInstalledCheck.Checked = false;
                gameLaunchedOnceCheck.Checked = false;
                modHasBeenInstalledCheck.Checked = false;
                MessageBox.Show("No gamefolder path specified!", "Oh-oh! Spaghettio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                validFolderCheck.Checked = true;
            }
            //bepInExInstalledCheck
            if (!Directory.Exists(gameFolderTextBox.Text + "\\BepInEx"))
            {
                bepInExInstalledCheck.Checked = false;
                gameLaunchedOnceCheck.Checked = false;
                modHasBeenInstalledCheck.Checked = false;
                MessageBox.Show("BepInEx is not installed. Click the Begin Installation Procedure to install it!", "Oh-oh! Spaghettio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bepInExInstalledCheck.Checked = true;
            }
            //pluginFolderCheck
            if (!Directory.Exists(gameFolderTextBox.Text + "\\BepInEx\\plugins"))
            {
                gameLaunchedOnceCheck.Checked = false;
                modHasBeenInstalledCheck.Checked = false;
                MessageBox.Show("Launch the game once to generate all required folders!", "Oh-oh! Spaghettio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                gameLaunchedOnceCheck.Checked = true;
            }
            //modInstallationCheck
            if (!File.Exists(gameFolderTextBox.Text + "\\BepInEx\\plugins\\Return_Null_Mod.dll"))
            {
                modHasBeenInstalledCheck.Checked = false;
                MessageBox.Show("Mod is not installed! Click the Begin Installation Procedure to install it!", "Oh-oh! Spaghettio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            modHasBeenInstalledCheck.Checked = true;
            MessageBox.Show("Mod has been successfully installed!", "It's alive!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            if (!validFolderCheck.Checked)
            {
                MessageBox.Show("Invalid game folder or folder not selected! Open it using \"Open...\" button!", "Oh-oh! Spaghettio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!bepInExInstalledCheck.Checked)
            {
                try
                {
                    string resultFileName;
                    AddLog("[BepInEx] Installing BepInEx.");
                    AddLog("[BepInEx] Downloading BepInEx archive.");
                    if (System.Environment.Is64BitOperatingSystem)
                    {
                        AddLog("[BepInEx] Running under x64 bit system.");
                        //downloading X64
                        using (var client = new WebClient())
                        {
                            client.DownloadFile("https://github.com/BepInEx/BepInEx/releases/download/v5.4.21/BepInEx_x64_5.4.21.0.zip", "BepInEx_x64.zip");
                            resultFileName = "BepInEx_x64.zip";
                        }
                    }
                    else
                    {
                        AddLog("[BepInEx] Running under x32 bit system.");
                        //downloading X32
                        using (var client = new WebClient())
                        {
                            client.DownloadFile("https://github.com/BepInEx/BepInEx/releases/download/v5.4.21/BepInEx_x86_5.4.21.0.zip", "BepInEx_x86.zip");
                            resultFileName = "BepInEx_x86.zip";
                        }
                    }
                    AddLog("[BepInEx] Download completed.");
                    AddLog("[BepInEx] Extracting...");
                    ZipFile.ExtractToDirectory($"./{resultFileName}", gameFolderTextBox.Text + "\\");
                    AddLog("[BepInEx] Extracted!");
                    bepInExInstalledCheck.Checked = true;
                    File.Delete($"./{resultFileName}");
                    MessageBox.Show("BepInEx has been successfully installed! You need to launch the game now to generate all folders. You will not be able to continue, unless you launch the game! After launching the game, recheck the game folder.", "Installation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    AddLog($"[ERROR] Installation failed! Error: {ex.Message}. Open an issue on the mod's github page for assistance!");
                }
            }

            if (!gameLaunchedOnceCheck.Checked)
            {
                MessageBox.Show("Launch the game once to continue! If you have done that already, recheck the game folder!", "Installation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!modHasBeenInstalledCheck.Checked)
            {
                try
                {
                    AddLog("[ModInstaller] Downloading latest mod release.");
                    using (var client = new WebClient())
                    {

                        client.DownloadFile($"{GetFinalRedirect("https://github.com/artv15/BBCR-Return-Null-BepInEx-Mod/releases/latest")}/mod.dll", "mod.dll");
                    }
                    AddLog("[ModInstaller] Downloaded.");
                    AddLog($"[ModInstaller] Copying mod inside {gameFolderTextBox.Text + "\\BepInEx\\plugins"} directory...");
                    File.Move("./mod.dll", gameFolderTextBox.Text + "\\BepInEx\\plugins\\Return_Null_Mod.dll");
                    AddLog("[ModInstaller] Installation completed!");
                    modHasBeenInstalledCheck.Checked = true;
                    MessageBox.Show("Mod has been successfully installed!", "It's alive!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    AddLog($"[ERROR] Installation failed! Error: {ex.Message}. Open an issue on the mod's github page for assistance!");
                }
            }
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {
            outputTextBox.SelectionStart = outputTextBox.Text.Length;
            outputTextBox.ScrollToCaret();
        }
    }
}