namespace WinFormDSSimulator.marketDialogForms
{
    partial class FreePlayersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreePlayersForm));
            this.btnSpeak = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayerInfo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstFreePlayers = new System.Windows.Forms.ListBox();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(382, 298);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(112, 50);
            this.btnSpeak.TabIndex = 53;
            this.btnSpeak.Text = "Speak with Him";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Player Info";
            // 
            // txtPlayerInfo
            // 
            this.txtPlayerInfo.Location = new System.Drawing.Point(119, 298);
            this.txtPlayerInfo.Multiline = true;
            this.txtPlayerInfo.Name = "txtPlayerInfo";
            this.txtPlayerInfo.ReadOnly = true;
            this.txtPlayerInfo.Size = new System.Drawing.Size(258, 94);
            this.txtPlayerInfo.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // lstFreePlayers
            // 
            this.lstFreePlayers.FormattingEnabled = true;
            this.lstFreePlayers.Location = new System.Drawing.Point(9, 8);
            this.lstFreePlayers.Name = "lstFreePlayers";
            this.lstFreePlayers.Size = new System.Drawing.Size(485, 251);
            this.lstFreePlayers.TabIndex = 54;
            this.lstFreePlayers.SelectedIndexChanged += new System.EventHandler(this.ListSelectEvent);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(429, 354);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(65, 28);
            this.btnQuit.TabIndex = 55;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FreePlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 394);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lstFreePlayers);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlayerInfo);
            this.Name = "FreePlayersForm";
            this.Text = "Free Players List";
            this.Load += new System.EventHandler(this.FreePlayersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlayerInfo;
        private System.Windows.Forms.ListBox lstFreePlayers;
        private System.Windows.Forms.Button btnQuit;
    }
}