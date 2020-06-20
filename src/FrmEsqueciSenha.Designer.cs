namespace Projeto_AppEstudos_TCC
{
    partial class FrmEsqueciSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEsqueciSenha));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEnviarSenha = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.painelEmail = new System.Windows.Forms.Panel();
            this.txtEmail_EsqueceuSenha = new System.Windows.Forms.TextBox();
            this.painelUsuario = new System.Windows.Forms.Panel();
            this.txtUsuario_EsqueceuSenha = new System.Windows.Forms.TextBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(324, 215);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(89, 36);
            this.btnVoltar.TabIndex = 53;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnEnviarSenha
            // 
            this.btnEnviarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.btnEnviarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnEnviarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarSenha.Location = new System.Drawing.Point(119, 175);
            this.btnEnviarSenha.Name = "btnEnviarSenha";
            this.btnEnviarSenha.Size = new System.Drawing.Size(159, 36);
            this.btnEnviarSenha.TabIndex = 50;
            this.btnEnviarSenha.Text = "Enviar Senha";
            this.btnEnviarSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviarSenha.UseVisualStyleBackColor = false;
            this.btnEnviarSenha.Click += new System.EventHandler(this.btnEnviarSenha_Click_1);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(41, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(344, 49);
            this.lblTitulo.TabIndex = 41;
            this.lblTitulo.Text = "Esqueceu Senha";
            // 
            // pbEmail
            // 
            this.pbEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbEmail.Image")));
            this.pbEmail.Location = new System.Drawing.Point(90, 129);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(27, 25);
            this.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmail.TabIndex = 76;
            this.pbEmail.TabStop = false;
            // 
            // painelEmail
            // 
            this.painelEmail.BackColor = System.Drawing.Color.White;
            this.painelEmail.Location = new System.Drawing.Point(121, 152);
            this.painelEmail.Name = "painelEmail";
            this.painelEmail.Size = new System.Drawing.Size(150, 1);
            this.painelEmail.TabIndex = 75;
            // 
            // txtEmail_EsqueceuSenha
            // 
            this.txtEmail_EsqueceuSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtEmail_EsqueceuSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail_EsqueceuSenha.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtEmail_EsqueceuSenha.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail_EsqueceuSenha.Location = new System.Drawing.Point(127, 132);
            this.txtEmail_EsqueceuSenha.Name = "txtEmail_EsqueceuSenha";
            this.txtEmail_EsqueceuSenha.Size = new System.Drawing.Size(163, 18);
            this.txtEmail_EsqueceuSenha.TabIndex = 74;
            this.txtEmail_EsqueceuSenha.Tag = "";
            this.txtEmail_EsqueceuSenha.Text = "E-Mail";
            this.txtEmail_EsqueceuSenha.Enter += new System.EventHandler(this.txtEMail_Enter);
            this.txtEmail_EsqueceuSenha.Leave += new System.EventHandler(this.txtEMail_Leave);
            // 
            // painelUsuario
            // 
            this.painelUsuario.BackColor = System.Drawing.Color.White;
            this.painelUsuario.Location = new System.Drawing.Point(121, 110);
            this.painelUsuario.Name = "painelUsuario";
            this.painelUsuario.Size = new System.Drawing.Size(150, 1);
            this.painelUsuario.TabIndex = 78;
            // 
            // txtUsuario_EsqueceuSenha
            // 
            this.txtUsuario_EsqueceuSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtUsuario_EsqueceuSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario_EsqueceuSenha.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtUsuario_EsqueceuSenha.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario_EsqueceuSenha.Location = new System.Drawing.Point(127, 90);
            this.txtUsuario_EsqueceuSenha.Name = "txtUsuario_EsqueceuSenha";
            this.txtUsuario_EsqueceuSenha.Size = new System.Drawing.Size(163, 18);
            this.txtUsuario_EsqueceuSenha.TabIndex = 77;
            this.txtUsuario_EsqueceuSenha.Tag = "";
            this.txtUsuario_EsqueceuSenha.Text = "Usuário";
            this.txtUsuario_EsqueceuSenha.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario_EsqueceuSenha.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(91, 86);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(27, 25);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 80;
            this.pbUser.TabStop = false;
            // 
            // FrmEsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(415, 253);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.painelUsuario);
            this.Controls.Add(this.txtUsuario_EsqueceuSenha);
            this.Controls.Add(this.pbEmail);
            this.Controls.Add(this.painelEmail);
            this.Controls.Add(this.txtEmail_EsqueceuSenha);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEnviarSenha);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEsqueciSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classroom";
            this.Load += new System.EventHandler(this.FrmEsqueciSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEnviarSenha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.Panel painelEmail;
        private System.Windows.Forms.TextBox txtEmail_EsqueceuSenha;
        private System.Windows.Forms.Panel painelUsuario;
        private System.Windows.Forms.TextBox txtUsuario_EsqueceuSenha;
        private System.Windows.Forms.PictureBox pbUser;
    }
}