namespace ehospitalsystem_WebApi.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public int PatientHealthCareNumber { get; set; }
        public string? PatientType { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? FamilyName { get; set; }
        public string? HomeAddress { get; set; }
        public string? AreaLocality { get; set; }
        public string? City { get; set; }
        public string? StateProvince { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
    }
}
