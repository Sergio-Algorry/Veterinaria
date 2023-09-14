using Microsoft.EntityFrameworkCore;
using Veterinaria.Server.Data.Entity;

namespace Veterinaria.Server.Data
{
    public class Bd : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

    }
}
