using PatientsMedicines.DataLayer;

namespace PatientsMedicines.UseCases.GetMedicineGroups
{
    public interface IGetMedicineGroups
    {
        Task<IEnumerable<MedicineGroup>> GetMedicineGroups();
    }
}
