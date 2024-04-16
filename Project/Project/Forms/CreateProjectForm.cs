using Microsoft.VisualBasic.ApplicationServices;
using Project.Database;
using Project.Database.Entities;
using System.Diagnostics.Metrics;

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

            foreach (var measurement in _dbContext.Measurements)
            {
                cmbMeasurementID.Items.Add($"(ID: {measurement.ID})");
            }
        }

        // Получение ID пользователя из выбранного имени в комбобоксе
        private int GetUserIDFromComboBox()
        {
            string selectedUser = cmbUserID.SelectedItem.ToString();
            int startIndex = selectedUser.IndexOf("(ID: ") + 5;
            int endIndex = selectedUser.IndexOf(")");
            string userIDString = selectedUser.Substring(startIndex, endIndex - startIndex);
            return int.Parse(userIDString);
        }

        // Получение ID сотрудника из выбранного имени в комбобоксе
        private int GetEmployeeIDFromComboBox()
        {
            string selectedEmployee = cmbEmpID.SelectedItem.ToString();
            int startIndex = selectedEmployee.IndexOf("(ID: ") + 5;
            int endIndex = selectedEmployee.IndexOf(")");
            string employeeIDString = selectedEmployee.Substring(startIndex, endIndex - startIndex);
            return int.Parse(employeeIDString);
        }

        // Получение ID измерения из выбранного имени в комбобоксе
        private int GetMeasurementIDFromComboBox()
        {
            string selectedMeasurement = cmbMeasurementID.SelectedItem.ToString();
            int startIndex = selectedMeasurement.IndexOf("(ID: ") + 5;
            int endIndex = selectedMeasurement.IndexOf(")");
            string measurementIDString = selectedMeasurement.Substring(startIndex, endIndex - startIndex);
            return int.Parse(measurementIDString);
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
                    UserID = GetUserIDFromComboBox(),
                    EmployeeID = GetEmployeeIDFromComboBox(),
                    MeasurementID = GetMeasurementIDFromComboBox()
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
                   cmbMeasurementID.SelectedItem != null;
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
