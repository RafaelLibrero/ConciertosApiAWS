﻿using ConciertosApiAWS.Models;
using Microsoft.EntityFrameworkCore;

namespace ConciertosApiAWS.Data
{
    public class ConciertosContext: DbContext
    {
        public ConciertosContext(DbContextOptions<ConciertosContext> options) : base(options) { }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<CategoriaEvento> Categorias { get; set; }
    }
}
