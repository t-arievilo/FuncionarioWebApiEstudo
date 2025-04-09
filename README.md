🧑‍💼 FuncionarioWebApiEstudo
API REST criada como projeto de estudo para gerenciamento de funcionários. O sistema permite cadastrar, consultar, atualizar e deletar registros de funcionários com informações como nome, sobrenome, turno, departamento e status de atividade.

🚀 Tecnologias utilizadas
.NET 7 / ASP.NET Core Web API

Entity Framework Core

SQL Server (via EF migrations)

AutoMapper

Swagger (Swashbuckle)

JSON Enum Serialization

Git + GitHub

📁 Estrutura do Projeto
nginx
Copiar
Editar
FuncionarioWebApi
│
├── Controllers              # Endpoints da API
├── Data                    # ApplicationDbContext e migrations
├── Enums                   # Tipos de Turno e Departamento
├── Models                  # Modelo Funcionario
├── Services                # Lógica de negócio (FuncionarioService)
├── Program.cs              # Configuração principal
└── appsettings.json        # Configurações de ambiente
⚙️ Funcionalidades
 Cadastrar funcionário

 Listar todos os funcionários

 Buscar funcionário por ID

 Atualizar dados de um funcionário

 Deletar funcionário

 Utilização de enums com serialização de texto via [JsonConverter]

 Migrations com EF Core para criação do banco

🧪 Rodando o projeto localmente
Clone o repositório:

bash
Copiar
Editar
git clone https://github.com/t-arievilo/FuncionarioWebApiEstudo.git
cd FuncionarioWebApiEstudo
Restaure os pacotes:

bash
Copiar
Editar
dotnet restore
Aplique as migrations no banco de dados local:

bash
Copiar
Editar
dotnet ef database update
Rode o projeto:

bash
Copiar
Editar
dotnet run
Acesse a documentação da API (Swagger):

bash
Copiar
Editar
https://localhost:{porta}/swagger
📌 Observações
A pasta .vs/, arquivos de build e configs locais estão ignorados no .gitignore.

Certifique-se de ter o SQL Server local rodando e configurado corretamente no appsettings.json.

✍️ Autor
Feito com 💻 por Thiago
Projeto de estudo pessoal como parte da jornada de aprendizado em ASP.NET Core.
