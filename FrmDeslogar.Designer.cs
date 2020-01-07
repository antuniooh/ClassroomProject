namespace Projeto_AppEstudos_TCC
{
    partial class FrmDeslogar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeslogar));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnDeslogarNao = new System.Windows.Forms.Button();
            this.btnDeslogarSim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(24, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(364, 49);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "Deseja Deslogar?";
            // 
            // btnDeslogarNao
            // 
            this.btnDeslogarNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnDeslogarNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeslogarNao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeslogarNao.ForeColor = System.Drawing.Color.White;
            this.btnDeslogarNao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeslogarNao.Location = new System.Drawing.Point(218, 147);
            this.btnDeslogarNao.Name = "btnDeslogarNao";
            this.btnDeslogarNao.Size = new System.Drawing.Size(159, 36);
            this.btnDeslogarNao.TabIndex = 41;
            this.btnDeslogarNao.Text = "Não";
            this.btnDeslogarNao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeslogarNao.UseVisualStyleBackColor = false;
            this.btnDeslogarNao.Click += new System.EventHandler(this.BtnDeslogarNao_Click);
            // 
            // btnDeslogarSim
            // 
            this.btnDeslogarSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnDeslogarSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeslogarSim.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeslogarSim.ForeColor = System.Drawing.Color.White;
            this.btnDeslogarSim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeslogarSim.Location = new System.Drawing.Point(10, 147);
            this.btnDeslogarSim.Name = "btnDeslogarSim";
            this.btnDeslogarSim.Size = new System.Drawing.Size(159, 36);
            this.btnDeslogarSim.TabIndex = 40;
            this.btnDeslogarSim.Text = "Sim";
            this.btnDeslogarSim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeslogarSim.UseVisualStyleBackColor = false;
            this.btnDeslogarSim.Click += new System.EventHandler(this.btnDeslogarSim_Click);
            // 
            // FrmDeslogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(386, 223);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnDeslogarNao);
            this.Controls.Add(this.btnDeslogarSim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDeslogar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classroom";
            this.Load += new System.EventHandler(this.FrmDeslogar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnDeslogarNao;
        private System.Windows.Forms.Button btnDeslogarSim;
    }
}