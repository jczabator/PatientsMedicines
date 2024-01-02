namespace PatientsMedicines.DataLayer;

public class Medicine
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string SerialNumber { get; set; }
    public DateOnly ExpiryDate { get; set; }
    IList<MedicineGroup> MedicineGroups { get; set; }
}