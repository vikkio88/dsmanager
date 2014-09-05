namespace WinFormDSSimulator
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.pnlNewGame = new System.Windows.Forms.Panel();
            this.pnlMainMenuGame = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnChooseTeam = new System.Windows.Forms.Button();
            this.txtTeamInfo = new System.Windows.Forms.TextBox();
            this.cboNumb = new System.Windows.Forms.ComboBox();
            this.btnGenerateTeamsFromFiles = new System.Windows.Forms.Button();
            this.btnGenerateRandomTeams = new System.Windows.Forms.Button();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timerUtils = new System.Windows.Forms.Timer(this.components);
            this.btnNextRound = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNextRound = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayerTeamInfo = new System.Windows.Forms.TextBox();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMyTeamInfo = new System.Windows.Forms.Button();
            this.btnFixture = new System.Windows.Forms.Button();
            this.btnOtherTeams = new System.Windows.Forms.Button();
            this.btnLeagueStat = new System.Windows.Forms.Button();
            this.btnSpeakWithCoach = new System.Windows.Forms.Button();
            this.btnMarket = new System.Windows.Forms.Button();
            this.txtLastMatch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNewGame.SuspendLayout();
            this.pnlMainMenuGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(169, 417);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(0, 0);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(169, 50);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormDSSimulator.Properties.Resources.splash;
            this.pictureBox1.Location = new System.Drawing.Point(176, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 337);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Location = new System.Drawing.Point(0, 56);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(169, 50);
            this.btnLoadGame.TabIndex = 3;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.Location = new System.Drawing.Point(1, 112);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(169, 50);
            this.btnExitGame.TabIndex = 4;
            this.btnExitGame.Text = "Exit";
            this.btnExitGame.UseVisualStyleBackColor = true;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.Location = new System.Drawing.Point(37, 304);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(99, 34);
            this.btnRecords.TabIndex = 5;
            this.btnRecords.Text = "Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // pnlNewGame
            // 
            this.pnlNewGame.Controls.Add(this.pnlMainMenuGame);
            this.pnlNewGame.Controls.Add(this.btnChooseTeam);
            this.pnlNewGame.Controls.Add(this.txtTeamInfo);
            this.pnlNewGame.Controls.Add(this.cboNumb);
            this.pnlNewGame.Controls.Add(this.btnGenerateTeamsFromFiles);
            this.pnlNewGame.Controls.Add(this.btnGenerateRandomTeams);
            this.pnlNewGame.Controls.Add(this.lstTeams);
            this.pnlNewGame.Controls.Add(this.txtPlayerName);
            this.pnlNewGame.Controls.Add(this.label1);
            this.pnlNewGame.Location = new System.Drawing.Point(1, 1);
            this.pnlNewGame.Name = "pnlNewGame";
            this.pnlNewGame.Size = new System.Drawing.Size(679, 382);
            this.pnlNewGame.TabIndex = 6;
            this.pnlNewGame.Visible = false;
            // 
            // pnlMainMenuGame
            // 
            this.pnlMainMenuGame.Controls.Add(this.txtLastMatch);
            this.pnlMainMenuGame.Controls.Add(this.label5);
            this.pnlMainMenuGame.Controls.Add(this.btnMarket);
            this.pnlMainMenuGame.Controls.Add(this.btnSpeakWithCoach);
            this.pnlMainMenuGame.Controls.Add(this.btnLeagueStat);
            this.pnlMainMenuGame.Controls.Add(this.btnOtherTeams);
            this.pnlMainMenuGame.Controls.Add(this.btnFixture);
            this.pnlMainMenuGame.Controls.Add(this.btnMyTeamInfo);
            this.pnlMainMenuGame.Controls.Add(this.txtTable);
            this.pnlMainMenuGame.Controls.Add(this.label4);
            this.pnlMainMenuGame.Controls.Add(this.txtPlayerTeamInfo);
            this.pnlMainMenuGame.Controls.Add(this.label3);
            this.pnlMainMenuGame.Controls.Add(this.txtNextRound);
            this.pnlMainMenuGame.Controls.Add(this.label2);
            this.pnlMainMenuGame.Controls.Add(this.btnNextRound);
            this.pnlMainMenuGame.Controls.Add(this.splitter2);
            this.pnlMainMenuGame.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenuGame.Name = "pnlMainMenuGame";
            this.pnlMainMenuGame.Size = new System.Drawing.Size(679, 404);
            this.pnlMainMenuGame.TabIndex = 8;
            this.pnlMainMenuGame.Visible = false;
            this.pnlMainMenuGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainMenuGame_Paint);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 404);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // btnChooseTeam
            // 
            this.btnChooseTeam.Enabled = false;
            this.btnChooseTeam.Location = new System.Drawing.Point(536, 323);
            this.btnChooseTeam.Name = "btnChooseTeam";
            this.btnChooseTeam.Size = new System.Drawing.Size(92, 51);
            this.btnChooseTeam.TabIndex = 7;
            this.btnChooseTeam.Text = "Choose Team";
            this.btnChooseTeam.UseVisualStyleBackColor = true;
            this.btnChooseTeam.Click += new System.EventHandler(this.btnChooseTeam_Click);
            // 
            // txtTeamInfo
            // 
            this.txtTeamInfo.Enabled = false;
            this.txtTeamInfo.Location = new System.Drawing.Point(148, 72);
            this.txtTeamInfo.Multiline = true;
            this.txtTeamInfo.Name = "txtTeamInfo";
            this.txtTeamInfo.Size = new System.Drawing.Size(355, 303);
            this.txtTeamInfo.TabIndex = 6;
            // 
            // cboNumb
            // 
            this.cboNumb.FormattingEnabled = true;
            this.cboNumb.Items.AddRange(new object[] {
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18"});
            this.cboNumb.Location = new System.Drawing.Point(172, 41);
            this.cboNumb.Name = "cboNumb";
            this.cboNumb.Size = new System.Drawing.Size(57, 21);
            this.cboNumb.TabIndex = 5;
            this.cboNumb.Text = "4";
            // 
            // btnGenerateTeamsFromFiles
            // 
            this.btnGenerateTeamsFromFiles.Location = new System.Drawing.Point(250, 41);
            this.btnGenerateTeamsFromFiles.Name = "btnGenerateTeamsFromFiles";
            this.btnGenerateTeamsFromFiles.Size = new System.Drawing.Size(159, 23);
            this.btnGenerateTeamsFromFiles.TabIndex = 4;
            this.btnGenerateTeamsFromFiles.Text = "Teams From Files";
            this.btnGenerateTeamsFromFiles.UseVisualStyleBackColor = true;
            this.btnGenerateTeamsFromFiles.Click += new System.EventHandler(this.btnGenerateTeamsFromFiles_Click);
            // 
            // btnGenerateRandomTeams
            // 
            this.btnGenerateRandomTeams.Location = new System.Drawing.Point(6, 41);
            this.btnGenerateRandomTeams.Name = "btnGenerateRandomTeams";
            this.btnGenerateRandomTeams.Size = new System.Drawing.Size(159, 23);
            this.btnGenerateRandomTeams.TabIndex = 3;
            this.btnGenerateRandomTeams.Text = "Generate Random Teams";
            this.btnGenerateRandomTeams.UseVisualStyleBackColor = true;
            this.btnGenerateRandomTeams.Click += new System.EventHandler(this.btnGenerateRandomTeams_Click);
            // 
            // lstTeams
            // 
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.Location = new System.Drawing.Point(6, 70);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(123, 277);
            this.lstTeams.TabIndex = 2;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.ListSelectEvent);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(77, 4);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(191, 20);
            this.txtPlayerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(8, 386);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 31);
            this.lblStatus.TabIndex = 7;
            // 
            // timerUtils
            // 
            this.timerUtils.Tick += new System.EventHandler(this.timerUtils_Tick);
            // 
            // btnNextRound
            // 
            this.btnNextRound.Location = new System.Drawing.Point(3, 4);
            this.btnNextRound.Name = "btnNextRound";
            this.btnNextRound.Size = new System.Drawing.Size(169, 50);
            this.btnNextRound.TabIndex = 2;
            this.btnNextRound.Text = "Play Next Round";
            this.btnNextRound.UseVisualStyleBackColor = true;
            this.btnNextRound.Click += new System.EventHandler(this.btnNextRound_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Next Round";
            // 
            // txtNextRound
            // 
            this.txtNextRound.Enabled = false;
            this.txtNextRound.Location = new System.Drawing.Point(422, 25);
            this.txtNextRound.Multiline = true;
            this.txtNextRound.Name = "txtNextRound";
            this.txtNextRound.Size = new System.Drawing.Size(249, 116);
            this.txtNextRound.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Team Info";
            // 
            // txtPlayerTeamInfo
            // 
            this.txtPlayerTeamInfo.Enabled = false;
            this.txtPlayerTeamInfo.Location = new System.Drawing.Point(196, 30);
            this.txtPlayerTeamInfo.Multiline = true;
            this.txtPlayerTeamInfo.Name = "txtPlayerTeamInfo";
            this.txtPlayerTeamInfo.Size = new System.Drawing.Size(213, 108);
            this.txtPlayerTeamInfo.TabIndex = 6;
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(199, 166);
            this.txtTable.Multiline = true;
            this.txtTable.Name = "txtTable";
            this.txtTable.ReadOnly = true;
            this.txtTable.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTable.Size = new System.Drawing.Size(213, 209);
            this.txtTable.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Table";
            // 
            // btnMyTeamInfo
            // 
            this.btnMyTeamInfo.Location = new System.Drawing.Point(6, 60);
            this.btnMyTeamInfo.Name = "btnMyTeamInfo";
            this.btnMyTeamInfo.Size = new System.Drawing.Size(126, 50);
            this.btnMyTeamInfo.TabIndex = 9;
            this.btnMyTeamInfo.Text = "My Team Info";
            this.btnMyTeamInfo.UseVisualStyleBackColor = true;
            // 
            // btnFixture
            // 
            this.btnFixture.Location = new System.Drawing.Point(6, 116);
            this.btnFixture.Name = "btnFixture";
            this.btnFixture.Size = new System.Drawing.Size(126, 50);
            this.btnFixture.TabIndex = 10;
            this.btnFixture.Text = "Fixture";
            this.btnFixture.UseVisualStyleBackColor = true;
            this.btnFixture.Click += new System.EventHandler(this.btnFixture_Click);
            // 
            // btnOtherTeams
            // 
            this.btnOtherTeams.Location = new System.Drawing.Point(3, 303);
            this.btnOtherTeams.Name = "btnOtherTeams";
            this.btnOtherTeams.Size = new System.Drawing.Size(126, 50);
            this.btnOtherTeams.TabIndex = 11;
            this.btnOtherTeams.Text = "Other Teams";
            this.btnOtherTeams.UseVisualStyleBackColor = true;
            // 
            // btnLeagueStat
            // 
            this.btnLeagueStat.Location = new System.Drawing.Point(3, 247);
            this.btnLeagueStat.Name = "btnLeagueStat";
            this.btnLeagueStat.Size = new System.Drawing.Size(126, 50);
            this.btnLeagueStat.TabIndex = 12;
            this.btnLeagueStat.Text = "League Statistics";
            this.btnLeagueStat.UseVisualStyleBackColor = true;
            // 
            // btnSpeakWithCoach
            // 
            this.btnSpeakWithCoach.Location = new System.Drawing.Point(555, 303);
            this.btnSpeakWithCoach.Name = "btnSpeakWithCoach";
            this.btnSpeakWithCoach.Size = new System.Drawing.Size(114, 50);
            this.btnSpeakWithCoach.TabIndex = 13;
            this.btnSpeakWithCoach.Text = "Speak with the Coach";
            this.btnSpeakWithCoach.UseVisualStyleBackColor = true;
            // 
            // btnMarket
            // 
            this.btnMarket.Location = new System.Drawing.Point(557, 235);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(112, 50);
            this.btnMarket.TabIndex = 14;
            this.btnMarket.Text = "Market";
            this.btnMarket.UseVisualStyleBackColor = true;
            // 
            // txtLastMatch
            // 
            this.txtLastMatch.Enabled = false;
            this.txtLastMatch.Location = new System.Drawing.Point(424, 166);
            this.txtLastMatch.Multiline = true;
            this.txtLastMatch.Name = "txtLastMatch";
            this.txtLastMatch.Size = new System.Drawing.Size(249, 52);
            this.txtLastMatch.TabIndex = 16;
            this.txtLastMatch.Text = "No Match Played";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Last Match";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 417);
            this.Controls.Add(this.pnlNewGame);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.splitter1);
            this.Name = "MainForm";
            this.Text = "DSsimulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNewGame.ResumeLayout(false);
            this.pnlNewGame.PerformLayout();
            this.pnlMainMenuGame.ResumeLayout(false);
            this.pnlMainMenuGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Panel pnlNewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateTeamsFromFiles;
        private System.Windows.Forms.Button btnGenerateRandomTeams;
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.ComboBox cboNumb;
        private System.Windows.Forms.TextBox txtTeamInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timerUtils;
        private System.Windows.Forms.Button btnChooseTeam;
        private System.Windows.Forms.Panel pnlMainMenuGame;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TextBox txtPlayerTeamInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNextRound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNextRound;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Button btnSpeakWithCoach;
        private System.Windows.Forms.Button btnLeagueStat;
        private System.Windows.Forms.Button btnOtherTeams;
        private System.Windows.Forms.Button btnFixture;
        private System.Windows.Forms.Button btnMyTeamInfo;
        private System.Windows.Forms.TextBox txtLastMatch;
        private System.Windows.Forms.Label label5;
    }
}

