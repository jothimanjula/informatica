using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InfomaticsDataLayer.Models
{
    public partial class INFOMATICSMEETINGContext : DbContext
    {
        protected string DatabaseConnectionString;
        public INFOMATICSMEETINGContext()
        {
        }

        public INFOMATICSMEETINGContext(DbContextOptions<INFOMATICSMEETINGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Livemeeting> Livemeeting { get; set; }
        public virtual DbSet<Useraccounts> Useraccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DatabaseConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DatabaseConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livemeeting>(entity =>
            {
                entity.ToTable("LIVEMEETING");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LiveMeetingAgenda)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LiveMeetingAttendees)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LiveMeetingDate).HasColumnType("datetime");

                entity.Property(e => e.LiveMeetingSubject)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Useraccounts>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__USERACCO__1788CC4C55B3C7FE");

                entity.ToTable("USERACCOUNTS");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
