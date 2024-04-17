using Project.Database;
using Project.Database.Entities;
using System.Xml.Linq;

namespace Project.Forms
{
    public partial class CreateRouteForm : Form
    {
        private readonly AppDbContext _dbContext;
        public CreateRouteForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
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
                var newRoute = new Route
                {
                    RouteName = txbName.Text,
                    RouteDescription = txbDesc.Text
                };

                _dbContext.Routes.Add(newRoute);
                _dbContext.SaveChanges();

                MessageBox.Show("Узел успешно создан.");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании узла: {ex?.InnerException?.Message}");
                MessageBox.Show($"Ошибка при создании узла: {ex?.Message}");
            }
        }

        private bool AreAllFieldsFilled()
        {
            return !string.IsNullOrEmpty(txbName.Text) &&
                !string.IsNullOrEmpty(txbDesc.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CreateRouteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
