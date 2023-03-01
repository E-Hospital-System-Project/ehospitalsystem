namespace ehospitalsystem_WebApi.Models
{
    public class Medical_Employee
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string? JobTitle { get; set; }
        public string? EmployeeLevel { get; set; }
        public int DepartmentId { get; set; }
        public string? EmployeeFirstName { get; set; }
        public string? EmployeeLastName { get; set;}
        public string? EmployeeMiddleName { get; set; }
        public string? EmployeeHouseAddress { get; set; }
        public string? City { get; set;}
        public string? PostalCode { get; set;}
        public string? Country { get; set;}
        public string? PhoneNumber { get; set;}
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfHired { get; set; }
        public DateTime? DateExited { get; set; }
    }
}
