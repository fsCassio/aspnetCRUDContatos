using ProjetoWebAppCsharp.Models;

namespace ProjetoWebAppCsharp.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
