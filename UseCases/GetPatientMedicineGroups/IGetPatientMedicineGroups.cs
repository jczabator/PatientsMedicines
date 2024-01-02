using PatientsMedicines.DataLayer;

namespace PatientsMedicines.UseCases.GetPatientMedicineGroups
{
    public interface IGetPatientMedicineGroups
    {
        Task<IEnumerable<PatientMedicineGroup>> GetPatientMedicineGroups();
    }
}
