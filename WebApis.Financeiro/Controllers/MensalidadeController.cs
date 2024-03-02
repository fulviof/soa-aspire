using Microsoft.AspNetCore.Mvc;

namespace WebApis.Financeiro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MensalidadeController : Controller
    {

        [HttpGet]
        public IActionResult ObterMensalidadeAluno()
        {
            return Ok(new List<object>() { 
                new { aluno = 261640127, mes = 1, ano = 2024, valor = 800 }, 
                new { aluno = 261640127, mes = 2, ano = 2024, valor = 800 } 
            });
        }
    }
}
