using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Database.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string UserName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }
    }

    public enum Role
    {
        Admin,
        Worker
    }
}
