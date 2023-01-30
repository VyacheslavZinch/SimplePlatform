using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SimplePlatform.Database;

public partial class GeneralDbContext : DbContext
{
    public GeneralDbContext()
    {
    }

    public GeneralDbContext(DbContextOptions<GeneralDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserAuthDatum> UserAuthData { get; set; }

    public virtual DbSet<UserInfo> UserInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-5R0C0SM\\SQLEXPRESS;Initial Catalog=GeneralDB;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserAuthDatum>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("USER_AUTH_DATA");

            entity.HasIndex(e => e.Uid, "IX_USER_AUTH_DATA");

            entity.Property(e => e.Uid)
                .HasMaxLength(50)
                .HasColumnName("UID");
            entity.Property(e => e.AuthToken)
                .HasMaxLength(50)
                .HasColumnName("AUTH_TOKEN");
            entity.Property(e => e.DateOfToken)
                .HasMaxLength(50)
                .HasColumnName("DATE_OF_TOKEN");

            entity.HasOne(d => d.UidNavigation).WithOne(p => p.UserAuthDatum)
                .HasForeignKey<UserAuthDatum>(d => d.Uid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_AUTH_DATA_USER_INFO");
        });

        modelBuilder.Entity<UserInfo>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("USER_INFO");

            entity.Property(e => e.Uid)
                .HasMaxLength(50)
                .HasColumnName("UID");
            entity.Property(e => e.Dateofbirth)
                .HasMaxLength(50)
                .HasColumnName("DATEOFBIRTH");
            entity.Property(e => e.Dateofregistration)
                .HasMaxLength(50)
                .HasColumnName("DATEOFREGISTRATION");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("NAME");
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .HasColumnName("SURNAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
