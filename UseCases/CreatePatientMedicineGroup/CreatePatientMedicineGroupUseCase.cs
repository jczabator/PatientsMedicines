using PatientsMedicines.DataLayer;

namespace PatientsMedicines.UseCases.CreatePatientMedicineGroup
{
    public class CreatePatientMedicineGroupUseCase : ICreatePatientMedicineGroup
    {
        private readonly MedicineResearchDbContext _context;

        public CreatePatientMedicineGroupUseCase(MedicineResearchDbContext context)
        {
            _context = context;
        }

        public async Task CreatePatientMedicineGroup(PatientMedicineGroup patientMedicineGroup)
        {
            _context.PatientMedicineGroups.Add(patientMedicineGroup);
            _context.SaveChanges();
        }
    }
}
