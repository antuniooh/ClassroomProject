namespace Projeto_AppEstudos_TCC
{
    partial class FrmRecuperar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecuperar));
            this.btnDesativado = new System.Windows.Forms.Button();
            this.btnEnviarSenha = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDesativado
            // 
            this.btnDesativado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.btnDesativado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesativado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDesativado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnDesativado.Location = new System.Drawing.Point(57, 125);
            this.btnDesativado.Name = "btnDesativado";
            this.btnDesativado.Size = new System.Drawing.Size(303, 67);
            this.btnDesativado.TabIndex = 1;
            this.btnDesativado.Text = "Recuperar Usuário Desativado";
            this.btnDesativado.UseVisualStyleBackColor = false;
            this.btnDesativado.Click += new System.EventHandler(this.btnDesativado_Click);
            // 
            // btnEnviarSenha
            // 
            this.btnEnviarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.btnEnviarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnEnviarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarSenha.Location = new System.Drawing.Point(57, 52);
            this.btnEnviarSenha.Name = "btnEnviarSenha";
            this.btnEnviarSenha.Size = new System.Drawing.Size(303, 67);
            this.btnEnviarSenha.TabIndex = 55;
            this.btnEnviarSenha.Text = "Esqueci a Senha";
            this.btnEnviarSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviarSenha.UseVisualStyleBackColor = false;
            this.btnEnviarSenha.Click += new System.EventHandler(this.btnEnviarSenha_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(328, 214);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(89, 36);
            this.btnVoltar.TabIndex = 54;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmRecuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(416, 249);
            this.Controls.Add(this.btnEnviarSenha);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDesativado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRecuperar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classroom";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDesativado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEnviarSenha;
    }
}