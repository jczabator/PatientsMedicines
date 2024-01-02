using Microsoft.EntityFrameworkCore;
using PatientsMedicines.DataLayer;

namespace PatientsMedicines.UseCases.GetPatientMedicineGroups
{
    public class GetPatientMedicineGroupsUseCase : IGetPatientMedicineGroups
    {
        private readonly MedicineResearchDbContext _context;

        public GetPatientMedicineGroupsUseCase(MedicineResearchDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PatientMedicineGroup>> GetPatientMedicineGroups()
        {
            return await _context.PatientMedicineGroups.AsNoTracking()
                .Include(m => m.MedicineGroup)
                .ThenInclude(mg => mg.Group)
                .Include(m => m.MedicineGroup)
                .ThenInclude(mg => mg.Medicine)
                .Include(m => m.Patient).ToListAsync();
        }
    }
}
