using ConciertosApiAWS.Models;
using ConciertosApiAWS.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConciertosApiAWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private RepositoryConciertos repo;

        public EventosController(RepositoryConciertos repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Evento>>> Get()
        {
            return await this.repo.GetEventosAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Evento>>> GetId(int id)
        {
            return await this.repo.GetEventosByCategoriaAsync(id);
        }
    }
}
