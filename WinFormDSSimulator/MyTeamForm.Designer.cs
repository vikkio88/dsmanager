namespace WinFormDSSimulator
{
    partial class MyTeamForm
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
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.txtTeamInfo = new System.Windows.Forms.TextBox();
            this.txtPlayerInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Location = new System.Drawing.Point(12, 191);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(150, 238);
            this.lstPlayers.TabIndex = 0;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.ListSelectEvent);
            // 
            // txtTeamInfo
            // 
            this.txtTeamInfo.Location = new System.Drawing.Point(3, 33);
            this.txtTeamInfo.Multiline = true;
            this.txtTeamInfo.Name = "txtTeamInfo";
            this.txtTeamInfo.ReadOnly = true;
            this.txtTeamInfo.Size = new System.Drawing.Size(433, 127);
            this.txtTeamInfo.TabIndex = 1;
            // 
            // txtPlayerInfo
            // 
            this.txtPlayerInfo.Location = new System.Drawing.Point(168, 191);
            this.txtPlayerInfo.Multiline = true;
            this.txtPlayerInfo.Name = "txtPlayerInfo";
            this.txtPlayerInfo.ReadOnly = true;
            this.txtPlayerInfo.Size = new System.Drawing.Size(268, 116);
            this.txtPlayerInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Players List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player Info";
            // 
            // MyTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 438);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerInfo);
            this.Controls.Add(this.txtTeamInfo);
            this.Controls.Add(this.lstPlayers);
            this.Name = "MyTeamForm";
            this.Text = "my Team";
            this.Load += new System.EventHandler(this.MyTeamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.TextBox txtTeamInfo;
        private System.Windows.Forms.TextBox txtPlayerInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}