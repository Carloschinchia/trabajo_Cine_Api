using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API_Cine.Models;

public partial class DbCineContext : DbContext
{
    public DbCineContext()
    {
    }

    public DbCineContext(DbContextOptions<DbCineContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pelicula> Peliculas { get; set; }

    public virtual DbSet<Registro> Registros { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pelicula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pelicula__3213E83FED18D958");

            entity.ToTable("pelicula");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descrision)
                .IsUnicode(false)
                .HasColumnName("descrision");
            entity.Property(e => e.Imagen)
                .IsUnicode(false)
                .HasColumnName("imagen");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("precio");
        });

        modelBuilder.Entity<Registro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__registro__3213E83FD32C79BC");

            entity.ToTable("registros");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdPelicula).HasColumnName("id_pelicula");
            entity.Property(e => e.IdUsuaario).HasColumnName("id_usuaario");

            entity.HasOne(d => d.IdPeliculaNavigation).WithMany(p => p.Registros)
                .HasForeignKey(d => d.IdPelicula)
                .HasConstraintName("FK__registros__id_pe__5165187F");

            entity.HasOne(d => d.IdUsuaarioNavigation).WithMany(p => p.Registros)
                .HasForeignKey(d => d.IdUsuaario)
                .HasConstraintName("FK__registros__id_us__5070F446");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usuarios__3213E83F58E9035B");

            entity.ToTable("usuarios");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contraseña");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
