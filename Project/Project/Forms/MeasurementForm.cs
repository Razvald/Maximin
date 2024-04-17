using Project.Create;
using Project.Database;
using Project.Database.Entities;

namespace Project.Forms
{
    public partial class MeasurementForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly User _user;
        private readonly MainForm _mainForm;
        public MeasurementForm(AppDbContext dbContext, User user, MainForm mainForm)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _user = user;
            _mainForm = mainForm;


            if (_user.UserRole == Role.Admin)
            {
                btnAdd.Visible = true;
                btnSave.Visible = true;
                dgvMeasure.ReadOnly = false;
            }
            else
            {
                btnAdd.Visible = false;
                btnSave.Visible = false;
                dgvMeasure.ReadOnly = true;
            }
        }

        private void MeasurementForm_Load(object sender, EventArgs e)
        {
            List<Measurement> measurements = _dbContext.Measurements.ToList();

            dgvMeasure.Columns.Clear();
            dgvMeasure.AutoGenerateColumns = false;

            dgvMeasure.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID"
            });
            dgvMeasure.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Value",
                HeaderText = "Value"
            });
            dgvMeasure.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "XCoordinate",
                HeaderText = "X Coordinate"
            });
            dgvMeasure.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "YCoordinate",
                HeaderText = "Y Coordinate"
            });

            dgvMeasure.DataSource = measurements;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateMeasureForm createMeasureForm = new(_dbContext);
            createMeasureForm.ShowDialog();
            UpdateMeasureList();
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

        private void MeasurementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Show();
        }

        private void UpdateMeasureList()
        {
            dgvMeasure.DataSource = null;
            dgvMeasure.DataSource = _dbContext.Measurements.ToList();
        }
    }
}
