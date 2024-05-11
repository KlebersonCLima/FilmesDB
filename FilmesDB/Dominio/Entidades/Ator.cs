using FilmesDB.Dominio.Enumeradores;

namespace FilmesDB.Dominio.Entidades
{
    public class Ator
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Nacionalidade Nacionalidade { get; set; }
        public DateTime Aniversario { get; set; }
        public string Sexo { get; set; }

    }
}
