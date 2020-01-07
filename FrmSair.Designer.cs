namespace Projeto_AppEstudos_TCC
{
    partial class FrmSair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSair));
            this.btnSairSim = new System.Windows.Forms.Button();
            this.btnSairNao = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSairSim
            // 
            this.btnSairSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSairSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairSim.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairSim.ForeColor = System.Drawing.Color.White;
            this.btnSairSim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairSim.Location = new System.Drawing.Point(12, 146);
            this.btnSairSim.Name = "btnSairSim";
            this.btnSairSim.Size = new System.Drawing.Size(159, 36);
            this.btnSairSim.TabIndex = 35;
            this.btnSairSim.Text = "Sim";
            this.btnSairSim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSairSim.UseVisualStyleBackColor = false;
            this.btnSairSim.Click += new System.EventHandler(this.btnSairSim_Click);
            // 
            // btnSairNao
            // 
            this.btnSairNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSairNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairNao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairNao.ForeColor = System.Drawing.Color.White;
            this.btnSairNao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairNao.Location = new System.Drawing.Point(215, 146);
            this.btnSairNao.Name = "btnSairNao";
            this.btnSairNao.Size = new System.Drawing.Size(159, 36);
            this.btnSairNao.TabIndex = 36;
            this.btnSairNao.Text = "Não";
            this.btnSairNao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSairNao.UseVisualStyleBackColor = false;
            this.btnSairNao.Click += new System.EventHandler(this.btnSairNao_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(72, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(259, 49);
            this.lblTitulo.TabIndex = 39;
            this.lblTitulo.Text = "Deseja Sair?";
            // 
            // FrmSair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(386, 223);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSairNao);
            this.Controls.Add(this.btnSairSim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classroom";
            this.Load += new System.EventHandler(this.FrmSair_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSairSim;
        private System.Windows.Forms.Button btnSairNao;
        private System.Windows.Forms.Label lblTitulo;
    }
}