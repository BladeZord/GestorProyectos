﻿// <auto-generated />
using System;
using GProyectos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GProyectos.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20231223154411_v1.1.1")]
    partial class v111
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GProyectos.Models.Clients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Empresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Actualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Creacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Provincia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Representante1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Representante2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Representante3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector_Laboral")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}
