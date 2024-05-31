# Projeto CRUD Contatos - ASP.NET C# 
Siga as etapas abaixo para rodar o projeto com segurança:
Na IDE Visual Studio Community em Ferramentas > Gerenciador de Pacotes NuGet > Digitar o comando abaixo para executar a migration: 
```
Update-Database -Context BancoContext
```
Após isso troque o servidor em appsettings.json
```
"ConnectionStrings": {
  "DataBase": "{SuaMaquina}\\SQLCASSIO; Database=DB_SistemaContatos; User Id=sa; Password=123456; TrustServerCertificate=True"
}
```
Após isso compile o projeto normalmente.
