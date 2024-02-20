namespace MoviesAPI.MODELS
{
    public class Pelicula
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public int GeneroID { get; set; }
        public Genero Genero { get; set; }

    }
}
