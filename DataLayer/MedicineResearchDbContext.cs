using Microsoft.EntityFrameworkCore;
using System.IO;

namespace PatientsMedicines.DataLayer;

public class MedicineResearchDbContext : DbContext
{
    public DbSet<Group> Groups { get; set; }
    public DbSet<Medicine> Medicines { get; set; }
    public DbSet<MedicineGroup> MedicineGroups { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<PatientMedicineGroup> PatientMedicineGroups { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<PatientAddress> PatientAddresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MedicineResearch; Integrated Security = True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Group>().HasData(new Group { Id = 1, Name = "A"});
        modelBuilder.Entity<Group>().HasData(new Group { Id = 2, Name = "B"});

        modelBuilder.Entity<Medicine>().HasData(new Medicine { Id = 1, Name = "Pfumoflux", SerialNumber = "ASD1234QWER", ExpiryDate = DateOnly.FromDateTime(DateTime.Now), 
            Description= @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus rutrum nisi quis interdum tincidunt. 
                Suspendisse venenatis diam eu dui pulvinar, vel auctor felis aliquam. Quisque bibendum velit consectetur tellus suscipit, 
                sit amet accumsan enim sagittis. Vestibulum sit amet diam et orci pulvinar interdum. Nulla ac nulla a ligula euismod accumsan. 
                In ac turpis eu eros hendrerit sagittis. Aliquam erat volutpat. Aliquam blandit pretium congue." });

        modelBuilder.Entity<MedicineGroup>().HasData(new MedicineGroup { Id = 1, GroupId = 1, MedicineId = 1, GroupType = GroupType.Normal });
        modelBuilder.Entity<MedicineGroup>().HasData(new MedicineGroup { Id = 2, GroupId = 2, MedicineId = null, GroupType = GroupType.Control });

        modelBuilder.Entity<Patient>().HasData(new Patient { Id = 1, FirstName = "Jan", LastName = "Kowalski", Age = 45, 
            BirthDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-45)), Gender = Gender.Male, SocialNumber = "72033075515", 
            Height = 175, Weight = 80, BMI = 27, EmailAddress = "jan.kowalski@email.com", PhoneNumber = "123456789"
        });

        modelBuilder.Entity<Patient>().HasData(new Patient
        {
            Id = 2,
            FirstName = "Janina",
            LastName = "Kowalska",
            Age = 47,
            BirthDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-47)),
            Gender = Gender.Female,
            SocialNumber = "72033075515",
            Height = 155,
            Weight = 70,
            BMI = 30,
            EmailAddress = "janina.kowalska@email.com",
            PhoneNumber = "12345678"
        });

        modelBuilder.Entity<PatientMedicineGroup>().HasData(new PatientMedicineGroup { Id = 1, PatientId = 1, MedicineGroupId = 1 });
        modelBuilder.Entity<PatientMedicineGroup>().HasData(new PatientMedicineGroup { Id = 2, PatientId = 2, MedicineGroupId = 2 });

        modelBuilder.Entity<Address>().HasData(new Address
        {
            Id = 1,
            Street = "Borowska",
            HouseNumber = "500A",
            FlatNumber = "14C",
            City = "Wrocław",
            Country = "Polska",
            PostalCode = "56-662",
            Region = "Lower Silesia"
        });

        modelBuilder.Entity<PatientAddress>().HasData(new PatientAddress { Id = 1, AddressId = 1, PatientId = 1});
        modelBuilder.Entity<PatientAddress>().HasData(new PatientAddress { Id = 2, AddressId = 1, PatientId = 2 });
    }
}
