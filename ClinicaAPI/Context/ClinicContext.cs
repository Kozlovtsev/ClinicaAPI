using Microsoft.EntityFrameworkCore;

namespace ClinicaAPI.Context
{
    public class ClinicContext: DbContext
    {
        public ClinicContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;initial catalog=ClinicDatabase;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;");
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
    }
}
