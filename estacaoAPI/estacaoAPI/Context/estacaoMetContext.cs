using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace estacaoAPI.Models
{
    public partial class estacaoMetContext : DbContext
    {
        public estacaoMetContext()
        {
        }

        public estacaoMetContext(DbContextOptions<estacaoMetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Leitura> Leitura { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=localhost;Database=estacaoMet;Port=5432;User Id=postgres;Password=vodk@net;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Leitura>(entity =>
            {
                entity.HasKey(e => e.IdLeitura);

                entity.ToTable("leitura");

                entity.Property(e => e.IdLeitura).HasColumnName("id_leitura");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasColumnName("hash")
                    .HasMaxLength(32)
                    .ForNpgsqlHasComment("6e1bbb5671b2dd6de8292c8374a1c01a");

                entity.Property(e => e.Temp).HasColumnName("temp");

                entity.Property(e => e.Umid).HasColumnName("umid");

                entity.Property(e => e.Veloc).HasColumnName("veloc");
            });
        }
    }
}
