

using FilmesDB.Dominio.Enumeradores;


//ComentarioTeste

namespace FilmesDB.Dominio.Entidades
{
    public class Filme
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public DateTime Lancamento { get; set; }
        public Genero Genero { get; set; }
        public string Sinopse { get; set;}

    }
}
