namespace Mod_Installer
{
    partial class InstallerLegacy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bypassPluginFolderCheck = new System.Windows.Forms.CheckBox();
            this.GameFolderCheck = new System.Windows.Forms.Button();
            this.gamefolderOpenButton = new System.Windows.Forms.Button();
            this.gameFolderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.installButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gameLaunchedOnceCheck = new System.Windows.Forms.CheckBox();
            this.modHasBeenInstalledCheck = new System.Windows.Forms.CheckBox();
            this.bepInExInstalledCheck = new System.Windows.Forms.CheckBox();
            this.validFolderCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bypassPluginFolderCheck);
            this.groupBox1.Controls.Add(this.GameFolderCheck);
            this.groupBox1.Controls.Add(this.gamefolderOpenButton);
            this.groupBox1.Controls.Add(this.gameFolderTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game folder selection";
            // 
            // bypassPluginFolderCheck
            // 
            this.bypassPluginFolderCheck.AutoSize = true;
            this.bypassPluginFolderCheck.Location = new System.Drawing.Point(87, 66);
            this.bypassPluginFolderCheck.Name = "bypassPluginFolderCheck";
            this.bypassPluginFolderCheck.Size = new System.Drawing.Size(181, 19);
            this.bypassPluginFolderCheck.TabIndex = 4;
            this.bypassPluginFolderCheck.Text = "Ignore plugin folder presence";
            this.bypassPluginFolderCheck.UseVisualStyleBackColor = true;
            this.bypassPluginFolderCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GameFolderCheck
            // 
            this.GameFolderCheck.Location = new System.Drawing.Point(6, 66);
            this.GameFolderCheck.Name = "GameFolderCheck";
            this.GameFolderCheck.Size = new System.Drawing.Size(75, 23);
            this.GameFolderCheck.TabIndex = 3;
            this.GameFolderCheck.Text = "Check";
            this.GameFolderCheck.UseVisualStyleBackColor = true;
            this.GameFolderCheck.Click += new System.EventHandler(this.GameFolderCheck_Click);
            // 
            // gamefolderOpenButton
            // 
            this.gamefolderOpenButton.Location = new System.Drawing.Point(310, 37);
            this.gamefolderOpenButton.Name = "gamefolderOpenButton";
            this.gamefolderOpenButton.Size = new System.Drawing.Size(75, 23);
            this.gamefolderOpenButton.TabIndex = 2;
            this.gamefolderOpenButton.Text = "Open...";
            this.gamefolderOpenButton.UseVisualStyleBackColor = true;
            this.gamefolderOpenButton.Click += new System.EventHandler(this.gamefolderOpenButton_Click);
            // 
            // gameFolderTextBox
            // 
            this.gameFolderTextBox.Location = new System.Drawing.Point(6, 37);
            this.gameFolderTextBox.Name = "gameFolderTextBox";
            this.gameFolderTextBox.Size = new System.Drawing.Size(298, 23);
            this.gameFolderTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select your game folder";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.installButton);
            this.groupBox2.Controls.Add(this.outputTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Installation Log";
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(6, 138);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(155, 23);
            this.installButton.TabIndex = 1;
            this.installButton.Text = "Begin Installation Process";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.outputTextBox.Location = new System.Drawing.Point(6, 22);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(379, 110);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.Text = "";
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gameLaunchedOnceCheck);
            this.groupBox3.Controls.Add(this.modHasBeenInstalledCheck);
            this.groupBox3.Controls.Add(this.bepInExInstalledCheck);
            this.groupBox3.Controls.Add(this.validFolderCheck);
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Installation checks";
            // 
            // gameLaunchedOnceCheck
            // 
            this.gameLaunchedOnceCheck.AutoSize = true;
            this.gameLaunchedOnceCheck.Enabled = false;
            this.gameLaunchedOnceCheck.Location = new System.Drawing.Point(6, 72);
            this.gameLaunchedOnceCheck.Name = "gameLaunchedOnceCheck";
            this.gameLaunchedOnceCheck.Size = new System.Drawing.Size(192, 19);
            this.gameLaunchedOnceCheck.TabIndex = 3;
            this.gameLaunchedOnceCheck.Text = "All folders have been generated";
            this.gameLaunchedOnceCheck.UseVisualStyleBackColor = true;
            // 
            // modHasBeenInstalledCheck
            // 
            this.modHasBeenInstalledCheck.AutoSize = true;
            this.modHasBeenInstalledCheck.Enabled = false;
            this.modHasBeenInstalledCheck.Location = new System.Drawing.Point(6, 97);
            this.modHasBeenInstalledCheck.Name = "modHasBeenInstalledCheck";
            this.modHasBeenInstalledCheck.Size = new System.Drawing.Size(98, 19);
            this.modHasBeenInstalledCheck.TabIndex = 2;
            this.modHasBeenInstalledCheck.Text = "Mod installed";
            this.modHasBeenInstalledCheck.UseVisualStyleBackColor = true;
            // 
            // bepInExInstalledCheck
            // 
            this.bepInExInstalledCheck.AutoSize = true;
            this.bepInExInstalledCheck.Enabled = false;
            this.bepInExInstalledCheck.Location = new System.Drawing.Point(6, 47);
            this.bepInExInstalledCheck.Name = "bepInExInstalledCheck";
            this.bepInExInstalledCheck.Size = new System.Drawing.Size(115, 19);
            this.bepInExInstalledCheck.TabIndex = 1;
            this.bepInExInstalledCheck.Text = "BepInEx installed";
            this.bepInExInstalledCheck.UseVisualStyleBackColor = true;
            // 
            // validFolderCheck
            // 
            this.validFolderCheck.AutoSize = true;
            this.validFolderCheck.Enabled = false;
            this.validFolderCheck.Location = new System.Drawing.Point(6, 22);
            this.validFolderCheck.Name = "validFolderCheck";
            this.validFolderCheck.Size = new System.Drawing.Size(119, 19);
            this.validFolderCheck.TabIndex = 0;
            this.validFolderCheck.Text = "Game folder valid";
            this.validFolderCheck.UseVisualStyleBackColor = true;
            // 
            // InstallerLegacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 433);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InstallerLegacy";
            this.Text = "Return null Mod Installer [LEGACY]";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button GameFolderCheck;
        private Button gamefolderOpenButton;
        private TextBox gameFolderTextBox;
        private Label label1;
        private GroupBox groupBox2;
        private RichTextBox outputTextBox;
        private GroupBox groupBox3;
        private CheckBox modHasBeenInstalledCheck;
        private CheckBox bepInExInstalledCheck;
        private CheckBox validFolderCheck;
        private CheckBox gameLaunchedOnceCheck;
        private Button installButton;
        private CheckBox bypassPluginFolderCheck;
    }
}