using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BL.Models;

public partial class ZGroup1תלמידותאורייןאוחיוןWebapiCsharpMydatabaseMdfContext : DbContext
{
    public ZGroup1תלמידותאורייןאוחיוןWebapiCsharpMydatabaseMdfContext()
    {
    }

    public ZGroup1תלמידותאורייןאוחיוןWebapiCsharpMydatabaseMdfContext(DbContextOptions<ZGroup1תלמידותאורייןאוחיוןWebapiCsharpMydatabaseMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='Z:\\group1\\תלמידות\\אוריין אוחיון\\WebAPI\\Csharp\\MyDatabase.mdf';Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ArrivalHour).HasColumnType("date");
            entity.Property(e => e.EventDate).HasColumnType("date");
            entity.Property(e => e.Orderid).HasColumnName("orderid");
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.SumDresses).HasColumnName("sumDresses");

            entity.HasOne(d => d.Person).WithMany()
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK__Orders__PersonID__37A5467C");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Persons__AA2FFB854F0D195C");

            entity.Property(e => e.PersonId)
                .ValueGeneratedNever()
                .HasColumnName("PersonID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
