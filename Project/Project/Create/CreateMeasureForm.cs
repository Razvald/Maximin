using Project.Database;
using Project.Database.Entities;

namespace Project.Create
{
    public partial class CreateMeasureForm : Form
    {
        private readonly AppDbContext _dbContext;
        public CreateMeasureForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Заполните все данные");
                return;
            }

            try
            {
                var newMeasure = new Measurement
                {
                    Value = Convert.ToInt32(txbValue.Text),
                    XCoordinate = Convert.ToInt32(txbXCoord.Text),
                    YCoordinate = Convert.ToInt32(txbYCoord.Text)
                };

                _dbContext.Measurements.Add(newMeasure);
                _dbContext.SaveChanges();

                MessageBox.Show("Измерение успешно создано.");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании измерения: {ex?.InnerException?.Message}");
                MessageBox.Show($"Ошибка при создании измерения: {ex?.Message}");
            }
        }

        private bool AreAllFieldsFilled()
        {
            return !string.IsNullOrEmpty(txbValue.Text) &&
                   !string.IsNullOrEmpty(txbXCoord.Text) &&
                   !string.IsNullOrEmpty(txbYCoord.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CreateMeasureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
