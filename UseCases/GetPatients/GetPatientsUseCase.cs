using Microsoft.EntityFrameworkCore;
using PatientsMedicines.DataLayer;

namespace PatientsMedicines.UseCases.GetPatients
{
    public class GetPatientsUseCase : IGetPatients
    {
        private MedicineResearchDbContext _context;

        public GetPatientsUseCase(MedicineResearchDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Patient>> GetPatients()
        {
            return await _context.Patients.ToListAsync();
        }
    }
}
