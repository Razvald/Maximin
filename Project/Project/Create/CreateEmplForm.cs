using Project.Database;
using Project.Database.Entities;

namespace Project.Create
{
    public partial class CreateEmplForm : Form
    {
        private readonly AppDbContext _dbContext;

        public CreateEmplForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            foreach (PositionType type in Enum.GetValues(typeof(PositionType)))
            {
                cmbPosition.Items.Add(type.ToString());
            }
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
                string selectedType = cmbPosition.SelectedItem.ToString();
                PositionType position = PositionType.Manager;
                if (Enum.TryParse(selectedType, out PositionType pos))
                {
                    position = pos;
                }

                var newEmp = new Employee
                {
                    Name = txbName.Text,
                    Position = position
                };

                _dbContext.Employees.Add(newEmp);
                _dbContext.SaveChanges();

                MessageBox.Show("Пользователь успешно создан.");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании клиента: {ex?.InnerException?.Message}");
                MessageBox.Show($"Ошибка при создании клиента: {ex?.Message}");
            }
        }

        private bool AreAllFieldsFilled()
        {
            return !string.IsNullOrEmpty(txbName.Text) &&
                   cmbPosition.SelectedItem != null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CreateEmplForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
