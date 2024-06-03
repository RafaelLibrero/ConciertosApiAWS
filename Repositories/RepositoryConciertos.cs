using ConciertosApiAWS.Data;
using ConciertosApiAWS.Models;
using Microsoft.EntityFrameworkCore;

namespace ConciertosApiAWS.Repositories
{
    public class RepositoryConciertos
    {
        private ConciertosContext context;

        public RepositoryConciertos(ConciertosContext context)
        {
            this.context = context;
        }

        public async Task<List<CategoriaEvento>> GetCategoriaEventosAsync()
        {
            return await this.context.Categorias.ToListAsync();
        }

        public async Task<List<Evento>> GetEventosAsync()
        {
            return await this.context.Eventos.ToListAsync();
        }

        public async Task<List<Evento>> GetEventosByCategoriaAsync(int idCategoria)
        {
            return await
                this.context.Eventos
                .Where(x => x.IdCategoria == idCategoria)
                .ToListAsync();
        }
    }
}
