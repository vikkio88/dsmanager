namespace WinFormDSSimulator.marketDialogForms
{
    partial class SpeakWithPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeakWithPlayer));
            this.btnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtOffer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayerInfo = new System.Windows.Forms.TextBox();
            this.btnChangeOffer = new System.Windows.Forms.Button();
            this.txtNewOff = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpNewOffer = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpNewOffer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(248, 270);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(112, 50);
            this.btnReject.TabIndex = 50;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(12, 270);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(112, 50);
            this.btnAccept.TabIndex = 49;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtOffer
            // 
            this.txtOffer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOffer.Location = new System.Drawing.Point(10, 145);
            this.txtOffer.Multiline = true;
            this.txtOffer.Name = "txtOffer";
            this.txtOffer.ReadOnly = true;
            this.txtOffer.Size = new System.Drawing.Size(435, 33);
            this.txtOffer.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Player Request";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Player Info";
            // 
            // txtPlayerInfo
            // 
            this.txtPlayerInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPlayerInfo.Location = new System.Drawing.Point(125, 26);
            this.txtPlayerInfo.Multiline = true;
            this.txtPlayerInfo.Name = "txtPlayerInfo";
            this.txtPlayerInfo.ReadOnly = true;
            this.txtPlayerInfo.Size = new System.Drawing.Size(258, 94);
            this.txtPlayerInfo.TabIndex = 44;
            // 
            // btnChangeOffer
            // 
            this.btnChangeOffer.Location = new System.Drawing.Point(130, 270);
            this.btnChangeOffer.Name = "btnChangeOffer";
            this.btnChangeOffer.Size = new System.Drawing.Size(112, 50);
            this.btnChangeOffer.TabIndex = 51;
            this.btnChangeOffer.Text = "Change offer";
            this.btnChangeOffer.UseVisualStyleBackColor = true;
            this.btnChangeOffer.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNewOff
            // 
            this.txtNewOff.Location = new System.Drawing.Point(23, 28);
            this.txtNewOff.Name = "txtNewOff";
            this.txtNewOff.Size = new System.Drawing.Size(39, 20);
            this.txtNewOff.TabIndex = 52;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(12, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(13, 23);
            this.button3.TabIndex = 54;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "M €";
            // 
            // grpNewOffer
            // 
            this.grpNewOffer.Controls.Add(this.btnSend);
            this.grpNewOffer.Controls.Add(this.txtNewOff);
            this.grpNewOffer.Controls.Add(this.button2);
            this.grpNewOffer.Controls.Add(this.label2);
            this.grpNewOffer.Controls.Add(this.button3);
            this.grpNewOffer.Enabled = false;
            this.grpNewOffer.Location = new System.Drawing.Point(13, 185);
            this.grpNewOffer.Name = "grpNewOffer";
            this.grpNewOffer.Size = new System.Drawing.Size(177, 65);
            this.grpNewOffer.TabIndex = 57;
            this.grpNewOffer.TabStop = false;
            this.grpNewOffer.Text = "New Offer";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(112, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(57, 50);
            this.btnSend.TabIndex = 58;
            this.btnSend.Text = "Send Offer";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // SpeakWithPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 342);
            this.Controls.Add(this.grpNewOffer);
            this.Controls.Add(this.btnChangeOffer);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtOffer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlayerInfo);
            this.Name = "SpeakWithPlayer";
            this.Text = "Speak with Player";
            this.Load += new System.EventHandler(this.SpeakWithPlayer_Load);
            this.grpNewOffer.ResumeLayout(false);
            this.grpNewOffer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtOffer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlayerInfo;
        private System.Windows.Forms.Button btnChangeOffer;
        private System.Windows.Forms.TextBox txtNewOff;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpNewOffer;
        private System.Windows.Forms.Button btnSend;
    }
}