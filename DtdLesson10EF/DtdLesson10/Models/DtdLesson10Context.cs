using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DtdLesson10.Models;

public partial class DtdLesson10Context : DbContext
{
    public DtdLesson10Context()
    {
    }

    public DtdLesson10Context(DbContextOptions<DtdLesson10Context> options)
        : base(options)
    {
    }



    public virtual DbSet<DtdPost> DtdPosts { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=LAPTOPDUONG;Database=DtdLesson10;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DtdPost>(entity =>
        {
            entity.HasKey(e => e.DtdId);

            entity.ToTable("DtdPost");

            entity.Property(e => e.DtdId)
                .ValueGeneratedNever()
                .HasColumnName("dtdId");
            entity.Property(e => e.DtdContent)
                .HasColumnType("ntext")
                .HasColumnName("dtdContent");
            entity.Property(e => e.DtdImage)
                .HasMaxLength(250)
                .HasColumnName("dtdImage");
            entity.Property(e => e.DtdStatus).HasColumnName("dtdStatus");
            entity.Property(e => e.DtdTitle)
                .HasMaxLength(250)
                .HasColumnName("dtdTitle");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
