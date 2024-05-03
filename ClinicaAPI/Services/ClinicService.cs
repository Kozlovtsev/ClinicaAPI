using ClinicaAPI.Context;

namespace ClinicaAPI.Services
{
    public class ClinicService
    {
        private ClinicContext _context;

        public ClinicService()
        {
            _context = new ClinicContext();
        }

        public async Task Add(object entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Doctors> GetDoctors()
        {
            return _context.Doctors.ToList();
        }

        public IEnumerable<Patient> GetPatients()
        {
            return _context.Patients.ToList();
        }

        public async Task UpdateDoctors(Guid doctorId, Doctors newData)
        {
            var doctor = await _context.Doctors.FindAsync(doctorId);
            if (doctor != null)
            {
                doctor.FirstName = newData.FirstName;
                doctor.LastName = newData.LastName;
                doctor.Specialization = newData.Specialization;
                doctor.Office = newData.Office;

                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdatePatient(Guid patientId, Patient newData)
        {
            var patient = await _context.Patients.FindAsync(patientId);
            if (patient != null)
            {
                patient.FirstName = newData.FirstName;
                patient.LastName = newData.LastName;
                patient.Age = newData.Age;
                patient.Gender = newData.Gender;
                patient.InsuranceNumber = newData.InsuranceNumber;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteDoctors(Guid doctorId)
        {
            var doctor = await _context.Doctors.FindAsync(doctorId);
            if (doctor != null)
            {
                _context.Doctors.Remove(doctor);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeletePatient(Guid patientId)
        {
            var patient = await _context.Patients.FindAsync(patientId);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                await _context.SaveChangesAsync();
            }
        }
    }
}
