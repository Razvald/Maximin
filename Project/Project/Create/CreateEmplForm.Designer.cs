namespace Project.Create
{
    partial class CreateEmplForm
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
            cmbPosition = new ComboBox();
            btnAdd = new Button();
            btnClose = new Button();
            label3 = new Label();
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
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(12, 89);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(229, 29);
            cmbPosition.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Bottom;
            btnAdd.Location = new Point(0, 192);
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
            btnClose.Location = new Point(0, 137);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(253, 55);
            btnClose.TabIndex = 4;
            btnClose.Text = "Отмена";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 7;
            label3.Text = "Должность";
            // 
            // CreateEmplForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 247);
            Controls.Add(label3);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(cmbPosition);
            Controls.Add(txbName);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CreateEmplForm";
            Text = "CreateEmplForm";
            FormClosed += CreateEmplForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbName;
        private ComboBox cmbPosition;
        private Button btnAdd;
        private Button btnClose;
        private Label label3;
    }
}