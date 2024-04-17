using Project.Database;
using Project.Database.Entities;

namespace Project.Create
{
    public partial class CreateUserForm : Form
    {
        private readonly AppDbContext _dbContext;
        public CreateUserForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            foreach (Role type in Enum.GetValues(typeof(Role)))
            {
                cmbRole.Items.Add(type.ToString());
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
                string selectedType = cmbRole.SelectedItem.ToString();
                Role rol = Role.Worker;
                if (Enum.TryParse(selectedType, out Role role))
                {
                    rol = role;
                }

                var newUser = new User
                {
                    Login = txbLogin.Text,
                    Password = txbPassword.Text,
                    UserName = txbName.Text,
                    UserRole = rol
                };

                _dbContext.Users.Add(newUser);
                _dbContext.SaveChanges();

                MessageBox.Show("Пользователь успешно создан.");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании пользователя: {ex?.InnerException?.Message}");
                MessageBox.Show($"Ошибка при создании пользователя: {ex?.Message}");
            }
        }


        private bool AreAllFieldsFilled()
        {
            return !string.IsNullOrEmpty(txbLogin.Text) &&
                   !string.IsNullOrEmpty(txbName.Text) &&
                   !string.IsNullOrEmpty(txbPassword.Text) &&
                   cmbRole.SelectedItem != null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CreateUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
