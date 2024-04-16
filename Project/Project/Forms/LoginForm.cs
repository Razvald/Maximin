using Project.Database;
using Project.Forms;

namespace Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var _dbContext = new AppDbContext();
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
