﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using workshop.wwwapi.Data;

#nullable disable

namespace workshop.wwwapi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("workshop.wwwapi.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Booking")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("bookings");

                    b.Property<int>("DoctorId")
                        .HasColumnType("integer")
                        .HasColumnName("doctor_id");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer")
                        .HasColumnName("patient_id");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Booking = "2024-02-08",
                            DoctorId = 3,
                            PatientId = 1
                        },
                        new
                        {
                            Id = 2,
                            Booking = "2024-02-08",
                            DoctorId = 1,
                            PatientId = 4
                        },
                        new
                        {
                            Id = 3,
                            Booking = "2024-02-08",
                            DoctorId = 3,
                            PatientId = 2
                        },
                        new
                        {
                            Id = 4,
                            Booking = "2024-02-08",
                            DoctorId = 2,
                            PatientId = 6
                        },
                        new
                        {
                            Id = 5,
                            Booking = "2024-02-08",
                            DoctorId = 3,
                            PatientId = 3
                        },
                        new
                        {
                            Id = 6,
                            Booking = "2024-02-08",
                            DoctorId = 3,
                            PatientId = 5
                        },
                        new
                        {
                            Id = 7,
                            Booking = "2024-02-08",
                            DoctorId = 2,
                            PatientId = 7
                        },
                        new
                        {
                            Id = 8,
                            Booking = "2024-02-08",
                            DoctorId = 1,
                            PatientId = 8
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("doctor_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("doctor_full_name");

                    b.HasKey("Id");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Doktor Docktorsson"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Jöran Jöransson"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Filip Filipsson"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MedicineId"));

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("MedicineId");

                    b.ToTable("medicines");

                    b.HasData(
                        new
                        {
                            MedicineId = 1,
                            Description = "Description 1",
                            Name = "Medicine 1"
                        },
                        new
                        {
                            MedicineId = 2,
                            Description = "Description 2",
                            Name = "Medicine 2"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("patient_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("patient_full_name");

                    b.HasKey("Id");

                    b.ToTable("patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Johan Johansson"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Sven Svensson"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Anders Andresson"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Erik Eriksson"
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Emma Eriksson"
                        },
                        new
                        {
                            Id = 6,
                            FullName = "Knut Knutsson"
                        },
                        new
                        {
                            Id = 7,
                            FullName = "Bengt Bengtsson"
                        },
                        new
                        {
                            Id = 8,
                            FullName = "Jesper Jespersson"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PrescriptionId"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("integer")
                        .HasColumnName("appointment_id");

                    b.Property<string>("Notes")
                        .HasColumnType("text")
                        .HasColumnName("notes");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("AppointmentId");

                    b.ToTable("prescriptions");

                    b.HasData(
                        new
                        {
                            PrescriptionId = 1,
                            AppointmentId = 1
                        },
                        new
                        {
                            PrescriptionId = 2,
                            AppointmentId = 2
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.PrescriptionMedicine", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .HasColumnType("integer")
                        .HasColumnName("prescription_id");

                    b.Property<int>("MedicineId")
                        .HasColumnType("integer")
                        .HasColumnName("medicine_id");

                    b.Property<string>("Notes")
                        .HasColumnType("text")
                        .HasColumnName("notes");

                    b.Property<int?>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantiry");

                    b.HasKey("PrescriptionId", "MedicineId");

                    b.HasIndex("MedicineId");

                    b.ToTable("prescription_medicine");

                    b.HasData(
                        new
                        {
                            PrescriptionId = 1,
                            MedicineId = 1,
                            Notes = "Take with food",
                            Quantity = 2
                        },
                        new
                        {
                            PrescriptionId = 1,
                            MedicineId = 2,
                            Notes = "Before bedtime",
                            Quantity = 1
                        },
                        new
                        {
                            PrescriptionId = 2,
                            MedicineId = 2,
                            Notes = "Twice a day",
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Appointment", b =>
                {
                    b.HasOne("workshop.wwwapi.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("workshop.wwwapi.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Prescription", b =>
                {
                    b.HasOne("workshop.wwwapi.Models.Appointment", "Appointment")
                        .WithMany("Prescriptions")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.PrescriptionMedicine", b =>
                {
                    b.HasOne("workshop.wwwapi.Models.Medicine", "Medicine")
                        .WithMany("PrescriptionMedicines")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("workshop.wwwapi.Models.Prescription", "Prescription")
                        .WithMany("PrescriptionMedicines")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Appointment", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Medicine", b =>
                {
                    b.Navigation("PrescriptionMedicines");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Patient", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Prescription", b =>
                {
                    b.Navigation("PrescriptionMedicines");
                });
#pragma warning restore 612, 618
        }
    }
}
