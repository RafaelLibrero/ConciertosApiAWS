using ConciertosApiAWS.Models;
using ConciertosApiAWS.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ConciertosApiAWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController: ControllerBase
    {
        private RepositoryConciertos repo;

        public CategoriasController(RepositoryConciertos repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoriaEvento>>> Get()
        {
            return await this.repo.GetCategoriaEventosAsync();
        }
    }
}
