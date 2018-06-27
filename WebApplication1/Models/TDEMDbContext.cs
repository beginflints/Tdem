using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class TDEMDbContext : DbContext
    {
        public TDEMDbContext()
        {
        }

        public TDEMDbContext(DbContextOptions<TDEMDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Body> Body { get; set; }
        public virtual DbSet<Header> Header { get; set; }
        public virtual DbSet<Tailer> Tailer { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=172.19.102.43;Initial Catalog=TDEM;Persist Security Info=True;User ID=sa;Password=edi@1234");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Body>(entity =>
            {
                entity.HasKey(e => new { e.Inv, e.InvDate, e.ContainerNo });

                entity.Property(e => e.Inv)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ContainerNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ata)
                    .HasColumnName("ATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Atd)
                    .HasColumnName("ATD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CompleteInpectionDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTdemwh)
                    .HasColumnName("DateTDEMWH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateYusenCy)
                    .HasColumnName("DateYusenCY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EndFtdemurrage)
                    .HasColumnName("EndFTDemurrage")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EndFtdetention)
                    .HasColumnName("EndFTDetention")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EndFtstorage)
                    .HasColumnName("EndFTStorage")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EndRec)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Etd)
                    .HasColumnName("ETD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ExCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExCompany)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseFixContainer)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseOverFt)
                    .HasColumnName("ExpenseOverFT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Ftdemurrage).HasColumnName("FTDemurrage");

                entity.Property(e => e.Ftdetention).HasColumnName("FTDetention");

                entity.Property(e => e.Ftstorage).HasColumnName("FTStorage");

                entity.Property(e => e.ImCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ImCompany)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocationTdem)
                    .HasColumnName("LocationTDEM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OtherExpense)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.RpackOwner)
                    .HasColumnName("RPackOwner")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RpackQty).HasColumnName("RPackQty");

                entity.Property(e => e.RpackType)
                    .HasColumnName("RPackType")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCca)
                    .HasColumnName("ShipCCA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Terminal)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vessel)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.FileNameNavigation)
                    .WithMany(p => p.Body)
                    .HasForeignKey(d => d.FileName)
                    .HasConstraintName("FK_Body_Header");
            });

            modelBuilder.Entity<Header>(entity =>
            {
                entity.HasKey(e => e.FileName);

                entity.Property(e => e.FileName)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BeginFileName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BeginFromSys)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BeginInterfaceName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BeginRec)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BeginRecLength)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BeginToSys)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EndRec)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FromSys)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HeadSymbol)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InterfaceName)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.InterfaceType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecLength)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ToSysName)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tailer>(entity =>
            {
                entity.HasKey(e => e.FileName);

                entity.Property(e => e.FileName)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BeginRec)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BeginTotalRec)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EndRec)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TailerSymbol)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalRec)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.HasOne(d => d.FileNameNavigation)
                    .WithOne(p => p.Tailer)
                    .HasForeignKey<Tailer>(d => d.FileName)
                    .HasConstraintName("FK_Tailer_Header");
            });
        }
    }
}
