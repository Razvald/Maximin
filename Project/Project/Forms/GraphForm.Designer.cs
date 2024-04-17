namespace Project.Forms
{
    partial class GraphForm
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
            btnBack = new Button();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            cmbRoute = new ComboBox();
            btnPie = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 37);
            btnBack.TabIndex = 14;
            btnBack.Text = "Вернуться";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(12, 55);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(660, 403);
            formsPlot1.TabIndex = 15;
            // 
            // cmbRoute
            // 
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(232, 17);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(164, 29);
            cmbRoute.TabIndex = 16;
            cmbRoute.SelectedIndexChanged += cmbRoute_SelectedIndexChanged;
            // 
            // btnPie
            // 
            btnPie.Location = new Point(122, 12);
            btnPie.Name = "btnPie";
            btnPie.Size = new Size(104, 37);
            btnPie.TabIndex = 17;
            btnPie.Text = "Круговой";
            btnPie.UseVisualStyleBackColor = true;
            btnPie.Click += btnPie_Click;
            // 
            // GraphForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 470);
            Controls.Add(btnPie);
            Controls.Add(cmbRoute);
            Controls.Add(formsPlot1);
            Controls.Add(btnBack);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "GraphForm";
            Text = "GraphForm";
            FormClosed += GraphForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private ComboBox cmbRoute;
        private Button btnPie;
    }
}