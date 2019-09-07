using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ticket1.Models
{
    public partial class busticketContext : DbContext
    {
        public busticketContext()
        {
        }

        public busticketContext(DbContextOptions<busticketContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Bookinfo> Bookinfo { get; set; }
        public virtual DbSet<Bus> Bus { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user=root;password=1478521; database=busticket;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admin");

                entity.Property(e => e.Id).HasColumnType("varchar(16)");

                entity.Property(e => e.Password).HasColumnType("varchar(16)");
            });

            modelBuilder.Entity<Bookinfo>(entity =>
            {
                entity.HasKey(e => e.Bid)
                    .HasName("PRIMARY");

                entity.ToTable("bookinfo");

                entity.Property(e => e.Bid)
                    .HasColumnName("BId")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.BusCode).HasColumnType("varchar(10)");

                entity.Property(e => e.Count).HasColumnType("int(3)");

                entity.Property(e => e.End).HasColumnType("varchar(10)");

                entity.Property(e => e.EndTime).HasColumnType("varchar(20)");

                entity.Property(e => e.Price).HasColumnType("varchar(10)");

                entity.Property(e => e.Start).HasColumnType("varchar(10)");

                entity.Property(e => e.StartTime).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Bus>(entity =>
            {
                entity.HasKey(e => e.BusCode)
                    .HasName("PRIMARY");

                entity.ToTable("bus");

                entity.Property(e => e.BusCode).HasColumnType("varchar(10)");

                entity.Property(e => e.Driver).HasColumnType("varchar(10)");

                entity.Property(e => e.SeatNum).HasColumnType("int(3)");

                entity.Property(e => e.Type).HasColumnType("varchar(5)");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PRIMARY");

                entity.ToTable("ticket");

                entity.HasIndex(e => e.BusCode)
                    .HasName("FK_Reference_1");

                entity.HasIndex(e => e.InfoId)
                    .HasName("FK_Reference_3");

                entity.HasIndex(e => e.UserId)
                    .HasName("FK_Reference_2");

                entity.Property(e => e.Tid).HasColumnType("varchar(20)");

                entity.Property(e => e.BusCode).HasColumnType("varchar(10)");

                entity.Property(e => e.CreatTime).HasColumnType("varchar(20)");

                entity.Property(e => e.End).HasColumnType("varchar(10)");

                entity.Property(e => e.EndTime).HasColumnType("varchar(20)");

                entity.Property(e => e.InfoId).HasColumnType("varchar(5)");

                entity.Property(e => e.Price).HasColumnType("varchar(10)");

                entity.Property(e => e.Start).HasColumnType("varchar(10)");

                entity.Property(e => e.StartTime).HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnType("varchar(16)");

                entity.Property(e => e.UserIdCode).HasColumnType("int(20)");

                entity.Property(e => e.UserName).HasColumnType("varchar(10)");

                entity.HasOne(d => d.BusCodeNavigation)
                    .WithMany(p => p.Ticket)
                    .HasForeignKey(d => d.BusCode)
                    .HasConstraintName("FK_Reference_1");

                entity.HasOne(d => d.Info)
                    .WithMany(p => p.Ticket)
                    .HasForeignKey(d => d.InfoId)
                    .HasConstraintName("FK_Reference_3");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Ticket)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Reference_2");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id).HasColumnType("varchar(16)");

                entity.Property(e => e.Age).HasColumnType("int(3)");

                entity.Property(e => e.IdCode).HasColumnType("int(20)");

                entity.Property(e => e.Name).HasColumnType("varchar(10)");

                entity.Property(e => e.Password).HasColumnType("varchar(16)");

                entity.Property(e => e.Sex).HasColumnType("varchar(10)");
            });
        }
    }
}
