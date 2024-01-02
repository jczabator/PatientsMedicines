using Microsoft.EntityFrameworkCore;

namespace PatientsMedicines.DataLayer
{
    public class MedicineResearchDbContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<MedicineGroup> MedicineGroups { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientMedicineGroup> PatientMedicineGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MedicineResearch; Integrated Security = True");
        }                
    }
}
