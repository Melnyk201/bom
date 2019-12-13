﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderFoodTeam;

namespace OrderFoodTeam.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191213164843_ttt")]
    partial class ttt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderFoodTeam.Models.Image", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("OrderFoodTeam.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("Productid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Productid");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("OrderFoodTeam.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Imageid")
                        .HasColumnType("int");

                    b.Property<int>("Measurement")
                        .HasColumnType("int");

                    b.Property<byte>("MeasurementEnum")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<byte>("ProductEnum")
                        .HasColumnType("tinyint");

                    b.HasKey("id");

                    b.HasIndex("Imageid");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("OrderFoodTeam.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("ReservationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReservationTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("OrderFoodTeam.Models.Table", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Reserved")
                        .HasColumnType("bit");

                    b.Property<int>("SeatsQuantity")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Table");
                });

            modelBuilder.Entity("OrderFoodTeam.Models.Order", b =>
                {
                    b.HasOne("OrderFoodTeam.Models.Product", "Product")
                        .WithMany("Order")
                        .HasForeignKey("Productid");
                });

            modelBuilder.Entity("OrderFoodTeam.Models.Product", b =>
                {
                    b.HasOne("OrderFoodTeam.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("Imageid");
                });
#pragma warning restore 612, 618
        }
    }
}
