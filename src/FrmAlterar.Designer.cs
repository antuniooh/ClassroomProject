namespace Projeto_AppEstudos_TCC
{
    partial class FrmAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterar));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.painelCurso = new System.Windows.Forms.Panel();
            this.txtSenhaAtual_Alterar = new System.Windows.Forms.TextBox();
            this.painelUser = new System.Windows.Forms.Panel();
            this.cbCurso_Alterar = new System.Windows.Forms.ComboBox();
            this.txtConfSenha_Alterar = new System.Windows.Forms.TextBox();
            this.painelConfirmSenha = new System.Windows.Forms.Panel();
            this.painelNome = new System.Windows.Forms.Panel();
            this.txtNome_Alterar = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.painelNovaSenha = new System.Windows.Forms.Panel();
            this.txtSenha_Alterar = new System.Windows.Forms.TextBox();
            this.painelSenha = new System.Windows.Forms.Panel();
            this.txtUsuario_Alterar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSenha = new System.Windows.Forms.Button();
            this.btnConfSenha = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();
            this.btnNome = new System.Windows.Forms.Button();
            this.btnNovaSenha = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblConfirmSenha = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.painelEmail = new System.Windows.Forms.Panel();
            this.txtEmail_Alterar = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.painelTopo = new System.Windows.Forms.Panel();
            this.painelBaixo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            this.btnCancelar.Location = new System.Drawing.Point(400, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(159, 36);
            this.btnCancelar.TabIndex = 85;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // painelCurso
            // 
            this.painelCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.painelCurso.Location = new System.Drawing.Point(435, 296);
            this.painelCurso.Name = "painelCurso";
            this.painelCurso.Size = new System.Drawing.Size(198, 1);
            this.painelCurso.TabIndex = 84;
            // 
            // txtSenhaAtual_Alterar
            // 
            this.txtSenhaAtual_Alterar.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenhaAtual_Alterar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaAtual_Alterar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtSenhaAtual_Alterar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSenhaAtual_Alterar.Location = new System.Drawing.Point(206, 201);
            this.txtSenhaAtual_Alterar.Name = "txtSenhaAtual_Alterar";
            this.txtSenhaAtual_Alterar.Size = new System.Drawing.Size(184, 18);
            this.txtSenhaAtual_Alterar.TabIndex = 83;
            this.txtSenhaAtual_Alterar.Tag = "";
            this.txtSenhaAtual_Alterar.UseSystemPasswordChar = true;
            // 
            // painelUser
            // 
            this.painelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.painelUser.Location = new System.Drawing.Point(428, 162);
            this.painelUser.Name = "painelUser";
            this.painelUser.Size = new System.Drawing.Size(172, 1);
            this.painelUser.TabIndex = 81;
            // 
            // cbCurso_Alterar
            // 
            this.cbCurso_Alterar.BackColor = System.Drawing.SystemColors.Control;
            this.cbCurso_Alterar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurso_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCurso_Alterar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cbCurso_Alterar.FormattingEnabled = true;
            this.cbCurso_Alterar.Items.AddRange(new object[] {
            "Publicidade",
            "Engenharia Civil",
            "Administração",
            "Letras",
            "Economia",
            "Psicologia",
            "Direito",
            "Medicina",
            "Ciência da Computação"});
            this.cbCurso_Alterar.Location = new System.Drawing.Point(435, 265);
            this.cbCurso_Alterar.Margin = new System.Windows.Forms.Padding(2);
            this.cbCurso_Alterar.Name = "cbCurso_Alterar";
            this.cbCurso_Alterar.Size = new System.Drawing.Size(200, 28);
            this.cbCurso_Alterar.TabIndex = 80;
            // 
            // txtConfSenha_Alterar
            // 
            this.txtConfSenha_Alterar.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfSenha_Alterar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfSenha_Alterar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtConfSenha_Alterar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtConfSenha_Alterar.Location = new System.Drawing.Point(206, 333);
            this.txtConfSenha_Alterar.Name = "txtConfSenha_Alterar";
            this.txtConfSenha_Alterar.Size = new System.Drawing.Size(184, 18);
            this.txtConfSenha_Alterar.TabIndex = 78;
            this.txtConfSenha_Alterar.Tag = "";
            this.txtConfSenha_Alterar.UseSystemPasswordChar = true;
            // 
            // painelConfirmSenha
            // 
            this.painelConfirmSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.painelConfirmSenha.Location = new System.Drawing.Point(200, 354);
            this.painelConfirmSenha.Name = "painelConfirmSenha";
            this.painelConfirmSenha.Size = new System.Drawing.Size(172, 1);
            this.painelConfirmSenha.TabIndex = 77;
            // 
            // painelNome
            // 
            this.painelNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.painelNome.Location = new System.Drawing.Point(200, 162);
            this.painelNome.Name = "painelNome";
            this.painelNome.Size = new System.Drawing.Size(172, 1);
            this.painelNome.TabIndex = 74;
            // 
            // txtNome_Alterar
            // 
            this.txtNome_Alterar.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome_Alterar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome_Alterar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtNome_Alterar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNome_Alterar.Location = new System.Drawing.Point(206, 142);
            this.txtNome_Alterar.Name = "txtNome_Alterar";
            this.txtNome_Alterar.Size = new System.Drawing.Size(184, 18);
            this.txtNome_Alterar.TabIndex = 73;
            this.txtNome_Alterar.Tag = "";
            this.txtNome_Alterar.Text = "Nome Completo";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(206, 405);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(179, 36);
            this.btnAlterar.TabIndex = 71;
            this.btnAlterar.Text = "Confirmar Alterações";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // painelNovaSenha
            // 
            this.painelNovaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.painelNovaSenha.Location = new System.Drawing.Point(197, 288);
            this.painelNovaSenha.Name = "painelNovaSenha";
            this.painelNovaSenha.Size = new System.Drawing.Size(172, 1);
            this.painelNovaSenha.TabIndex = 70;
            // 
            // txtSenha_Alterar
            // 
            this.txtSenha_Alterar.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenha_Alterar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha_Alterar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtSenha_Alterar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSenha_Alterar.Location = new System.Drawing.Point(204, 267);
            this.txtSenha_Alterar.Name = "txtSenha_Alterar";
            this.txtSenha_Alterar.Size = new System.Drawing.Size(184, 18);
            this.txtSenha_Alterar.TabIndex = 69;
            this.txtSenha_Alterar.Tag = "";
            this.txtSenha_Alterar.UseSystemPasswordChar = true;
            // 
            // painelSenha
            // 
            this.painelSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.painelSenha.Location = new System.Drawing.Point(200, 221);
            this.painelSenha.Name = "painelSenha";
            this.painelSenha.Size = new System.Drawing.Size(172, 1);
            this.painelSenha.TabIndex = 68;
            // 
            // txtUsuario_Alterar
            // 
            this.txtUsuario_Alterar.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsuario_Alterar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario_Alterar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtUsuario_Alterar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsuario_Alterar.Location = new System.Drawing.Point(435, 142);
            this.txtUsuario_Alterar.Name = "txtUsuario_Alterar";
            this.txtUsuario_Alterar.Size = new System.Drawing.Size(184, 18);
            this.txtUsuario_Alterar.TabIndex = 67;
            this.txtUsuario_Alterar.Tag = "";
            this.txtUsuario_Alterar.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label4.Location = new System.Drawing.Point(264, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 49);
            this.label4.TabIndex = 65;
            this.label4.Text = "Alterar Dados";
            // 
            // btnSenha
            // 
            this.btnSenha.BackColor = System.Drawing.SystemColors.Control;
            this.btnSenha.FlatAppearance.BorderSize = 0;
            this.btnSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSenha.Image = ((System.Drawing.Image)(resources.GetObject("btnSenha.Image")));
            this.btnSenha.Location = new System.Drawing.Point(169, 198);
            this.btnSenha.Name = "btnSenha";
            this.btnSenha.Size = new System.Drawing.Size(27, 25);
            this.btnSenha.TabIndex = 82;
            this.btnSenha.UseVisualStyleBackColor = false;
            this.btnSenha.Click += new System.EventHandler(this.btnSenha_Click);
            // 
            // btnConfSenha
            // 
            this.btnConfSenha.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfSenha.FlatAppearance.BorderSize = 0;
            this.btnConfSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfSenha.Image = ((System.Drawing.Image)(resources.GetObject("btnConfSenha.Image")));
            this.btnConfSenha.Location = new System.Drawing.Point(169, 331);
            this.btnConfSenha.Name = "btnConfSenha";
            this.btnConfSenha.Size = new System.Drawing.Size(27, 25);
            this.btnConfSenha.TabIndex = 79;
            this.btnConfSenha.UseVisualStyleBackColor = false;
            this.btnConfSenha.Click += new System.EventHandler(this.btnConfSenha_Click);
            // 
            // btnCurso
            // 
            this.btnCurso.BackColor = System.Drawing.SystemColors.Control;
            this.btnCurso.FlatAppearance.BorderSize = 0;
            this.btnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnCurso.Image")));
            this.btnCurso.Location = new System.Drawing.Point(400, 263);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(27, 25);
            this.btnCurso.TabIndex = 76;
            this.btnCurso.UseVisualStyleBackColor = false;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // btnNome
            // 
            this.btnNome.BackColor = System.Drawing.SystemColors.Control;
            this.btnNome.FlatAppearance.BorderSize = 0;
            this.btnNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNome.Image = ((System.Drawing.Image)(resources.GetObject("btnNome.Image")));
            this.btnNome.Location = new System.Drawing.Point(169, 140);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(27, 25);
            this.btnNome.TabIndex = 75;
            this.btnNome.UseVisualStyleBackColor = false;
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // btnNovaSenha
            // 
            this.btnNovaSenha.BackColor = System.Drawing.SystemColors.Control;
            this.btnNovaSenha.FlatAppearance.BorderSize = 0;
            this.btnNovaSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaSenha.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaSenha.Image")));
            this.btnNovaSenha.Location = new System.Drawing.Point(169, 265);
            this.btnNovaSenha.Name = "btnNovaSenha";
            this.btnNovaSenha.Size = new System.Drawing.Size(27, 25);
            this.btnNovaSenha.TabIndex = 72;
            this.btnNovaSenha.UseVisualStyleBackColor = false;
            this.btnNovaSenha.Click += new System.EventHandler(this.btnNovaSenha_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.Location = new System.Drawing.Point(400, 140);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(27, 25);
            this.btnUsuario.TabIndex = 66;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNome.Location = new System.Drawing.Point(200, 119);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 19);
            this.lblNome.TabIndex = 86;
            this.lblNome.Text = "Nome";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblUser.Location = new System.Drawing.Point(428, 123);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 19);
            this.lblUser.TabIndex = 87;
            this.lblUser.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblSenha.Location = new System.Drawing.Point(200, 179);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(93, 19);
            this.lblSenha.TabIndex = 88;
            this.lblSenha.Text = "Senha Atual";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNovaSenha.Location = new System.Drawing.Point(200, 248);
            this.lblNovaSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(94, 19);
            this.lblNovaSenha.TabIndex = 89;
            this.lblNovaSenha.Text = "Nova Senha";
            // 
            // lblConfirmSenha
            // 
            this.lblConfirmSenha.AutoSize = true;
            this.lblConfirmSenha.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblConfirmSenha.Location = new System.Drawing.Point(200, 312);
            this.lblConfirmSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmSenha.Name = "lblConfirmSenha";
            this.lblConfirmSenha.Size = new System.Drawing.Size(165, 19);
            this.lblConfirmSenha.TabIndex = 90;
            this.lblConfirmSenha.Text = "Confirmar Nova Senha";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCurso.Location = new System.Drawing.Point(428, 241);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(116, 19);
            this.lblCurso.TabIndex = 91;
            this.lblCurso.Text = "Curso Desejado";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEmail.Location = new System.Drawing.Point(428, 181);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 19);
            this.lblEmail.TabIndex = 95;
            this.lblEmail.Text = "Email";
            // 
            // painelEmail
            // 
            this.painelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.painelEmail.Location = new System.Drawing.Point(428, 221);
            this.painelEmail.Name = "painelEmail";
            this.painelEmail.Size = new System.Drawing.Size(172, 1);
            this.painelEmail.TabIndex = 94;
            // 
            // txtEmail_Alterar
            // 
            this.txtEmail_Alterar.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail_Alterar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail_Alterar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtEmail_Alterar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmail_Alterar.Location = new System.Drawing.Point(435, 201);
            this.txtEmail_Alterar.Name = "txtEmail_Alterar";
            this.txtEmail_Alterar.Size = new System.Drawing.Size(184, 18);
            this.txtEmail_Alterar.TabIndex = 93;
            this.txtEmail_Alterar.Tag = "";
            this.txtEmail_Alterar.Text = "Email";
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmail.FlatAppearance.BorderSize = 0;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
            this.btnEmail.Location = new System.Drawing.Point(400, 198);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(27, 25);
            this.btnEmail.TabIndex = 92;
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // painelTopo
            // 
            this.painelTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.painelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTopo.Location = new System.Drawing.Point(0, 0);
            this.painelTopo.Name = "painelTopo";
            this.painelTopo.Size = new System.Drawing.Size(791, 15);
            this.painelTopo.TabIndex = 96;
            // 
            // painelBaixo
            // 
            this.painelBaixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.painelBaixo.Location = new System.Drawing.Point(0, 476);
            this.painelBaixo.Margin = new System.Windows.Forms.Padding(2);
            this.painelBaixo.Name = "painelBaixo";
            this.painelBaixo.Size = new System.Drawing.Size(791, 11);
            this.painelBaixo.TabIndex = 100;
            // 
            // FrmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(791, 487);
            this.Controls.Add(this.painelBaixo);
            this.Controls.Add(this.painelTopo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.painelEmail);
            this.Controls.Add(this.txtEmail_Alterar);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblConfirmSenha);
            this.Controls.Add(this.lblNovaSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.painelCurso);
            this.Controls.Add(this.txtSenhaAtual_Alterar);
            this.Controls.Add(this.btnSenha);
            this.Controls.Add(this.painelUser);
            this.Controls.Add(this.cbCurso_Alterar);
            this.Controls.Add(this.btnConfSenha);
            this.Controls.Add(this.txtConfSenha_Alterar);
            this.Controls.Add(this.painelConfirmSenha);
            this.Controls.Add(this.btnCurso);
            this.Controls.Add(this.btnNome);
            this.Controls.Add(this.painelNome);
            this.Controls.Add(this.txtNome_Alterar);
            this.Controls.Add(this.btnNovaSenha);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.painelNovaSenha);
            this.Controls.Add(this.txtSenha_Alterar);
            this.Controls.Add(this.painelSenha);
            this.Controls.Add(this.txtUsuario_Alterar);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classroom";
            this.Load += new System.EventHandler(this.FrmAlterar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel painelCurso;
        private System.Windows.Forms.TextBox txtSenhaAtual_Alterar;
        private System.Windows.Forms.Button btnSenha;
        private System.Windows.Forms.Panel painelUser;
        private System.Windows.Forms.ComboBox cbCurso_Alterar;
        private System.Windows.Forms.Button btnConfSenha;
        private System.Windows.Forms.TextBox txtConfSenha_Alterar;
        private System.Windows.Forms.Panel painelConfirmSenha;
        private System.Windows.Forms.Button btnCurso;
        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.Panel painelNome;
        private System.Windows.Forms.TextBox txtNome_Alterar;
        private System.Windows.Forms.Button btnNovaSenha;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel painelNovaSenha;
        private System.Windows.Forms.TextBox txtSenha_Alterar;
        private System.Windows.Forms.Panel painelSenha;
        private System.Windows.Forms.TextBox txtUsuario_Alterar;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Label lblConfirmSenha;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel painelEmail;
        private System.Windows.Forms.TextBox txtEmail_Alterar;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Panel painelTopo;
        private System.Windows.Forms.Panel painelBaixo;
    }
}