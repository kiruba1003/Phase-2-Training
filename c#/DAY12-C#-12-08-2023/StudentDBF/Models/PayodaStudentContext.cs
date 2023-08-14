using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentDBF.Models;

public partial class PayodaStudentContext : DbContext
{
    public PayodaStudentContext()
    {
    }

    public PayodaStudentContext(DbContextOptions<PayodaStudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; initial catalog = PayodaStudent; integrated security=SSPI; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Rollno);

            entity.Property(e => e.Rollno).ValueGeneratedNever();
            entity.Property(e => e.Phno).HasColumnName("phno");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
