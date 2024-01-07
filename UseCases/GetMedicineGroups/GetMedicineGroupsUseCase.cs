using Microsoft.EntityFrameworkCore;
using PatientsMedicines.DataLayer;

namespace PatientsMedicines.UseCases.GetMedicineGroups
{
    public class GetMedicineGroupsUseCase : IGetMedicineGroups
    {
        private readonly MedicineResearchDbContext _context;

        public GetMedicineGroupsUseCase(MedicineResearchDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MedicineGroup>> GetMedicineGroups()
        {
            return await _context.MedicineGroups
                .AsNoTracking()
                .Include(mg => mg.Group)
                .Include(mg => mg.Medicine)                
                .ToListAsync();
        }
    }
}
