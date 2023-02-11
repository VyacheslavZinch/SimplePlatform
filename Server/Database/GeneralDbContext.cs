using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Server.Database;

public partial class GeneralDbContext : DbContext
{
    public GeneralDbContext()
    {
    }

    public GeneralDbContext(DbContextOptions<GeneralDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserAuthorization> UserAuthorizations { get; set; }

    public virtual DbSet<UserInfo> UserInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-5R0C0SM\\SQLEXPRESS;Initial Catalog=GeneralDB;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserAuthorization>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("UserAuthorization");

            entity.Property(e => e.Uid)
                .HasMaxLength(50)
                .HasColumnName("UID");
            entity.Property(e => e.AuthToken).HasMaxLength(50);
            entity.Property(e => e.DateOfToken).HasMaxLength(50);

            entity.HasOne(d => d.UidNavigation).WithOne(p => p.UserAuthorization)
                .HasForeignKey<UserAuthorization>(d => d.Uid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("UID_FromUserInfo_To_UserAuthorization");
        });

        modelBuilder.Entity<UserInfo>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("UserInfo");

            entity.Property(e => e.Uid)
                .HasMaxLength(50)
                .HasColumnName("UID");
            entity.Property(e => e.Dateofbirth).HasMaxLength(50);
            entity.Property(e => e.Dateofregistration).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
