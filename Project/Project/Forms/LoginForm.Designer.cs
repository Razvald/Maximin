﻿namespace Project
{
    partial class LoginForm
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
            label2 = new Label();
            label3 = new Label();
            txbLogin = new TextBox();
            txbPassword = new TextBox();
            btnLogin = new Button();
            cmbConnect = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(12, 33);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(228, 29);
            txbLogin.TabIndex = 3;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(12, 98);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(228, 29);
            txbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Dock = DockStyle.Bottom;
            btnLogin.Location = new Point(0, 235);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(252, 46);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // cmbConnect
            // 
            cmbConnect.FormattingEnabled = true;
            cmbConnect.Location = new Point(12, 154);
            cmbConnect.Name = "cmbConnect";
            cmbConnect.Size = new Size(228, 29);
            cmbConnect.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 130);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 7;
            label1.Text = "Название БД";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 281);
            Controls.Add(label1);
            Controls.Add(cmbConnect);
            Controls.Add(btnLogin);
            Controls.Add(txbPassword);
            Controls.Add(txbLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosed += LoginForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txbLogin;
        private TextBox txbPassword;
        private Button btnLogin;
        private ComboBox cmbConnect;
        private Label label1;
    }
}