namespace Project.Forms
{
    partial class MainForm
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
            btnExit = new Button();
            btnLogOut = new Button();
            btnEmp = new Button();
            btnUsers = new Button();
            btnProjects = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 36);
            label1.TabIndex = 0;
            label1.Text = "Меню";
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.Location = new Point(0, 259);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(192, 47);
            btnExit.TabIndex = 1;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.Location = new Point(0, 212);
            btnLogOut.Margin = new Padding(0);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(192, 47);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Выход из аккаунта";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnEmp
            // 
            btnEmp.Dock = DockStyle.Bottom;
            btnEmp.Location = new Point(0, 165);
            btnEmp.Margin = new Padding(0);
            btnEmp.Name = "btnEmp";
            btnEmp.Size = new Size(192, 47);
            btnEmp.TabIndex = 3;
            btnEmp.Text = "Заказчики";
            btnEmp.UseVisualStyleBackColor = true;
            btnEmp.Click += btnEmp_Click;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Bottom;
            btnUsers.Location = new Point(0, 118);
            btnUsers.Margin = new Padding(0);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(192, 47);
            btnUsers.TabIndex = 4;
            btnUsers.Text = "Пользователи";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnProjects
            // 
            btnProjects.Dock = DockStyle.Bottom;
            btnProjects.Location = new Point(0, 71);
            btnProjects.Margin = new Padding(0);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(192, 47);
            btnProjects.TabIndex = 5;
            btnProjects.Text = "Проекты";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += btnProjects_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(192, 306);
            Controls.Add(btnProjects);
            Controls.Add(btnUsers);
            Controls.Add(btnEmp);
            Controls.Add(btnLogOut);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnExit;
        private Button btnLogOut;
        private Button btnEmp;
        private Button btnUsers;
        private Button btnProjects;
    }
}