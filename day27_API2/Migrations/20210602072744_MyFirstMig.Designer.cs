﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using day27_API2.Models;

namespace day27_API2.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20210602072744_MyFirstMig")]
    partial class MyFirstMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("day27_API2.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetails_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Additional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Crust_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Crust_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Crust_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity_1")
                        .HasColumnType("int");

                    b.Property<int>("Quantity_2")
                        .HasColumnType("int");

                    b.Property<int>("Quantity_3")
                        .HasColumnType("int");

                    b.Property<string>("Suggestions_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suggestions_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suggestions_3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderDetails_ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("day27_API2.Models.Product", b =>
                {
                    b.Property<int>("Pizza_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Crust")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsVeg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pizza_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Toppings")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pizza_Id");

                    b.ToTable("products");
                });
#pragma warning restore 612, 618
        }
    }
}
