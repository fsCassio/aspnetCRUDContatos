using Microsoft.EntityFrameworkCore;
using ProjetoWebAppCsharp.Models;

namespace ProjetoWebAppCsharp.Data
{
    // herdando o contexto do banco
    public class BancoContext : DbContext
    {
        //construtor passando a informaçao de options para DbContext
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-IR7B107\\SQLCASSIO; Database=DB_SistemaContatos; User Id=sa; Password=123456; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
