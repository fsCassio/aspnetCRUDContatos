using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoWebAppCsharp.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelaContatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CpfCnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RgIe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeAbreviado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeFederativa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Alteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });


            migrationBuilder.InsertData(
                table: "Contatos",
                columns: new[] { "Codigo", "Tipo", "CpfCnpj", "RgIe", "Nome", "NomeAbreviado", "Cep", "Logradouro", "Numero", "Complemento", "Bairro", "Municipio", "UnidadeFederativa", "Email", "Celular", "Inclusao" },
                values: new object[,]
                {
                    {"2b06a3d4-54d8-4c14-9814-648f85bab81b","PF","79035842197"   ,"07128346996"   ,"João Gabriel Carvalho","Vitor Hugo"     ,"64010269"  ,"Vila Leonardo Teixeira"           ,"24" ,"","Dom Cabral"                   ,"Campos do Norte"      ,"TO","ypereira@uol.com.br"              ,"4115336452"   ,"2024-05-31 12:00:00"},
                    {"8adc6085-dbc8-4157-a3c3-228afc2d0565","PJ","67394152000197","5521962524866" ,"Jesus Souza Ltda."    ,"e Filhos"       ,"46038-875" ,"Condomínio Ana Vitória Jesus"     ,"86" ,"","Vila Olhos D'água"            ,"Duarte"               ,"SC","qjesus@uol.com.br"                ,"05003356055"  ,"2024-05-31 12:00:00"},
                    {"967259bc-2323-4cff-ad52-ff07298578cc","PF","24703168553"   ,"74085312979"   ,"Bryan da Rosa"        ,"Diego"          ,"70716154"  ,"Passarela Maria Eduarda Lima"     ,"35" ,"","Buraco Quente"                ,"Peixoto de Melo"      ,"MT","melissafarias@peixoto.com"        ,"3139491677"   ,"2024-05-31 12:00:00"},
                    {"6b2bf8ab-6eed-4979-8d53-0123eec43781","PF","24096573892"   ,"43091825698"   ,"Isabelly Nogueira"    ,"Maria"          ,"33967183"  ,"Núcleo Barbosa"                   ,"40" ,"","Barreiro"                     ,"Silveira de Minas"    ,"CE","fernandesana-vitoria@nogueira.br" ,"6177058215"   ,"2024-05-31 12:00:00"},
                    {"1c35996a-26a8-4911-a2ea-8e28e8c2d291","PF","20167549820"   ,"90361257406"   ,"Ana Julia Barbosa"    ,"Thiago"         ,"50796-983" ,"Favela de Oliveira"               ,"952","","Vila Real 1ª Seção"           ,"Cardoso de Ribeiro"   ,"ES","fsilveira@da.com"                 ,"03007865159"  ,"2024-05-31 12:00:00"},
                    {"9d8a33b2-0eff-4ecf-ad68-65c33fbce0d4","PJ","29150683000145","5561963816404" ,"Monteiro Alves S.A."  ,"e Filhos"       ,"86926-692" ,"Trevo de Barros"                  ,"30" ,"","Embaúbas"                     ,"Farias"               ,"SE","eloahsilveira@ig.com.br"          ,"4171623415"   , "2024-05-31 12:00:00"},
                    {"c7686437-ddde-402e-8eda-2b067c47ee2c","PF","78261594319"   ,"06294871549"   ,"Luana Monteiro"       ,"Augusto"        ,"63501-144" ,"Setor Cardoso"                    ,"76" ,"","Pirineus"                     ,"Cavalcanti"           ,"DF","zpeixoto@gmail.com"               ,"2103056453"   , "2024-05-31 12:00:00"},
                    {"d497aacd-e60d-4153-9989-c63cc56c7dfc","PF","69537124819"   ,"69103587240"   ,"Kamilly Pinto"        ,"Anthony"        ,"90630-983" ,"Travessa Nascimento"              ,"75" ,"","Vila Ouro Minas"              ,"Silveira"             ,"RS","gomeslorenzo@viana.com"           ,"1197200273"   , "2024-05-31 12:00:00"},
                    {"b2f60c6c-cadd-41b2-a46c-457900c66adc","PJ","81475632000103","5511930584880" ,"da Rocha"             ,"- ME"           ,"94450-124" ,"Loteamento Luana Aragão"          ,"81" ,"","Taquaril"                     ,"Cardoso da Praia"     ,"AL","catarina47@hotmail.com"           ,"1199998711"   , "2024-05-31 12:00:00"},
                    {"b7a06a12-7f0d-4c77-b4cc-1a9cda1ae179","PF","79281530686"   ,"31856402762"   ,"Srta. Alana Carvalho" ,"Valentina"      ,"02212-631" ,"Viaduto Alves"                    ,"424","","Vila Da Luz"                  ,"da Luz"               ,"MG","cda-rocha@ig.com.br"              ,"1186183480"   , "2024-05-31 12:00:00"},
                    {"c54f039a-6056-4dea-8096-ba14e3941679","PJ","78034651000190","5531917085291" ,"Gonçalves S.A."       ,"S/A"            ,"70959-081" ,"Alameda de Teixeira"              ,"268","","Vila Santo Antônio"           ,"da Luz da Mata"       ,"AL","levi16@novaes.com"                ,"46229986"     , "2024-05-31 12:00:00"},
                    {"1afd3cdc-7d08-477a-aa10-f9748e1524bb","PF","59138260786"   ,"40863519270"   ,"João Pedro Souza"     ,"Daniela"        ,"29199366"  ,"Trecho Luiz Fernando Ribeiro"     ,"808","","Nova Cintra"                  ,"Viana Alegre"         ,"MS","juliada-paz@farias.net"           ,"8148988858"   , "2024-05-31 12:00:00"},
                    {"d65e174c-605a-4987-9b88-2b5d44c75189","PJ","13298765000100","5551920226869" ,"Silva"                ,"S.A."           ,"37951471"  ,"Largo das Neves"                  ,"96" ,"","Marieta 2ª Seção"             ,"Nogueira"             ,"ES","dfarias@gmail.com"                ,"26844845"     , "2024-05-31 12:00:00"},
                    {"2c9dc41b-1741-430c-a2de-47142195cc6f","PJ","25601834000183","5571962119708" ,"Sales"                ,"- ME"           ,"51921-961" ,"Estação de Santos"                ,"99" ,"","Leticia"                      ,"Melo Grande"          ,"RJ","maite55@hotmail.com"              ,"4123031340"   , "2024-05-31 12:00:00"},
                    {"517171d0-51bd-4d46-bfdf-522b0e34bdac","PF","02791683496"   ,"19567028494"   ,"Benício Silva"        ,"Carlos Eduardo" ,"59060980"  ,"Colônia Correia"                  ,"252","","Maravilha"                    ,"da Paz Alegre"        ,"RR","ian43@yahoo.com.br"               ,"1165753902"   , "2024-05-31 12:00:00"},
                    {"49f968a0-6603-4fcd-8389-9aa9e53bb9db","PJ","25678943000107","5511955092054" ,"Souza Almeida - EI"   ,"- EI"           ,"91302775"  ,"Campo de Cavalcanti"              ,"15" ,"","Rio Branco"                   ,"da Cruz do Campo"     ,"RR","marianarezende@yahoo.com.br"      ,"7181990674"   , "2024-05-31 12:00:00"},
                    {"a283d512-10b3-4ef2-ae70-f7d20d2aeaac","PJ","23084791000180","5571936893525" ,"Martins - EI"         ,"e Filhos"       ,"45661-799" ,"Praça Ferreira"                   ,"75" ,"","Conjunto Celso Machado"       ,"Freitas do Norte"     ,"MA","lorenzo05@fogaca.br"              ,"09004442410"  , "2024-05-31 12:00:00"},
                    {"9c7abf24-0a42-41aa-b606-d3a7b5767bcd","PF","61849703566"   ,"89137452088"   ,"Isaac da Cruz"        ,"Henrique"       ,"53614-340" ,"Lago de Gonçalves"                ,"77" ,"","Vila Suzana Primeira Seção"   ,"da Luz"               ,"CE","santosfrancisco@silva.com"        ,"8105289810"   , "2024-05-31 12:00:00"},
                    {"61e371b9-c7df-41fa-b346-ae2bfe2389a0","PJ","48725130000118","5521953125746" ,"Silva Ltda."          ,"S/A"            ,"24319539"  ,"Lagoa de Sales"                   ,"2"  ,"","Ouro Preto"                   ,"Vieira"               ,"PB","ana-carolina90@da.br"             ,"6190134838"   ,"2024-05-31 12:00:00"},
                    {"959c8dbc-de7e-4e26-8270-1decb3f96899","PJ","98053421000185","5521977839722" ,"Nascimento"           ,"- EI"           ,"04411-151" ,"Viela Porto"                      ,"21" ,"","Jardim São José"              ,"da Mota Grande"       ,"PI","renan98@pinto.com"                ,"5195807745"   , "2024-05-31 12:00:00"},
                    {"fb793032-0215-4562-992c-59f419efbeed","PF","47016892549"   ,"28314097560"   ,"João Felipe Fogaça"   ,"Valentina"      ,"30425573"  ,"Travessa Maria Alice Moraes"      ,"97" ,"","Santa Efigênia"               ,"Nascimento"           ,"GO","njesus@ig.com.br"                 ,"4126021507"   , "2024-05-31 12:00:00"},
                    {"47eefc03-6bca-4f8a-b16b-f3be1fd9a011","PF","95623841791"   ,"21563940752"   ,"Melissa da Luz"       ,"Marina"         ,"67095-639" ,"Passarela de Ferreira"            ,"82" ,"","Parque São José"              ,"Moreira de Goiás"     ,"RO","bgoncalves@ig.com.br"             ,"8113732179"   , "2024-05-31 12:00:00"},
                    {"16d4e9aa-615a-44cd-8a5a-82ceea1e1530","PF","38291604703"   ,"10432879650"   ,"Dr. Vitor Hugo Pires" ,"Melissa"        ,"07329-623" ,"Condomínio de Novaes"             ,"852","","Teixeira Dias"                ,"Novaes"               ,"CE","zrezende@caldeira.com"            ,"8440761442"   , "2024-05-31 12:00:00"},
                    {"fb2173db-e8c2-4c88-84e9-e15eb73fe7c3","PJ","35790286000130","5511951718403" ,"Cardoso - ME"         ,"Ltda."          ,"04556807"  ,"Vale de Gonçalves"                ,"38" ,"","Vista Alegre"                 ,"Pinto Verde"          ,"RS","clarice29@cunha.com"              ,"05006883240"  , "2024-05-31 12:00:00"},
                    {"a573c1ca-92d1-4427-84dd-9a20c965593b","PF","67305194280"   ,"85491026794"   ,"Sr. Levi Lopes"       ,"Juliana"        ,"93620-051" ,"Largo de Correia"                 ,"747","","Bonfim"                       ,"Martins de Gomes"     ,"CE","erickcunha@aragao.com"            ,"8188272594"   , "2024-05-31 12:00:00"},
                    {"bc3e4e03-cf10-42c1-9814-3a33d2f1dab5","PJ","78349526000179","5511951028688" ,"Correia - ME"         ,"S/A"            ,"41148-739" ,"Setor Mendes"                     ,"18" ,"","Lourdes"                      ,"Costa do Sul"         ,"PE","da-pazbarbara@bol.com.br"         ,"2158560995"   , "2024-05-31 12:00:00"},
                    {"09c5cf8c-613b-49ff-a25b-e9b4de01c231","PJ","21598436000102","5561947877506" ,"Ferreira"             ,"Ltda."          ,"56272713"  ,"Setor Luna Moraes"                ,"2"  ,"","Cdi Jatoba"                   ,"Lima"                 ,"TO","nmoraes@cardoso.br"               ,"8113937054"   , "2024-05-31 12:00:00"},
                    {"e87c72a9-147b-4c09-b39b-073db01172c7","PF","62495837182"   ,"14067285353"   ,"Francisco da Cruz"    ,"Vitor"          ,"76403-469" ,"Estrada Luiz Miguel Carvalho"     ,"9"  ,"","Estrela Do Oriente"           ,"Viana Verde"          ,"SP","bdias@ig.com.br"                  ,"3135364306"   , "2024-05-31 12:00:00"},
                    {"774df929-1913-4d3e-bda5-ec6259d18bd6","PF","48032591605"   ,"53946172873"   ,"Heitor das Neves"     ,"Milena"         ,"85292425"  ,"Viaduto Moura"                    ,"21" ,"","Vila Do Pombal"               ,"Ferreira"             ,"SC","claricesouza@gmail.com"           ,"3146272097"   , "2024-05-31 12:00:00"},
                    {"cdd6644f-7229-463f-9114-36c92b71954c","PF","56340179207"   ,"12795463016"   ,"Enzo Duarte"          ,"Bárbara"        ,"49318475"  ,"Estrada Lima"                     ,"2"  ,"","Vila Nova Gameleira 2ª Seção" ,"Barbosa"              ,"CE","icardoso@gmail.com"               ,"1134375125"   , "2024-05-31 12:00:00"}
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");
        }
    }
}
