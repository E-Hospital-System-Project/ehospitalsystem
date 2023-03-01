using ehospitalsystem_WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ehospitalsystem_WebApi.Data
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        public DbSet<Patient>? Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Medical_Employee> Employees { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<MedicalDrug> MedicalDrugs { get; set; }
        public DbSet<PatientDrugTreatment> PatientDrugTreatments { get; set; }
        public DbSet<PatientMedicalRecord> PatientMedicalRecords { get; set; }
        public DbSet<PatientVitals> PatientVitals { get; set; }
        public DbSet<Ref_Drug_Category> Ref_Drug_Categories { get; set; }
    }
}
