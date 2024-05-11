using FilmesDB.Aplicacao.Servicos;
using FilmesDB.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace FilmesDB.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmesController: Controller
    {
        private readonly IServico<Filme> _filmeServico;

        public FilmesController(IServico<Filme> filmeServico)
        {
            _filmeServico = filmeServico;
        }

        [HttpGet(Name = "BuscarFilmes")]
        public IEnumerable<Filme> Get()
        {
            return this._filmeServico.BuscarTodos();
        }

        [HttpPost(Name = "cadastrarFilmes")]
        public void Post(Filme filme)
        {
            _filmeServico.Inserir(filme);
        }

        [HttpPatch(Name = "AtualizarFilmes")]
        public void Patch(Filme filme)
        {
            _filmeServico.Atualizar(filme);
        }

        [HttpDelete(Name = "DeletarFilmes")]
        public void Delete(Filme filme)
        {
            _filmeServico.Deletar(filme);
        }
    }
}
