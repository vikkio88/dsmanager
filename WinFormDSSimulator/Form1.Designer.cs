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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.pnlNewGame = new System.Windows.Forms.Panel();
            this.cboNumb = new System.Windows.Forms.ComboBox();
            this.btnGenerateTeamsFromFiles = new System.Windows.Forms.Button();
            this.btnGenerateRandomTeams = new System.Windows.Forms.Button();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeamInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNewGame.SuspendLayout();
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
            this.pnlNewGame.Controls.Add(this.txtTeamInfo);
            this.pnlNewGame.Controls.Add(this.cboNumb);
            this.pnlNewGame.Controls.Add(this.btnGenerateTeamsFromFiles);
            this.pnlNewGame.Controls.Add(this.btnGenerateRandomTeams);
            this.pnlNewGame.Controls.Add(this.lstTeams);
            this.pnlNewGame.Controls.Add(this.txtPlayerName);
            this.pnlNewGame.Controls.Add(this.label1);
            this.pnlNewGame.Location = new System.Drawing.Point(0, 1);
            this.pnlNewGame.Name = "pnlNewGame";
            this.pnlNewGame.Size = new System.Drawing.Size(789, 413);
            this.pnlNewGame.TabIndex = 6;
            this.pnlNewGame.Visible = false;
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
            // txtTeamInfo
            // 
            this.txtTeamInfo.Enabled = false;
            this.txtTeamInfo.Location = new System.Drawing.Point(148, 72);
            this.txtTeamInfo.Multiline = true;
            this.txtTeamInfo.Name = "txtTeamInfo";
            this.txtTeamInfo.Size = new System.Drawing.Size(355, 303);
            this.txtTeamInfo.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 417);
            this.Controls.Add(this.pnlNewGame);
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
            this.ResumeLayout(false);

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
    }
}

