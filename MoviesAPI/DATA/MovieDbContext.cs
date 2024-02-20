using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MoviesAPI.MODELS;

namespace MoviesAPI.DATA
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<ArtistaPelicula> ArtistaPeliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }
    }
}
