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
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<RouteMeasurement> RouteMeasurement { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
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
                new() { ID = 3, Login = "3", Password = "3", UserName = "asdfg", UserRole = Role.Worker }
            };
            List<Employee> employees = new()
            {
                new() { ID = 1, Name = "xcvbn", Position = PositionType.Technician },
                new() { ID = 2, Name = "uiop", Position = PositionType.Manager },
                new() { ID = 3, Name = "hjkl", Position = PositionType.Engineer }
            };
            List<Projekt> projekts = new()
            {
                new() { ID = 1, Cost = 14, OrderDate = new DateTime(2024, 4, 14), UserID = 2, EmployeeID = 1, RouteID = 1 },
                new() { ID = 2, Cost = 68, OrderDate = new DateTime(2024, 4, 15), UserID = 3, EmployeeID = 2, RouteID = 2 }
            };
            List<Route> routes = new()
            {
                new() { ID = 1, RouteName = "first", RouteLength = 2 },
                new() { ID = 2, RouteName = "second", RouteLength = 4 }
            };
            List<Measurement> measurements = new()
            {
                new() { ID = 1, Value = 123, XCoordinate = 13, YCoordinate = 11 },
                new() { ID = 2, Value = 89, XCoordinate = 53, YCoordinate = 37 },
                new() { ID = 3, Value = 52, XCoordinate = 11, YCoordinate = 90 },
                new() { ID = 4, Value = 35, XCoordinate = 34, YCoordinate = 34 },
                new() { ID = 5, Value = 72, XCoordinate = 22, YCoordinate = 26 },
                new() { ID = 6, Value = 105, XCoordinate = 8, YCoordinate = 87 }
            };
            List<RouteMeasurement> routeMeasurements = new()
            {
                new() { ID = 1, MeasurementId = 1, RouteId = 1 },
                new() { ID = 2, MeasurementId = 2, RouteId = 1 },
                new() { ID = 3, MeasurementId = 3, RouteId = 2 },
                new() { ID = 4, MeasurementId = 4, RouteId = 2 },
                new() { ID = 5, MeasurementId = 5, RouteId = 2 },
                new() { ID = 6, MeasurementId = 6, RouteId = 2 }
            };

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Employee>().HasData(employees);
            modelBuilder.Entity<Projekt>().HasData(projekts);
            modelBuilder.Entity<Route>().HasData(routes);
            modelBuilder.Entity<Measurement>().HasData(measurements);
            modelBuilder.Entity<RouteMeasurement>().HasData(routeMeasurements);
        }

        public override int SaveChanges()
        {
            var addedRouteMeasurements = ChangeTracker.Entries<RouteMeasurement>()
                .Where(e => e.State == EntityState.Added)
                .ToList();

            foreach (var entry in addedRouteMeasurements)
            {
                var routeId = entry.Property("RouteId").CurrentValue;

                var route = Routes.FirstOrDefault(r => r.ID == (int)routeId);
                if (route != null)
                {
                    var measurementCount = RouteMeasurement.Count(rm => rm.RouteId == route.ID);
                    route.RouteLength = measurementCount + 1;
                }
            }

            return base.SaveChanges();
        }
    }
}
