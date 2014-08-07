using System.ComponentModel;
namespace DsManager
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.playerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerSurnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillAvgDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerNameDataGridViewTextBoxColumn,
            this.playerSurnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.skillAvgDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.valDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 257);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(582, 264);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Acquista";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soldi Disponibili:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "M €";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(519, 273);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(19, 13);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "90";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerNameDataGridViewTextBoxColumn1,
            this.playerSurnameDataGridViewTextBoxColumn1,
            this.ageDataGridViewTextBoxColumn1,
            this.skillAvgDataGridViewTextBoxColumn1,
            this.nationalityDataGridViewTextBoxColumn1,
            this.valDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.playerBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(16, 302);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(641, 322);
            this.dataGridView2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Informazioni Squadra";
            // 
            // playerNameDataGridViewTextBoxColumn1
            // 
            this.playerNameDataGridViewTextBoxColumn1.DataPropertyName = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.playerNameDataGridViewTextBoxColumn1.Name = "playerNameDataGridViewTextBoxColumn1";
            // 
            // playerSurnameDataGridViewTextBoxColumn1
            // 
            this.playerSurnameDataGridViewTextBoxColumn1.DataPropertyName = "PlayerSurname";
            this.playerSurnameDataGridViewTextBoxColumn1.HeaderText = "Cognome";
            this.playerSurnameDataGridViewTextBoxColumn1.Name = "playerSurnameDataGridViewTextBoxColumn1";
            // 
            // ageDataGridViewTextBoxColumn1
            // 
            this.ageDataGridViewTextBoxColumn1.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn1.HeaderText = "Etá";
            this.ageDataGridViewTextBoxColumn1.Name = "ageDataGridViewTextBoxColumn1";
            // 
            // skillAvgDataGridViewTextBoxColumn1
            // 
            this.skillAvgDataGridViewTextBoxColumn1.DataPropertyName = "SkillAvg";
            this.skillAvgDataGridViewTextBoxColumn1.HeaderText = "Media %";
            this.skillAvgDataGridViewTextBoxColumn1.Name = "skillAvgDataGridViewTextBoxColumn1";
            // 
            // nationalityDataGridViewTextBoxColumn1
            // 
            this.nationalityDataGridViewTextBoxColumn1.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn1.HeaderText = "Nationalitá";
            this.nationalityDataGridViewTextBoxColumn1.Name = "nationalityDataGridViewTextBoxColumn1";
            // 
            // valDataGridViewTextBoxColumn1
            // 
            this.valDataGridViewTextBoxColumn1.DataPropertyName = "Val";
            this.valDataGridViewTextBoxColumn1.HeaderText = "Valore M€";
            this.valDataGridViewTextBoxColumn1.Name = "valDataGridViewTextBoxColumn1";
            // 
            // playerBindingSource1
            // 
            this.playerBindingSource1.DataSource = typeof(DsManager.Models.Player);
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.Frozen = true;
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            this.playerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerSurnameDataGridViewTextBoxColumn
            // 
            this.playerSurnameDataGridViewTextBoxColumn.DataPropertyName = "PlayerSurname";
            this.playerSurnameDataGridViewTextBoxColumn.Frozen = true;
            this.playerSurnameDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.playerSurnameDataGridViewTextBoxColumn.Name = "playerSurnameDataGridViewTextBoxColumn";
            this.playerSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.Frozen = true;
            this.ageDataGridViewTextBoxColumn.HeaderText = "Etá";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // skillAvgDataGridViewTextBoxColumn
            // 
            this.skillAvgDataGridViewTextBoxColumn.DataPropertyName = "SkillAvg";
            this.skillAvgDataGridViewTextBoxColumn.Frozen = true;
            this.skillAvgDataGridViewTextBoxColumn.HeaderText = "Media %";
            this.skillAvgDataGridViewTextBoxColumn.Name = "skillAvgDataGridViewTextBoxColumn";
            this.skillAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.Frozen = true;
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationalitá";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valDataGridViewTextBoxColumn
            // 
            this.valDataGridViewTextBoxColumn.DataPropertyName = "Val";
            this.valDataGridViewTextBoxColumn.HeaderText = "Prezzo (M €)";
            this.valDataGridViewTextBoxColumn.Name = "valDataGridViewTextBoxColumn";
            this.valDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(DsManager.Models.Player);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 660);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerSurnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillAvgDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource playerBindingSource1;
        private System.Windows.Forms.Label label3;
    }
}

