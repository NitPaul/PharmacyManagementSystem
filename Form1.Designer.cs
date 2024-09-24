﻿namespace PharmacyManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passTextField = new Guna.UI2.WinForms.Guna2TextBox();
            this.userNameTxtField = new Guna.UI2.WinForms.Guna2TextBox();
            this.signIn_btn = new Guna.UI2.WinForms.Guna2Button();
            this.login_btn = new Guna.UI2.WinForms.Guna2Button();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.medicinePicture_panel = new System.Windows.Forms.Panel();
            this.forgetPass_btn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.medicinePicture_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 578);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jokerman", 13.8F);
            this.label3.Location = new System.Drawing.Point(92, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.forgetPass_btn);
            this.panel1.Controls.Add(this.passTextField);
            this.panel1.Controls.Add(this.userNameTxtField);
            this.panel1.Controls.Add(this.signIn_btn);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(102, 144);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 504);
            this.panel1.TabIndex = 3;
            // 
            // passTextField
            // 
            this.passTextField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTextField.DefaultText = "";
            this.passTextField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTextField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTextField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTextField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTextField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTextField.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTextField.Location = new System.Drawing.Point(122, 285);
            this.passTextField.Margin = new System.Windows.Forms.Padding(8, 16, 8, 16);
            this.passTextField.Name = "passTextField";
            this.passTextField.PasswordChar = '*';
            this.passTextField.PlaceholderText = "";
            this.passTextField.SelectedText = "";
            this.passTextField.Size = new System.Drawing.Size(318, 43);
            this.passTextField.TabIndex = 6;
            this.passTextField.TextChanged += new System.EventHandler(this.passTextField_TextChanged);
            // 
            // userNameTxtField
            // 
            this.userNameTxtField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxtField.DefaultText = "";
            this.userNameTxtField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameTxtField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTxtField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTxtField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTxtField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTxtField.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxtField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTxtField.Location = new System.Drawing.Point(122, 150);
            this.userNameTxtField.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userNameTxtField.Name = "userNameTxtField";
            this.userNameTxtField.PasswordChar = '\0';
            this.userNameTxtField.PlaceholderText = "";
            this.userNameTxtField.SelectedText = "";
            this.userNameTxtField.Size = new System.Drawing.Size(318, 43);
            this.userNameTxtField.TabIndex = 5;
            // 
            // signIn_btn
            // 
            this.signIn_btn.BorderRadius = 19;
            this.signIn_btn.BorderThickness = 1;
            this.signIn_btn.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_btn.ForeColor = System.Drawing.Color.White;
            this.signIn_btn.HoverState.BorderColor = System.Drawing.Color.Black;
            this.signIn_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.signIn_btn.HoverState.ForeColor = System.Drawing.Color.Aqua;
            this.signIn_btn.Image = ((System.Drawing.Image)(resources.GetObject("signIn_btn.Image")));
            this.signIn_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.signIn_btn.Location = new System.Drawing.Point(314, 371);
            this.signIn_btn.Name = "signIn_btn";
            this.signIn_btn.Size = new System.Drawing.Size(180, 45);
            this.signIn_btn.TabIndex = 4;
            this.signIn_btn.Text = "Sign In";
            this.signIn_btn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // login_btn
            // 
            this.login_btn.BorderRadius = 19;
            this.login_btn.BorderThickness = 1;
            this.login_btn.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.HoverState.BorderColor = System.Drawing.Color.Black;
            this.login_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.login_btn.HoverState.ForeColor = System.Drawing.Color.Aqua;
            this.login_btn.Image = ((System.Drawing.Image)(resources.GetObject("login_btn.Image")));
            this.login_btn.ImageSize = new System.Drawing.Size(50, 50);
            this.login_btn.Location = new System.Drawing.Point(98, 371);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(180, 45);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Login";
            this.login_btn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BorderRadius = 1;
            this.exitBtn.FillColor = System.Drawing.Color.PaleTurquoise;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.exitBtn.Location = new System.Drawing.Point(1338, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(42, 40);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // medicinePicture_panel
            // 
            this.medicinePicture_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("medicinePicture_panel.BackgroundImage")));
            this.medicinePicture_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.medicinePicture_panel.Controls.Add(this.panel1);
            this.medicinePicture_panel.Location = new System.Drawing.Point(690, 0);
            this.medicinePicture_panel.Name = "medicinePicture_panel";
            this.medicinePicture_panel.Size = new System.Drawing.Size(690, 761);
            this.medicinePicture_panel.TabIndex = 4;
            // 
            // forgetPass_btn
            // 
            this.forgetPass_btn.BackColor = System.Drawing.Color.Transparent;
            this.forgetPass_btn.BorderRadius = 25;
            this.forgetPass_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.forgetPass_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.forgetPass_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.forgetPass_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.forgetPass_btn.FillColor = System.Drawing.Color.Transparent;
            this.forgetPass_btn.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Bold);
            this.forgetPass_btn.ForeColor = System.Drawing.Color.DarkBlue;
            this.forgetPass_btn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.forgetPass_btn.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.forgetPass_btn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.forgetPass_btn.HoverState.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetPass_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.forgetPass_btn.Location = new System.Drawing.Point(161, 422);
            this.forgetPass_btn.Name = "forgetPass_btn";
            this.forgetPass_btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.forgetPass_btn.PressedDepth = 20;
            this.forgetPass_btn.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.forgetPass_btn.Size = new System.Drawing.Size(233, 39);
            this.forgetPass_btn.TabIndex = 7;
            this.forgetPass_btn.Text = "Forget Password";
            this.forgetPass_btn.Click += new System.EventHandler(this.forgetPass_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 761);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.medicinePicture_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.medicinePicture_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2TextBox passTextField;
        private Guna.UI2.WinForms.Guna2TextBox userNameTxtField;
        private Guna.UI2.WinForms.Guna2Button signIn_btn;
        private Guna.UI2.WinForms.Guna2Button login_btn;
        private System.Windows.Forms.Panel medicinePicture_panel;
        private Guna.UI2.WinForms.Guna2Button forgetPass_btn;
    }
}