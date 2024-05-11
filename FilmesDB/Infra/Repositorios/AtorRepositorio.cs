using FilmesDB.Dominio.Entidades;
using FilmesDB.Infra.Contexto;

namespace FilmesDB.Infra.Repositorios
{
    public class AtorRepositorio: IRepositorio<Ator>
    {
        private readonly DbContexto _dbContexto;

        public AtorRepositorio(DbContexto dbContexto)
        {
            _dbContexto = dbContexto;
        }

        public void Atualizar(Ator dado)
        {
            _dbContexto.Atores.Update(dado);
        }

        public Ator BuscarPorId(int id)
        {
            return _dbContexto.Atores.FirstOrDefault(
                x => x.Id == id);
        }

        public Ator BuscarPorNome(string nome)
        {
            return _dbContexto.Atores.FirstOrDefault(
                x => x.Nome == nome);
        }

        public IEnumerable<Ator> BuscarTodos()
        {
            return _dbContexto.Atores.ToList();
        }

        public void Deletar(Ator dado)
        {
            _dbContexto.Atores.Remove(dado);
        }

        public void Inserir(Ator dado)
        {
            _dbContexto.Atores.Add(dado);
        }
    }
}
