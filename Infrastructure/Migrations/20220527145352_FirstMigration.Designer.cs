﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(EducationalFormsContext))]
    [Migration("20220527145352_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Models.Consultant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Consultant");
                });

            modelBuilder.Entity("Domain.Models.FailureReason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FailureReason");
                });

            modelBuilder.Entity("Domain.Models.FamiliarityMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FamiliarityMethod");
                });

            modelBuilder.Entity("Domain.Models.Lead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CalledOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int?>("ConsultantId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FailureReasonId")
                        .HasColumnType("int");

                    b.Property<int?>("FamiliarityMethodId")
                        .HasColumnType("int");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifyOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("ConsultantId");

                    b.HasIndex("FailureReasonId");

                    b.HasIndex("FamiliarityMethodId");

                    b.ToTable("Lead");
                });

            modelBuilder.Entity("Domain.Models.LeadSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LeadId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeadId");

                    b.ToTable("LeadSkill");
                });

            modelBuilder.Entity("Domain.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentServiceId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("Domain.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int?>("StudentSkillId")
                        .HasColumnType("int");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentSkillId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("Domain.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Citizen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConsultantId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FamiliarityMethodId")
                        .HasColumnType("int");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifyOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PhotoAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfIssued")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PortalStatus")
                        .HasColumnType("bit");

                    b.Property<string>("WhatsAppNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConsultantId");

                    b.HasIndex("FamiliarityMethodId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Domain.Models.StudentService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentService");
                });

            modelBuilder.Entity("Domain.Models.StudentSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentSkill");
                });

            modelBuilder.Entity("LeadSkillSkill", b =>
                {
                    b.Property<int>("LeadSkillsId")
                        .HasColumnType("int");

                    b.Property<int>("SkillsId")
                        .HasColumnType("int");

                    b.HasKey("LeadSkillsId", "SkillsId");

                    b.HasIndex("SkillsId");

                    b.ToTable("LeadSkillSkill");
                });

            modelBuilder.Entity("Domain.Models.Lead", b =>
                {
                    b.HasOne("Domain.Models.Consultant", "Consultant")
                        .WithMany()
                        .HasForeignKey("ConsultantId");

                    b.HasOne("Domain.Models.FailureReason", "FailureReason")
                        .WithMany()
                        .HasForeignKey("FailureReasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.FamiliarityMethod", "FamiliarityMethod")
                        .WithMany()
                        .HasForeignKey("FamiliarityMethodId");

                    b.Navigation("Consultant");

                    b.Navigation("FailureReason");

                    b.Navigation("FamiliarityMethod");
                });

            modelBuilder.Entity("Domain.Models.LeadSkill", b =>
                {
                    b.HasOne("Domain.Models.Lead", "Lead")
                        .WithMany("LeadSkills")
                        .HasForeignKey("LeadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Lead_LeadSkills");

                    b.Navigation("Lead");
                });

            modelBuilder.Entity("Domain.Models.Service", b =>
                {
                    b.HasOne("Domain.Models.StudentService", null)
                        .WithMany("Services")
                        .HasForeignKey("StudentServiceId");
                });

            modelBuilder.Entity("Domain.Models.Skill", b =>
                {
                    b.HasOne("Domain.Models.StudentSkill", null)
                        .WithMany("Skills")
                        .HasForeignKey("StudentSkillId");
                });

            modelBuilder.Entity("Domain.Models.Student", b =>
                {
                    b.HasOne("Domain.Models.Consultant", "Consultant")
                        .WithMany()
                        .HasForeignKey("ConsultantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.FamiliarityMethod", "FamiliarityMethod")
                        .WithMany()
                        .HasForeignKey("FamiliarityMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consultant");

                    b.Navigation("FamiliarityMethod");
                });

            modelBuilder.Entity("Domain.Models.StudentService", b =>
                {
                    b.HasOne("Domain.Models.Student", "Student")
                        .WithMany("StudentServices")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Student_StudentServices");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Domain.Models.StudentSkill", b =>
                {
                    b.HasOne("Domain.Models.Student", "Student")
                        .WithMany("StudentSkills")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Student_StudentSkills");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("LeadSkillSkill", b =>
                {
                    b.HasOne("Domain.Models.LeadSkill", null)
                        .WithMany()
                        .HasForeignKey("LeadSkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Lead", b =>
                {
                    b.Navigation("LeadSkills");
                });

            modelBuilder.Entity("Domain.Models.Student", b =>
                {
                    b.Navigation("StudentServices");

                    b.Navigation("StudentSkills");
                });

            modelBuilder.Entity("Domain.Models.StudentService", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("Domain.Models.StudentSkill", b =>
                {
                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
