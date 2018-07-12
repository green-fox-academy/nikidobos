using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace fashionstoregf.Models
{
    public partial class gffashionstoreContext : DbContext
    {
        public DbSet<Warehouse> Warehouses { get; set; }
        public gffashionstoreContext()
        {
        }

        public gffashionstoreContext(DbContextOptions<gffashionstoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Warehouse> Warehouse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=gffashionstore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.ToTable("warehouse");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasColumnName("item_name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnName("unit_price");
            });
        }
    }
}
