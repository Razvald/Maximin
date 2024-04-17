using Microsoft.EntityFrameworkCore;
using Project.Database;
using Project.Database.Entities;
using System.Xml.Linq;

namespace Project.Create
{
    public partial class CreateRouteMeasForm : Form
    {
        private readonly AppDbContext _dbContext;
        public CreateRouteMeasForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            foreach (var measures in _dbContext.Measurements)
            {
                cmbMeasure.Items.Add($"(ID: {measures.ID})");
            }

            foreach (var routes in _dbContext.Routes)
            {
                cmbRoute.Items.Add($"{routes.RouteName} (ID: {routes.ID})");
            }
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
                var newEmp = new RouteMeasurement
                {
                    MeasurementId = GetIDFromComboBox(cmbMeasure),
                    RouteId = GetIDFromComboBox(cmbRoute),
                };

                _dbContext.RouteMeasurement.Add(newEmp);
                _dbContext.SaveChanges();

                MessageBox.Show("Связь успешно создана.");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании связи: {ex?.InnerException?.Message}");
                MessageBox.Show($"Ошибка при создании связи: {ex?.Message}");
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

        private bool AreAllFieldsFilled()
        {
            return cmbMeasure.SelectedItem != null &&
                   cmbRoute.SelectedItem != null;
        }

        private void CreateRouteMeasForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
