﻿// <auto-generated />
using System;
using ControleABordo.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleABordo.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241012010156_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ControleABordo.API.Models.Passageiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<int>("VooId")
                        .HasColumnType("int");

                    b.Property<int>("Years")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VooId");

                    b.ToTable("Passageiros");
                });

            modelBuilder.Entity("ControleABordo.API.Models.Voo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanhiaAerea")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Voos");
                });

            modelBuilder.Entity("ControleABordo.API.Models.Passageiro", b =>
                {
                    b.HasOne("ControleABordo.API.Models.Voo", "Voo")
                        .WithMany("Passageiros")
                        .HasForeignKey("VooId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Voo");
                });

            modelBuilder.Entity("ControleABordo.API.Models.Voo", b =>
                {
                    b.Navigation("Passageiros");
                });
#pragma warning restore 612, 618
        }
    }
}
