namespace Projeto_AppEstudos_TCC
{
    partial class FrmExcluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExcluir));
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtSenha_Excluir = new System.Windows.Forms.TextBox();
            this.painelSenha = new System.Windows.Forms.Panel();
            this.txtMensagem_Excluir = new System.Windows.Forms.TextBox();
            this.painelMensagem = new System.Windows.Forms.Panel();
            this.painelEsquerdo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(34, 38);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(129, 20);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Digite sua Senha";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblMensagem.ForeColor = System.Drawing.Color.White;
            this.lblMensagem.Location = new System.Drawing.Point(35, 120);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(142, 20);
            this.lblMensagem.TabIndex = 1;
            this.lblMensagem.Text = "Diga-nos o motivo";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(49, 344);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(159, 36);
            this.btnExcluir.TabIndex = 48;
            this.btnExcluir.Text = "Confirmar Exclusão";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(214, 344);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(159, 36);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtSenha_Excluir
            // 
            this.txtSenha_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtSenha_Excluir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha_Excluir.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtSenha_Excluir.ForeColor = System.Drawing.Color.DimGray;
            this.txtSenha_Excluir.Location = new System.Drawing.Point(50, 64);
            this.txtSenha_Excluir.Name = "txtSenha_Excluir";
            this.txtSenha_Excluir.Size = new System.Drawing.Size(184, 18);
            this.txtSenha_Excluir.TabIndex = 68;
            this.txtSenha_Excluir.Tag = "";
            this.txtSenha_Excluir.Text = "Senha";
            this.txtSenha_Excluir.UseSystemPasswordChar = true;
            this.txtSenha_Excluir.Enter += new System.EventHandler(this.txtSenha_Excluir_Enter);
            this.txtSenha_Excluir.Leave += new System.EventHandler(this.txtSenha_Excluir_Leave);
            // 
            // painelSenha
            // 
            this.painelSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.painelSenha.Location = new System.Drawing.Point(48, 84);
            this.painelSenha.Name = "painelSenha";
            this.painelSenha.Size = new System.Drawing.Size(172, 1);
            this.painelSenha.TabIndex = 82;
            // 
            // txtMensagem_Excluir
            // 
            this.txtMensagem_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtMensagem_Excluir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensagem_Excluir.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtMensagem_Excluir.ForeColor = System.Drawing.Color.DimGray;
            this.txtMensagem_Excluir.Location = new System.Drawing.Point(64, 156);
            this.txtMensagem_Excluir.Multiline = true;
            this.txtMensagem_Excluir.Name = "txtMensagem_Excluir";
            this.txtMensagem_Excluir.Size = new System.Drawing.Size(302, 156);
            this.txtMensagem_Excluir.TabIndex = 83;
            this.txtMensagem_Excluir.Tag = "";
            this.txtMensagem_Excluir.Text = "Escreva aqui...";
            this.txtMensagem_Excluir.UseSystemPasswordChar = true;
            this.txtMensagem_Excluir.Enter += new System.EventHandler(this.txtMensagem_Excluir_Enter);
            this.txtMensagem_Excluir.Leave += new System.EventHandler(this.txtMensagem_Excluir_Leave);
            // 
            // painelMensagem
            // 
            this.painelMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.painelMensagem.Location = new System.Drawing.Point(74, 318);
            this.painelMensagem.Name = "painelMensagem";
            this.painelMensagem.Size = new System.Drawing.Size(276, 1);
            this.painelMensagem.TabIndex = 84;
            // 
            // painelEsquerdo
            // 
            this.painelEsquerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.painelEsquerdo.Location = new System.Drawing.Point(-1, -2);
            this.painelEsquerdo.Name = "painelEsquerdo";
            this.painelEsquerdo.Size = new System.Drawing.Size(30, 414);
            this.painelEsquerdo.TabIndex = 85;
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(403, 410);
            this.Controls.Add(this.painelEsquerdo);
            this.Controls.Add(this.painelMensagem);
            this.Controls.Add(this.txtMensagem_Excluir);
            this.Controls.Add(this.painelSenha);
            this.Controls.Add(this.txtSenha_Excluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Excluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classroom";
            this.Load += new System.EventHandler(this.Excluir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtSenha_Excluir;
        private System.Windows.Forms.Panel painelSenha;
        private System.Windows.Forms.TextBox txtMensagem_Excluir;
        private System.Windows.Forms.Panel painelMensagem;
        private System.Windows.Forms.Panel painelEsquerdo;
    }
}