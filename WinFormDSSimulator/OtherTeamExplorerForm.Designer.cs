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
            this.SuspendLayout();
            // 
            // txtTeamInfo
            // 
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
            // OtherTeamExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 349);
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
    }
}