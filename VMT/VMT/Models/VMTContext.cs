using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VMT.Models
{
    public partial class VMTContext : DbContext
    {
        public VMTContext()
        {
        }

        public VMTContext(DbContextOptions<VMTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HangHoa> HangHoa { get; set; }
        public virtual DbSet<VanChuyen> VanChuyen { get; set; }
        public virtual DbSet<Xe> Xe { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=VMT;Persist Security Info=True;User ID=sa;Password=123456");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<HangHoa>(entity =>
            {
                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.Gia).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ref).HasMaxLength(100);

                entity.Property(e => e.Ten).HasMaxLength(250);
            });

            modelBuilder.Entity<VanChuyen>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BienSoXe)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.HangHoaRef).HasMaxLength(100);

                entity.Property(e => e.NgayVanChuyen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ref).HasMaxLength(100);

                entity.Property(e => e.XeRef).HasMaxLength(100);

                entity.HasOne(d => d.HangHoa)
                    .WithMany(p => p.VanChuyen)
                    .HasForeignKey(d => d.HangHoaId)
                    .HasConstraintName("FK__VanChuyen__HangHoa");

                entity.HasOne(d => d.Xe)
                    .WithMany(p => p.VanChuyen)
                    .HasForeignKey(d => d.XeId)
                    .HasConstraintName("FK__VanChuyen__Xe");
            });

            modelBuilder.Entity<Xe>(entity =>
            {
                entity.HasIndex(e => e.BienSoXe)
                    .HasName("UQ__Xe__A78059921A4D5864")
                    .IsUnique();

                entity.Property(e => e.BienSoXe)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.HangXe).HasMaxLength(250);

                entity.Property(e => e.Ref).HasMaxLength(100);
            });
        }
    }
}
