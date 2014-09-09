namespace WinFormDSSimulator
{
    partial class FixtureForm
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
            this.txtFixture = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFixture
            // 
            this.txtFixture.Location = new System.Drawing.Point(12, 12);
            this.txtFixture.Multiline = true;
            this.txtFixture.Name = "txtFixture";
            this.txtFixture.ReadOnly = true;
            this.txtFixture.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFixture.Size = new System.Drawing.Size(247, 410);
            this.txtFixture.TabIndex = 7;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(161, 428);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(98, 34);
            this.btnQuit.TabIndex = 23;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FixtureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 470);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtFixture);
            this.Name = "FixtureForm";
            this.Text = "Season Fixture";
            this.Load += new System.EventHandler(this.FixtureForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFixture;
        private System.Windows.Forms.Button btnQuit;
    }
}