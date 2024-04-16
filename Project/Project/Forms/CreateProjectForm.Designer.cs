namespace Project.Forms
{
    partial class CreateProjectForm
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
            btnAdd = new Button();
            btnClose = new Button();
            label1 = new Label();
            txtProjectName = new TextBox();
            cmbUserID = new ComboBox();
            label2 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            datePickerOrderDate = new DateTimePicker();
            label4 = new Label();
            txtCost = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbEmpID = new ComboBox();
            label7 = new Label();
            cmbMeasurementID = new ComboBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Bottom;
            btnAdd.Location = new Point(0, 474);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(253, 55);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Создать";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Bottom;
            btnClose.Location = new Point(0, 419);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(253, 55);
            btnClose.TabIndex = 1;
            btnClose.Text = "Отмена";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 2;
            label1.Text = "Название проекта";
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new Point(12, 33);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(229, 29);
            txtProjectName.TabIndex = 3;
            // 
            // cmbUserID
            // 
            cmbUserID.FormattingEnabled = true;
            cmbUserID.Location = new Point(12, 257);
            cmbUserID.Name = "cmbUserID";
            cmbUserID.Size = new Size(229, 29);
            cmbUserID.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 5;
            label2.Text = "Описание проекта";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 89);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(229, 29);
            txtDescription.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 7;
            label3.Text = "Дата";
            // 
            // datePickerOrderDate
            // 
            datePickerOrderDate.Location = new Point(12, 145);
            datePickerOrderDate.Name = "datePickerOrderDate";
            datePickerOrderDate.Size = new Size(229, 29);
            datePickerOrderDate.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 9;
            label4.Text = "Цена";
            // 
            // txtCost
            // 
            txtCost.Location = new Point(12, 201);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(229, 29);
            txtCost.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 233);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 11;
            label5.Text = "Пользователь";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 289);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 12;
            label6.Text = "Клиент";
            // 
            // cmbEmpID
            // 
            cmbEmpID.FormattingEnabled = true;
            cmbEmpID.Location = new Point(12, 313);
            cmbEmpID.Name = "cmbEmpID";
            cmbEmpID.Size = new Size(229, 29);
            cmbEmpID.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 345);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 14;
            label7.Text = "Измерения";
            // 
            // cmbMeasurementID
            // 
            cmbMeasurementID.FormattingEnabled = true;
            cmbMeasurementID.Location = new Point(12, 369);
            cmbMeasurementID.Name = "cmbMeasurementID";
            cmbMeasurementID.Size = new Size(229, 29);
            cmbMeasurementID.TabIndex = 15;
            // 
            // CreateProjectForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 529);
            Controls.Add(cmbMeasurementID);
            Controls.Add(label7);
            Controls.Add(cmbEmpID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCost);
            Controls.Add(label4);
            Controls.Add(datePickerOrderDate);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(cmbUserID);
            Controls.Add(txtProjectName);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CreateProjectForm";
            Text = "CreateProjectForm";
            FormClosed += CreateProjectForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnClose;
        private Label label1;
        private TextBox txtProjectName;
        private ComboBox cmbUserID;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private DateTimePicker datePickerOrderDate;
        private Label label4;
        private TextBox txtCost;
        private Label label5;
        private Label label6;
        private ComboBox cmbEmpID;
        private Label label7;
        private ComboBox cmbMeasurementID;
    }
}