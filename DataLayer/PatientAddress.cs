namespace PatientsMedicines.DataLayer
{
    public class PatientAddress
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public Patient Patient { get; set; }
    }
}
