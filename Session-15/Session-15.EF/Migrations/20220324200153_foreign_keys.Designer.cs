﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Session_15.EF.Contex;

#nullable disable

namespace Session_15.EF.Migrations
{
    [DbContext(typeof(PetShopContex))]
    [Migration("20220324200153_foreign_keys")]
    partial class foreign_keys
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Session_15.Model.Customer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ObjectStatus")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tin")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("ID");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("Session_15.Model.Employee", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EmpType")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ObjectStatus")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("Session_15.Model.Pet", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AnimalType")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Cost")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("FoodTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HealthStatus")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("ObjectStatus")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("FoodTypeID");

                    b.ToTable("Pet", (string)null);
                });

            modelBuilder.Entity("Session_15.Model.PetFood", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Cost")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ObjectStatus")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PetFood", (string)null);
                });

            modelBuilder.Entity("Session_15.Model.Transaction", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasMaxLength(100)
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeID")
                        .HasMaxLength(100)
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PetFoodID")
                        .HasMaxLength(100)
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PetFoodPrice")
                        .HasMaxLength(100)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PetFoodQty")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<Guid>("PetID")
                        .HasMaxLength(100)
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PetPrice")
                        .HasMaxLength(100)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPrice")
                        .HasMaxLength(100)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("PetID")
                        .IsUnique();

                    b.ToTable("Transaction", (string)null);
                });

            modelBuilder.Entity("Session_15.Model.Pet", b =>
                {
                    b.HasOne("Session_15.Model.PetFood", "FoodType")
                        .WithMany()
                        .HasForeignKey("FoodTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodType");
                });

            modelBuilder.Entity("Session_15.Model.Transaction", b =>
                {
                    b.HasOne("Session_15.Model.Customer", null)
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Session_15.Model.Employee", null)
                        .WithMany("Transactions")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Session_15.Model.Pet", null)
                        .WithOne("Transaction")
                        .HasForeignKey("Session_15.Model.Transaction", "PetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Session_15.Model.Customer", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Session_15.Model.Employee", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Session_15.Model.Pet", b =>
                {
                    b.Navigation("Transaction")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
