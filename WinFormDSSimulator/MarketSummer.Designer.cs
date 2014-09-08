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
            this.SuspendLayout();
            // 
            // txtEvents
            // 
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
            this.btnMyTeam.Enabled = false;
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
            this.pnlMainMarket.Location = new System.Drawing.Point(4, 2);
            this.pnlMainMarket.Name = "pnlMainMarket";
            this.pnlMainMarket.Size = new System.Drawing.Size(579, 410);
            this.pnlMainMarket.TabIndex = 16;
            this.pnlMainMarket.Visible = false;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMyTeam;
        private System.Windows.Forms.Panel pnlMainMarket;
    }
}