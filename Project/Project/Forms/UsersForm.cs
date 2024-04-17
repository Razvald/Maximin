using Project.Create;
using Project.Database;
using Project.Database.Entities;

namespace Project.Forms
{
    public partial class UsersForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly User _user;
        private readonly MainForm _mainForm;
        public UsersForm(AppDbContext dbContext, User user, MainForm mainForm)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _user = user;
            _mainForm = mainForm;

            if (_user.UserRole == Role.Admin)
            {
                btnAdd.Visible = true;
                btnSave.Visible = true;
                dgvUsers.ReadOnly = false;
            }
            else
            {
                btnAdd.Visible = false;
                btnSave.Visible = false;
                dgvUsers.ReadOnly = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var createUserForm = new CreateUserForm(_dbContext);
            createUserForm.ShowDialog();
            UpdateUsersList();
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

        private void UsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Show();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            List<User> users = _dbContext.Users.ToList();

            dgvUsers.Columns.Clear();
            dgvUsers.AutoGenerateColumns = false;

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID"
            });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserName",
                HeaderText = "Name"
            });

            if (_user.UserRole == Role.Admin)
            {
                dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Login",
                    HeaderText = "Login"
                });
                dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Password",
                    HeaderText = "Password"
                });
            }
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserRole",
                HeaderText = "UserRole"
            });

            dgvUsers.DataSource = users;
        }

        private void UpdateUsersList()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = _dbContext.Users.ToList();
        }
    }
}
