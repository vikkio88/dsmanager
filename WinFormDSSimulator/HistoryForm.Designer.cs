namespace WinFormDSSimulator
{
    partial class HistoryForm
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
            this.txtLeagueHistory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlayerHistory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLeagueHistory
            // 
            this.txtLeagueHistory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLeagueHistory.Location = new System.Drawing.Point(12, 23);
            this.txtLeagueHistory.Multiline = true;
            this.txtLeagueHistory.Name = "txtLeagueHistory";
            this.txtLeagueHistory.ReadOnly = true;
            this.txtLeagueHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLeagueHistory.Size = new System.Drawing.Size(366, 163);
            this.txtLeagueHistory.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "League History";
            // 
            // txtPlayerHistory
            // 
            this.txtPlayerHistory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPlayerHistory.Location = new System.Drawing.Point(12, 220);
            this.txtPlayerHistory.Multiline = true;
            this.txtPlayerHistory.Name = "txtPlayerHistory";
            this.txtPlayerHistory.ReadOnly = true;
            this.txtPlayerHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPlayerHistory.Size = new System.Drawing.Size(366, 163);
            this.txtPlayerHistory.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Player History";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(280, 401);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(98, 34);
            this.btnQuit.TabIndex = 24;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 447);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtPlayerHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLeagueHistory);
            this.Controls.Add(this.label4);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeagueHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlayerHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuit;
    }
}