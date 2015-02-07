namespace MuleFiller
{
    partial class PathPicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Path = new System.Windows.Forms.TextBox();
            this.BTN_PickPath = new System.Windows.Forms.Button();
            this.openDiabloExec = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // TB_Path
            // 
            this.TB_Path.Location = new System.Drawing.Point(3, 3);
            this.TB_Path.Name = "TB_Path";
            this.TB_Path.ReadOnly = true;
            this.TB_Path.Size = new System.Drawing.Size(276, 20);
            this.TB_Path.TabIndex = 0;
            this.TB_Path.Text = "Path to Diablo II.exe";
            // 
            // BTN_PickPath
            // 
            this.BTN_PickPath.Location = new System.Drawing.Point(285, 3);
            this.BTN_PickPath.Name = "BTN_PickPath";
            this.BTN_PickPath.Size = new System.Drawing.Size(51, 23);
            this.BTN_PickPath.TabIndex = 1;
            this.BTN_PickPath.Text = "...";
            this.BTN_PickPath.UseVisualStyleBackColor = true;
            this.BTN_PickPath.Click += new System.EventHandler(this.BTN_PickPath_Click);
            // 
            // openDiabloExec
            // 
            this.openDiabloExec.FileName = "Diablo II.exe";
            this.openDiabloExec.Filter = "D2Exe|Diablo II.exe";
            this.openDiabloExec.Title = "Select Diablo II.exe";
            // 
            // PathPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_PickPath);
            this.Controls.Add(this.TB_Path);
            this.Name = "PathPicker";
            this.Size = new System.Drawing.Size(340, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_PickPath;
        private System.Windows.Forms.OpenFileDialog openDiabloExec;
        public System.Windows.Forms.TextBox TB_Path;
    }
}
