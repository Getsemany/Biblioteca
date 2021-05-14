﻿// <auto-generated />
using Biblioteca.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Biblioteca.Migrations.DetallePrestamo
{
    [DbContext(typeof(DetallePrestamoContext))]
    [Migration("20210514202257_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Biblioteca.Models.DetallePrestamo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("idLibro")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idPrestamo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("DetallePrestamo");
                });
#pragma warning restore 612, 618
        }
    }
}
