using System.ComponentModel.DataAnnotations;

namespace WebbyMyself.Models
{
    public class Class
    {
        [Key]
        public int? ID { get; set; }

        public string? ClassName { get; set; }

        [Required]
        public int BranchID { get; set; }
    }
}
