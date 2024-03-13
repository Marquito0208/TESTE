
using Microsoft.AspNetCore.Mvc;


namespace futebol_api.Controllers
{

    [ApiController]
    [Route("/api/[controller]")]
    public class JogadorController : ControllerBase
    {
        private static jogador teste = new jogador();

        [HttpGet]
        public ActionResult<jogador> Get()
        {
            return (teste);
            Console.WriteLine("AAAAA FUNCIONA GITHUB");
        }

    }
}
