using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVCEST.Models
{
    public partial class NOTASDBContext : DbContext
    {
        public NOTASDBContext()
        {
        }

        public NOTASDBContext(DbContextOptions<NOTASDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NotasEst> NotasEsts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=CCBB-06\\CCBB06; Database=NOTASDB; integrated security= true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NotasEst>(entity =>
            {
                entity.HasKey(e => e.IdNotasEst)
                    .HasName("PK__NotasEst__B416967DDBD0B982");

                entity.ToTable("NotasEst");

                entity.Property(e => e.Apellido).HasMaxLength(30);

                entity.Property(e => e.Carnet).HasMaxLength(12);

                entity.Property(e => e.Iipn).HasColumnName("IIPN");

                entity.Property(e => e.Ipn).HasColumnName("IPN");

                entity.Property(e => e.Nf).HasColumnName("NF");

                entity.Property(e => e.Nombre).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
