namespace ehospitalsystem_WebApi.Models
{
    public class PatientMedicalRecord
    {
        public int Id { get; set; }
        public int  PatientHealthCareNumber { get; set; }
        public string? PrincipalDoctor { get; set; }
        public string? AllergiesList { get; set; }
        public string? MedicalCondition { get; set; }
        public string? Surgical_Operation { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public string? ReasonOfAdmission { get; set; }
        public int DiagnosisId { get; set; }
        public string? ClincialSummary { get; set; }
        public DateTime DateDischarged { get; set; }
        public string? ConditionAtDischarged { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
