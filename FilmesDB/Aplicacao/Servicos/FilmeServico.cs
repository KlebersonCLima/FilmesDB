using FilmesDB.Dominio.Entidades;
using FilmesDB.Infra.Repositorios;

namespace FilmesDB.Aplicacao.Servicos
{
    public class FilmeServico : IServico<Filme>
    {
        private readonly IRepositorio<Filme> _filmeRepositorio;

        public FilmeServico(IRepositorio<Filme> filmeRepositorio)
        {
            _filmeRepositorio = filmeRepositorio;
        }

        public void Atualizar(Filme dado)
        {
            if(_filmeRepositorio.BuscarPorId(dado.Id) 
                is not null)
            {
                _filmeRepositorio.Atualizar(dado);
            }
        }

        public Filme BuscarPorId(int id)
        {
            return _filmeRepositorio.BuscarPorId(id);

        }

        public Filme BuscarPorNome(string nome)
        {
            return _filmeRepositorio.BuscarPorNome(nome);
        }

        public IEnumerable<Filme> BuscarTodos()
        {
            return _filmeRepositorio.BuscarTodos();
        }

        public void Deletar(Filme dado)
        {
            if (_filmeRepositorio.BuscarPorId(dado.Id)
                is not null)
            {
                _filmeRepositorio.Deletar(dado);
            }
        }

        public void Inserir(Filme dado)
        {
            _filmeRepositorio.Inserir(dado);
        }
    }
}
