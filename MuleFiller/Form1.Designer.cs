namespace MuleFiller
{
    partial class Form1
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
            this.BTN_Load = new System.Windows.Forms.Button();
            this.BTN_Release = new System.Windows.Forms.Button();
            this.LBL_WPrefix = new System.Windows.Forms.Label();
            this.TB_Prefix = new System.Windows.Forms.TextBox();
            this.TB_SessionCount = new System.Windows.Forms.TextBox();
            this.LBL_Sessions = new System.Windows.Forms.Label();
            this.TB_Gamename = new System.Windows.Forms.TextBox();
            this.LBL_Prefix = new System.Windows.Forms.Label();
            this.LBL_PW = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.GB_Difficulty = new System.Windows.Forms.GroupBox();
            this.RB_Normal = new System.Windows.Forms.RadioButton();
            this.RB_Nightmare = new System.Windows.Forms.RadioButton();
            this.RB_Hell = new System.Windows.Forms.RadioButton();
            this.ucPathPicker = new MuleFiller.PathPicker();
            this.LBL_GamesState = new System.Windows.Forms.Label();
            this.LBL_Commander = new System.Windows.Forms.Label();
            this.LBL_CurrentGame = new System.Windows.Forms.Label();
            this.GB_Difficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Load
            // 
            this.BTN_Load.Location = new System.Drawing.Point(233, 8);
            this.BTN_Load.Name = "BTN_Load";
            this.BTN_Load.Size = new System.Drawing.Size(122, 38);
            this.BTN_Load.TabIndex = 0;
            this.BTN_Load.Text = "Start games";
            this.BTN_Load.UseVisualStyleBackColor = true;
            this.BTN_Load.Click += new System.EventHandler(this.BTN_Load_Click);
            // 
            // BTN_Release
            // 
            this.BTN_Release.Location = new System.Drawing.Point(233, 52);
            this.BTN_Release.Name = "BTN_Release";
            this.BTN_Release.Size = new System.Drawing.Size(122, 52);
            this.BTN_Release.TabIndex = 1;
            this.BTN_Release.Text = "Activate commander";
            this.BTN_Release.UseVisualStyleBackColor = true;
            this.BTN_Release.Click += new System.EventHandler(this.BTN_Release_Click);
            // 
            // LBL_WPrefix
            // 
            this.LBL_WPrefix.AutoSize = true;
            this.LBL_WPrefix.Location = new System.Drawing.Point(12, 72);
            this.LBL_WPrefix.Name = "LBL_WPrefix";
            this.LBL_WPrefix.Size = new System.Drawing.Size(77, 13);
            this.LBL_WPrefix.TabIndex = 4;
            this.LBL_WPrefix.Text = "Window prefix:";
            // 
            // TB_Prefix
            // 
            this.TB_Prefix.Location = new System.Drawing.Point(105, 69);
            this.TB_Prefix.Name = "TB_Prefix";
            this.TB_Prefix.Size = new System.Drawing.Size(112, 20);
            this.TB_Prefix.TabIndex = 5;
            this.TB_Prefix.Text = "TX";
            // 
            // TB_SessionCount
            // 
            this.TB_SessionCount.Location = new System.Drawing.Point(105, 102);
            this.TB_SessionCount.Name = "TB_SessionCount";
            this.TB_SessionCount.Size = new System.Drawing.Size(33, 20);
            this.TB_SessionCount.TabIndex = 7;
            this.TB_SessionCount.Text = "3";
            // 
            // LBL_Sessions
            // 
            this.LBL_Sessions.AutoSize = true;
            this.LBL_Sessions.Location = new System.Drawing.Point(37, 105);
            this.LBL_Sessions.Name = "LBL_Sessions";
            this.LBL_Sessions.Size = new System.Drawing.Size(52, 13);
            this.LBL_Sessions.TabIndex = 10;
            this.LBL_Sessions.Text = "Sessions:";
            // 
            // TB_Gamename
            // 
            this.TB_Gamename.Location = new System.Drawing.Point(105, 10);
            this.TB_Gamename.Name = "TB_Gamename";
            this.TB_Gamename.Size = new System.Drawing.Size(112, 20);
            this.TB_Gamename.TabIndex = 3;
            this.TB_Gamename.Text = "InFlames";
            // 
            // LBL_Prefix
            // 
            this.LBL_Prefix.AutoSize = true;
            this.LBL_Prefix.Location = new System.Drawing.Point(28, 10);
            this.LBL_Prefix.Name = "LBL_Prefix";
            this.LBL_Prefix.Size = new System.Drawing.Size(61, 13);
            this.LBL_Prefix.TabIndex = 2;
            this.LBL_Prefix.Text = "Gamemane";
            // 
            // LBL_PW
            // 
            this.LBL_PW.AutoSize = true;
            this.LBL_PW.Location = new System.Drawing.Point(33, 37);
            this.LBL_PW.Name = "LBL_PW";
            this.LBL_PW.Size = new System.Drawing.Size(56, 13);
            this.LBL_PW.TabIndex = 11;
            this.LBL_PW.Text = "Password:";
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(105, 37);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(112, 20);
            this.TB_Password.TabIndex = 12;
            // 
            // GB_Difficulty
            // 
            this.GB_Difficulty.Controls.Add(this.RB_Hell);
            this.GB_Difficulty.Controls.Add(this.RB_Nightmare);
            this.GB_Difficulty.Controls.Add(this.RB_Normal);
            this.GB_Difficulty.Location = new System.Drawing.Point(15, 128);
            this.GB_Difficulty.Name = "GB_Difficulty";
            this.GB_Difficulty.Size = new System.Drawing.Size(202, 50);
            this.GB_Difficulty.TabIndex = 14;
            this.GB_Difficulty.TabStop = false;
            this.GB_Difficulty.Text = "Difficulty";
            // 
            // RB_Normal
            // 
            this.RB_Normal.AutoSize = true;
            this.RB_Normal.Checked = true;
            this.RB_Normal.Location = new System.Drawing.Point(6, 20);
            this.RB_Normal.Name = "RB_Normal";
            this.RB_Normal.Size = new System.Drawing.Size(58, 17);
            this.RB_Normal.TabIndex = 0;
            this.RB_Normal.TabStop = true;
            this.RB_Normal.Text = "Normal";
            this.RB_Normal.UseVisualStyleBackColor = true;
            // 
            // RB_Nightmare
            // 
            this.RB_Nightmare.AutoSize = true;
            this.RB_Nightmare.Location = new System.Drawing.Point(70, 20);
            this.RB_Nightmare.Name = "RB_Nightmare";
            this.RB_Nightmare.Size = new System.Drawing.Size(73, 17);
            this.RB_Nightmare.TabIndex = 1;
            this.RB_Nightmare.TabStop = true;
            this.RB_Nightmare.Text = "Nightmare";
            this.RB_Nightmare.UseVisualStyleBackColor = true;
            // 
            // RB_Hell
            // 
            this.RB_Hell.AutoSize = true;
            this.RB_Hell.Location = new System.Drawing.Point(149, 20);
            this.RB_Hell.Name = "RB_Hell";
            this.RB_Hell.Size = new System.Drawing.Size(43, 17);
            this.RB_Hell.TabIndex = 2;
            this.RB_Hell.TabStop = true;
            this.RB_Hell.Text = "Hell";
            this.RB_Hell.UseVisualStyleBackColor = true;
            // 
            // ucPathPicker
            // 
            this.ucPathPicker.Location = new System.Drawing.Point(15, 184);
            this.ucPathPicker.Name = "ucPathPicker";
            this.ucPathPicker.Size = new System.Drawing.Size(340, 32);
            this.ucPathPicker.TabIndex = 8;
            // 
            // LBL_GamesState
            // 
            this.LBL_GamesState.AutoSize = true;
            this.LBL_GamesState.Location = new System.Drawing.Point(230, 109);
            this.LBL_GamesState.Name = "LBL_GamesState";
            this.LBL_GamesState.Size = new System.Drawing.Size(130, 13);
            this.LBL_GamesState.TabIndex = 15;
            this.LBL_GamesState.Text = "Games state: UNKNOWN";
            // 
            // LBL_Commander
            // 
            this.LBL_Commander.AutoSize = true;
            this.LBL_Commander.Location = new System.Drawing.Point(230, 128);
            this.LBL_Commander.Name = "LBL_Commander";
            this.LBL_Commander.Size = new System.Drawing.Size(89, 13);
            this.LBL_Commander.TabIndex = 16;
            this.LBL_Commander.Text = "Commander: OFF";
            // 
            // LBL_CurrentGame
            // 
            this.LBL_CurrentGame.AutoSize = true;
            this.LBL_CurrentGame.Location = new System.Drawing.Point(230, 150);
            this.LBL_CurrentGame.Name = "LBL_CurrentGame";
            this.LBL_CurrentGame.Size = new System.Drawing.Size(73, 13);
            this.LBL_CurrentGame.TabIndex = 17;
            this.LBL_CurrentGame.Text = "Current game:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 225);
            this.Controls.Add(this.LBL_CurrentGame);
            this.Controls.Add(this.LBL_Commander);
            this.Controls.Add(this.LBL_GamesState);
            this.Controls.Add(this.GB_Difficulty);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.LBL_PW);
            this.Controls.Add(this.LBL_Sessions);
            this.Controls.Add(this.ucPathPicker);
            this.Controls.Add(this.TB_SessionCount);
            this.Controls.Add(this.TB_Prefix);
            this.Controls.Add(this.LBL_WPrefix);
            this.Controls.Add(this.TB_Gamename);
            this.Controls.Add(this.LBL_Prefix);
            this.Controls.Add(this.BTN_Release);
            this.Controls.Add(this.BTN_Load);
            this.Name = "Form1";
            this.Text = "My Bitches v6.9";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_Difficulty.ResumeLayout(false);
            this.GB_Difficulty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Load;
        private System.Windows.Forms.Button BTN_Release;
        private System.Windows.Forms.Label LBL_WPrefix;
        private System.Windows.Forms.TextBox TB_Prefix;
        private System.Windows.Forms.TextBox TB_SessionCount;
        private PathPicker ucPathPicker;
        private System.Windows.Forms.Label LBL_Sessions;
        private System.Windows.Forms.TextBox TB_Gamename;
        private System.Windows.Forms.Label LBL_Prefix;
        private System.Windows.Forms.Label LBL_PW;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.GroupBox GB_Difficulty;
        private System.Windows.Forms.RadioButton RB_Hell;
        private System.Windows.Forms.RadioButton RB_Nightmare;
        private System.Windows.Forms.RadioButton RB_Normal;
        private System.Windows.Forms.Label LBL_GamesState;
        private System.Windows.Forms.Label LBL_Commander;
        private System.Windows.Forms.Label LBL_CurrentGame;
    }
}

