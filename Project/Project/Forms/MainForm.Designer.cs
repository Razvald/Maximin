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
            btnMeasurement = new Button();
            btnRoutes = new Button();
            btnRouteMeas = new Button();
            btnGraph = new Button();
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
            btnExit.Location = new Point(0, 451);
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
            btnLogOut.Location = new Point(0, 404);
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
            btnEmp.Location = new Point(0, 357);
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
            btnUsers.Location = new Point(0, 310);
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
            btnProjects.Location = new Point(0, 263);
            btnProjects.Margin = new Padding(0);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(192, 47);
            btnProjects.TabIndex = 5;
            btnProjects.Text = "Проекты";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += btnProjects_Click;
            // 
            // btnMeasurement
            // 
            btnMeasurement.Dock = DockStyle.Bottom;
            btnMeasurement.Location = new Point(0, 216);
            btnMeasurement.Margin = new Padding(0);
            btnMeasurement.Name = "btnMeasurement";
            btnMeasurement.Size = new Size(192, 47);
            btnMeasurement.TabIndex = 6;
            btnMeasurement.Text = "Измерения";
            btnMeasurement.UseVisualStyleBackColor = true;
            btnMeasurement.Click += btnMeasurement_Click;
            // 
            // btnRoutes
            // 
            btnRoutes.Dock = DockStyle.Bottom;
            btnRoutes.Location = new Point(0, 169);
            btnRoutes.Margin = new Padding(0);
            btnRoutes.Name = "btnRoutes";
            btnRoutes.Size = new Size(192, 47);
            btnRoutes.TabIndex = 7;
            btnRoutes.Text = "Маршрут";
            btnRoutes.UseVisualStyleBackColor = true;
            btnRoutes.Click += btnRoutes_Click;
            // 
            // btnRouteMeas
            // 
            btnRouteMeas.Dock = DockStyle.Bottom;
            btnRouteMeas.Location = new Point(0, 118);
            btnRouteMeas.Margin = new Padding(0);
            btnRouteMeas.Name = "btnRouteMeas";
            btnRouteMeas.Size = new Size(192, 51);
            btnRouteMeas.TabIndex = 8;
            btnRouteMeas.Text = "Маршрут / Измерения";
            btnRouteMeas.UseVisualStyleBackColor = true;
            btnRouteMeas.Click += btnRouteMeas_Click;
            // 
            // btnGraph
            // 
            btnGraph.Dock = DockStyle.Bottom;
            btnGraph.Location = new Point(0, 67);
            btnGraph.Margin = new Padding(0);
            btnGraph.Name = "btnGraph";
            btnGraph.Size = new Size(192, 51);
            btnGraph.TabIndex = 9;
            btnGraph.Text = "Графики";
            btnGraph.UseVisualStyleBackColor = true;
            btnGraph.Click += btnGraph_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(192, 498);
            Controls.Add(btnGraph);
            Controls.Add(btnRouteMeas);
            Controls.Add(btnRoutes);
            Controls.Add(btnMeasurement);
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
        private Button btnMeasurement;
        private Button btnRoutes;
        private Button btnRouteMeas;
        private Button btnGraph;
    }
}