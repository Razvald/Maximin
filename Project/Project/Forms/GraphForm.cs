using Microsoft.EntityFrameworkCore;
using Project.Database;
using Project.Database.Entities;
using ScottPlot;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Project.Forms
{
    public partial class GraphForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly User _user;
        private readonly MainForm _mainForm;
        public GraphForm(AppDbContext dbContext, User user, MainForm mainForm)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _user = user;
            _mainForm = mainForm;

            FillComboBox();
            UpdatePlot();
        }

        private void UpdatePlot()
        {
            formsPlot1.Plot.Clear();

            var unique = _dbContext.Routes.Select(w => w.ID).Distinct().ToList();

            List<PieSlice> slices = new();

            foreach (var id in unique)
            {
                int count = _dbContext.RouteMeasurement.Count(rw => rw.RouteId == id);

                PieSlice slice = new()
                {
                    Value = count,
                    FillColor = GetColorForWellType(id),
                    Label = _dbContext.Routes.FirstOrDefault(r => r.ID == id).RouteName
                };

                slices.Add(slice);
            }

            var pie = formsPlot1.Plot.Add.Pie(slices);
            pie.ExplodeFraction = .1;
            pie.ShowSliceLabels = true;
            pie.SliceLabelDistance = 1.3;
            formsPlot1.Plot.Axes.SetLimits(-1, 1, -1.5, 1.5);

            formsPlot1.Plot.XLabel("");
            formsPlot1.Plot.YLabel("");

            formsPlot1.Refresh();
        }

        private static ScottPlot.Color GetColorForWellType(int wellType)
        {
            return wellType switch
            {
                1 => Colors.Red,
                2 => Colors.Blue,
                3 => Colors.Green,
                4 => Colors.Gray,
                _ => Colors.Aquamarine,
            };
        }

        private void FillComboBox()
        {
            cmbRoute.Items.Clear();
            foreach (var route in _dbContext.Routes)
            {
                cmbRoute.Items.Add(route.RouteName);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private void GraphForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Show();
        }

        private void cmbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlot1();
        }

        private void UpdatePlot1()
        {
            formsPlot1.Plot.Clear();

            Plot plot = formsPlot1.Plot;

            string selected = cmbRoute.SelectedItem?.ToString();

            var selectedRoute = _dbContext.Routes.FirstOrDefault(r => r.RouteName == selected);
            if (selectedRoute == null) return;

            // Получаем измерения, связанные с выбранным маршрутом
            var measurements = _dbContext.RouteMeasurement
                .Include(rm => rm.Measurement)
                .Where(rm => rm.RouteId == selectedRoute.ID)
                .Select(rm => rm.Measurement)
                .OrderBy(m => m.XCoordinate)  // Сортировка по X
                .ToList();

            if (!measurements.Any()) return;

            // Извлекаем координаты
            double[] X = measurements.Select(m => m.XCoordinate).ToArray();
            double[] Y = measurements.Select(m => m.YCoordinate).ToArray();

            // Добавляем точки на график
            var scatter = plot.Add.Scatter(X, Y);
            scatter.Smooth = true;

            // Устанавливаем пределы осей
            plot.Axes.SetLimits(X.Min() - 10, X.Max() + 10, Y.Min() - 10, Y.Max() + 10);

            formsPlot1.Refresh();
        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            UpdatePlot();
        }
    }
}
