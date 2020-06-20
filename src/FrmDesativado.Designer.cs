namespace Projeto_AppEstudos_TCC
{
    partial class FrmDesativado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDesativado));
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.painelCPF = new System.Windows.Forms.Panel();
            this.pbCPF = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.painelEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEnviarSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCPF.ForeColor = System.Drawing.Color.DimGray;
            this.txtCPF.Location = new System.Drawing.Point(125, 99);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(148, 16);
            this.txtCPF.TabIndex = 101;
            this.txtCPF.Enter += new System.EventHandler(this.txtCPF_Enter);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCPF.Location = new System.Drawing.Point(120, 78);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 20);
            this.lblCPF.TabIndex = 100;
            this.lblCPF.Text = "CPF";
            // 
            // painelCPF
            // 
            this.painelCPF.BackColor = System.Drawing.SystemColors.Control;
            this.painelCPF.Location = new System.Drawing.Point(123, 118);
            this.painelCPF.Name = "painelCPF";
            this.painelCPF.Size = new System.Drawing.Size(150, 1);
            this.painelCPF.TabIndex = 98;
            // 
            // pbCPF
            // 
            this.pbCPF.Image = ((System.Drawing.Image)(resources.GetObject("pbCPF.Image")));
            this.pbCPF.Location = new System.Drawing.Point(87, 74);
            this.pbCPF.Name = "pbCPF";
            this.pbCPF.Size = new System.Drawing.Size(27, 25);
            this.pbCPF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCPF.TabIndex = 99;
            this.pbCPF.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(122, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 109;
            this.lblEmail.Text = "Email";
            // 
            // pbEmail
            // 
            this.pbEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbEmail.Image")));
            this.pbEmail.Location = new System.Drawing.Point(87, 148);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(27, 25);
            this.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmail.TabIndex = 108;
            this.pbEmail.TabStop = false;
            // 
            // painelEmail
            // 
            this.painelEmail.BackColor = System.Drawing.SystemColors.Control;
            this.painelEmail.Location = new System.Drawing.Point(123, 191);
            this.painelEmail.Name = "painelEmail";
            this.painelEmail.Size = new System.Drawing.Size(150, 1);
            this.painelEmail.TabIndex = 107;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(128, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 16);
            this.txtEmail.TabIndex = 106;
            this.txtEmail.Tag = "";
            this.txtEmail.Text = "Ex: example@live.com";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(331, 242);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(89, 36);
            this.btnVoltar.TabIndex = 110;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(24, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(399, 49);
            this.lblTitulo.TabIndex = 112;
            this.lblTitulo.Text = "Usuário Desativado";
            // 
            // btnEnviarSenha
            // 
            this.btnEnviarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.btnEnviarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnEnviarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarSenha.Location = new System.Drawing.Point(116, 211);
            this.btnEnviarSenha.Name = "btnEnviarSenha";
            this.btnEnviarSenha.Size = new System.Drawing.Size(159, 36);
            this.btnEnviarSenha.TabIndex = 113;
            this.btnEnviarSenha.Text = "Enviar Senha";
            this.btnEnviarSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviarSenha.UseVisualStyleBackColor = false;
            this.btnEnviarSenha.Click += new System.EventHandler(this.btnEnviarSenha_Click);
            // 
            // FrmDesativado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(420, 281);
            this.Controls.Add(this.btnEnviarSenha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pbEmail);
            this.Controls.Add(this.painelEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.pbCPF);
            this.Controls.Add(this.painelCPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDesativado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classroom";
            this.Load += new System.EventHandler(this.FrmDesativado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.PictureBox pbCPF;
        private System.Windows.Forms.Panel painelCPF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.Panel painelEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEnviarSenha;
    }
}