﻿// <auto-generated />
using System;
using MVCSQLEFCore.DAL.Concrete.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCSQLEFCore.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    [Migration("20221125183702_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCSQLEFCore.Entities.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InternId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("SpecialtyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("MVCSQLEFCore.Entities.Intern", b =>
                {
                    b.Property<int>("InternId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InternId");

                    b.ToTable("Interns");
                });

            modelBuilder.Entity("MVCSQLEFCore.Entities.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"));

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("MVCSQLEFCore.Entities.Specialty", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("NumberOfPatients")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialtyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.ToTable("Specialties");
                });

            modelBuilder.Entity("MVCSQLEFCore.Entities.Doctor", b =>
                {
                    b.HasOne("MVCSQLEFCore.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("MVCSQLEFCore.Entities.Intern", b =>
                {
                    b.HasOne("MVCSQLEFCore.Entities.Doctor", "Doctor")
                        .WithOne("Intern")
                        .HasForeignKey("MVCSQLEFCore.Entities.Intern", "InternId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("MVCSQLEFCore.Entities.Patient", b =>
                {
                    b.HasOne("MVCSQLEFCore.Entities.Doctor", "Doctor")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("MVCSQLEFCore.Entities.Specialty", b =>
                {
                    b.HasOne("MVCSQLEFCore.Entities.Doctor", "Doctor")
                        .WithOne("Specialty")
                        .HasForeignKey("MVCSQLEFCore.Entities.Specialty", "DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("MVCSQLEFCore.Entities.Doctor", b =>
                {
                    b.Navigation("Intern");

                    b.Navigation("Patients");

                    b.Navigation("Specialty");
                });
#pragma warning restore 612, 618
        }
    }
}
