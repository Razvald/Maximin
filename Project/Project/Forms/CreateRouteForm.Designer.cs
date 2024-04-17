namespace Project.Forms
{
    partial class CreateRouteForm
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
            txbName = new TextBox();
            txbDesc = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Bottom;
            btnClose.Location = new Point(0, 137);
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
            btnAdd.Location = new Point(0, 192);
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
            label1.Size = new Size(84, 21);
            label1.TabIndex = 7;
            label1.Text = "Название";
            // 
            // txbName
            // 
            txbName.Location = new Point(12, 33);
            txbName.Name = "txbName";
            txbName.Size = new Size(229, 29);
            txbName.TabIndex = 8;
            // 
            // txbDesc
            // 
            txbDesc.Location = new Point(12, 89);
            txbDesc.Name = "txbDesc";
            txbDesc.Size = new Size(229, 29);
            txbDesc.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 9;
            label2.Text = "Описание";
            // 
            // CreateRouteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 247);
            Controls.Add(txbDesc);
            Controls.Add(label2);
            Controls.Add(txbName);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CreateRouteForm";
            Text = "CreateRouteForm";
            FormClosed += CreateRouteForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnAdd;
        private Label label1;
        private TextBox txbName;
        private TextBox txbDesc;
        private Label label2;
    }
}