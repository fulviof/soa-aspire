using Microsoft.AspNetCore.Mvc;

namespace WebApis.Academico.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : Controller
    {
        [HttpGet]
        public IActionResult RetornaAluno()
        {
            //alteração academico3////asdasdasdasdalterandoooooo
            return Ok(new {nome = "Fulvio Fanelli", curso =  "Sistemas de Informação", status = "Cursando"});
        }
    }
}
