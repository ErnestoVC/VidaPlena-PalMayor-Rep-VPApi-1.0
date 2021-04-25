﻿// <auto-generated />
using System;
using ApiVP.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiVP.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiVP.Domain.Entities.ABVC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TipoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoId");

                    b.ToTable("ABVCs");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Anciano", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FamiliarId")
                        .HasColumnType("int");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FamiliarId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Ancianos");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.AncianoABVC", b =>
                {
                    b.Property<int>("AncianoId")
                        .HasColumnType("int");

                    b.Property<int>("ABVCId")
                        .HasColumnType("int");

                    b.HasKey("AncianoId", "ABVCId");

                    b.HasIndex("ABVCId");

                    b.ToTable("AncianoABVCs");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Enfermero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Colegiatura")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<int>("EspecialidadId")
                        .HasColumnType("int");

                    b.Property<string>("Experiencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradoId")
                        .HasColumnType("int");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<string>("Universidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadId");

                    b.HasIndex("GradoId");

                    b.HasIndex("PersonaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Enfermeros");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.EnfermeroOferta", b =>
                {
                    b.Property<int>("EnfermeroId")
                        .HasColumnType("int");

                    b.Property<int>("OfertaId")
                        .HasColumnType("int");

                    b.HasKey("EnfermeroId", "OfertaId");

                    b.HasIndex("OfertaId");

                    b.ToTable("EnfermeroOfertas");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Especialidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Familiar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Familiares");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.FechaAtencion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("date");

                    b.Property<int>("OfertaId")
                        .HasColumnType("int");

                    b.Property<int>("RangoHoraId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfertaId");

                    b.HasIndex("RangoHoraId");

                    b.ToTable("FechaAtenciones");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Grado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Grados");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Oferta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AncianoId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("AncianoId");

                    b.ToTable("Ofertas");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.RangoHora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("Fin")
                        .HasColumnType("time(0)");

                    b.Property<TimeSpan>("Inicio")
                        .HasColumnType("time(0)");

                    b.HasKey("Id");

                    b.ToTable("RangoHoras");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Costo")
                        .HasColumnType("money");

                    b.Property<int>("EnfermeroId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("OfertaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnfermeroId");

                    b.HasIndex("OfertaId");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Tipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contrasenya")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.ABVC", b =>
                {
                    b.HasOne("ApiVP.Domain.Entities.Tipo", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Anciano", b =>
                {
                    b.HasOne("ApiVP.Domain.Entities.Familiar", "Familiar")
                        .WithMany("Ancianos")
                        .HasForeignKey("FamiliarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiVP.Domain.Entities.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.AncianoABVC", b =>
                {
                    b.HasOne("ApiVP.Domain.Entities.ABVC", "ABVC")
                        .WithMany("AncianoABVCs")
                        .HasForeignKey("ABVCId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiVP.Domain.Entities.Anciano", "Anciano")
                        .WithMany("AncianoABVCs")
                        .HasForeignKey("AncianoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Enfermero", b =>
                {
                    b.HasOne("ApiVP.Domain.Entities.Especialidad", "Especialidad")
                        .WithMany("Enfermeros")
                        .HasForeignKey("EspecialidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiVP.Domain.Entities.Grado", "Grado")
                        .WithMany("Enfermeros")
                        .HasForeignKey("GradoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiVP.Domain.Entities.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiVP.Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.EnfermeroOferta", b =>
                {
                    b.HasOne("ApiVP.Domain.Entities.Enfermero", "Enfermero")
                        .WithMany("EnfermeroOfertas")
                        .HasForeignKey("EnfermeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiVP.Domain.Entities.Oferta", "Oferta")
                        .WithMany("EnfermeroOfertas")
                        .HasForeignKey("OfertaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Familiar", b =>
                {
                    b.HasOne("ApiVP.Domain.Entities.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiVP.Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.FechaAtencion", b =>
                {
                    b.HasOne("ApiVP.Domain.Entities.Oferta", "Oferta")
                        .WithMany("FechaAtenciones")
                        .HasForeignKey("OfertaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiVP.Domain.Entities.RangoHora", "RangoHora")
                        .WithMany("FechaAtenciones")
                        .HasForeignKey("RangoHoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Oferta", b =>
                {
                    b.HasOne("ApiVP.Domain.Entities.Anciano", "Anciano")
                        .WithMany()
                        .HasForeignKey("AncianoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Servicio", b =>
                {
                    b.HasOne("ApiVP.Domain.Entities.Enfermero", "Enfermero")
                        .WithMany("Servicios")
                        .HasForeignKey("EnfermeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiVP.Domain.Entities.Oferta", "Oferta")
                        .WithMany()
                        .HasForeignKey("OfertaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiVP.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("ApiVP.Domain.Entities.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
