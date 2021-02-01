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
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CompanySentOutLead", b =>
                {
                    b.Property<int>("CompaniesSentToId")
                        .HasColumnType("int");

                    b.Property<int>("LeadsId")
                        .HasColumnType("int");

                    b.HasKey("CompaniesSentToId", "LeadsId");

                    b.HasIndex("LeadsId");

                    b.ToTable("CompanySentOutLead");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Accomplished")
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

                    b.ToTable("Company");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.CompanyJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("JobId");

                    b.ToTable("CompanyJob");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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
                        .UseIdentityColumn();

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
                        .UseIdentityColumn();

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int?>("SentOutLeadId")
                        .HasColumnType("int");

                    b.Property<int?>("ValidatedLeadId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SentOutLeadId");

                    b.HasIndex("ValidatedLeadId");

                    b.ToTable("LeadJobb");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.LostLead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LostLead");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.SentOutLead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

                    b.ToTable("SentOutLead");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.ValidatedLead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

            modelBuilder.Entity("CompanySentOutLead", b =>
                {
                    b.HasOne("TradgardsproffsenAPI.Entities.Company", null)
                        .WithMany()
                        .HasForeignKey("CompaniesSentToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TradgardsproffsenAPI.Entities.SentOutLead", null)
                        .WithMany()
                        .HasForeignKey("LeadsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.LeadJob", b =>
                {
                    b.HasOne("TradgardsproffsenAPI.Entities.SentOutLead", null)
                        .WithMany("Jobs")
                        .HasForeignKey("SentOutLeadId");

                    b.HasOne("TradgardsproffsenAPI.Entities.ValidatedLead", null)
                        .WithMany("Jobs")
                        .HasForeignKey("ValidatedLeadId");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.Company", b =>
                {
                    b.Navigation("AvailableJobs");
                });

            modelBuilder.Entity("TradgardsproffsenAPI.Entities.SentOutLead", b =>
                {
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
