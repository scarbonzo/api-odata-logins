using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

public partial class LoginTrackingContext : DbContext
{
    public LoginTrackingContext()
    {
    }

    public LoginTrackingContext(DbContextOptions<LoginTrackingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblLogins> TblLogins { get; set; }
    public virtual DbSet<TblLoginsV2> TblLoginsV2 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

        modelBuilder.Entity<TblLogins>(entity =>
        {
            entity.HasKey(e => e.Loginid);

            entity.ToTable("tblLogins");

            entity.Property(e => e.Loginid).HasColumnName("loginid");

            entity.Property(e => e.Date)
                .HasColumnName("date")
                .HasColumnType("datetime");

            entity.Property(e => e.Dc)
                .IsRequired()
                .HasColumnName("dc")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Logintype)
                .IsRequired()
                .HasColumnName("logintype")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Machine)
                .IsRequired()
                .HasColumnName("machine")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Username)
                .IsRequired()
                .HasColumnName("username")
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblLoginsV2>(entity =>
        {
            entity.ToTable("tblLoginsV2");

            entity.HasIndex(e => e.Username)
                .HasName("IX_tblLoginsV2");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Date)
                .HasColumnName("date")
                .HasColumnType("datetime");

            entity.Property(e => e.Dc)
                .IsRequired()
                .HasColumnName("dc")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Gw)
                .IsRequired()
                .HasColumnName("gw")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Logintype)
                .IsRequired()
                .HasColumnName("logintype")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Machine)
                .IsRequired()
                .HasColumnName("machine")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Username)
                .IsRequired()
                .HasColumnName("username")
                .HasMaxLength(50)
                .IsUnicode(false);
        });
    }
}
