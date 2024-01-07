namespace PatientsMedicines.DataLayer;

//TODO: not needed table
public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    IList<MedicineGroup> MedicineGroups { get; set; }
}
