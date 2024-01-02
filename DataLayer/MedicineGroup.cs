namespace PatientsMedicines.DataLayer
{
    public class MedicineGroup
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int? MedicineId { get; set; }
        public GroupType GroupType { get; set; }
        public IList<PatientMedicineGroup> PatientMedicineGroups { get; set; }
        public Group Group { get; set; }
        public Medicine Medicine { get; set; }
    }
}
