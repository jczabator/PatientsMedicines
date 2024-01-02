namespace PatientsMedicines.DataLayer
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string SocialNumber { get; set; }
        public int Age { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public decimal BMI { get; set; }
        public IList<PatientMedicineGroup> PatientMedicineGroups { get; set; } 
    }
}
