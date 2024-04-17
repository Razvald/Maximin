namespace Project.Forms
{
    partial class EmployeesForm
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
            btnSave = new Button();
            btnBack = new Button();
            dgvEmpls = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmpls).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(453, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 37);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(563, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 37);
            btnSave.TabIndex = 10;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 37);
            btnBack.TabIndex = 9;
            btnBack.Text = "Вернуться";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvEmpls
            // 
            dgvEmpls.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpls.Dock = DockStyle.Bottom;
            dgvEmpls.Location = new Point(0, 55);
            dgvEmpls.Name = "dgvEmpls";
            dgvEmpls.RowTemplate.Height = 25;
            dgvEmpls.Size = new Size(684, 415);
            dgvEmpls.TabIndex = 8;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 470);
            Controls.Add(btnAdd);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            Controls.Add(dgvEmpls);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "EmployeesForm";
            Text = "EmployeesForm";
            FormClosed += EmployeesForm_FormClosed;
            Load += EmployeesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpls).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnSave;
        private Button btnBack;
        private DataGridView dgvEmpls;
    }
}