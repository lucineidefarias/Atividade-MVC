using aec_mvc_entity_framework.Models;
using Microsoft.EntityFrameworkCore;

namespace aec_mvc_entity_framework.Servicos
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
} 
