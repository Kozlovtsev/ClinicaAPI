namespace ClinicaAPI.Context
{
    public class Patient
    {
        public Guid PatientID { get; set; }
        public string? FirstName { get; set;}
        public string? LastName { get; set;}
        public int? Age { get; set;}
        public string? Gender { get; set; }
        public string? InsuranceNumber { get; set; }
    }
}
