using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pizzaria.model;

public partial class Pizzaria09Context : DbContext
{
    public Pizzaria09Context()
    {
    }

    public Pizzaria09Context(DbContextOptions<Pizzaria09Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Bordum> Borda { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Massa> Massas { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Pizza> Pizzas { get; set; }

    public virtual DbSet<PizzaSabor> PizzaSabors { get; set; }

    public virtual DbSet<Sabor> Sabors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;User ID=sa;Password=39478312r;Database=pizzaria09;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bordum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Borda__3214EC07907078E2");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estado__3214EC07D76AB5C6");

            entity.ToTable("Estado");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        modelBuilder.Entity<Massa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Massa__3214EC07260B67C3");

            entity.ToTable("Massa");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pedido__3214EC07DAFD42DC");

            entity.ToTable("Pedido");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdEstado).HasColumnName("Id_Estado");
            entity.Property(e => e.IdPizza).HasColumnName("Id_Pizza");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK__Pedido__Id_Estad__5DCAEF64");

            entity.HasOne(d => d.IdPizzaNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdPizza)
                .HasConstraintName("FK__Pedido__Id_Pizza__5CD6CB2B");
        });

        modelBuilder.Entity<Pizza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pizza__3214EC0794AD6D73");

            entity.ToTable("Pizza");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdBorda).HasColumnName("Id_Borda");
            entity.Property(e => e.IdMassa).HasColumnName("Id_Massa");

            entity.HasOne(d => d.IdBordaNavigation).WithMany(p => p.Pizzas)
                .HasForeignKey(d => d.IdBorda)
                .HasConstraintName("FK__Pizza__Id_Borda__5070F446");

            entity.HasOne(d => d.IdMassaNavigation).WithMany(p => p.Pizzas)
                .HasForeignKey(d => d.IdMassa)
                .HasConstraintName("FK__Pizza__Id_Massa__4F7CD00D");
        });

        modelBuilder.Entity<PizzaSabor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pizza_Sa__3214EC07F977DD9B");

            entity.ToTable("Pizza_Sabor");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdPizza).HasColumnName("Id_Pizza");
            entity.Property(e => e.IdSabor).HasColumnName("Id_Sabor");

            entity.HasOne(d => d.IdPizzaNavigation).WithMany(p => p.PizzaSabors)
                .HasForeignKey(d => d.IdPizza)
                .HasConstraintName("FK__Pizza_Sab__Id_Pi__534D60F1");

            entity.HasOne(d => d.IdSaborNavigation).WithMany(p => p.PizzaSabors)
                .HasForeignKey(d => d.IdSabor)
                .HasConstraintName("FK__Pizza_Sab__Id_Sa__5441852A");
        });

        modelBuilder.Entity<Sabor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sabor__3214EC0737BEE902");

            entity.ToTable("Sabor");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
