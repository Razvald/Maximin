using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Database.Entities
{
    public class Projekt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string? ProjectName { get; set; }
        public string? ProjectDescription { get; set; }
        public DateTime OrderDate { get; set; }
        public Status Status { get; set; }
        public int Cost { get; set; }

        [ForeignKey("User")]
        public int? UserID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }

        [ForeignKey("Measurement")]
        public int MeasurementID { get; set; }

        public virtual User User { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Measurement Measurement { get; set; }
    }

    public enum Status
    {
        Complete,
        Wainting
    }
}
