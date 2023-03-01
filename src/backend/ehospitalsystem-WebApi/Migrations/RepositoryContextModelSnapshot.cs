﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ehospitalsystem_WebApi.Data;

#nullable disable

namespace ehospitalsystem_WebApi.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ehospitalsystem_WebApi.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("AppointmentTime")
                        .HasColumnType("time");

                    b.Property<string>("AppointmentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientHealthCareNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("ehospitalsystem_WebApi.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DepartmentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ehospitalsystem_WebApi.Models.Diagnosis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Others")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientHealthCareNumber")
                        .HasColumnType("int");

                    b.Property<string>("Primary_Diagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Primary_Symtoms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secondary_Diagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("ehospitalsystem_WebApi.Models.Medical_Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateExited")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfHired")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeHouseAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeMiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ehospitalsystem_WebApi.Models.MedicalDrug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DosageAdministered")
                        .HasColumnType("int");

                    b.Property<int>("DosageDuration")
                        .HasColumnType("int");

                    b.Property<int>("DrugCategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("DrugCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DrugDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("MedicalDrugs");
                });

            modelBuilder.Entity("ehospitalsystem_WebApi.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AreaLocality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientHealthCareNumber")
                        .HasColumnType("int");

                    b.Property<string>("PatientType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateProvince")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("ehospitalsystem_WebApi.Models.PatientDrugTreatment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DateOfTreatment")
                        .HasColumnType("int");

                    b.Property<int>("DiagnosisId")
                        .HasColumnType("int");

                    b.Property<int>("PatientHealthCareNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PatientDrugTreatments");
                });

            modelBuilder.Entity("ehospitalsystem_WebApi.Models.PatientMedicalRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("AdmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AllergiesList")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClincialSummary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConditionAtDischarged")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDischarged")
                        .HasColumnType("datetime2");

                    b.Property<int>("DiagnosisId")
                        .HasColumnType("int");

                    b.Property<string>("MedicalCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientHealthCareNumber")
                        .HasColumnType("int");

                    b.Property<string>("PrincipalDoctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonOfAdmission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surgical_Operation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PatientMedicalRecords");
                });

            modelBuilder.Entity("ehospitalsystem_WebApi.Models.PatientVitals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BloodPressure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodSugar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientHealthCareNumber")
                        .HasColumnType("int");

                    b.Property<double>("Patient_Height")
                        .HasColumnType("float");

                    b.Property<double>("Patient_Weight")
                        .HasColumnType("float");

                    b.Property<string>("PulseRate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PatientVitals");
                });

            modelBuilder.Entity("ehospitalsystem_WebApi.Models.Ref_Drug_Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ref_Drug_Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
