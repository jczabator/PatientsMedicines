namespace PatientsMedicines.DataLayer
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GroupType GroupType { get; set; }
        IList<MedicineGroup> MedicineGroups { get; set; }
    }
}
