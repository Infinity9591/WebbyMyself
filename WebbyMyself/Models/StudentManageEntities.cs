using Microsoft.EntityFrameworkCore;
using WebbyMyself.Models;

namespace WebbyMyself.Models
{
    public class StudentManageEntities : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBulder)
        {
            optionsBulder.UseSqlServer(
                "Data Source=DESKTOP-24T1NPF; Initial Catalog=SV;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            );
        }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Student> Student { get; set; }
    }
}
