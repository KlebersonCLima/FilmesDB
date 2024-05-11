using FilmesDB.Dominio.Enumeradores;

namespace FilmesDB.Dominio.Entidades
{
    public class Serie
    {
        public int Temporadas {  get; set; }
        public int NumeroDeEpisodios { get; set; }
        public bool Finalizada { get; set; }
        public string Nome { get; set; }
        public int Id { get; set; }
        public DateTime Lancamento { get; set; }
        public Genero Genero { get; set; }
        public string Sinopse { get; set; }

    }


}

