﻿namespace JobApplication
{
    partial class TinTuyenDung
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
            this.header1 = new JobApplication.Header();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Location = new System.Drawing.Point(1, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1600, 869);
            this.header1.TabIndex = 0;
            // 
            // TinTuyenDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 714);
            this.Controls.Add(this.header1);
            this.Name = "TinTuyenDung";
            this.ResumeLayout(false);

        }

        #endregion

        private Header header1;
    }
}