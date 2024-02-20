namespace MoviesAPI.MODELS
{
    public class ArtistaPelicula
    {
        public int ID { get; set; }
        public int ArtistaID { get; set; }
        public int PeliculaID { get; set; }
        //Propiedad de Navegación
        public Artista Artista { get; set; }
        public Pelicula Pelicula { get; set; }
    }
}
