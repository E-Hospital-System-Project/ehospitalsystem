namespace ehospitalsystem_WebApi.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientHealthCareNumber { get; set; }
        public string? AppointmentType { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
    }
}
