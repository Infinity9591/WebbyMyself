using Microsoft.EntityFrameworkCore;
using WebbyMyself.Models;

namespace WebbyMyself.Models
{
    public class StudentManageEntities : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBulder)
        {
            optionsBulder.UseSqlServer(
                "your connection string"
            );
        }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Student> Student { get; set; }
    }
}
