using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project.Database.Entities
{
    public class Route
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string? RouteName { get; set; }
        public string? RouteDescription { get; set; }
        public int RouteLength { get; set; } = 0;
    }
}
