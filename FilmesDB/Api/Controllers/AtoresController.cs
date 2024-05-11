using FilmesDB.Aplicacao.Servicos;
using FilmesDB.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace FilmesDB.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtoresController: Controller
    {
        private readonly IServico<Ator> AtorServico;

        public AtoresController(IServico<Ator> atorServico)
        {
            AtorServico = atorServico;
        }

        [HttpGet(Name = "BuscarAtores")]
        public IEnumerable<Ator> Get()
        {
            return AtorServico.BuscarTodos();
        }

        [HttpPost(Name = "cadastrarAtores")]
        public void Post(Ator ator)
        {
            AtorServico.Inserir(ator);
        }

        [HttpPatch(Name = "AtualizarAtores")]
        public void Patch(Ator ator)
        {
            AtorServico.Atualizar(ator);
        }

        [HttpDelete(Name = "DeletarAtores")]
        public void Delete(Ator ator)
        {
            AtorServico.Deletar(ator);
        }
    }
}
