﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tickets.DataAccess.EntityFramework;

namespace Tickets.DataAccess.Migrations
{
    [DbContext(typeof(ModDbContext))]
    partial class ModDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tickets.DataAccess.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tic_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("tic_FechaActualizacion");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("tic_FechaCreacion");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("tic_Status");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tic_Usuario");

                    b.HasKey("Id");

                    b.ToTable("Ticket");
                });
#pragma warning restore 612, 618
        }
    }
}
