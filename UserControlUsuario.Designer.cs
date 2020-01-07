namespace Projeto_AppEstudos_TCC
{
    partial class UserControlUsuario
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.btnAlterarUsuario = new System.Windows.Forms.Button();
            this.btnDesempenho = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnEnviarFoto = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.btnExcluirUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirUsuario.FlatAppearance.BorderSize = 0;
            this.btnExcluirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUsuario.ForeColor = System.Drawing.Color.White;
            this.btnExcluirUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirUsuario.Location = new System.Drawing.Point(230, 307);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(159, 36);
            this.btnExcluirUsuario.TabIndex = 48;
            this.btnExcluirUsuario.Text = "Excluir Conta";
            this.btnExcluirUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirUsuario.UseVisualStyleBackColor = false;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // btnAlterarUsuario
            // 
            this.btnAlterarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.btnAlterarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAlterarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAlterarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarUsuario.Location = new System.Drawing.Point(47, 364);
            this.btnAlterarUsuario.Name = "btnAlterarUsuario";
            this.btnAlterarUsuario.Size = new System.Drawing.Size(159, 36);
            this.btnAlterarUsuario.TabIndex = 46;
            this.btnAlterarUsuario.Text = "Alterar Dados";
            this.btnAlterarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarUsuario.UseVisualStyleBackColor = false;
            this.btnAlterarUsuario.Click += new System.EventHandler(this.btnAlterarUsuario_Click);
            // 
            // btnDesempenho
            // 
            this.btnDesempenho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.btnDesempenho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesempenho.FlatAppearance.BorderSize = 0;
            this.btnDesempenho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesempenho.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesempenho.ForeColor = System.Drawing.Color.White;
            this.btnDesempenho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesempenho.Location = new System.Drawing.Point(47, 307);
            this.btnDesempenho.Name = "btnDesempenho";
            this.btnDesempenho.Size = new System.Drawing.Size(159, 36);
            this.btnDesempenho.TabIndex = 49;
            this.btnDesempenho.Text = "Desempenho";
            this.btnDesempenho.UseVisualStyleBackColor = false;
            this.btnDesempenho.Click += new System.EventHandler(this.btnDesempenho_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl1.Location = new System.Drawing.Point(124, 111);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(57, 20);
            this.lbl1.TabIndex = 50;
            this.lbl1.Text = "Nome:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl2.Location = new System.Drawing.Point(112, 137);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(67, 20);
            this.lbl2.TabIndex = 51;
            this.lbl2.Text = "Usuário:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl3.Location = new System.Drawing.Point(122, 166);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(57, 20);
            this.lbl3.TabIndex = 52;
            this.lbl3.Text = "E-Mail:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl4.Location = new System.Drawing.Point(52, 196);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(129, 20);
            this.lbl4.TabIndex = 53;
            this.lbl4.Text = "Curso Desejado:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblNome.Location = new System.Drawing.Point(191, 111);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 54;
            this.lblNome.Text = "label5";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblUsuario.Location = new System.Drawing.Point(191, 137);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 20);
            this.lblUsuario.TabIndex = 55;
            this.lblUsuario.Text = "label6";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblEmail.Location = new System.Drawing.Point(191, 166);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 56;
            this.lblEmail.Text = "label7";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblCurso.Location = new System.Drawing.Point(191, 196);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(53, 20);
            this.lblCurso.TabIndex = 57;
            this.lblCurso.Text = "label8";
            // 
            // btnEnviarFoto
            // 
            this.btnEnviarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.btnEnviarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarFoto.FlatAppearance.BorderSize = 0;
            this.btnEnviarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarFoto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarFoto.ForeColor = System.Drawing.Color.White;
            this.btnEnviarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarFoto.Location = new System.Drawing.Point(538, 206);
            this.btnEnviarFoto.Name = "btnEnviarFoto";
            this.btnEnviarFoto.Size = new System.Drawing.Size(136, 32);
            this.btnEnviarFoto.TabIndex = 60;
            this.btnEnviarFoto.Text = "Atualizar Foto";
            this.btnEnviarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviarFoto.UseVisualStyleBackColor = false;
            this.btnEnviarFoto.Click += new System.EventHandler(this.btnEnviarFoto_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(39, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(482, 47);
            this.lblTitulo.TabIndex = 62;
            this.lblTitulo.Text = "Informações do Usuário";
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.btnDeslogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeslogar.FlatAppearance.BorderSize = 0;
            this.btnDeslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeslogar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeslogar.ForeColor = System.Drawing.Color.White;
            this.btnDeslogar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeslogar.Location = new System.Drawing.Point(230, 364);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(159, 36);
            this.btnDeslogar.TabIndex = 47;
            this.btnDeslogar.Text = "Deslogar";
            this.btnDeslogar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeslogar.UseVisualStyleBackColor = false;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // pcbFoto
            // 
            this.pcbFoto.Image = global::Projeto_AppEstudos_TCC.Properties.Resources.usuario;
            this.pcbFoto.Location = new System.Drawing.Point(545, 77);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(122, 123);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 61;
            this.pcbFoto.TabStop = false;
            // 
            // UserControlUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.btnEnviarFoto);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnDesempenho);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.btnDeslogar);
            this.Controls.Add(this.btnAlterarUsuario);
            this.Name = "UserControlUsuario";
            this.Size = new System.Drawing.Size(799, 420);
            this.Load += new System.EventHandler(this.UserControlUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Button btnAlterarUsuario;
        private System.Windows.Forms.Button btnDesempenho;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnEnviarFoto;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnDeslogar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
