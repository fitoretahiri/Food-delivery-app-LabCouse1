﻿// <auto-generated />
using System;
using Food_delivery_app_LabCouse1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Food_delivery_app_LabCouse1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220602100735_addPerdoruesiToDatabase")]
    partial class addPerdoruesiToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Food_delivery_app_LabCouse1.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("emertimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nr_artikujve")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Food_delivery_app_LabCouse1.Models.Perdoruesi", b =>
                {
                    b.Property<int>("perdoruesiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("email")
                        .HasColumnType("int");

                    b.Property<string>("emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nr_telefonit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photoProfile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("roliID")
                        .HasColumnType("int");

                    b.HasKey("perdoruesiID");

                    b.HasIndex("roliID");

                    b.ToTable("Perdoruesi");
                });

            modelBuilder.Entity("Food_delivery_app_LabCouse1.Models.Qyteti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("emri")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Qyteti");
                });

            modelBuilder.Entity("Food_delivery_app_LabCouse1.Models.Restoranti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("data_regjistrimit")
                        .HasColumnType("datetime2");

                    b.Property<string>("emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nr_kontaktues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qyteti")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restoranti");
                });

            modelBuilder.Entity("Food_delivery_app_LabCouse1.Models.Roli", b =>
                {
                    b.Property<int>("roliID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roliID");

                    b.ToTable("Roli");
                });

            modelBuilder.Entity("Food_delivery_app_LabCouse1.Models.Useri", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("confirmPsw")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mbiemri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photoProfile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("roliID")
                        .HasColumnType("int");

                    b.HasKey("userID");

                    b.HasIndex("roliID");

                    b.ToTable("Useri");
                });

            modelBuilder.Entity("Food_delivery_app_LabCouse1.Models.Perdoruesi", b =>
                {
                    b.HasOne("Food_delivery_app_LabCouse1.Models.Roli", "roli")
                        .WithMany()
                        .HasForeignKey("roliID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("roli");
                });

            modelBuilder.Entity("Food_delivery_app_LabCouse1.Models.Useri", b =>
                {
                    b.HasOne("Food_delivery_app_LabCouse1.Models.Roli", "roli")
                        .WithMany()
                        .HasForeignKey("roliID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("roli");
                });
#pragma warning restore 612, 618
        }
    }
}
