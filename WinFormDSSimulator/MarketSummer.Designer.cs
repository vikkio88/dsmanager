namespace WinFormDSSimulator
{
    partial class MarketSummer
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
            this.txtEvents = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMyTeam = new System.Windows.Forms.Button();
            this.pnlMainMarket = new System.Windows.Forms.Panel();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.lblWeeks = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnChangeRole = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlayerInfo = new System.Windows.Forms.TextBox();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeamInfo = new System.Windows.Forms.TextBox();
            this.btnPlayerRole = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnYouth = new System.Windows.Forms.Button();
            this.btnFreePlayers = new System.Windows.Forms.Button();
            this.btnPlayersInLeague = new System.Windows.Forms.Button();
            this.pnlMainMarket.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEvents
            // 
            this.txtEvents.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEvents.Location = new System.Drawing.Point(12, 38);
            this.txtEvents.Multiline = true;
            this.txtEvents.Name = "txtEvents";
            this.txtEvents.ReadOnly = true;
            this.txtEvents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEvents.Size = new System.Drawing.Size(571, 318);
            this.txtEvents.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Summer Events";
            // 
            // btnMyTeam
            // 
            this.btnMyTeam.Location = new System.Drawing.Point(471, 362);
            this.btnMyTeam.Name = "btnMyTeam";
            this.btnMyTeam.Size = new System.Drawing.Size(112, 50);
            this.btnMyTeam.TabIndex = 15;
            this.btnMyTeam.Text = "my Team";
            this.btnMyTeam.UseVisualStyleBackColor = true;
            this.btnMyTeam.Click += new System.EventHandler(this.btnMyTeam_Click);
            // 
            // pnlMainMarket
            // 
            this.pnlMainMarket.Controls.Add(this.btnNextWeek);
            this.pnlMainMarket.Controls.Add(this.lblWeeks);
            this.pnlMainMarket.Controls.Add(this.groupBox1);
            this.pnlMainMarket.Controls.Add(this.label3);
            this.pnlMainMarket.Controls.Add(this.label4);
            this.pnlMainMarket.Controls.Add(this.txtPlayerInfo);
            this.pnlMainMarket.Controls.Add(this.lstPlayers);
            this.pnlMainMarket.Controls.Add(this.label2);
            this.pnlMainMarket.Controls.Add(this.txtTeamInfo);
            this.pnlMainMarket.Controls.Add(this.btnPlayerRole);
            this.pnlMainMarket.Controls.Add(this.btnQuit);
            this.pnlMainMarket.Controls.Add(this.btnTrain);
            this.pnlMainMarket.Controls.Add(this.btnYouth);
            this.pnlMainMarket.Controls.Add(this.btnFreePlayers);
            this.pnlMainMarket.Controls.Add(this.btnPlayersInLeague);
            this.pnlMainMarket.Location = new System.Drawing.Point(4, 2);
            this.pnlMainMarket.Name = "pnlMainMarket";
            this.pnlMainMarket.Size = new System.Drawing.Size(590, 410);
            this.pnlMainMarket.TabIndex = 16;
            this.pnlMainMarket.Visible = false;
            this.pnlMainMarket.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainMarket_Paint);
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextWeek.Location = new System.Drawing.Point(553, 374);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(34, 36);
            this.btnNextWeek.TabIndex = 34;
            this.btnNextWeek.Text = ">";
            this.btnNextWeek.UseVisualStyleBackColor = true;
            this.btnNextWeek.Click += new System.EventHandler(this.btnNextWeek_Click);
            // 
            // lblWeeks
            // 
            this.lblWeeks.AutoSize = true;
            this.lblWeeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeks.Location = new System.Drawing.Point(381, 374);
            this.lblWeeks.Name = "lblWeeks";
            this.lblWeeks.Size = new System.Drawing.Size(152, 31);
            this.lblWeeks.TabIndex = 33;
            this.lblWeeks.Text = "Week 1/15";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboRole);
            this.groupBox1.Controls.Add(this.btnSell);
            this.groupBox1.Controls.Add(this.btnChangeRole);
            this.groupBox1.Location = new System.Drawing.Point(321, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 104);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Operations";
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(76, 75);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(42, 21);
            this.cboRole.TabIndex = 31;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(140, 19);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(112, 50);
            this.btnSell.TabIndex = 29;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnChangeRole
            // 
            this.btnChangeRole.Location = new System.Drawing.Point(6, 19);
            this.btnChangeRole.Name = "btnChangeRole";
            this.btnChangeRole.Size = new System.Drawing.Size(112, 50);
            this.btnChangeRole.TabIndex = 30;
            this.btnChangeRole.Text = "Change Role";
            this.btnChangeRole.UseVisualStyleBackColor = true;
            this.btnChangeRole.Click += new System.EventHandler(this.btnChangeRole_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Player Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Players List";
            // 
            // txtPlayerInfo
            // 
            this.txtPlayerInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPlayerInfo.Location = new System.Drawing.Point(321, 172);
            this.txtPlayerInfo.Multiline = true;
            this.txtPlayerInfo.Name = "txtPlayerInfo";
            this.txtPlayerInfo.ReadOnly = true;
            this.txtPlayerInfo.Size = new System.Drawing.Size(258, 72);
            this.txtPlayerInfo.TabIndex = 26;
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Location = new System.Drawing.Point(165, 172);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(150, 238);
            this.lstPlayers.TabIndex = 25;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.ListSelectEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Team Info";
            // 
            // txtTeamInfo
            // 
            this.txtTeamInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTeamInfo.Location = new System.Drawing.Point(165, 23);
            this.txtTeamInfo.Multiline = true;
            this.txtTeamInfo.Name = "txtTeamInfo";
            this.txtTeamInfo.ReadOnly = true;
            this.txtTeamInfo.Size = new System.Drawing.Size(414, 127);
            this.txtTeamInfo.TabIndex = 23;
            // 
            // btnPlayerRole
            // 
            this.btnPlayerRole.Location = new System.Drawing.Point(8, 66);
            this.btnPlayerRole.Name = "btnPlayerRole";
            this.btnPlayerRole.Size = new System.Drawing.Size(151, 50);
            this.btnPlayerRole.TabIndex = 22;
            this.btnPlayerRole.Text = "Search Player per Role";
            this.btnPlayerRole.UseVisualStyleBackColor = true;
            this.btnPlayerRole.Click += new System.EventHandler(this.btnPlayerRole_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(8, 343);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(112, 50);
            this.btnQuit.TabIndex = 21;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(8, 234);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(112, 50);
            this.btnTrain.TabIndex = 20;
            this.btnTrain.Text = "Train Team";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnYouth
            // 
            this.btnYouth.Location = new System.Drawing.Point(8, 178);
            this.btnYouth.Name = "btnYouth";
            this.btnYouth.Size = new System.Drawing.Size(151, 50);
            this.btnYouth.TabIndex = 19;
            this.btnYouth.Text = "Youth Club";
            this.btnYouth.UseVisualStyleBackColor = true;
            this.btnYouth.Click += new System.EventHandler(this.btnYouth_Click);
            // 
            // btnFreePlayers
            // 
            this.btnFreePlayers.Location = new System.Drawing.Point(8, 122);
            this.btnFreePlayers.Name = "btnFreePlayers";
            this.btnFreePlayers.Size = new System.Drawing.Size(151, 50);
            this.btnFreePlayers.TabIndex = 18;
            this.btnFreePlayers.Text = "Free Players";
            this.btnFreePlayers.UseVisualStyleBackColor = true;
            this.btnFreePlayers.Click += new System.EventHandler(this.btnFreePlayers_Click);
            // 
            // btnPlayersInLeague
            // 
            this.btnPlayersInLeague.Location = new System.Drawing.Point(8, 10);
            this.btnPlayersInLeague.Name = "btnPlayersInLeague";
            this.btnPlayersInLeague.Size = new System.Drawing.Size(151, 50);
            this.btnPlayersInLeague.TabIndex = 17;
            this.btnPlayersInLeague.Text = "Search For Player in League";
            this.btnPlayersInLeague.UseVisualStyleBackColor = true;
            this.btnPlayersInLeague.Click += new System.EventHandler(this.btnPlayersInLeague_Click);
            // 
            // MarketSummer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 416);
            this.Controls.Add(this.pnlMainMarket);
            this.Controls.Add(this.btnMyTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEvents);
            this.Name = "MarketSummer";
            this.Text = "MarketSummer";
            this.Load += new System.EventHandler(this.MarketSummer_Load);
            this.pnlMainMarket.ResumeLayout(false);
            this.pnlMainMarket.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMyTeam;
        private System.Windows.Forms.Panel pnlMainMarket;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnYouth;
        private System.Windows.Forms.Button btnFreePlayers;
        private System.Windows.Forms.Button btnPlayersInLeague;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPlayerRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeamInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlayerInfo;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Button btnChangeRole;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWeeks;
        private System.Windows.Forms.Button btnNextWeek;
    }
}