using FilmesDB.Aplicacao.Servicos;
using FilmesDB.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace FilmesDB.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeriesController: Controller
    {
        private readonly IServico<Serie>_serieServico;

        public SeriesController(IServico<Serie> serieServico)
        {
            _serieServico = serieServico;
        }

        [HttpGet(Name = "BuscarSeries")]
        public IEnumerable<Serie> Get()
        {
           return _serieServico.BuscarTodos();
        }

        [HttpPost(Name = "cadastrarSeries")]
        public void Post(Serie serie)
        {
            _serieServico.Inserir(serie);
        }

        [HttpPatch(Name = "AtualizarSeries")]
        public void Patch(Serie serie)
        {
            _serieServico.Atualizar(serie);
        }

        [HttpDelete(Name = "DeletarSeries")]
        public void Delete(Serie serie)
        {
            _serieServico.Deletar(serie);   
        }
    }
}
