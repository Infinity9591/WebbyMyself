using System.ComponentModel.DataAnnotations;

namespace WebbyMyself.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        [Required]
        public int ClassID { get; set; }
    }
}
