using Microsoft.EntityFrameworkCore;
using global.Models;

namespace global.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Sensor> Sensores { get; set; }
        public DbSet<PrevisaoTempo> Previsoes { get; set; }
        public DbSet<LeituraSensor> LeituraSensores { get; set; }
        public DbSet<Alerta> Alertas { get; set; }
        public DbSet<LogApi> LogsApi { get; set; }
    }
}
