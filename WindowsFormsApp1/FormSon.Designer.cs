﻿namespace WindowsFormsApp1
{
    partial class FormSon
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
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_init = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_init = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(89, 77);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(483, 28);
            this.txt_ip.TabIndex = 0;
            // 
            // txt_init
            // 
            this.txt_init.Location = new System.Drawing.Point(89, 174);
            this.txt_init.Name = "txt_init";
            this.txt_init.Size = new System.Drawing.Size(483, 28);
            this.txt_init.TabIndex = 1;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(89, 275);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(483, 28);
            this.txt_login.TabIndex = 2;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(626, 61);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(124, 63);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "접속";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(626, 155);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(124, 63);
            this.btn_init.TabIndex = 4;
            this.btn_init.Text = "Init";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(626, 256);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(124, 63);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // FormSon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.txt_init);
            this.Controls.Add(this.txt_ip);
            this.Name = "FormSon";
            this.Text = "FormSon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSon_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_init;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Button btn_login;
    }
}