namespace ehospitalsystem_WebApi.Models
{
    public class MedicalDrug
    {
        public int Id { get; set; }
        public int DrugCategoryId { get; set; }
        public string? DrugName { get; set; }
        public string? DrugDescription { get;set; }
        public decimal UnitCost { get; set; }
        public decimal DrugCost { get; set; }
        public int DosageAdministered { get; set; }
        public int DosageDuration { get; set; }
    }
}
