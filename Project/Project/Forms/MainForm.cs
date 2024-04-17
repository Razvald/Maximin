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

        private void btnGraph_Click(object sender, EventArgs e)
        {
            GraphForm graphForm = new(_dbContext, _user, this);
            graphForm.Show();
            this.Hide();
        }

        private void btnRouteMeas_Click(object sender, EventArgs e)
        {
            RouteMeasForm routeMeasForm = new(_dbContext, _user, this);
            routeMeasForm.Show();
            this.Hide();
        }

        private void btnMeasurement_Click(object sender, EventArgs e)
        {
            MeasurementForm measurementForm = new(_dbContext, _user, this);
            measurementForm.Show();
            this.Hide();
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            RoutesForm routesForm = new(_dbContext, _user, this);
            routesForm.Show();
            this.Hide();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            ProjectsForm projectsForm = new(_dbContext, _user, this);
            projectsForm.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new(_dbContext, _user, this);
            usersForm.Show();
            this.Hide();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new(_dbContext, _user, this);
            employeesForm.Show();
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
