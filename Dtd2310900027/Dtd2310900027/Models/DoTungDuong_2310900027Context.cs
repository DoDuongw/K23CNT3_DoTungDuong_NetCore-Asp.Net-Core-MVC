using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dtd2310900027.Models;

public partial class DoTungDuong_2310900027Context : DbContext
{
    public DoTungDuong_2310900027Context()
    {
    }

    public DoTungDuong_2310900027Context(DbContextOptions<DoTungDuong_2310900027Context> options)
        : base(options)
    {
    }

    public virtual DbSet<DtdEmployee> DtdEmployees { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=LAPTOPDUONG;Database=DoTungDuong_2310900027;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DtdEmployee>(entity =>
        {
            entity.HasKey(e => e.DtdEmpId).HasName("PK__DtdEmplo__A79086D43E31812B");

            entity.ToTable("DtdEmployee");

            entity.Property(e => e.DtdEmpId)
                .ValueGeneratedNever()
                .HasColumnName("dtdEmpId");
            entity.Property(e => e.DtdEmpLevel)
                .HasMaxLength(50)
                .HasColumnName("dtdEmpLevel");
            entity.Property(e => e.DtdEmpName)
                .HasMaxLength(100)
                .HasColumnName("dtdEmpName");
            entity.Property(e => e.DtdEmpStartDate).HasColumnName("dtdEmpStartDate");
            entity.Property(e => e.DtdEmpStatus).HasColumnName("dtdEmpStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
