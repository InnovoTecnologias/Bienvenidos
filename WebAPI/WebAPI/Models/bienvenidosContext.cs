using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BienvenidosWebAPI.Models
{
    public partial class bienvenidosContext : DbContext
    {
        public bienvenidosContext()
        {
        }

        public bienvenidosContext(DbContextOptions<bienvenidosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Centro> Centro { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Equipamiento> Equipamiento { get; set; }
        public virtual DbSet<EquipamientoTipo> EquipamientoTipo { get; set; }
        public virtual DbSet<Espacio> Espacio { get; set; }
        public virtual DbSet<EspacioTipo> EspacioTipo { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<Integrante> Integrante { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Practica> Practica { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Centro>(entity =>
            {
                entity.ToTable("centro");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasMaxLength(250);

                entity.Property(e => e.Idciudad).HasColumnName("idciudad");

                entity.Property(e => e.Imagen).HasColumnName("imagen");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(70);

                entity.Property(e => e.Validado).HasColumnName("validado");

                entity.Property(e => e.ValidadoFecha).HasColumnName("validado_fecha");

                entity.Property(e => e.ValidadoPor)
                    .HasColumnName("validado_por")
                    .HasColumnType("character varying");

                entity.Property(e => e.Video)
                    .HasColumnName("video")
                    .HasMaxLength(250);

                entity.HasOne(d => d.IdciudadNavigation)
                    .WithMany(p => p.Centro)
                    .HasForeignKey(d => d.Idciudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_centro_idciudad");
            });

            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.ToTable("ciudad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idprovincia).HasColumnName("idprovincia");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying");

                entity.Property(e => e.Validado).HasColumnName("validado");

                entity.Property(e => e.ValidadoFecha).HasColumnName("validado_fecha");

                entity.Property(e => e.ValidadoPor)
                    .HasColumnName("validado_por")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.IdprovinciaNavigation)
                    .WithMany(p => p.Ciudad)
                    .HasForeignKey(d => d.Idprovincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ciudad_idprovincia");
            });

            modelBuilder.Entity<Equipamiento>(entity =>
            {
                entity.HasKey(e => e.IdequipamientoTipo)
                    .HasName("equipamiento_pkey");

                entity.ToTable("equipamiento");

                entity.Property(e => e.IdequipamientoTipo)
                    .HasColumnName("idequipamiento_tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(5000);

                entity.Property(e => e.Foto).HasColumnName("foto");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(150);

                entity.Property(e => e.Video)
                    .HasColumnName("video")
                    .HasMaxLength(250);

                entity.HasOne(d => d.IdequipamientoTipoNavigation)
                    .WithOne(p => p.Equipamiento)
                    .HasForeignKey<Equipamiento>(d => d.IdequipamientoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_equipamiento_idequipamiento_tipo");
            });

            modelBuilder.Entity<EquipamientoTipo>(entity =>
            {
                entity.ToTable("equipamiento_tipo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<Espacio>(entity =>
            {
                entity.HasKey(e => e.IdespacioTipo)
                    .HasName("espacio_pkey");

                entity.ToTable("espacio");

                entity.Property(e => e.IdespacioTipo)
                    .HasColumnName("idespacio_tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(5000);

                entity.Property(e => e.Foto).HasColumnName("foto");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(150);

                entity.Property(e => e.Video)
                    .HasColumnName("video")
                    .HasMaxLength(250);

                entity.HasOne(d => d.IdespacioTipoNavigation)
                    .WithOne(p => p.Espacio)
                    .HasForeignKey<Espacio>(d => d.IdespacioTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_espacio_idespacio_tipo");
            });

            modelBuilder.Entity<EspacioTipo>(entity =>
            {
                entity.ToTable("espacio_tipo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.ToTable("especialidad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<Integrante>(entity =>
            {
                entity.ToTable("integrante");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasMaxLength(70);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(5000);

                entity.Property(e => e.Foto).HasColumnName("foto");

                entity.Property(e => e.Idcentro)
                    .HasColumnName("idcentro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idespecialidad)
                    .HasColumnName("idespecialidad")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(70);

                entity.Property(e => e.Video)
                    .HasColumnName("video")
                    .HasMaxLength(250);

                entity.HasOne(d => d.IdcentroNavigation)
                    .WithMany(p => p.Integrante)
                    .HasForeignKey(d => d.Idcentro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_integrante_idcentro");

                entity.HasOne(d => d.IdespecialidadNavigation)
                    .WithMany(p => p.Integrante)
                    .HasForeignKey(d => d.Idespecialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_integrante_idespecialidad");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.ToTable("pais");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying");

                entity.Property(e => e.Validado).HasColumnName("validado");

                entity.Property(e => e.ValidadoFecha).HasColumnName("validado_fecha");

                entity.Property(e => e.ValidadoPor)
                    .HasColumnName("validado_por")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Practica>(entity =>
            {
                entity.ToTable("practica");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('practicas_id_seq'::regclass)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasColumnType("character varying");

                entity.Property(e => e.Idcentro)
                    .HasColumnName("idcentro")
                    .HasDefaultValueSql("nextval('practicas_idcentro_seq'::regclass)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(70);

                entity.Property(e => e.Video)
                    .HasColumnName("video")
                    .HasMaxLength(250);

                entity.HasOne(d => d.IdcentroNavigation)
                    .WithMany(p => p.Practica)
                    .HasForeignKey(d => d.Idcentro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_practica_idcentro");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.ToTable("provincia");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idpais).HasColumnName("idpais");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying");

                entity.Property(e => e.Validado).HasColumnName("validado");

                entity.Property(e => e.ValidadoFecha).HasColumnName("validado_fecha");

                entity.Property(e => e.ValidadoPor)
                    .HasColumnName("validado_por")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.IdpaisNavigation)
                    .WithMany(p => p.Provincia)
                    .HasForeignKey(d => d.Idpais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_provincia_idpais");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasColumnType("character varying");

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasColumnType("character varying");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying");

                entity.Property(e => e.Usuario1)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasColumnType("character varying");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
