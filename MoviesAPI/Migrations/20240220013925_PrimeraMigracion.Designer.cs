﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesAPI.DATA;

#nullable disable

namespace MoviesAPI.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20240220013925_PrimeraMigracion")]
    partial class PrimeraMigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MoviesAPI.MODELS.Artista", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Nombre")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Artistas");
                });

            modelBuilder.Entity("MoviesAPI.MODELS.ArtistaPelicula", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ArtistaID")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ArtistaID");

                    b.HasIndex("PeliculaID");

                    b.ToTable("ArtistaPeliculas");
                });

            modelBuilder.Entity("MoviesAPI.MODELS.Genero", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("MoviesAPI.MODELS.Pelicula", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("GeneroID")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GeneroID");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("MoviesAPI.MODELS.ArtistaPelicula", b =>
                {
                    b.HasOne("MoviesAPI.MODELS.Artista", "Artista")
                        .WithMany()
                        .HasForeignKey("ArtistaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviesAPI.MODELS.Pelicula", "Pelicula")
                        .WithMany()
                        .HasForeignKey("PeliculaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artista");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("MoviesAPI.MODELS.Pelicula", b =>
                {
                    b.HasOne("MoviesAPI.MODELS.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");
                });
#pragma warning restore 612, 618
        }
    }
}
