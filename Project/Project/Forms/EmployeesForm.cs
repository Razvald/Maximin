using Project.Create;
using Project.Database;
using Project.Database.Entities;

namespace Project.Forms
{
    public partial class EmployeesForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly User _user;
        private readonly MainForm _mainForm;
        public EmployeesForm(AppDbContext dbContext, User user, MainForm mainForm)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _user = user;
            _mainForm = mainForm;

            if (_user.UserRole == Role.Admin)
            {
                btnAdd.Visible = true;
                btnSave.Visible = true;
                dgvEmpls.ReadOnly = false;
            }
            else
            {
                btnAdd.Visible = false;
                btnSave.Visible = false;
                dgvEmpls.ReadOnly = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateEmplForm createEmplForm = new(_dbContext);
            createEmplForm.ShowDialog();
            UpdateEmplsList();
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

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            List<Employee> employees = _dbContext.Employees.ToList();

            dgvEmpls.Columns.Clear();
            dgvEmpls.AutoGenerateColumns = false;

            dgvEmpls.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID"
            });
            dgvEmpls.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name"
            });
            dgvEmpls.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Position",
                HeaderText = "Position"
            });

            dgvEmpls.DataSource = employees;
        }

        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Show();
        }

        private void UpdateEmplsList()
        {
            dgvEmpls.DataSource = null;
            dgvEmpls.DataSource = _dbContext.Employees.ToList();
        }
    }
}
