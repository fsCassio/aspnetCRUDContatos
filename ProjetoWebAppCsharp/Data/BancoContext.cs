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

    }
}
