using PatientsMedicines.DataLayer;

namespace PatientsMedicines.UseCases.GetPatients
{
    public interface IGetPatients
    {
        Task<IEnumerable<Patient>> GetPatients();
    }
}
