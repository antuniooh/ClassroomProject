namespace Projeto_AppEstudos_TCC
{
    partial class FrmSairLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSairLogin));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSairLoginNao = new System.Windows.Forms.Button();
            this.btnSairLoginSim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(72, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(259, 49);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "Deseja Sair?";
            // 
            // btnSairLoginNao
            // 
            this.btnSairLoginNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSairLoginNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairLoginNao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairLoginNao.ForeColor = System.Drawing.Color.White;
            this.btnSairLoginNao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairLoginNao.Location = new System.Drawing.Point(215, 146);
            this.btnSairLoginNao.Name = "btnSairLoginNao";
            this.btnSairLoginNao.Size = new System.Drawing.Size(159, 36);
            this.btnSairLoginNao.TabIndex = 41;
            this.btnSairLoginNao.Text = "Não";
            this.btnSairLoginNao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSairLoginNao.UseVisualStyleBackColor = false;
            this.btnSairLoginNao.Click += new System.EventHandler(this.btnSairLoginNao_Click);
            // 
            // btnSairLoginSim
            // 
            this.btnSairLoginSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSairLoginSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairLoginSim.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairLoginSim.ForeColor = System.Drawing.Color.White;
            this.btnSairLoginSim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairLoginSim.Location = new System.Drawing.Point(12, 146);
            this.btnSairLoginSim.Name = "btnSairLoginSim";
            this.btnSairLoginSim.Size = new System.Drawing.Size(159, 36);
            this.btnSairLoginSim.TabIndex = 40;
            this.btnSairLoginSim.Text = "Sim";
            this.btnSairLoginSim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSairLoginSim.UseVisualStyleBackColor = false;
            this.btnSairLoginSim.Click += new System.EventHandler(this.btnSairLoginSim_Click);
            // 
            // FrmSairLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(386, 223);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSairLoginNao);
            this.Controls.Add(this.btnSairLoginSim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSairLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classroom";
            this.Load += new System.EventHandler(this.FrmSairLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSairLoginNao;
        private System.Windows.Forms.Button btnSairLoginSim;
    }
}