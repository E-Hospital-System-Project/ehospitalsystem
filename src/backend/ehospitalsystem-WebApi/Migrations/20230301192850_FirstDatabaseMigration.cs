using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ehospitalsystem_WebApi.Migrations
{
    public partial class FirstDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientHealthCareNumber = table.Column<int>(type: "int", nullable: false),
                    AppointmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppointmentTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diagnoses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientHealthCareNumber = table.Column<int>(type: "int", nullable: false),
                    Primary_Symtoms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Primary_Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Secondary_Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Others = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnoses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    EmployeeFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeHouseAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfHired = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateExited = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalDrugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrugCategoryId = table.Column<int>(type: "int", nullable: false),
                    DrugName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DrugCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DosageAdministered = table.Column<int>(type: "int", nullable: false),
                    DosageDuration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalDrugs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientDrugTreatments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientHealthCareNumber = table.Column<int>(type: "int", nullable: false),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    DateOfTreatment = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDrugTreatments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientMedicalRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientHealthCareNumber = table.Column<int>(type: "int", nullable: false),
                    PrincipalDoctor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllergiesList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surgical_Operation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReasonOfAdmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    ClincialSummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDischarged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConditionAtDischarged = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedicalRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientHealthCareNumber = table.Column<int>(type: "int", nullable: false),
                    PatientType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaLocality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientVitals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientHealthCareNumber = table.Column<int>(type: "int", nullable: false),
                    Patient_Height = table.Column<double>(type: "float", nullable: false),
                    Patient_Weight = table.Column<double>(type: "float", nullable: false),
                    PulseRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodPressure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodSugar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientVitals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Drug_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrugCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Drug_Categories", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "MedicalDrugs");

            migrationBuilder.DropTable(
                name: "PatientDrugTreatments");

            migrationBuilder.DropTable(
                name: "PatientMedicalRecords");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "PatientVitals");

            migrationBuilder.DropTable(
                name: "Ref_Drug_Categories");
        }
    }
}
