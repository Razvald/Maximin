using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Database.Entities
{
    public class RouteMeasurement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("Route")]
        public int RouteId { get; set; }

        [ForeignKey("Measurement")]
        public int MeasurementId { get; set; }

        public virtual Route Route { get; set; }
        public virtual Measurement Measurement { get; set; }
    }
}
