using FilmesDB.Dominio.Entidades;
using FilmesDB.Infra.Contexto;

namespace FilmesDB.Infra.Repositorios
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private readonly DbContexto _dbContexto;

        public FilmeRepositorio(DbContexto dbContexto)
        {
            _dbContexto = dbContexto;
        }

        public void Atualizar(Filme dado)
        {
            _dbContexto.Filmes.Update(dado);
        }

        public Filme BuscarPorId(int id)
        {
            return _dbContexto.Filmes.FirstOrDefault(
                x => x.Id == id);
        }

        public Filme BuscarPorNome(string nome)
        {
            return _dbContexto.Filmes.FirstOrDefault(
                x => x.Nome == nome);
        }

        public IEnumerable<Filme> BuscarTodos()
        {
            return _dbContexto.Filmes.ToList();
        }

        public void Deletar(Filme dado)
        {
            _dbContexto.Filmes.Remove(dado);
        }

        public void Inserir(Filme dado)
        {
            _dbContexto.Filmes.Add(dado);
        }
    }
}
