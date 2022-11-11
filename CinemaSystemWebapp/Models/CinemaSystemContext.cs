using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CinemaSystemWebapp.Models
{
    public partial class CinemaSystemContext : DbContext
    {
        public CinemaSystemContext()
        {
        }

        public CinemaSystemContext(DbContextOptions<CinemaSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Film> Films { get; set; } = null!;
        public virtual DbSet<Room> Rooms { get; set; } = null!;
        public virtual DbSet<Show> Shows { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost;database=CinemaSystem;trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Desc).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(64);
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.ToTable("Film");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Desc).HasMaxLength(1024);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(128)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.ReleaseDate).HasColumnType("date");

                entity.HasMany(d => d.Categories)
                    .WithMany(p => p.Films)
                    .UsingEntity<Dictionary<string, object>>(
                        "FilmCategory",
                        l => l.HasOne<Category>().WithMany().HasForeignKey("CategoryId").HasConstraintName("FK__FilmCateg__Categ__33D4B598"),
                        r => r.HasOne<Film>().WithMany().HasForeignKey("FilmId").HasConstraintName("FK__FilmCateg__FilmI__32E0915F"),
                        j =>
                        {
                            j.HasKey("FilmId", "CategoryId").HasName("PK__FilmCate__CC8DB13E4360EA3F");

                            j.ToTable("FilmCategory");

                            j.IndexerProperty<int>("FilmId").HasColumnName("FilmID");

                            j.IndexerProperty<int>("CategoryId").HasColumnName("CategoryID");
                        });
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");

                entity.HasIndex(e => e.Name, "UQ__Room__737584F616903076")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(64);
            });

            modelBuilder.Entity<Show>(entity =>
            {
                entity.ToTable("Show");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.Shows)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Show__FilmID__36B12243");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Shows)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Show__RoomID__37A5467C");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => new { e.ShowId, e.Row, e.Col })
                    .HasName("PK__Ticket__C18D1EE820A35CFC");

                entity.ToTable("Ticket");

                entity.Property(e => e.ShowId).HasColumnName("ShowID");

                entity.Property(e => e.Otp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("OTP")
                    .IsFixedLength();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Show)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.ShowId)
                    .HasConstraintName("FK__Ticket__ShowID__3C69FB99");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Ticket__UserID__3D5E1FD2");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.Email, "UQ__User__A9D10534017970C2")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AvatarUrl)
                    .HasMaxLength(128)
                    .HasColumnName("AvatarURL");

                entity.Property(e => e.Email).HasMaxLength(64);

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.Password).HasMaxLength(64);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
