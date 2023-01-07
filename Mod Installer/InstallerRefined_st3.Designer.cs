namespace Mod_Installer
{
    partial class InstallerRefined_st3
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
            this.installModGroupBox = new System.Windows.Forms.GroupBox();
            this.installButton = new System.Windows.Forms.Button();
            this.installationProgressBar = new System.Windows.Forms.ProgressBar();
            this.installationLogTextBox = new System.Windows.Forms.RichTextBox();
            this.installModLabel = new System.Windows.Forms.Label();
            this.installModGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // installModGroupBox
            // 
            this.installModGroupBox.Controls.Add(this.installButton);
            this.installModGroupBox.Controls.Add(this.installationProgressBar);
            this.installModGroupBox.Controls.Add(this.installationLogTextBox);
            this.installModGroupBox.Controls.Add(this.installModLabel);
            this.installModGroupBox.Location = new System.Drawing.Point(12, 12);
            this.installModGroupBox.Name = "installModGroupBox";
            this.installModGroupBox.Size = new System.Drawing.Size(391, 241);
            this.installModGroupBox.TabIndex = 0;
            this.installModGroupBox.TabStop = false;
            this.installModGroupBox.Text = "Stage 3/3 - Installing the mod";
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(6, 210);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(379, 23);
            this.installButton.TabIndex = 3;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // installationProgressBar
            // 
            this.installationProgressBar.Location = new System.Drawing.Point(6, 181);
            this.installationProgressBar.Name = "installationProgressBar";
            this.installationProgressBar.Size = new System.Drawing.Size(379, 23);
            this.installationProgressBar.TabIndex = 2;
            // 
            // installationLogTextBox
            // 
            this.installationLogTextBox.Location = new System.Drawing.Point(6, 52);
            this.installationLogTextBox.Name = "installationLogTextBox";
            this.installationLogTextBox.Size = new System.Drawing.Size(379, 123);
            this.installationLogTextBox.TabIndex = 1;
            this.installationLogTextBox.Text = "";
            this.installationLogTextBox.TextChanged += new System.EventHandler(this.installationLogTextBox_TextChanged);
            // 
            // installModLabel
            // 
            this.installModLabel.AutoSize = true;
            this.installModLabel.Location = new System.Drawing.Point(6, 19);
            this.installModLabel.Name = "installModLabel";
            this.installModLabel.Size = new System.Drawing.Size(368, 30);
            this.installModLabel.TabIndex = 0;
            this.installModLabel.Text = "The preparations are completed and we are ready to install the mod. \r\nClick the i" +
    "nstall button to install the mod.";
            // 
            // InstallerRefined_st3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 262);
            this.Controls.Add(this.installModGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InstallerRefined_st3";
            this.Text = "Return null Mod Installer [NEW]";
            this.installModGroupBox.ResumeLayout(false);
            this.installModGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox installModGroupBox;
        private Button installButton;
        private ProgressBar installationProgressBar;
        private RichTextBox installationLogTextBox;
        private Label installModLabel;
    }
}