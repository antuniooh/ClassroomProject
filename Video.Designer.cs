﻿namespace Projeto_AppEstudos_TCC
{
    partial class Video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video));
            this.wbVideos = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbVideos
            // 
            this.wbVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbVideos.Location = new System.Drawing.Point(0, 0);
            this.wbVideos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wbVideos.MinimumSize = new System.Drawing.Size(15, 16);
            this.wbVideos.Name = "wbVideos";
            this.wbVideos.Size = new System.Drawing.Size(454, 386);
            this.wbVideos.TabIndex = 0;
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 386);
            this.Controls.Add(this.wbVideos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Video";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbVideos;
    }
}