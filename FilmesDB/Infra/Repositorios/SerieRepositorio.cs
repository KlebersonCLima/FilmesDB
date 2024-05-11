using FilmesDB.Dominio.Entidades;
using FilmesDB.Infra.Contexto;

namespace FilmesDB.Infra.Repositorios
{
    public class SerieRepositorio: IRepositorio<Serie>
    {
        private readonly DbContexto _dbContexto;

        public SerieRepositorio(DbContexto dbContexto)
        {
            _dbContexto = dbContexto;
        }

        public void Atualizar(Serie dado)
        {
            _dbContexto.Series.Update(dado);
        }

        public Serie BuscarPorId(int id)
        {
            return _dbContexto.Series.FirstOrDefault(
                x => x.Id == id);
        }

        public Serie BuscarPorNome(string nome)
        {
            return _dbContexto.Series.FirstOrDefault(
                x => x.Nome == nome);
        }

        public IEnumerable<Serie> BuscarTodos()
        {
            return _dbContexto.Series.ToList();
        }

        public void Deletar(Serie dado)
        {
            _dbContexto.Series.Remove(dado);
        }

        public void Inserir(Serie dado)
        {
            _dbContexto.Series.Add(dado);
        }
    }
}
