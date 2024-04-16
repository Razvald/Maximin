using Project.Database;
using Project.Database.Entities;

namespace Project.Forms
{
    public partial class ProjectsForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly User _user;
        private readonly MainForm _mainForm;
        public ProjectsForm(AppDbContext dbContext, User user, MainForm mainForm)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _user = user;
            _mainForm = mainForm;

            if (_user.UserRole == Role.Admin)
            {
                btnAdd.Visible = true;
            }
            else
            {
                btnAdd.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var createProjectForm = new CreateProjectForm(_dbContext);
            var result = createProjectForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                UpdateProjectsList();
            }

            UpdateProjectsList();
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
                MessageBox.Show(ex?.InnerException?.Message);
            }
        }

        private void ProjectsForm_Load(object sender, EventArgs e)
        {
            List<Projekt> projects;

            if (_user.UserRole == Role.Admin)
            {
                projects = _dbContext.Projects.ToList();
            }
            else
            {
                projects = _dbContext.Projects.Where(p => p.UserID == _user.ID).ToList();
            }

            dgvProjects.Columns.Clear();

            dgvProjects.AutoGenerateColumns = false;

            dgvProjects.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID"
            });
            dgvProjects.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProjectName",
                HeaderText = "Title"
            });
            dgvProjects.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProjectDescription",
                HeaderText = "Description"
            });
            dgvProjects.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderDate",
                HeaderText = "Date"
            });
            dgvProjects.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cost",
                HeaderText = "Cost"
            });

            dgvProjects.DataSource = projects;
        }

        private void UpdateProjectsList()
        {
            // Обновляем список проектов после добавления нового
            dgvProjects.DataSource = null;
            dgvProjects.DataSource = _dbContext.Projects.ToList();
        }

        private void ProjectsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Show();
        }
    }
}
