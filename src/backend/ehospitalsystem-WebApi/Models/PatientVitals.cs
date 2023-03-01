namespace ehospitalsystem_WebApi.Models
{
    public class PatientVitals
    {
        public int Id { get; set; }
        public int PatientHealthCareNumber { get; set; }
        public double Patient_Height { get; set; }
        public double Patient_Weight { get; set; }
        public string? PulseRate { get; set; }
        public string? BloodPressure { get; set; }
        public string? BloodSugar { get; set; }
    }
}
