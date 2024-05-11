using FilmesDB.Dominio.Entidades;
using FilmesDB.Infra.Repositorios;

namespace FilmesDB.Aplicacao.Servicos
{
    public class AtorServico: IServico<Ator>
    {
        private readonly IRepositorio<Ator> _atorRepositorio;

        public AtorServico(IRepositorio<Ator> atorRepositorio)
        {
            _atorRepositorio = atorRepositorio;
        }

        public void Atualizar(Ator dado)
        {
            if (_atorRepositorio.BuscarPorId(dado.Id)
                is not null)
            {
                _atorRepositorio.Atualizar(dado);
            }
        }

        public Ator BuscarPorId(int id)
        {
            return _atorRepositorio.BuscarPorId(id);

        }

        public Ator BuscarPorNome(string nome)
        {
            return _atorRepositorio.BuscarPorNome(nome);
        }

        public IEnumerable<Ator> BuscarTodos()
        {
            return _atorRepositorio.BuscarTodos();
        }

        public void Deletar(Ator dado)
        {
            if (_atorRepositorio.BuscarPorId(dado.Id)
                is not null)
            {
                _atorRepositorio.Deletar(dado);
            }
        }

        public void Inserir(Ator dado)
        {
            _atorRepositorio.Inserir(dado);
        }
    }
}

