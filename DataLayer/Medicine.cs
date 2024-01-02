namespace PatientsMedicines.DataLayer
{
    public class Medicine
    {
        public int Id { get; set; }
        public string MedicineSynonym { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string ExpiryDate { get; set; }
    }
}
