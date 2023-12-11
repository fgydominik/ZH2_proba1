using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZH2_proba1.Models;

public partial class BoardGameContext : DbContext
{
    public BoardGameContext()
    {
    }

    public BoardGameContext(DbContextOptions<BoardGameContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<Kategorium> Kategoria { get; set; }

    public virtual DbSet<Rendele> Rendeles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=softeng2023.database.windows.net;Initial Catalog=BoardGame;User ID=hallgato;Password=Password123;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasKey(e => e.GameSk);

            entity.ToTable("Game");

            entity.Property(e => e.GameSk).HasColumnName("GameSK");
            entity.Property(e => e.ArFt).HasColumnName("Ar_Ft");
            entity.Property(e => e.IdotartamPerc).HasColumnName("Idotartam_Perc");
            entity.Property(e => e.KategoriaFk).HasColumnName("KategoriaFK");
            entity.Property(e => e.MaxLetszam).HasColumnName("Max_Letszam");
            entity.Property(e => e.MinLetszam).HasColumnName("Min_Letszam");
            entity.Property(e => e.Nev).HasMaxLength(40);
            entity.Property(e => e.SzuksegesEletkor).HasColumnName("Szukseges_Eletkor");

            entity.HasOne(d => d.KategoriaFkNavigation).WithMany(p => p.Games)
                .HasForeignKey(d => d.KategoriaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Game_Kategoria");
        });

        modelBuilder.Entity<Kategorium>(entity =>
        {
            entity.HasKey(e => e.KategoriaSk);

            entity.Property(e => e.KategoriaSk).HasColumnName("KategoriaSK");
            entity.Property(e => e.KategoriaNev)
                .HasMaxLength(50)
                .HasColumnName("Kategoria_Nev");
        });

        modelBuilder.Entity<Rendele>(entity =>
        {
            entity.HasKey(e => e.RendelesId);

            entity.Property(e => e.RendelesId).HasColumnName("RendelesID");
            entity.Property(e => e.FizetendoFt).HasColumnName("Fizetendo_Ft");
            entity.Property(e => e.GameFk).HasColumnName("GameFK");
            entity.Property(e => e.MennyisegDb).HasColumnName("Mennyiseg_Db");

            entity.HasOne(d => d.GameFkNavigation).WithMany(p => p.Rendeles)
                .HasForeignKey(d => d.GameFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rendeles_Game");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
