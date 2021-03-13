using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Cinema.Logic.DB
{
    public partial class CinemaDB : DbContext
    {
        public CinemaDB()
        {
        }

        public CinemaDB(DbContextOptions<CinemaDB> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<MovieInfo> MovieInfo { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<Timetable> Timetable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Sandra Aunina\\Documents\\Cinema.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategorieId)
                    .HasName("PK__Categori__F643ADA6C8060EAF");

                entity.Property(e => e.Categorie)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MovieInfo>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Director).HasMaxLength(200);

                entity.Property(e => e.Image).HasMaxLength(350);

                entity.Property(e => e.PricePerPerson)
                    .HasColumnName("Price (per person)")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Title).HasMaxLength(150);
            });

            modelBuilder.Entity<Timetable>(entity =>
            {
                entity.Property(e => e.SeatsAvailable).HasDefaultValueSql("((10))");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
