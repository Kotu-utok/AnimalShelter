﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DAL.Models.DALAnimalModel", b =>
                {
                    b.Property<int>("AnimalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateOfArrival")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("WeightAtArrivalKG")
                        .HasColumnType("float");

                    b.HasKey("AnimalID");

                    b.ToTable("animalsinfo");
                });

            modelBuilder.Entity("DAL.Models.DALPrescriptionModel", b =>
                {
                    b.Property<int>("MedicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnimalID")
                        .HasColumnType("int");

                    b.Property<string>("Prescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MedicationID");

                    b.ToTable("prescription");
                });

            modelBuilder.Entity("DAL.Models.DalExaminationModel", b =>
                {
                    b.Property<int>("ExaminationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnimalID")
                        .HasColumnType("int");

                    b.Property<int>("MedicationID")
                        .HasColumnType("int");

                    b.Property<string>("Observations")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("QuarantineStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RehabiliationStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("VaccinationStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Weight")
                        .HasColumnType("float");

                    b.HasKey("ExaminationID");

                    b.ToTable("excamination");
                });
#pragma warning restore 612, 618
        }
    }
}
