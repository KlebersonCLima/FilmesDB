using FilmesDB.Dominio.Entidades;
using FilmesDB.Infra.Repositorios;

namespace FilmesDB.Aplicacao.Servicos
{
    public class SerieServico: IServico<Serie>
    {
        private readonly IRepositorio<Serie>_serieRepositorio;

        public SerieServico(IRepositorio<Serie> serieRepositorio)
        {
            _serieRepositorio = serieRepositorio;
        }

        public void Atualizar(Serie dado)
        {
            if (_serieRepositorio.BuscarPorId(dado.Id)
                is not null)
            {
                _serieRepositorio.Atualizar(dado);
            }
        }

        public Serie BuscarPorId(int id)
        {
            return _serieRepositorio.BuscarPorId(id);

        }

        public Serie BuscarPorNome(string nome)
        {
            return _serieRepositorio.BuscarPorNome(nome);
        }

        public IEnumerable<Serie> BuscarTodos()
        {
            return _serieRepositorio.BuscarTodos();
        }

        public void Deletar(Serie dado)
        {
            if (_serieRepositorio.BuscarPorId(dado.Id)
                is not null)
            {
                _serieRepositorio.Deletar(dado);
            }
        }

        public void Inserir(Serie dado)
        {
            _serieRepositorio.Inserir(dado);
        }
    }
}
