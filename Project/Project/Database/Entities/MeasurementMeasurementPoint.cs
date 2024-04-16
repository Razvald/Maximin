using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project.Database.Entities
{
    public class MeasurementMeasurementPoint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("Measurement")]
        public int MeasurementID { get; set; }

        [ForeignKey("MeasurementPoint")]
        public int MeasurementPointID { get; set; }

        public Measurement Measurement { get; set; }
        public MeasurementPoint MeasurementPoint { get; set; }
    }
}
