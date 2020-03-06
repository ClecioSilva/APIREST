using Microsoft.AspNetCore.Mvc;

namespace ApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasaShowController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(){
            return Ok(new {nome = "Clecio Silva", empresa = "GFT"}); //Status code =200 && dados
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id){
            return Ok("Théo Almeida" + id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CasaShowTemp cTemp){
            return Ok(new {info = "Você criou uma nova Casa de Show", CasaShow = cTemp});
        }

        public class CasaShowTemp{
            public string Nome{get;set;}
            public string End{get;set;}
        }
        
    }
}