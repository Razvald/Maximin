using Project.Database;
using Project.Database.Entities;

namespace Project.Forms
{
    public partial class RoutesForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly User _user;
        private readonly MainForm _mainForm;
        public RoutesForm(AppDbContext dbContext, User user, MainForm mainForm)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _user = user;
            _mainForm = mainForm;

            if (_user.UserRole == Role.Admin)
            {
                btnAdd.Visible = true;
                btnSave.Visible = true;
                dgvRoute.ReadOnly = false;
            }
            else
            {
                btnAdd.Visible = false;
                btnSave.Visible = false;
                dgvRoute.ReadOnly = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateRouteForm createRouteForm = new(_dbContext);
            createRouteForm.ShowDialog();
            UpdateRoutesList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _dbContext.SaveChanges();
                MessageBox.Show("Сохранение выполнено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex?.Message);
                MessageBox.Show(ex?.InnerException?.Message);
            }
        }

        private void RoutesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Show();
        }

        private void UpdateRoutesList()
        {
            dgvRoute.DataSource = null;
            dgvRoute.DataSource = _dbContext.Routes.ToList();
        }

        private void RoutesForm_Load(object sender, EventArgs e)
        {
            List<Route> routes = _dbContext.Routes.ToList();

            dgvRoute.Columns.Clear();
            dgvRoute.AutoGenerateColumns = false;

            dgvRoute.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID"
            });
            dgvRoute.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RouteName",
                HeaderText = "Name"
            });
            dgvRoute.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RouteDescription",
                HeaderText = "Description"
            });
            dgvRoute.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RouteLength",
                HeaderText = "Length",
                ReadOnly = true
            });

            dgvRoute.DataSource = routes;
        }
    }
}
