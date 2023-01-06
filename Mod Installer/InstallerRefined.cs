using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod_Installer
{
    public partial class InstallerRefined : Form
    {
        public InstallerRefined()
        {
            InitializeComponent();

            GameFolderPathTextBox.ReadOnly = true;
            Console.WriteLine("[INSTALLER REFINED] Ready!");
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[INSTALLER REFINED] Beginning folder selection.");
            var gameFolderPathDialog = new FolderBrowserDialog();
            Console.WriteLine("[INSTALLER REFINED] Waiting for dialog result...");
            var gameFolderPathDialogResult = gameFolderPathDialog.ShowDialog();
            Console.WriteLine("[INSTALLER REFINED] Dialog finished.");
            if (gameFolderPathDialogResult == DialogResult.OK)
            {
                Console.WriteLine("[INSTALLER REFINED] Checking the folder.");
                var gameFolderPath = gameFolderPathDialog.SelectedPath;

                if (!File.Exists(gameFolderPath + "\\BALDI.exe")) //is folder valid
                {
                    Console.WriteLine("[INSTALLER REFINED] Invalid folder provided.");
                    MessageBox.Show("Invalid folder! It should contain \"BALDI.exe\".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Console.WriteLine("[INSTALLER REFINED] Valid folder, locking in and enabling the Continue button...");

                nextStageButton.Enabled = true;
                SelectFolderButton.Enabled = false;

                nextStageButton.Text = "Continue...";

                GameFolderPathTextBox.Text = gameFolderPath;
                Program.gameFolderPath = gameFolderPath;
                Console.WriteLine("[INSTALLER REFINED] Stage 1 finished.");
            }
            else
            {
                Console.WriteLine("[INSTALLER REFINED] Unexpected result from the folder dialog. Waiting for the next one");
            }
        }

        private void nextStageButton_Click(object sender, EventArgs e)
        {
            var stage2Form = new InstallerRefined_st2();
            stage2Form.Show();
            stage2Form.FormClosed += (object sender, FormClosedEventArgs e) =>
            {
                this.Close();
            };
            this.Hide();
        }
    }
}
