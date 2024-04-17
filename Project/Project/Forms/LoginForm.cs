using Microsoft.EntityFrameworkCore;
using Project.Database;
using Project.Forms;

namespace Project
{
    public partial class LoginForm : Form
    {
        private string _selectedConnectionString;

        public LoginForm()
        {
            InitializeComponent();
            InitializeDatabaseComboBox();
        }

        private void InitializeDatabaseComboBox()
        {
            cmbConnect.Items.Add("LogProject");
            cmbConnect.Items.Add("FortunaMA_107g2_Logging");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _selectedConnectionString = cmbConnect.Text;

            if (string.IsNullOrEmpty(_selectedConnectionString))
            {
                MessageBox.Show("Пожалуйста, выберите строку подключения.");
                return;
            }
            if (cmbConnect.SelectedItem?.ToString() == "LogProject")
            {
                _selectedConnectionString = $"Server=(local); Database={cmbConnect.Text}; Integrated Security=true;";
            }
            else if (cmbConnect.SelectedItem?.ToString() == "FortunaMA_107g2_Logging")
            {
                _selectedConnectionString = $"Data Source=DBSRV\\AG2023; Initial Catalog={cmbConnect.Text}; Integrated Security=true;";
            }
            else
            {
                _selectedConnectionString = $"Data Source=DBSRV\\AG2023; Initial Catalog={cmbConnect.Text}; Integrated Security=true;";
            }

            var _dbContext = CreateDbContext();
            var user = _dbContext.Users
                .FirstOrDefault(u => u.Login == txbLogin.Text && u.Password == txbPassword.Text);

            if (user != null)
            {
                MainForm mainForm = new(_dbContext, user, this);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверные учетные данные. Пожалуйста, попробуйте снова.");
            }
        }

        private AppDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(_selectedConnectionString);
            return new AppDbContext(optionsBuilder.Options);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
