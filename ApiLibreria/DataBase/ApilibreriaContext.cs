using System;
using Microsoft.EntityFrameworkCore;

namespace DataBase;

public partial class ApilibreriaContext : DbContext
{
    public ApilibreriaContext()
    {
    }

    public ApilibreriaContext(DbContextOptions<ApilibreriaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<LoginModel> LoginModels { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);fd
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasIndex(e => e.UserIdUser, "IX_Books_UserIdUser");

            entity.Property(e => e.Editorial).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<LoginModel>(entity =>
        {
            entity.HasKey(e => e.LoginId);

            entity.ToTable("LoginModel");

            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.Detail)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.DetailId).HasName("PK_Detail");

            entity.ToTable("OrderDetail");

            entity.Property(e => e.Detail).HasMaxLength(200);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.Dni).HasMaxLength(8);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
