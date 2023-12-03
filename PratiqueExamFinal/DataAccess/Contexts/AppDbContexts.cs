﻿using Microsoft.EntityFrameworkCore;
using PratiqueExamFinal.DataAccess.DTOs;
using PratiqueExamFinal.DataAccess.Pivots;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueExamFinal.DataAccess.Contexts;
internal class AppDbContexts : DbContext
{
    public DbSet<SerieTele> SerieTeles { get; set; }
    public DbSet<Acteur> Acteurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(ConfigurationManager.ConnectionStrings["Connexion"].ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<SerieTele>()
            .ToTable("SerieTeles")
            .HasKey(teleserie => teleserie.Id);

        modelBuilder.Entity<SerieTele>()
             .Property(teleserie => teleserie.Id)
             .HasColumnName("Id")
             .HasColumnType("int");

        modelBuilder.Entity<SerieTele>()
             .Property(teleserie => teleserie.NomSerietele)
             .HasColumnName("NomSerieTele")
             .HasColumnType($"nvarchar({SerieTele.MAX_NOMSERIETELE_LENGTH})");

        modelBuilder.Entity<SerieTele>()
             .Property(teleserie => teleserie.Genre)
             .HasColumnName("Genre")
             .HasColumnType($"nvarchar({SerieTele.MAX_GENRE_LENGTH})");

        modelBuilder.Entity<SerieTele>()
             .Property(teleserie => teleserie.Version)
             .HasColumnName("Version")
             .IsRowVersion();



       
        modelBuilder.Entity<Acteur>()
            .ToTable("Acteurs")
            .HasKey(acteur => acteur.Id);

        modelBuilder.Entity<Acteur>()
             .Property(acteur => acteur.Id)
             .HasColumnName("Id")
             .HasColumnType("int");

        modelBuilder.Entity<Acteur>()
             .Property(acteur => acteur.NomActeur)
             .HasColumnName("NomActeur")
             .HasColumnType($"nvarchar({Acteur.MAX_NOM_LENGTH})");

        modelBuilder.Entity<Acteur>()
            .Property(acteur => acteur.Age)
            .HasColumnName("Age")
            .HasColumnType($"nvarchar({Acteur.MAX_AGE_LENGTH})");


        modelBuilder.Entity<Acteur>()
             .Property(acteur => acteur.Version)
             .HasColumnName("Version")
             .IsRowVersion();

        modelBuilder.Entity<SerieTele>()
            .HasMany(acteur => acteur.Acteurs)
            .WithMany(acteur => acteur.SerieTeles)
            .UsingEntity<SerieTeleActeurs>().ToTable("SerieTeleActeur")
            .HasKey(acteurSerieTele => new { acteurSerieTele.ActeurId, acteurSerieTele.SerieTeleId});

        modelBuilder.Entity<SerieTele>().HasData(
            new SerieTele() { Id = 1, NomSerietele = "Mandalorian", Genre = "Science-Fiction"},
            new SerieTele() { Id = 2, NomSerietele = "Avatar", Genre = "Adventure" }
            );

        modelBuilder.Entity<Acteur>().HasData(
           new Acteur() { Id = 1, NomActeur = "Pedro Pascal", Age = "48" },
           new Acteur() { Id = 2, NomActeur = "Zach Tyler", Age = "30" },
           new Acteur() { Id = 3, NomActeur = "Giancarlo Esposito", Age = "65" }
           );


    }
}
