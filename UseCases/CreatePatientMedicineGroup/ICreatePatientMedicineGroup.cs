using PatientsMedicines.DataLayer;

namespace PatientsMedicines.UseCases.CreatePatientMedicineGroup
{
    public interface ICreatePatientMedicineGroup
    {
        Task CreatePatientMedicineGroup(PatientMedicineGroup patientMedicineGroup);
    }
}
