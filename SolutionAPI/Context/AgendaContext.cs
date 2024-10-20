using Microsoft.EntityFrameworkCore;
using SolutionAPI.Controllers;
using SolutionAPI.Model;

namespace SolutionAPI.Context
{
    public class AgendaContext :DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options ) : base (options)
        {
            
        }

        public DbSet<Contato> Contatos { get; set; }

    }
}
