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
    public partial class InstallerPicker : Form
    {
        public InstallerPicker()
        {
            Console.WriteLine("[PICKER] Starting up...");
            InitializeComponent();
            Console.WriteLine("[PICKER] Ready");
        }

        void CloseAllOpenForms()
        {
            Console.WriteLine("[PICKER (CloseAllOpenForms)] Destroying all opened forms...");
            try
            {
                foreach (Form form in Application.OpenForms)
                {
                    form.Close();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[PICKER (CloseAllOpenForms)] [ERROR] Umm, an exception occured during form closure. Exception: {ex.Message}.");
                Console.ResetColor();
            }
            Console.WriteLine("[PICKER (CloseAllOpenForms)] Presumably closed all open forms.");
        }

        private void startLegacyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("[PICKER] Starting up legacy installer...");

                Console.WriteLine("[PICKER] Launching...");
                var nf = new InstallerLegacy();
                nf.Show();
                nf.FormClosed += (object obj, FormClosedEventArgs ev) =>
                {
                    this.Close();
                };


                this.Visible = false;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[PICKER] [FATAL] Umm, launching failed. Exception: {ex.Message}.");
                Console.ResetColor();
            }
        }

        private void startNewButton_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("[PICKER] Starting up new installer...");

                Console.WriteLine("[PICKER] Launching...");
                var nf = new InstallerRefined();
                nf.Show();
                nf.FormClosed += (object obj, FormClosedEventArgs ev) =>
                {
                    this.Close();
                };
                this.Visible = false;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[PICKER] [FATAL] Umm, launching failed. Exception: {ex.Message}.");
                Console.ResetColor();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            startLegacyButton.Enabled = legacyEnableOverride.Checked;
        }
    }
}
