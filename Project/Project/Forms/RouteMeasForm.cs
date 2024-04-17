using Project.Create;
using Project.Database;
using Project.Database.Entities;

namespace Project.Forms
{
    public partial class RouteMeasForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly User _user;
        private readonly MainForm _mainForm;
        public RouteMeasForm(AppDbContext dbContext, User user, MainForm mainForm)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _user = user;
            _mainForm = mainForm;

            if (_user.UserRole == Role.Admin)
            {
                btnAdd.Visible = true;
                btnSave.Visible = true;
                dgvRouteMeas.ReadOnly = false;
            }
            else
            {
                btnAdd.Visible = false;
                btnSave.Visible = false;
                dgvRouteMeas.ReadOnly = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateRouteMeasForm createRouteMeasForm = new(_dbContext);
            createRouteMeasForm.ShowDialog();
            UpdateRouteMeasList();
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

        private void RouteMeasForm_Load(object sender, EventArgs e)
        {
            List<RouteMeasurement> employees = _dbContext.RouteMeasurement.ToList();

            dgvRouteMeas.Columns.Clear();
            dgvRouteMeas.AutoGenerateColumns = false;

            dgvRouteMeas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID"
            });
            dgvRouteMeas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MeasurementId",
                HeaderText = "Measurement Id"
            });
            dgvRouteMeas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RouteId",
                HeaderText = "Route Id"
            });

            dgvRouteMeas.DataSource = employees;
        }

        private void UpdateRouteMeasList()
        {
            dgvRouteMeas.DataSource = null;
            dgvRouteMeas.DataSource = _dbContext.RouteMeasurement.ToList();
        }

        private void RouteMeasForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Show();
        }
    }
}
