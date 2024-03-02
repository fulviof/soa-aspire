using Microsoft.AspNetCore.Mvc;

namespace WebApis.Vestibular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessoSeletivoController : Controller
    {

        [HttpGet]
        public IActionResult ObterProcessoSeletivo()
        {
            return Ok(new List<object>() { 
                new { nome = "Processo Seletivo Top Cursos Prudente", inicio = "26/02/2024", fim = "26/03/2024" },
                new { nome = "Processo Seletivo Top Cursos Jaú", inicio = "26/02/2024", fim = "26/03/2024" },
                new { nome = "Processo Seletivo Top Cursos Guarujá", inicio = "26/02/2024", fim = "26/03/2024" },
            });
        }
    }
}
