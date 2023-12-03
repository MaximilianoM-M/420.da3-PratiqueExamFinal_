﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PratiqueExamFinal.DataAccess.Contexts;

#nullable disable

namespace PratiqueExamFinal.Migrations
{
    [DbContext(typeof(AppDbContexts))]
    [Migration("20231203054553_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PratiqueExamFinal.DataAccess.DTOs.Acteur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasColumnName("Age");

                    b.Property<string>("NomActeur")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("NomActeur");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("Version");

                    b.HasKey("Id");

                    b.ToTable("Acteurs", (string)null);
                });

            modelBuilder.Entity("PratiqueExamFinal.DataAccess.DTOs.SerieTele", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Genre");

                    b.Property<string>("NomSerietele")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("NomSerieTele");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("Version");

                    b.HasKey("Id");

                    b.ToTable("SerieTeles", (string)null);
                });

            modelBuilder.Entity("PratiqueExamFinal.DataAccess.Pivots.SerieTeleActeurs", b =>
                {
                    b.Property<int>("ActeurId")
                        .HasColumnType("int");

                    b.Property<int>("SerieTeleId")
                        .HasColumnType("int");

                    b.HasKey("ActeurId", "SerieTeleId");

                    b.HasIndex("SerieTeleId");

                    b.ToTable("SerieTeleActeur", (string)null);
                });

            modelBuilder.Entity("PratiqueExamFinal.DataAccess.Pivots.SerieTeleActeurs", b =>
                {
                    b.HasOne("PratiqueExamFinal.DataAccess.DTOs.Acteur", null)
                        .WithMany()
                        .HasForeignKey("ActeurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PratiqueExamFinal.DataAccess.DTOs.SerieTele", null)
                        .WithMany()
                        .HasForeignKey("SerieTeleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}