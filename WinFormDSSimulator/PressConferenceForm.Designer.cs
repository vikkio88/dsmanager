namespace WinFormDSSimulator
{
    partial class PressConferenceForm
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnGoodJobPlayer = new System.Windows.Forms.Button();
            this.btnBadJobTeam = new System.Windows.Forms.Button();
            this.btnGoodJobTeam = new System.Windows.Forms.Button();
            this.txtPress = new System.Windows.Forms.TextBox();
            this.txtCons = new System.Windows.Forms.TextBox();
            this.btnBadobPlayer = new System.Windows.Forms.Button();
            this.grpTeam = new System.Windows.Forms.GroupBox();
            this.grpPlayer = new System.Windows.Forms.GroupBox();
            this.cboPlayers = new System.Windows.Forms.ComboBox();
            this.btnGoodbye = new System.Windows.Forms.Button();
            this.grpTeam.SuspendLayout();
            this.grpPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Enabled = false;
            this.btnQuit.Location = new System.Drawing.Point(417, 413);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(98, 34);
            this.btnQuit.TabIndex = 23;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnGoodJobPlayer
            // 
            this.btnGoodJobPlayer.Location = new System.Drawing.Point(6, 19);
            this.btnGoodJobPlayer.Name = "btnGoodJobPlayer";
            this.btnGoodJobPlayer.Size = new System.Drawing.Size(112, 50);
            this.btnGoodJobPlayer.TabIndex = 26;
            this.btnGoodJobPlayer.Text = "Praise a Player";
            this.btnGoodJobPlayer.UseVisualStyleBackColor = true;
            this.btnGoodJobPlayer.Click += new System.EventHandler(this.btnGoodJobPlayer_Click);
            // 
            // btnBadJobTeam
            // 
            this.btnBadJobTeam.Location = new System.Drawing.Point(117, 19);
            this.btnBadJobTeam.Name = "btnBadJobTeam";
            this.btnBadJobTeam.Size = new System.Drawing.Size(112, 50);
            this.btnBadJobTeam.TabIndex = 25;
            this.btnBadJobTeam.Text = "Express Dissatisfaction";
            this.btnBadJobTeam.UseVisualStyleBackColor = true;
            this.btnBadJobTeam.Click += new System.EventHandler(this.btnBadJobTeam_Click);
            // 
            // btnGoodJobTeam
            // 
            this.btnGoodJobTeam.Location = new System.Drawing.Point(6, 19);
            this.btnGoodJobTeam.Name = "btnGoodJobTeam";
            this.btnGoodJobTeam.Size = new System.Drawing.Size(112, 50);
            this.btnGoodJobTeam.TabIndex = 24;
            this.btnGoodJobTeam.Text = "Praise the Team";
            this.btnGoodJobTeam.UseVisualStyleBackColor = true;
            this.btnGoodJobTeam.Click += new System.EventHandler(this.btnGoodJobTeam_Click);
            // 
            // txtPress
            // 
            this.txtPress.Location = new System.Drawing.Point(12, 12);
            this.txtPress.Multiline = true;
            this.txtPress.Name = "txtPress";
            this.txtPress.ReadOnly = true;
            this.txtPress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPress.Size = new System.Drawing.Size(503, 122);
            this.txtPress.TabIndex = 28;
            // 
            // txtCons
            // 
            this.txtCons.Location = new System.Drawing.Point(12, 326);
            this.txtCons.Multiline = true;
            this.txtCons.Name = "txtCons";
            this.txtCons.ReadOnly = true;
            this.txtCons.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCons.Size = new System.Drawing.Size(503, 81);
            this.txtCons.TabIndex = 29;
            // 
            // btnBadobPlayer
            // 
            this.btnBadobPlayer.Location = new System.Drawing.Point(117, 19);
            this.btnBadobPlayer.Name = "btnBadobPlayer";
            this.btnBadobPlayer.Size = new System.Drawing.Size(112, 50);
            this.btnBadobPlayer.TabIndex = 30;
            this.btnBadobPlayer.Text = "Blame a Player";
            this.btnBadobPlayer.UseVisualStyleBackColor = true;
            this.btnBadobPlayer.Click += new System.EventHandler(this.btnBadobPlayer_Click);
            // 
            // grpTeam
            // 
            this.grpTeam.Controls.Add(this.btnGoodJobTeam);
            this.grpTeam.Controls.Add(this.btnBadJobTeam);
            this.grpTeam.Location = new System.Drawing.Point(12, 144);
            this.grpTeam.Name = "grpTeam";
            this.grpTeam.Size = new System.Drawing.Size(235, 107);
            this.grpTeam.TabIndex = 31;
            this.grpTeam.TabStop = false;
            this.grpTeam.Text = "Team Action";
            // 
            // grpPlayer
            // 
            this.grpPlayer.Controls.Add(this.cboPlayers);
            this.grpPlayer.Controls.Add(this.btnGoodJobPlayer);
            this.grpPlayer.Controls.Add(this.btnBadobPlayer);
            this.grpPlayer.Location = new System.Drawing.Point(270, 144);
            this.grpPlayer.Name = "grpPlayer";
            this.grpPlayer.Size = new System.Drawing.Size(235, 107);
            this.grpPlayer.TabIndex = 32;
            this.grpPlayer.TabStop = false;
            this.grpPlayer.Text = "Player Action";
            // 
            // cboPlayers
            // 
            this.cboPlayers.FormattingEnabled = true;
            this.cboPlayers.Location = new System.Drawing.Point(55, 75);
            this.cboPlayers.Name = "cboPlayers";
            this.cboPlayers.Size = new System.Drawing.Size(121, 21);
            this.cboPlayers.TabIndex = 31;
            // 
            // btnGoodbye
            // 
            this.btnGoodbye.Location = new System.Drawing.Point(209, 257);
            this.btnGoodbye.Name = "btnGoodbye";
            this.btnGoodbye.Size = new System.Drawing.Size(98, 34);
            this.btnGoodbye.TabIndex = 33;
            this.btnGoodbye.Text = "Say Goodbye";
            this.btnGoodbye.UseVisualStyleBackColor = true;
            this.btnGoodbye.Click += new System.EventHandler(this.btnGoodbye_Click);
            // 
            // PressConferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.btnGoodbye);
            this.Controls.Add(this.grpPlayer);
            this.Controls.Add(this.grpTeam);
            this.Controls.Add(this.txtCons);
            this.Controls.Add(this.txtPress);
            this.Controls.Add(this.btnQuit);
            this.Name = "PressConferenceForm";
            this.Text = "Press Conference";
            this.Load += new System.EventHandler(this.PressConferenceForm_Load);
            this.grpTeam.ResumeLayout(false);
            this.grpPlayer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnGoodJobPlayer;
        private System.Windows.Forms.Button btnBadJobTeam;
        private System.Windows.Forms.Button btnGoodJobTeam;
        private System.Windows.Forms.TextBox txtPress;
        private System.Windows.Forms.TextBox txtCons;
        private System.Windows.Forms.Button btnBadobPlayer;
        private System.Windows.Forms.GroupBox grpTeam;
        private System.Windows.Forms.GroupBox grpPlayer;
        private System.Windows.Forms.ComboBox cboPlayers;
        private System.Windows.Forms.Button btnGoodbye;
    }
}