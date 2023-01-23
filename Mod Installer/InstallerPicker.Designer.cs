namespace Mod_Installer
{
    partial class InstallerPicker
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
            this.infoHeadingLabel = new System.Windows.Forms.Label();
            this.infoDescriptionLabel = new System.Windows.Forms.Label();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.LegacyGroupBox = new System.Windows.Forms.GroupBox();
            this.legacyEnableOverride = new System.Windows.Forms.CheckBox();
            this.startLegacyButton = new System.Windows.Forms.Button();
            this.legacyDescriptionLabel = new System.Windows.Forms.Label();
            this.NewGroupBox = new System.Windows.Forms.GroupBox();
            this.startNewButton = new System.Windows.Forms.Button();
            this.newDescriptionLabel = new System.Windows.Forms.Label();
            this.releaseNotes = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoGroupBox.SuspendLayout();
            this.LegacyGroupBox.SuspendLayout();
            this.NewGroupBox.SuspendLayout();
            this.releaseNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoHeadingLabel
            // 
            this.infoHeadingLabel.AutoSize = true;
            this.infoHeadingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoHeadingLabel.Location = new System.Drawing.Point(118, 19);
            this.infoHeadingLabel.Name = "infoHeadingLabel";
            this.infoHeadingLabel.Size = new System.Drawing.Size(152, 21);
            this.infoHeadingLabel.TabIndex = 0;
            this.infoHeadingLabel.Text = "Pick installer version";
            // 
            // infoDescriptionLabel
            // 
            this.infoDescriptionLabel.AutoSize = true;
            this.infoDescriptionLabel.Location = new System.Drawing.Point(6, 40);
            this.infoDescriptionLabel.Name = "infoDescriptionLabel";
            this.infoDescriptionLabel.Size = new System.Drawing.Size(387, 45);
            this.infoDescriptionLabel.TabIndex = 1;
            this.infoDescriptionLabel.Text = "There are 2 options avaliable: Legacy (it\'s not so user-friendly) and New. \r\nIf y" +
    "ou want to test the new version of the installer, choose New. \r\nOtherwise, I hig" +
    "hly recommend to use Legacy.";
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.infoHeadingLabel);
            this.InfoGroupBox.Controls.Add(this.infoDescriptionLabel);
            this.InfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(397, 100);
            this.InfoGroupBox.TabIndex = 2;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Info";
            // 
            // LegacyGroupBox
            // 
            this.LegacyGroupBox.Controls.Add(this.legacyEnableOverride);
            this.LegacyGroupBox.Controls.Add(this.startLegacyButton);
            this.LegacyGroupBox.Controls.Add(this.legacyDescriptionLabel);
            this.LegacyGroupBox.Location = new System.Drawing.Point(12, 118);
            this.LegacyGroupBox.Name = "LegacyGroupBox";
            this.LegacyGroupBox.Size = new System.Drawing.Size(397, 124);
            this.LegacyGroupBox.TabIndex = 3;
            this.LegacyGroupBox.TabStop = false;
            this.LegacyGroupBox.Text = "Legacy";
            // 
            // legacyEnableOverride
            // 
            this.legacyEnableOverride.AutoSize = true;
            this.legacyEnableOverride.Location = new System.Drawing.Point(6, 81);
            this.legacyEnableOverride.Name = "legacyEnableOverride";
            this.legacyEnableOverride.Size = new System.Drawing.Size(302, 34);
            this.legacyEnableOverride.TabIndex = 2;
            this.legacyEnableOverride.Text = "I understand that old installer is no longer supported\r\nand may break at any time" +
    "";
            this.legacyEnableOverride.UseVisualStyleBackColor = true;
            this.legacyEnableOverride.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // startLegacyButton
            // 
            this.startLegacyButton.Enabled = false;
            this.startLegacyButton.Location = new System.Drawing.Point(6, 52);
            this.startLegacyButton.Name = "startLegacyButton";
            this.startLegacyButton.Size = new System.Drawing.Size(385, 23);
            this.startLegacyButton.TabIndex = 1;
            this.startLegacyButton.Text = "Start Legacy";
            this.startLegacyButton.UseVisualStyleBackColor = true;
            this.startLegacyButton.Click += new System.EventHandler(this.startLegacyButton_Click);
            // 
            // legacyDescriptionLabel
            // 
            this.legacyDescriptionLabel.AutoSize = true;
            this.legacyDescriptionLabel.Location = new System.Drawing.Point(6, 19);
            this.legacyDescriptionLabel.Name = "legacyDescriptionLabel";
            this.legacyDescriptionLabel.Size = new System.Drawing.Size(339, 30);
            this.legacyDescriptionLabel.TabIndex = 0;
            this.legacyDescriptionLabel.Text = "Old installer, you can still use it but I highly recommend to use \r\nthe new one b" +
    "elow";
            // 
            // NewGroupBox
            // 
            this.NewGroupBox.Controls.Add(this.startNewButton);
            this.NewGroupBox.Controls.Add(this.newDescriptionLabel);
            this.NewGroupBox.Location = new System.Drawing.Point(12, 248);
            this.NewGroupBox.Name = "NewGroupBox";
            this.NewGroupBox.Size = new System.Drawing.Size(397, 89);
            this.NewGroupBox.TabIndex = 4;
            this.NewGroupBox.TabStop = false;
            this.NewGroupBox.Text = "New";
            // 
            // startNewButton
            // 
            this.startNewButton.Location = new System.Drawing.Point(6, 55);
            this.startNewButton.Name = "startNewButton";
            this.startNewButton.Size = new System.Drawing.Size(385, 23);
            this.startNewButton.TabIndex = 1;
            this.startNewButton.Text = "Start New (Recommended)";
            this.startNewButton.UseVisualStyleBackColor = true;
            this.startNewButton.Click += new System.EventHandler(this.startNewButton_Click);
            // 
            // newDescriptionLabel
            // 
            this.newDescriptionLabel.AutoSize = true;
            this.newDescriptionLabel.Location = new System.Drawing.Point(6, 19);
            this.newDescriptionLabel.Name = "newDescriptionLabel";
            this.newDescriptionLabel.Size = new System.Drawing.Size(306, 30);
            this.newDescriptionLabel.TabIndex = 0;
            this.newDescriptionLabel.Text = "New installer, now 60% more user friendly! It\'s way easier\r\nto use than the old o" +
    "ne!\r\n";
            // 
            // releaseNotes
            // 
            this.releaseNotes.Controls.Add(this.label2);
            this.releaseNotes.Controls.Add(this.label1);
            this.releaseNotes.Location = new System.Drawing.Point(415, 12);
            this.releaseNotes.Name = "releaseNotes";
            this.releaseNotes.Size = new System.Drawing.Size(281, 325);
            this.releaseNotes.TabIndex = 5;
            this.releaseNotes.TabStop = false;
            this.releaseNotes.Text = "Release notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = " - Legacy installer is now disabled by default, but\r\nyou can always enable it bac" +
    "k\r\n - That\'s kinda it, thanks for reading 0.1 release\r\nnotes!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "0.1.0.0 Release notes";
            // 
            // InstallerPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 347);
            this.Controls.Add(this.releaseNotes);
            this.Controls.Add(this.NewGroupBox);
            this.Controls.Add(this.LegacyGroupBox);
            this.Controls.Add(this.InfoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InstallerPicker";
            this.Text = "Return null Mod Installer [PICKER]";
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.LegacyGroupBox.ResumeLayout(false);
            this.LegacyGroupBox.PerformLayout();
            this.NewGroupBox.ResumeLayout(false);
            this.NewGroupBox.PerformLayout();
            this.releaseNotes.ResumeLayout(false);
            this.releaseNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label infoHeadingLabel;
        private Label infoDescriptionLabel;
        private GroupBox InfoGroupBox;
        private GroupBox LegacyGroupBox;
        private Button startLegacyButton;
        private Label legacyDescriptionLabel;
        private GroupBox NewGroupBox;
        private Button startNewButton;
        private Label newDescriptionLabel;
        private GroupBox releaseNotes;
        private Label label2;
        private Label label1;
        private CheckBox legacyEnableOverride;
    }
}