﻿namespace CoBan_SuKienTrongForm
{
    partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.btnHienThi = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Họ tên:";
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(139, 48);
			this.txtHoTen.Multiline = true;
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(609, 37);
			this.txtHoTen.TabIndex = 1;
			// 
			// btnHienThi
			// 
			this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHienThi.Location = new System.Drawing.Point(42, 128);
			this.btnHienThi.Name = "btnHienThi";
			this.btnHienThi.Size = new System.Drawing.Size(329, 62);
			this.btnHienThi.TabIndex = 2;
			this.btnHienThi.Text = "&Hiển Thị";
			this.btnHienThi.UseVisualStyleBackColor = true;
			this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(419, 128);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(329, 62);
			this.btnThoat.TabIndex = 3;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.ClientSize = new System.Drawing.Size(800, 254);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnHienThi);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.label1);
			this.KeyPreview = true;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form 1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnThoat;
    }
}

