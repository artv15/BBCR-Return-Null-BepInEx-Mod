namespace Mod_Installer
{
    partial class InstallerRefined
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallerRefined));
            this.stage1GroupBox = new System.Windows.Forms.GroupBox();
            this.nextStageButton = new System.Windows.Forms.Button();
            this.commonPathLabel = new System.Windows.Forms.Label();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.GameFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.providePathLabel = new System.Windows.Forms.Label();
            this.stage1GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stage1GroupBox
            // 
            this.stage1GroupBox.Controls.Add(this.nextStageButton);
            this.stage1GroupBox.Controls.Add(this.commonPathLabel);
            this.stage1GroupBox.Controls.Add(this.SelectFolderButton);
            this.stage1GroupBox.Controls.Add(this.GameFolderPathTextBox);
            this.stage1GroupBox.Controls.Add(this.providePathLabel);
            this.stage1GroupBox.Location = new System.Drawing.Point(12, 12);
            this.stage1GroupBox.Name = "stage1GroupBox";
            this.stage1GroupBox.Size = new System.Drawing.Size(485, 222);
            this.stage1GroupBox.TabIndex = 0;
            this.stage1GroupBox.TabStop = false;
            this.stage1GroupBox.Text = "Stage 1/3 - Game Folder Selection";
            // 
            // nextStageButton
            // 
            this.nextStageButton.Enabled = false;
            this.nextStageButton.Location = new System.Drawing.Point(6, 186);
            this.nextStageButton.Name = "nextStageButton";
            this.nextStageButton.Size = new System.Drawing.Size(235, 23);
            this.nextStageButton.TabIndex = 4;
            this.nextStageButton.Text = "Waiting for a valid game folder...";
            this.nextStageButton.UseVisualStyleBackColor = true;
            this.nextStageButton.Click += new System.EventHandler(this.nextStageButton_Click);
            // 
            // commonPathLabel
            // 
            this.commonPathLabel.AutoSize = true;
            this.commonPathLabel.Location = new System.Drawing.Point(6, 88);
            this.commonPathLabel.Name = "commonPathLabel";
            this.commonPathLabel.Size = new System.Drawing.Size(456, 105);
            this.commonPathLabel.TabIndex = 3;
            this.commonPathLabel.Text = resources.GetString("commonPathLabel.Text");
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.Location = new System.Drawing.Point(404, 52);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFolderButton.TabIndex = 2;
            this.SelectFolderButton.Text = "Browse...";
            this.SelectFolderButton.UseVisualStyleBackColor = true;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // GameFolderPathTextBox
            // 
            this.GameFolderPathTextBox.Location = new System.Drawing.Point(6, 52);
            this.GameFolderPathTextBox.Name = "GameFolderPathTextBox";
            this.GameFolderPathTextBox.Size = new System.Drawing.Size(392, 23);
            this.GameFolderPathTextBox.TabIndex = 1;
            this.GameFolderPathTextBox.Text = "[Click the Browse... button]";
            // 
            // providePathLabel
            // 
            this.providePathLabel.AutoSize = true;
            this.providePathLabel.Location = new System.Drawing.Point(6, 19);
            this.providePathLabel.Name = "providePathLabel";
            this.providePathLabel.Size = new System.Drawing.Size(473, 30);
            this.providePathLabel.TabIndex = 0;
            this.providePathLabel.Text = "You need to provide the game path for us to install the mod. To do so, click the " +
    "\"Browse\"\r\nbutton and we will check if the folder is the right one.\r\n";
            // 
            // InstallerRefined
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 242);
            this.Controls.Add(this.stage1GroupBox);
            this.Name = "InstallerRefined";
            this.Text = "Return null Mod Installer [NEW]";
            this.stage1GroupBox.ResumeLayout(false);
            this.stage1GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox stage1GroupBox;
        private Label commonPathLabel;
        private Button SelectFolderButton;
        private TextBox GameFolderPathTextBox;
        private Label providePathLabel;
        private Button nextStageButton;
    }
}