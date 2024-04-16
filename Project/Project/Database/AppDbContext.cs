using Microsoft.EntityFrameworkCore;
using Project.Database.Entities;

namespace Project.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Projekt> Projects { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<MeasurementPoint> MeasurementPoints { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<MeasurementMeasurementPoint> MeasurementMeasurementPoints { get; set; }

        public AppDbContext() : base()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local); " +
                "Database=Maxim; " +
                "Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            List<User> users = new()
            {
                new() { ID = 1, Login = "1", Password = "1", UserName = "qwerty", UserRole = Role.Admin },
                new() { ID = 2, Login = "2", Password = "2", UserName = "asdfg", UserRole = Role.Worker },
                new() { ID = 3, Login = "2", Password = "2", UserName = "asdfg", UserRole = Role.Worker }
            };
            List<Employee> employees = new()
            {
                new() { ID = 1, Name = "xcvbn", Position = PositionType.Technician },
                new() { ID = 2, Name = "uiop", Position = PositionType.Manager },
                new() { ID = 3, Name = "hjkl", Position = PositionType.Engineer }
            };
            List<Projekt> projekts = new()
            {
                new() { ID = 1, Cost = 14, OrderDate = new DateTime(2024, 4, 14), Status = Status.Wainting, UserID = 2, EmployeeID = 1, MeasurementID = 1 },
                new() { ID = 2, Cost = 68, OrderDate = new DateTime(2024, 4, 15), Status = Status.Wainting, UserID = 3, EmployeeID = 2, MeasurementID = 2 }
            };
            List<Route> routes = new()
            {
                new() { ID = 1, ProjectID = 1, RouteLength = 12 },
                new() { ID = 2, ProjectID = 2, RouteLength = 24 }
            };
            List<MeasurementPoint> measurementPoints = new()
            {
                new() { ID = 1, XCoordinate = 1, YCoordinate = 1 },
                new() { ID = 2, XCoordinate = 3, YCoordinate = 8 },
                new() { ID = 3, XCoordinate = 2, YCoordinate = 9 },
                new() { ID = 4, XCoordinate = 6, YCoordinate = 2 }
            };
            List<Measurement> measurements = new()
            {
                new() { ID = 1 },
                new() { ID = 2 },
            };
            List<MeasurementMeasurementPoint> measurementMeasurements = new()
            {
                new() { ID = 1, MeasurementID = 1, MeasurementPointID = 1 },
                new() { ID = 2, MeasurementID = 1, MeasurementPointID = 2 },
                new() { ID = 3, MeasurementID = 2, MeasurementPointID = 3 },
                new() { ID = 4, MeasurementID = 2, MeasurementPointID = 4 }
            };

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Employee>().HasData(employees);
            modelBuilder.Entity<Projekt>().HasData(projekts);
            modelBuilder.Entity<Route>().HasData(routes);
            modelBuilder.Entity<MeasurementPoint>().HasData(measurementPoints);
            modelBuilder.Entity<Measurement>().HasData(measurements);
            modelBuilder.Entity<MeasurementMeasurementPoint>().HasData(measurementMeasurements);
        }
    }
}
