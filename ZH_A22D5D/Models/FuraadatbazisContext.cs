using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZH_A22D5D.Models;

public partial class FuraadatbazisContext : DbContext
{
    public FuraadatbazisContext()
    {
    }

    public FuraadatbazisContext(DbContextOptions<FuraadatbazisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Connection> Connection { get; set; }

    public virtual DbSet<Portfolio> Portfolio { get; set; }

    public virtual DbSet<Stocks> Stocks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=gaboradatbazisaxd.database.windows.net;Initial Catalog=furaadatbazis;User ID=hallgato;Password=Password123;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Connection>(entity =>
        {
            entity.Property(e => e.ConnectionId).HasColumnName("Connection_ID");
            entity.Property(e => e.PortfolioFk).HasColumnName("Portfolio_FK");
            entity.Property(e => e.StocksFk).HasColumnName("Stocks_FK");

            entity.HasOne(d => d.PortfolioFkNavigation).WithMany(p => p.Connection)
                .HasForeignKey(d => d.PortfolioFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Connection_Portfolio");

            entity.HasOne(d => d.StocksFkNavigation).WithMany(p => p.Connection)
                .HasForeignKey(d => d.StocksFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Connection_Stocks");
        });

        modelBuilder.Entity<Portfolio>(entity =>
        {
            entity.HasKey(e => e.PortfolioSk);

            entity.Property(e => e.PortfolioSk).HasColumnName("Portfolio_SK");
            entity.Property(e => e.PortfolioName)
                .HasMaxLength(50)
                .HasColumnName("Portfolio_Name");
        });

        modelBuilder.Entity<Stocks>(entity =>
        {
            entity.HasKey(e => e.StockSk);

            entity.Property(e => e.StockSk).HasColumnName("Stock_SK");
            entity.Property(e => e.Market).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Ticker).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
