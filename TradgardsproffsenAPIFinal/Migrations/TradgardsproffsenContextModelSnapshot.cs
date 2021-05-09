﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TradgardsproffsenAPI.DbContexts;

namespace TradgardsproffsenAPI.Migrations
{
    [DbContext(typeof(TradgardsproffsenContext))]
    partial class TradgardsproffsenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Accomplished")
                        .HasColumnType("int");

                    b.Property<int?>("CompletedLeadId")
                        .HasColumnType("int");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HitRate")
                        .HasColumnType("float");

                    b.Property<int>("Invoiced")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("LatestLead")
                        .HasColumnType("datetimeoffset");

                    b.Property<double>("Left")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SalesTarget")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CompletedLeadId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.CompanyJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("JobId");

                    b.ToTable("CompanyJob");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.CompanySentOutLead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("SentOutLeadId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SentOutLeadId");

                    b.ToTable("CompanySentOutLead");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.CompletedLead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyCompletedId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyCompletedId");

                    b.ToTable("CompletedLead");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.Lead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lead");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.LeadJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompletedLeadId")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int?>("SentOutLeadId")
                        .HasColumnType("int");

                    b.Property<int?>("ValidatedLeadId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompletedLeadId");

                    b.HasIndex("JobId");

                    b.HasIndex("SentOutLeadId");

                    b.HasIndex("ValidatedLeadId");

                    b.ToTable("LeadJob");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.LostLead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WasSentOut")
                        .HasColumnType("bit");

                    b.Property<bool>("WasValidated")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("LostLead");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.SentOutLead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("SentOutLead");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.ValidatedLead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ValidatedLead");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.Company", b =>
                {
                    b.HasOne("TradgardsproffsenAPI.Entities.CompletedLead", null)
                        .WithMany("CompaniesSentTo")
                        .HasForeignKey("CompletedLeadId");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.CompanyJob", b =>
                {
                    b.HasOne("TradgardsproffsenAPI.Entities.Company", "Company")
                        .WithMany("AvailableJobs")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TradgardsproffsenAPI.Entities.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.CompanySentOutLead", b =>
                {
                    b.HasOne("TradgardsproffsenAPI.Entities.SentOutLead", null)
                        .WithMany("CompaniesSentTo")
                        .HasForeignKey("SentOutLeadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.CompletedLead", b =>
                {
                    b.HasOne("TradgardsproffsenAPI.Entities.Company", "CompanyCompleted")
                        .WithMany()
                        .HasForeignKey("CompanyCompletedId");

                    b.Navigation("CompanyCompleted");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.LeadJob", b =>
                {
                    b.HasOne("TradgardsproffsenAPI.Entities.CompletedLead", null)
                        .WithMany("Jobs")
                        .HasForeignKey("CompletedLeadId");

                    b.HasOne("TradgardsproffsenAPI.Entities.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TradgardsproffsenAPI.Entities.SentOutLead", "SentOutLead")
                        .WithMany("Jobs")
                        .HasForeignKey("SentOutLeadId");

                    b.HasOne("TradgardsproffsenAPI.Entities.ValidatedLead", "ValidatedLead")
                        .WithMany("Jobs")
                        .HasForeignKey("ValidatedLeadId");

                    b.Navigation("Job");

                    b.Navigation("SentOutLead");

                    b.Navigation("ValidatedLead");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.SentOutLead", b =>
                {
                    b.HasOne("TradgardsproffsenAPI.Entities.Company", null)
                        .WithMany("Leads")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.Company", b =>
                {
                    b.Navigation("AvailableJobs");

                    b.Navigation("Leads");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.CompletedLead", b =>
                {
                    b.Navigation("CompaniesSentTo");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.SentOutLead", b =>
                {
                    b.Navigation("CompaniesSentTo");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.ValidatedLead", b =>
                {
                    b.Navigation("Jobs");
                });
#pragma warning restore 612, 618
        }
    }
}
