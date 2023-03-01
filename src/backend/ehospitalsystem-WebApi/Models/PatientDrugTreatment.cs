namespace ehospitalsystem_WebApi.Models
{
    public class PatientDrugTreatment
    {
        public int Id { get; set; }
        public int PatientHealthCareNumber { get; set; }
        public int DiagnosisId { get; set; }
        public int DateOfTreatment { get; set; }
        public string? Comment { get; set; }

    }
}
