using ProjetoWebAppCsharp.Data;
using ProjetoWebAppCsharp.Models;

namespace ProjetoWebAppCsharp.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        // inserçao no banco de dados
        public ContatoModel Adicionar(ContatoModel contato)
        {
            contato.Inclusao = DateTime.Now;
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);

            if (contatoDB == null) throw new Exception("Ocorreu um erro na atualização do contato!");

            contatoDB.Codigo = contato.Codigo;
            contatoDB.Tipo = contato.Tipo;
            contatoDB.CpfCnpj = contato.CpfCnpj;
            contatoDB.RgIe = contato.RgIe;
            contatoDB.Nome = contato.Nome;
            contatoDB.NomeAbreviado = contato.NomeAbreviado;
            contatoDB.Cep = contato.Cep;
            contatoDB.Logradouro = contato.Logradouro;
            contatoDB.Numero = contato.Numero;
            contatoDB.Complemento = contato.Complemento;
            contatoDB.Bairro = contato.Bairro;
            contatoDB.Municipio = contato.Municipio;
            contatoDB.UnidadeFederativa = contato.UnidadeFederativa;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;
            contatoDB.Alteracao = DateTime.Now;

            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);

            if (contatoDB == null) throw new Exception("Ocorreu um erro na exclusão do contato!");

            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
