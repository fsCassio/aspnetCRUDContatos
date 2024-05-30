using ProjetoWebAppCsharp.Models;

namespace ProjetoWebAppCsharp.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        
        List<ContatoModel> BuscarTodos();

        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel Atualizar(ContatoModel contato);

        bool Apagar(int id);
    }
}
