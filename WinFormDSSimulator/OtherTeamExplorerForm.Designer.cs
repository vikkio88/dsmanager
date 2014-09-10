namespace WinFormDSSimulator
{
    partial class OtherTeamExplorerForm
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
            this.txtTeamInfo = new System.Windows.Forms.TextBox();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTeamInfo
            // 
            this.txtTeamInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTeamInfo.Enabled = false;
            this.txtTeamInfo.Location = new System.Drawing.Point(155, 12);
            this.txtTeamInfo.Multiline = true;
            this.txtTeamInfo.Name = "txtTeamInfo";
            this.txtTeamInfo.Size = new System.Drawing.Size(355, 303);
            this.txtTeamInfo.TabIndex = 8;
            // 
            // lstTeams
            // 
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.Location = new System.Drawing.Point(13, 10);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(123, 277);
            this.lstTeams.TabIndex = 7;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.ListSelectEvent);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(412, 321);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(98, 34);
            this.btnQuit.TabIndex = 23;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // OtherTeamExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 367);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtTeamInfo);
            this.Controls.Add(this.lstTeams);
            this.Name = "OtherTeamExplorerForm";
            this.Text = "OtherTeamExplorerForm";
            this.Load += new System.EventHandler(this.OtherTeamExplorerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeamInfo;
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.Button btnQuit;
    }
}