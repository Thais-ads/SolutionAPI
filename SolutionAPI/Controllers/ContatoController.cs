using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SolutionAPI.Context;
using SolutionAPI.Model;

namespace SolutionAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ContatoController: ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext agendaContext)
        {

            _context = agendaContext;
        }

        [HttpPost("CriarContato")]
        public IActionResult Create(Contato a) {

            _context.Contatos.Add(a);
            _context.SaveChanges();
            return Ok(a);
        }


        [HttpGet("BuscarContato")]
        public IActionResult BuscarContato(int id)
        {
            var contato = _context.Contatos.Find(id);

            return Ok(contato);
        }


        [HttpGet("BuscarTodosContato")]
        public IActionResult BuscarTodosContato()
        {
            var contato = _context.Contatos.ToList();

            return Ok(contato);
        }


        [HttpGet("BuscarcontatoNome")]
        public IActionResult BuscarcontatoNome(string nome)
        {
            var contato = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contato);
        }


        [HttpPut("AtualizarContato")]
        public IActionResult AtualizarContato(int id, Contato a )
        {
            var contato = _context.Contatos.Find(id);

            if (contato != null) {

                contato.Nome = a.Nome;
                contato.Telefone = a.Telefone;
                contato.Ativo = a.Ativo;

                _context.Contatos.Update(contato);
                _context.SaveChanges();
                return Ok(contato);
            }

            return NotFound();
           
        }


        [HttpDelete("ApagarContato")]
        public IActionResult ApagarContato(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato != null) {

                _context.Contatos.Remove(contato);
                _context.SaveChanges();
                return Ok();
            }

            return NoContent();


        }



    }
}
