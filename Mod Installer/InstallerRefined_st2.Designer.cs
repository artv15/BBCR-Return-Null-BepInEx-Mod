namespace Mod_Installer
{
    partial class InstallerRefined_st2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bepInExInstalllabel = new System.Windows.Forms.GroupBox();
            this.installButton = new System.Windows.Forms.Button();
            this.installLogTextBox = new System.Windows.Forms.RichTextBox();
            this.installProgressBar = new System.Windows.Forms.ProgressBar();
            this.infoLabel = new System.Windows.Forms.Label();
            this.bepInExInstalllabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bepInExInstalllabel
            // 
            this.bepInExInstalllabel.Controls.Add(this.installButton);
            this.bepInExInstalllabel.Controls.Add(this.installLogTextBox);
            this.bepInExInstalllabel.Controls.Add(this.installProgressBar);
            this.bepInExInstalllabel.Controls.Add(this.infoLabel);
            this.bepInExInstalllabel.Location = new System.Drawing.Point(12, 12);
            this.bepInExInstalllabel.Name = "bepInExInstalllabel";
            this.bepInExInstalllabel.Size = new System.Drawing.Size(410, 242);
            this.bepInExInstalllabel.TabIndex = 0;
            this.bepInExInstalllabel.TabStop = false;
            this.bepInExInstalllabel.Text = "Stage 2/3 - BepInEx installation";
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(6, 211);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(390, 23);
            this.installButton.TabIndex = 3;
            this.installButton.Text = "Install BepInEx";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // installLogTextBox
            // 
            this.installLogTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.installLogTextBox.Location = new System.Drawing.Point(6, 67);
            this.installLogTextBox.Name = "installLogTextBox";
            this.installLogTextBox.Size = new System.Drawing.Size(390, 109);
            this.installLogTextBox.TabIndex = 2;
            this.installLogTextBox.Text = "";
            this.installLogTextBox.TextChanged += new System.EventHandler(this.installLogTextBox_TextChanged);
            // 
            // installProgressBar
            // 
            this.installProgressBar.Location = new System.Drawing.Point(6, 182);
            this.installProgressBar.Name = "installProgressBar";
            this.installProgressBar.Size = new System.Drawing.Size(390, 23);
            this.installProgressBar.TabIndex = 1;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(6, 19);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(390, 45);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Now we need to install BepInEx. It loads the plugin and allows me to use \r\nHarmon" +
    "y to patch the checks, so they will not run. Click the button to\r\nbegin the inst" +
    "allation.\r\n";
            // 
            // InstallerRefined_st2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 266);
            this.Controls.Add(this.bepInExInstalllabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InstallerRefined_st2";
            this.Text = "Return null Mod Installer [NEW]";
            this.bepInExInstalllabel.ResumeLayout(false);
            this.bepInExInstalllabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox bepInExInstalllabel;
        private Label infoLabel;
        private Button installButton;
        private RichTextBox installLogTextBox;
        private ProgressBar installProgressBar;
    }
}