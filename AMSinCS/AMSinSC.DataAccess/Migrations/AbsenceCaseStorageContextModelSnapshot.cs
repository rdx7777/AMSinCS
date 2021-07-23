﻿// <auto-generated />
using System;
using AMSinSC.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AMSinSC.DataAccess.Migrations
{
    [DbContext(typeof(AbsenceCaseStorageContext))]
    partial class AbsenceCaseStorageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AMSinSC.DataAccess.Entities.AbsenceCase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AbsenceReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverSupervisorComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HeadTeacherComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HeadTeacherId")
                        .HasColumnType("int");

                    b.Property<string>("HrSupervisorComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsAbsencePaid")
                        .HasColumnType("int");

                    b.Property<int>("IsApprovedByHeadTeacher")
                        .HasColumnType("int");

                    b.Property<int>("IsCaseResolved")
                        .HasColumnType("int");

                    b.Property<int>("IsCoverProvided")
                        .HasColumnType("int");

                    b.Property<int>("IsCoverRequired")
                        .HasColumnType("int");

                    b.Property<int>("PartDayType")
                        .HasColumnType("int");

                    b.Property<DateTime>("ResolvedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HeadTeacherId");

                    b.HasIndex("UserId");

                    b.ToTable("AbsenceCases");
                });

            modelBuilder.Entity("AMSinSC.DataAccess.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AMSinSC.DataAccess.Entities.AbsenceCase", b =>
                {
                    b.HasOne("AMSinSC.DataAccess.Entities.User", "HeadTeacher")
                        .WithMany()
                        .HasForeignKey("HeadTeacherId");

                    b.HasOne("AMSinSC.DataAccess.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("HeadTeacher");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}