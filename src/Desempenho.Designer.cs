namespace Projeto_AppEstudos_TCC
{
    partial class Desempenho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desempenho));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.painelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblMateria = new System.Windows.Forms.Label();
            this.dgDesempenho = new System.Windows.Forms.DataGridView();
            this.amateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERGUNTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACERTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.painelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDesempenho)).BeginInit();
            this.SuspendLayout();
            // 
            // painelTitulo
            // 
            this.painelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.painelTitulo.Controls.Add(this.lblTitulo);
            this.painelTitulo.Controls.Add(this.btnFechar);
            this.painelTitulo.Location = new System.Drawing.Point(-2, -1);
            this.painelTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.painelTitulo.Name = "painelTitulo";
            this.painelTitulo.Size = new System.Drawing.Size(870, 41);
            this.painelTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(357, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 23);
            this.lblTitulo.TabIndex = 46;
            this.lblTitulo.Text = "Desempenho";
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(841, 10);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(21, 23);
            this.btnFechar.TabIndex = 45;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Items.AddRange(new object[] {
            "Geral",
            "Matemática",
            "Ciências da Natureza",
            "Ciências Humanas",
            "Linguagens"});
            this.cbMateria.Location = new System.Drawing.Point(339, 103);
            this.cbMateria.Margin = new System.Windows.Forms.Padding(2);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(148, 21);
            this.cbMateria.TabIndex = 1;
            // 
            // btnExibir
            // 
            this.btnExibir.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnExibir.Location = new System.Drawing.Point(538, 93);
            this.btnExibir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(112, 37);
            this.btnExibir.TabIndex = 3;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblMateria.Location = new System.Drawing.Point(303, 81);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(71, 20);
            this.lblMateria.TabIndex = 5;
            this.lblMateria.Text = "Matéria:";
            // 
            // dgDesempenho
            // 
            this.dgDesempenho.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgDesempenho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDesempenho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDesempenho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amateria,
            this.DATA,
            this.PERGUNTAS,
            this.ACERTOS});
            this.dgDesempenho.Location = new System.Drawing.Point(101, 227);
            this.dgDesempenho.Name = "dgDesempenho";
            this.dgDesempenho.Size = new System.Drawing.Size(682, 216);
            this.dgDesempenho.TabIndex = 7;
            // 
            // amateria
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.amateria.DefaultCellStyle = dataGridViewCellStyle1;
            this.amateria.HeaderText = "MATERIA";
            this.amateria.Name = "amateria";
            this.amateria.ReadOnly = true;
            this.amateria.Width = 160;
            // 
            // DATA
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.DATA.DefaultCellStyle = dataGridViewCellStyle2;
            this.DATA.HeaderText = "DATA DO TESTE";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 160;
            // 
            // PERGUNTAS
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.PERGUNTAS.DefaultCellStyle = dataGridViewCellStyle3;
            this.PERGUNTAS.HeaderText = "PERGUNTAS RESPONDIDAS";
            this.PERGUNTAS.Name = "PERGUNTAS";
            this.PERGUNTAS.ReadOnly = true;
            this.PERGUNTAS.Width = 160;
            // 
            // ACERTOS
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.ACERTOS.DefaultCellStyle = dataGridViewCellStyle4;
            this.ACERTOS.HeaderText = "ACERTOS";
            this.ACERTOS.Name = "ACERTOS";
            this.ACERTOS.ReadOnly = true;
            this.ACERTOS.Width = 160;
            // 
            // Desempenho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 455);
            this.Controls.Add(this.dgDesempenho);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.painelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Desempenho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desempenho";
            this.Load += new System.EventHandler(this.Desempenho_Load);
            this.painelTitulo.ResumeLayout(false);
            this.painelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDesempenho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelTitulo;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.DataGridView dgDesempenho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn amateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERGUNTAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACERTOS;
    }
}