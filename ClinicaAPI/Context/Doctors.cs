using System.ComponentModel.DataAnnotations;

namespace ClinicaAPI.Context
{
    public class Doctors
    {
        [Key]
        public Guid DoctorID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Specialization { get; set; }
        public int? Office { get; set; }
    }
}
