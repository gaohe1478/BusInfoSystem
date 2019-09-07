using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ticket1.Model1
{
    public partial class busContext : DbContext
    {
        public busContext()
        {
        }

        public busContext(DbContextOptions<busContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bookinfo> Bookinfo { get; set; }
        public virtual DbSet<Bus> Bus { get; set; }
        public virtual DbSet<Line> Line { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user=root;password=1478521; database=bus;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bookinfo>(entity =>
            {
                entity.HasKey(e => e.Bid)
                    .HasName("PRIMARY");

                entity.ToTable("bookinfo");

                entity.HasIndex(e => e.BusCode)
                    .HasName("FK_Reference_4");

                entity.HasIndex(e => e.Lid)
                    .HasName("FK_Reference_5");

                entity.Property(e => e.Bid).HasColumnType("varchar(10)");

                entity.Property(e => e.BusCode).HasColumnType("varchar(10)");

                entity.Property(e => e.Lid).HasColumnType("varchar(10)");

                entity.Property(e => e.Price0).HasColumnType("varchar(20)");

                entity.Property(e => e.Price1).HasColumnType("varchar(20)");

                entity.Property(e => e.Price2).HasColumnType("varchar(20)");

                entity.Property(e => e.Price3).HasColumnType("varchar(20)");

                entity.Property(e => e.StartTime).HasColumnType("varchar(25)");

                entity.Property(e => e.Surplus).HasColumnType("int(3)");

                entity.Property(e => e.Usetime).HasColumnType("varchar(30)");

                entity.HasOne(d => d.BusCodeNavigation)
                    .WithMany(p => p.Bookinfo)
                    .HasForeignKey(d => d.BusCode)
                    .HasConstraintName("FK_Reference_4");

                entity.HasOne(d => d.L)
                    .WithMany(p => p.Bookinfo)
                    .HasForeignKey(d => d.Lid)
                    .HasConstraintName("FK_Reference_5");
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

            modelBuilder.Entity<Line>(entity =>
            {
                entity.HasKey(e => e.Lid)
                    .HasName("PRIMARY");

                entity.ToTable("line");

                entity.Property(e => e.Lid).HasColumnType("varchar(10)");

                entity.Property(e => e.End).HasColumnType("varchar(10)");

                entity.Property(e => e.Mid0).HasColumnType("varchar(10)");

                entity.Property(e => e.Mid1).HasColumnType("varchar(10)");

                entity.Property(e => e.Mid2).HasColumnType("varchar(10)");

                entity.Property(e => e.Start).HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PRIMARY");

                entity.ToTable("ticket");

                entity.Property(e => e.Tid).HasColumnType("varchar(20)");

                entity.Property(e => e.BusCode).HasColumnType("varchar(10)");

                entity.Property(e => e.End).HasColumnType("varchar(10)");

                

                entity.Property(e => e.Price).HasColumnType("varchar(20)");

                entity.Property(e => e.Start).HasColumnType("varchar(10)");

                entity.Property(e => e.StartTime).HasColumnType("varchar(20)");

                entity.Property(e => e.UserIdCode).HasColumnType("varchar(20)");

                entity.Property(e => e.UserName).HasColumnType("varchar(10)");

                entity.Property(e => e.creattime).HasColumnType("varchar(20)");
                entity.Property(e => e.Uid).HasColumnType("varchar(10)");
                entity.Property(e => e.Bid).HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("user");

                entity.Property(e => e.Uid).HasColumnType("varchar(10)");

                entity.Property(e => e.Age).HasColumnType("varchar(10)");

                entity.Property(e => e.IdCode).HasColumnType("varchar(20)");

                entity.Property(e => e.Name).HasColumnType("varchar(20)");

                entity.Property(e => e.Password).HasColumnType("varchar(20)");

                entity.Property(e => e.Sex).HasColumnType("varchar(10)");

                entity.Property(e => e.Type).HasColumnType("varchar(10)");
            });
        }
    }
}
