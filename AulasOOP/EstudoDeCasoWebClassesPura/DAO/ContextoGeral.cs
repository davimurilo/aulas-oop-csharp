using EstudoDeCasoWebClassesPura.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EstudoDeCasoWebClassesPura.DAO {
    public class ContextoGeral : DbContext {

        public ContextoGeral(DbContextOptions<ContextoGeral> options) : base(options)
        {
           
        }

        public DbSet<Cliente> Cliente { get; set; }

    }
}
