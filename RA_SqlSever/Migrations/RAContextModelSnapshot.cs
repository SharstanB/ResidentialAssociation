﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RA_SqlSever;

namespace RA_SqlSever.Migrations
{
    [DbContext(typeof(RAContext))]
    partial class RAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RA_Infrastructure.Models.Accounting.Finance", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BillNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FinanceType")
                        .HasColumnType("int");

                    b.Property<int>("ResidenceId")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(20,3)");

                    b.HasKey("Id");

                    b.HasIndex("ResidenceId");

                    b.ToTable("Finance", "Finance");
                });

            modelBuilder.Entity("RA_Infrastructure.Models.Main.Member", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AffiliationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CardNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DesisionNumber")
                        .HasColumnType("int");

                    b.Property<int>("Member_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("MembershipExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("SessionNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Member", "Main");
                });

            modelBuilder.Entity("RA_Infrastructure.Models.Main.Person", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BirthPlace")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<decimal>("Income")
                        .HasColumnType("decimal(15,5)");

                    b.Property<bool>("IsMarried")
                        .HasColumnType("bit");

                    b.Property<string>("JobAddress")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RegistrationNumber")
                        .HasColumnType("int");

                    b.Property<int>("SocialStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Person", "Main");
                });

            modelBuilder.Entity("RA_Infrastructure.Models.Main.Property", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DecisionNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FirstSideId")
                        .HasColumnType("int");

                    b.Property<int>("ResidenceId")
                        .HasColumnType("int");

                    b.Property<int>("SecondSideId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FirstSideId");

                    b.HasIndex("ResidenceId");

                    b.HasIndex("SecondSideId");

                    b.ToTable("Property", "Main");
                });

            modelBuilder.Entity("RA_Infrastructure.Models.Main.Residence", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ExpectedCost")
                        .HasColumnType("decimal(20,3)");

                    b.Property<decimal>("FinalCost")
                        .HasColumnType("decimal(20,3)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RecordNumber")
                        .HasColumnType("int");

                    b.Property<string>("ResidenceAddress")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ResidenceDirection")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ResidenceType")
                        .HasColumnType("int");

                    b.Property<int>("Residence_ID")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<string>("SectionNumber")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Residence", "Main");
                });

            modelBuilder.Entity("RA_Infrastructure.Models.Project", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ExpectedCost")
                        .HasColumnType("decimal(20,3)")
                        .HasColumnName("ExpectedPrice");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProjectCategory")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ProjectRegion")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Project_ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Project", "Main");
                });

            modelBuilder.Entity("RA_Infrastructure.Models.Setting.Settings", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MonthlyPremium")
                        .HasColumnType("decimal(20,3)");

                    b.HasKey("Id");

                    b.ToTable("ExpectedPrice", "Setting");
                });

            modelBuilder.Entity("RA_Infrastructure.Models.Accounting.Finance", b =>
                {
                    b.HasOne("RA_Infrastructure.Models.Main.Residence", "Residence")
                        .WithMany("Finances")
                        .HasForeignKey("ResidenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Residence");
                });

            modelBuilder.Entity("RA_Infrastructure.Models.Main.Member", b =>
                {
                    b.HasOne("RA_Infrastructure.Models.Main.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("RA_Infrastructure.Models.Main.Person", b =>
                {
                    b.HasOne("RA_Infrastructure.Models.Main.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("RA_Infrastructure.Models.Main.Property", b =>
                {
                    b.HasOne("RA_Infrastructure.Models.Main.Member", "FirstSide")
                        .WithMany("FirstSides")
                        .HasForeignKey("FirstSideId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("RA_Infrastructure.Models.Main.Residence", "Residence")
                        .WithMany("Properties")
                        .HasForeignKey("ResidenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RA_Infrastructure.Models.Main.Member", "SecondSide")
                        .WithMany("SecondSides")
                        .HasForeignKey("SecondSideId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("FirstSide");

                    b.Navigation("Residence");

                    b.Navigation("SecondSide");
                });

            modelBuilder.Entity("RA_Infrastructure.Models.Main.Residence", b =>
                {
                    b.HasOne("RA_Infrastructure.Models.Project", "Project")
                        .WithMany("Residences")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("RA_Infrastructure.Models.Main.Member", b =>
                {
                    b.Navigation("FirstSides");

                    b.Navigation("SecondSides");
                });

            modelBuilder.Entity("RA_Infrastructure.Models.Main.Residence", b =>
                {
                    b.Navigation("Finances");

                    b.Navigation("Properties");
                });

            modelBuilder.Entity("RA_Infrastructure.Models.Project", b =>
                {
                    b.Navigation("Residences");
                });
#pragma warning restore 612, 618
        }
    }
}
