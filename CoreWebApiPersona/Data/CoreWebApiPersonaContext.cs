using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreWebApiPersona.Modelo;

namespace CoreWebApiPersona.Data
{
    public class CoreWebApiPersonaContext : DbContext
    {
        public CoreWebApiPersonaContext (DbContextOptions<CoreWebApiPersonaContext> options)
            : base(options)
        {
        }

        public DbSet<CoreWebApiPersona.Modelo.Persona> Persona { get; set; }
    }
}
