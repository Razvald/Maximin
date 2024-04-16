using Project.Database;
using Project.Database.Entities;

namespace Project.Forms
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly User _user;
        private readonly LoginForm _loginForm;
        public MainForm(AppDbContext dbContext, User user, LoginForm loginForm)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _user = user;
            _loginForm = loginForm;
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            ProjectsForm projectsForm = new(_dbContext, _user, this);
            projectsForm.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
