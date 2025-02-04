﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using back_endTestCWTomas.Models;

namespace back_endTestCWTomas.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20210214210253_Inicial CW")]
    partial class InicialCW
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("back_endTestCWTomas.Models.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("back_endTestCWTomas.Models.Productos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("back_endTestCWTomas.Models.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("usuario")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
