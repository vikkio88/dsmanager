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
            // FixtureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 433);
            this.Controls.Add(this.txtFixture);
            this.Name = "FixtureForm";
            this.Text = "Season Fixture";
            this.Load += new System.EventHandler(this.FixtureForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFixture;
    }
}