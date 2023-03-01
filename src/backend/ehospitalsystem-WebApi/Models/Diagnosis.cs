namespace ehospitalsystem_WebApi.Models
{
    public class Diagnosis
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int PatientHealthCareNumber { get; set; }
        public string? Primary_Symtoms { get; set; }
        public string? Primary_Diagnosis { get; set; }
        public string? Secondary_Diagnosis { get; set; }
        public string? Others { get; set; }
    }
}
