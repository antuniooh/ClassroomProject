namespace Projeto_AppEstudos_TCC
{
    partial class Enem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enem));
            this.painelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblInscricoes = new System.Windows.Forms.Label();
            this.lblProvas = new System.Windows.Forms.Label();
            this.lblResumo = new System.Windows.Forms.Label();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.painelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // painelTitulo
            // 
            this.painelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.painelTitulo.Controls.Add(this.lblTitulo);
            this.painelTitulo.Controls.Add(this.btnFechar);
            this.painelTitulo.Location = new System.Drawing.Point(0, 0);
            this.painelTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.painelTitulo.Name = "painelTitulo";
            this.painelTitulo.Size = new System.Drawing.Size(598, 32);
            this.painelTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(273, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 20);
            this.lblTitulo.TabIndex = 47;
            this.lblTitulo.Text = "ENEM";
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(567, 2);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 31);
            this.btnFechar.TabIndex = 46;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblInscricoes
            // 
            this.lblInscricoes.AutoSize = true;
            this.lblInscricoes.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblInscricoes.ForeColor = System.Drawing.Color.White;
            this.lblInscricoes.Location = new System.Drawing.Point(38, 271);
            this.lblInscricoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInscricoes.Name = "lblInscricoes";
            this.lblInscricoes.Size = new System.Drawing.Size(187, 20);
            this.lblInscricoes.TabIndex = 2;
            this.lblInscricoes.Text = "Inscrições: 07/05 a 18/05";
            // 
            // lblProvas
            // 
            this.lblProvas.AutoSize = true;
            this.lblProvas.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblProvas.ForeColor = System.Drawing.Color.White;
            this.lblProvas.Location = new System.Drawing.Point(38, 294);
            this.lblProvas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvas.Name = "lblProvas";
            this.lblProvas.Size = new System.Drawing.Size(163, 20);
            this.lblProvas.TabIndex = 3;
            this.lblProvas.Text = "Provas: 04/11 e 11/11";
            // 
            // lblResumo
            // 
            this.lblResumo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblResumo.ForeColor = System.Drawing.Color.White;
            this.lblResumo.Location = new System.Drawing.Point(38, 350);
            this.lblResumo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(519, 293);
            this.lblResumo.TabIndex = 5;
            this.lblResumo.Text = resources.GetString("lblResumo.Text");
            // 
            // pbImagem
            // 
            this.pbImagem.Image = ((System.Drawing.Image)(resources.GetObject("pbImagem.Image")));
            this.pbImagem.Location = new System.Drawing.Point(55, 38);
            this.pbImagem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(488, 203);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 1;
            this.pbImagem.TabStop = false;
            // 
            // lblLink
            // 
            this.lblLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.lblLink.Location = new System.Drawing.Point(182, 649);
            this.lblLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(207, 21);
            this.lblLink.TabIndex = 6;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "https://enem.inep.gov.br";
            // 
            // Enem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(598, 699);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblResumo);
            this.Controls.Add(this.lblProvas);
            this.Controls.Add(this.lblInscricoes);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.painelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Enem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enem";
            this.painelTitulo.ResumeLayout(false);
            this.painelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Label lblInscricoes;
        private System.Windows.Forms.Label lblProvas;
        private System.Windows.Forms.Label lblResumo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.LinkLabel lblLink;
    }
}