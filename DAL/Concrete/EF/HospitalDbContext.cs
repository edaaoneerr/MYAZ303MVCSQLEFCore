using Microsoft.EntityFrameworkCore;
using MVCSQLEFCore.DAL.Config;
using MVCSQLEFCore.Entities;

namespace MVCSQLEFCore.DAL.Concrete.EF
{
    public class HospitalDbContext: DbContext
    {
        public string ConnectionString { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Intern> Interns { get; set; }

        public HospitalDbContext()
        {
            ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HospitalDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DoctorConfig());
            modelBuilder.ApplyConfiguration(new InternConfig());
            modelBuilder.ApplyConfiguration(new PatientConfig());
            modelBuilder.ApplyConfiguration(new SpecialtyConfig());

        }

    }
}
