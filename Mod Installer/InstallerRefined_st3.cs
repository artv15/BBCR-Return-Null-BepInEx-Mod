using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod_Installer
{
    public partial class InstallerRefined_st3 : Form
    {
        public InstallerRefined_st3()
        {
            InitializeComponent();

            installationProgressBar.Maximum = 100;
            installationProgressBar.Value = 0;

            installationLogTextBox.ReadOnly = true;

            Console.WriteLine("[INSTALLER REFINED] Entered stage 3.");
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

        private void installButton_Click(object sender, EventArgs e)
        {
            installButton.Enabled = false;

            if (File.Exists("./mod.dll"))
            {
                File.Delete("./mod.dll");
                Console.WriteLine($"[INSTALLER REFINED] mod.dll was already downloaded but not cleaned up, removing...");
            }

            if (!File.Exists(Program.gameFolderPath + "\\BepInEx\\plugins\\Return_Null_Mod.dll"))
            {
                Task.Run(() =>
                {
                    try
                    {
                        installationLogTextBox.Invoke(t => t.Text += "Separate thread created, Installation started.\n");
                        Console.WriteLine("[INSTALLER REFINED] Installation started on separate thread.");
                        using (var client = new WebClient())
                        {
                            Console.WriteLine("[INSTALLER REFINED] Downloading latest mod assembly.");
                            string downloadUri = GetFinalRedirect("https://github.com/artv15/BBCR-Return-Null-BepInEx-Mod/releases/latest") + "/mod.dll"; //getting latest version
                            downloadUri = downloadUri.Replace("tag", "download");
                            Console.WriteLine($"[INSTALLER REFINED] Final download url: {downloadUri}.");
                            Console.WriteLine($"[INSTALLER REFINED] Downloading...");
                            installationLogTextBox.Invoke(t => t.Text += $"Downloading, this may take some time...\n");
                            installationProgressBar.Invoke(t => t.Value = 10);
                            client.DownloadFile(downloadUri, "./mod.dll");
                            installationLogTextBox.Invoke(t => t.Text += $"Moving...\n");
                            installationProgressBar.Invoke(t => t.Value = 80);
                            Console.WriteLine($"[INSTALLER REFINED] Assembly downloaded.");
                        }
                        Console.WriteLine($"[INSTALLER REFINED] Moving the assembly.");
                        File.Move("./mod.dll", Program.gameFolderPath + "\\BepInEx\\plugins\\Return_Null_Mod.dll");
                        installationProgressBar.Invoke(t => t.Value = 100);
                        installationLogTextBox.Invoke(t => t.Text += $"Installed.\n");
                        Console.WriteLine($"[INSTALLER REFINED] Finished.");
                        MessageBox.Show("Mod has been successfully installed!", "Hooray!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    catch (Exception ex)
                    {
                        installationProgressBar.Invoke(t => t.Value = 0);
                        Console.WriteLine($"An exception occured during mod setup! Exception: {ex}");
                        installButton.Invoke(t => t.Enabled = true);
                    }
                });
            }
            else
            {
                installationProgressBar.Value = 100;
                installationLogTextBox.Text += "Mod has been already installed!\n";
            }
        }

        private void installationLogTextBox_TextChanged(object sender, EventArgs e)
        {
            installationLogTextBox.SelectionStart = installationLogTextBox.Text.Length;
            installationLogTextBox.ScrollToCaret();
        }
    }
}
