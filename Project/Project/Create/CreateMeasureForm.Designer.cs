namespace Project.Create
{
    partial class CreateMeasureForm
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
            btnClose = new Button();
            btnAdd = new Button();
            label1 = new Label();
            txbValue = new TextBox();
            txbXCoord = new TextBox();
            label2 = new Label();
            txbYCoord = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Bottom;
            btnClose.Location = new Point(0, 253);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(253, 55);
            btnClose.TabIndex = 6;
            btnClose.Text = "Отмена";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Bottom;
            btnAdd.Location = new Point(0, 308);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(253, 55);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Создать";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 7;
            label1.Text = "Значение";
            // 
            // txbValue
            // 
            txbValue.Location = new Point(12, 33);
            txbValue.Name = "txbValue";
            txbValue.Size = new Size(229, 29);
            txbValue.TabIndex = 8;
            // 
            // txbXCoord
            // 
            txbXCoord.Location = new Point(12, 89);
            txbXCoord.Name = "txbXCoord";
            txbXCoord.Size = new Size(229, 29);
            txbXCoord.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 9;
            label2.Text = "Координата X";
            // 
            // txbYCoord
            // 
            txbYCoord.Location = new Point(12, 145);
            txbYCoord.Name = "txbYCoord";
            txbYCoord.Size = new Size(229, 29);
            txbYCoord.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 11;
            label3.Text = "Координата Y";
            // 
            // CreateMeasureForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 363);
            Controls.Add(txbYCoord);
            Controls.Add(label3);
            Controls.Add(txbXCoord);
            Controls.Add(label2);
            Controls.Add(txbValue);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CreateMeasureForm";
            Text = "CreateMeasureForm";
            FormClosed += CreateMeasureForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnAdd;
        private Label label1;
        private TextBox txbValue;
        private TextBox txbXCoord;
        private Label label2;
        private TextBox txbYCoord;
        private Label label3;
    }
}