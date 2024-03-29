﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace mymdbwebapp.EfCoreModels
{
    public partial class MymdbContext : DbContext
    {
        public MymdbContext()
        {
        }

        public MymdbContext(DbContextOptions<MymdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AliasType> AliasTypes { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<NameBasic> NameBasics { get; set; }
        public virtual DbSet<NamesKnownForTitle> NamesKnownForTitles { get; set; }
        public virtual DbSet<NamesProfession> NamesProfessions { get; set; }
        public virtual DbSet<PrincipalsCharacter> PrincipalsCharacters { get; set; }
        public virtual DbSet<TitleAlias> TitleAliases { get; set; }
        public virtual DbSet<TitleAliasesType> TitleAliasesTypes { get; set; }
        public virtual DbSet<TitleBasic> TitleBasics { get; set; }
        public virtual DbSet<TitlePrincipal> TitlePrincipals { get; set; }
        public virtual DbSet<TitleType> TitleTypes { get; set; }
        public virtual DbSet<TitlesDirector> TitlesDirectors { get; set; }
        public virtual DbSet<TitlesGenre> TitlesGenres { get; set; }
        public virtual DbSet<TitlesWriter> TitlesWriters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=MyMDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<AliasType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.Property(e => e.Genre1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Genre");
            });

            modelBuilder.Entity<NameBasic>(entity =>
            {
                entity.HasKey(e => e.Nconst);

                entity.Property(e => e.Nconst)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryName)
                    .HasMaxLength(900)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NamesKnownForTitle>(entity =>
            {
                entity.HasKey(e => new { e.Tconst, e.Nconst });

                entity.Property(e => e.Tconst)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Nconst)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.NconstNavigation)
                    .WithMany(p => p.NamesKnownForTitles)
                    .HasForeignKey(d => d.Nconst)
                    .HasConstraintName("FK_NamesKnownForTitles_NameBasics");

                entity.HasOne(d => d.TconstNavigation)
                    .WithMany(p => p.NamesKnownForTitles)
                    .HasForeignKey(d => d.Tconst)
                    .HasConstraintName("FK_NamesKnownForTitles_TitleBasics");
            });

            modelBuilder.Entity<NamesProfession>(entity =>
            {
                entity.HasKey(e => new { e.Nconst, e.Profession });

                entity.Property(e => e.Nconst)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Profession)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.NconstNavigation)
                    .WithMany(p => p.NamesProfessions)
                    .HasForeignKey(d => d.Nconst)
                    .HasConstraintName("FK_NamesProfessions_NamesProfessions");
            });

            modelBuilder.Entity<PrincipalsCharacter>(entity =>
            {
                entity.HasKey(e => e.CharId);

                entity.Property(e => e.Character)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Principal)
                    .WithMany(p => p.PrincipalsCharacters)
                    .HasForeignKey(d => d.PrincipalId)
                    .HasConstraintName("FK_PrincipalsCharacters_PrincipalsCharacters");
            });

            modelBuilder.Entity<TitleAlias>(entity =>
            {
                entity.HasKey(e => e.AliasId)
                    .IsClustered(false);

                entity.HasIndex(e => e.Tconst, "ClusteredIndex_TitleAliases_Tconst")
                    .IsClustered();

                entity.Property(e => e.Attributes).IsUnicode(false);

                entity.Property(e => e.Language)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Tconst)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.TconstNavigation)
                    .WithMany(p => p.TitleAliases)
                    .HasForeignKey(d => d.Tconst)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TitleAliases_TitleBasics");
            });

            modelBuilder.Entity<TitleAliasesType>(entity =>
            {
                entity.HasKey(e => new { e.AliasId, e.AliasTypeId });

                entity.HasOne(d => d.Alias)
                    .WithMany(p => p.TitleAliasesTypes)
                    .HasForeignKey(d => d.AliasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TitleAliasesTypes_TitleAliases");

                entity.HasOne(d => d.AliasType)
                    .WithMany(p => p.TitleAliasesTypes)
                    .HasForeignKey(d => d.AliasTypeId)
                    .HasConstraintName("FK_TitleAliasesTypes_AliasTypes");
            });

            modelBuilder.Entity<TitleBasic>(entity =>
            {
                entity.HasKey(e => e.Tconst)
                    .HasName("PK_Titles");

                entity.HasIndex(e => e.PrimaryTitle, "NonClusteredIndex_PrimaryTitle");

                entity.Property(e => e.Tconst)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalTitle)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryTitle).IsUnicode(false);

                entity.HasOne(d => d.TitleTypeNavigation)
                    .WithMany(p => p.TitleBasics)
                    .HasForeignKey(d => d.TitleType)
                    .HasConstraintName("FK_TitleBasics_TitleTypes");
            });

            modelBuilder.Entity<TitlePrincipal>(entity =>
            {
                entity.HasKey(e => e.PrincipalId);

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Job).IsUnicode(false);

                entity.Property(e => e.Nconst)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Tconst)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.NconstNavigation)
                    .WithMany(p => p.TitlePrincipals)
                    .HasForeignKey(d => d.Nconst)
                    .HasConstraintName("FK_TitlePrincipals_NameBasics");

                entity.HasOne(d => d.TconstNavigation)
                    .WithMany(p => p.TitlePrincipals)
                    .HasForeignKey(d => d.Tconst)
                    .HasConstraintName("FK_TitlePrincipals_TitleBasics");
            });

            modelBuilder.Entity<TitleType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK_Types");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TitlesDirector>(entity =>
            {
                entity.HasKey(e => new { e.Tconst, e.DirectorNconst });

                entity.Property(e => e.Tconst)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DirectorNconst)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.DirectorNconstNavigation)
                    .WithMany(p => p.TitlesDirectors)
                    .HasForeignKey(d => d.DirectorNconst)
                    .HasConstraintName("FK_TitlesDirectors_NameBasics");

                entity.HasOne(d => d.TconstNavigation)
                    .WithMany(p => p.TitlesDirectors)
                    .HasForeignKey(d => d.Tconst)
                    .HasConstraintName("FK_TitlesDirectors_TitleBasics");
            });

            modelBuilder.Entity<TitlesGenre>(entity =>
            {
                entity.HasKey(e => new { e.TitleTconst, e.GenreId });

                entity.Property(e => e.TitleTconst)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.TitlesGenres)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK_TitlesGenres_Genres");

                entity.HasOne(d => d.TitleTconstNavigation)
                    .WithMany(p => p.TitlesGenres)
                    .HasForeignKey(d => d.TitleTconst)
                    .HasConstraintName("FK_TitlesGenres_Titles");
            });

            modelBuilder.Entity<TitlesWriter>(entity =>
            {
                entity.HasKey(e => new { e.Tconst, e.WriterNconst });

                entity.Property(e => e.Tconst)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.WriterNconst)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.TconstNavigation)
                    .WithMany(p => p.TitlesWriters)
                    .HasForeignKey(d => d.Tconst)
                    .HasConstraintName("FK_TitlesWriters_TitleBasics");

                entity.HasOne(d => d.WriterNconstNavigation)
                    .WithMany(p => p.TitlesWriters)
                    .HasForeignKey(d => d.WriterNconst)
                    .HasConstraintName("FK_TitlesWriters_NameBasics");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}