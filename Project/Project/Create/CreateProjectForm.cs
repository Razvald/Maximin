using Project.Database;
using Project.Database.Entities;

namespace Project.Forms
{
    public partial class CreateProjectForm : Form
    {
        private readonly AppDbContext _dbContext;
        public CreateProjectForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            foreach (var user in _dbContext.Users)
            {
                cmbUserID.Items.Add($"{user.UserName} (ID: {user.ID})");
            }

            foreach (var employee in _dbContext.Employees)
            {
                cmbEmpID.Items.Add($"{employee.Name} (ID: {employee.ID})");
            }

            foreach (var route in _dbContext.Routes)
            {
                cmbRoutesID.Items.Add($"{route.RouteName} (ID: {route.ID})");
            }
        }

        private int GetIDFromComboBox(ComboBox comboBox)
        {
            string selected = comboBox.SelectedItem.ToString();
            int startIndex = selected.IndexOf("(ID: ") + 5;
            int endIndex = selected.IndexOf(")");
            string iDString = selected.Substring(startIndex, endIndex - startIndex);
            return int.Parse(iDString);
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
                var newProject = new Projekt
                {
                    ProjectName = txtProjectName.Text,
                    ProjectDescription = txtDescription.Text,
                    OrderDate = datePickerOrderDate.Value,
                    Cost = Convert.ToInt32(txtCost.Text),
                    UserID = GetIDFromComboBox(cmbUserID),
                    EmployeeID = GetIDFromComboBox(cmbEmpID),
                    RouteID = GetIDFromComboBox(cmbRoutesID)
                };

                _dbContext.Projects.Add(newProject);
                _dbContext.SaveChanges();

                MessageBox.Show("Проект успешно создан.");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании проекта: {ex?.InnerException?.Message}");
            }
        }

        private bool AreAllFieldsFilled()
        {
            return !string.IsNullOrEmpty(txtProjectName.Text) &&
                   !string.IsNullOrEmpty(txtDescription.Text) &&
                   datePickerOrderDate.Value != null &&
                   !string.IsNullOrEmpty(txtCost.Text) &&
                   cmbUserID.SelectedItem != null &&
                   cmbEmpID.SelectedItem != null &&
                   cmbRoutesID.SelectedItem != null;
        }

        private void CreateProjectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
