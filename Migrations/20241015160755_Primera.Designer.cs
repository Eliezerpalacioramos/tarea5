﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace tarea_5.Migrations
{
    [DbContext(typeof(JuegosContext))]
    [Migration("20241015160755_Primera")]
    partial class Primera
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Personajes_Videojuegos", b =>
                {
                    b.Property<int>("Personajes_VideojuegosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Arma_Favorita")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Habilidad_Especial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Imagen_Personaje")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Nivel_Poder")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VideojuegoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Personajes_VideojuegosId");

                    b.HasIndex("VideojuegoId");

                    b.ToTable("Personajes");
                });

            modelBuilder.Entity("Plataforma", b =>
                {
                    b.Property<int>("PlataformaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PlataformaID");

                    b.ToTable("Plataformas");
                });

            modelBuilder.Entity("Videojuegos", b =>
                {
                    b.Property<int>("VideojuegosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Desarrollador")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha_Lanzamiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Imagen_Portada")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PlataformaID")
                        .HasColumnType("INTEGER");

                    b.HasKey("VideojuegosId");

                    b.HasIndex("PlataformaID");

                    b.ToTable("Videojuegos");
                });

            modelBuilder.Entity("Personajes_Videojuegos", b =>
                {
                    b.HasOne("Videojuegos", "Videojuego")
                        .WithMany("Personajes")
                        .HasForeignKey("VideojuegoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Videojuego");
                });

            modelBuilder.Entity("Videojuegos", b =>
                {
                    b.HasOne("Plataforma", "Plataforma")
                        .WithMany("Videojuegos")
                        .HasForeignKey("PlataformaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plataforma");
                });

            modelBuilder.Entity("Plataforma", b =>
                {
                    b.Navigation("Videojuegos");
                });

            modelBuilder.Entity("Videojuegos", b =>
                {
                    b.Navigation("Personajes");
                });
#pragma warning restore 612, 618
        }
    }
}
