using Microsoft.AspNetCore.Mvc;

namespace SolutionAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        public UsuarioController()
        {
            
        }

        [HttpGet("Apresentar/{nome}")]
        public ActionResult Apresentar(string nome) {



            var mensagem = $"Olá {nome}, seja bem vindo!";



            return Ok(mensagem);
        
        }

    }
}
