namespace WinFormDSSimulator
{
    partial class SpeakWithCoachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeakWithCoachForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCoachInfo = new System.Windows.Forms.TextBox();
            this.txtCoachWords = new System.Windows.Forms.TextBox();
            this.btnGoodJob = new System.Windows.Forms.Button();
            this.btnIwantMore = new System.Windows.Forms.Button();
            this.btnChangeModule = new System.Windows.Forms.Button();
            this.btnFireCoach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Coach Info";
            // 
            // txtCoachInfo
            // 
            this.txtCoachInfo.Location = new System.Drawing.Point(127, 22);
            this.txtCoachInfo.Multiline = true;
            this.txtCoachInfo.Name = "txtCoachInfo";
            this.txtCoachInfo.ReadOnly = true;
            this.txtCoachInfo.Size = new System.Drawing.Size(309, 133);
            this.txtCoachInfo.TabIndex = 6;
            // 
            // txtCoachWords
            // 
            this.txtCoachWords.Location = new System.Drawing.Point(15, 171);
            this.txtCoachWords.Multiline = true;
            this.txtCoachWords.Name = "txtCoachWords";
            this.txtCoachWords.ReadOnly = true;
            this.txtCoachWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCoachWords.Size = new System.Drawing.Size(421, 122);
            this.txtCoachWords.TabIndex = 8;
            // 
            // btnGoodJob
            // 
            this.btnGoodJob.Location = new System.Drawing.Point(15, 314);
            this.btnGoodJob.Name = "btnGoodJob";
            this.btnGoodJob.Size = new System.Drawing.Size(112, 50);
            this.btnGoodJob.TabIndex = 18;
            this.btnGoodJob.Text = "Good Job!";
            this.btnGoodJob.UseVisualStyleBackColor = true;
            this.btnGoodJob.Click += new System.EventHandler(this.btnGoodJob_Click);
            // 
            // btnIwantMore
            // 
            this.btnIwantMore.Location = new System.Drawing.Point(133, 314);
            this.btnIwantMore.Name = "btnIwantMore";
            this.btnIwantMore.Size = new System.Drawing.Size(112, 50);
            this.btnIwantMore.TabIndex = 19;
            this.btnIwantMore.Text = "I want more!";
            this.btnIwantMore.UseVisualStyleBackColor = true;
            this.btnIwantMore.Click += new System.EventHandler(this.btnIwantMore_Click);
            // 
            // btnChangeModule
            // 
            this.btnChangeModule.Location = new System.Drawing.Point(251, 314);
            this.btnChangeModule.Name = "btnChangeModule";
            this.btnChangeModule.Size = new System.Drawing.Size(112, 50);
            this.btnChangeModule.TabIndex = 20;
            this.btnChangeModule.Text = "Change Module";
            this.btnChangeModule.UseVisualStyleBackColor = true;
            this.btnChangeModule.Click += new System.EventHandler(this.btnChangeModule_Click);
            // 
            // btnFireCoach
            // 
            this.btnFireCoach.Location = new System.Drawing.Point(369, 314);
            this.btnFireCoach.Name = "btnFireCoach";
            this.btnFireCoach.Size = new System.Drawing.Size(67, 50);
            this.btnFireCoach.TabIndex = 21;
            this.btnFireCoach.Text = "Fire him";
            this.btnFireCoach.UseVisualStyleBackColor = true;
            this.btnFireCoach.Click += new System.EventHandler(this.btnFireCoach_Click);
            // 
            // SpeakWithCoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 376);
            this.Controls.Add(this.btnFireCoach);
            this.Controls.Add(this.btnChangeModule);
            this.Controls.Add(this.btnIwantMore);
            this.Controls.Add(this.btnGoodJob);
            this.Controls.Add(this.txtCoachWords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCoachInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SpeakWithCoachForm";
            this.Text = "Speak With Coach";
            this.Load += new System.EventHandler(this.SpeakWithCoachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCoachInfo;
        private System.Windows.Forms.TextBox txtCoachWords;
        private System.Windows.Forms.Button btnGoodJob;
        private System.Windows.Forms.Button btnIwantMore;
        private System.Windows.Forms.Button btnChangeModule;
        private System.Windows.Forms.Button btnFireCoach;
    }
}