namespace Project.Create
{
    partial class CreateUserForm
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
            label1 = new Label();
            txbName = new TextBox();
            cmbRole = new ComboBox();
            btnAdd = new Button();
            btnClose = new Button();
            txbLogin = new TextBox();
            label2 = new Label();
            txbPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // txbName
            // 
            txbName.Location = new Point(12, 33);
            txbName.Name = "txbName";
            txbName.Size = new Size(229, 29);
            txbName.TabIndex = 1;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(12, 201);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(229, 29);
            cmbRole.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Bottom;
            btnAdd.Location = new Point(0, 308);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(253, 55);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Создать";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Bottom;
            btnClose.Location = new Point(0, 253);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(253, 55);
            btnClose.TabIndex = 4;
            btnClose.Text = "Отмена";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(12, 89);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(229, 29);
            txbLogin.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 5;
            label2.Text = "Логин";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(12, 145);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(229, 29);
            txbPassword.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 7;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 9;
            label4.Text = "Роль";
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 363);
            Controls.Add(label4);
            Controls.Add(txbPassword);
            Controls.Add(label3);
            Controls.Add(txbLogin);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(cmbRole);
            Controls.Add(txbName);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CreateUserForm";
            Text = "CreateUserForm";
            FormClosed += CreateUserForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbName;
        private ComboBox cmbRole;
        private Button btnAdd;
        private Button btnClose;
        private TextBox txbLogin;
        private Label label2;
        private TextBox txbPassword;
        private Label label3;
        private Label label4;
    }
}