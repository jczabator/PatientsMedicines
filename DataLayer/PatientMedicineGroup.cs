namespace PatientsMedicines.DataLayer;

public class PatientMedicineGroup
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public int MedicineGroupId { get; set; }
    public Patient Patient { get; set; }
    public MedicineGroup MedicineGroup { get; set; }
}
