namespace Project.Create
{
    partial class CreateRouteMeasForm
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
            label3 = new Label();
            btnClose = new Button();
            btnAdd = new Button();
            cmbRoute = new ComboBox();
            label1 = new Label();
            cmbMeasure = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 13;
            label3.Text = "Route Id";
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Bottom;
            btnClose.Location = new Point(0, 137);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(253, 55);
            btnClose.TabIndex = 12;
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
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Создать";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbRoute
            // 
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(12, 84);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(229, 29);
            cmbRoute.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 8;
            label1.Text = "Measurement Id";
            // 
            // cmbMeasure
            // 
            cmbMeasure.FormattingEnabled = true;
            cmbMeasure.Location = new Point(12, 28);
            cmbMeasure.Name = "cmbMeasure";
            cmbMeasure.Size = new Size(229, 29);
            cmbMeasure.TabIndex = 14;
            // 
            // CreateRouteMeasForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 247);
            Controls.Add(cmbMeasure);
            Controls.Add(label3);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(cmbRoute);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CreateRouteMeasForm";
            Text = "CreateRouteMeasForm";
            FormClosed += CreateRouteMeasForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnClose;
        private Button btnAdd;
        private ComboBox cmbRoute;
        private Label label1;
        private ComboBox cmbMeasure;
    }
}