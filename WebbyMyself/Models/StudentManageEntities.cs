using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebbyMyself.Models;

namespace WebbyMyself.Models
{
    public class StudentManageEntities : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBulder)
        {
            optionsBulder.UseSqlServer(
                "Your connection string"
            );
        }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<ClassManage> ClassManage { get; set; }
        public virtual DbSet<StudentManage> StudentManage { get; set; }
    }
}
