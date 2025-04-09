# FuncionarioWebApi

Uma API desenvolvida em ASP.NET Core com Entity Framework Core para gerenciamento de funcionários, criada como projeto de estudo.

## 🔧 Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- SQL Server
- Swagger (para documentação da API)
- AutoMapper
- Git

## 📦 Funcionalidades

- ✅ Cadastro de funcionários
- 🔍 Consulta de todos os funcionários
- 🧾 Consulta de funcionário por ID
- ✏️ Atualização de dados de um funcionário
- 🗑️ Exclusão lógica de funcionário
- 🔁 Enum para Turno e Departamento, retornando nome amigável via JSON

## 📁 Estrutura do Projeto

```
FuncionarioWebApi/
├── Controllers/
├── Data/
├── Dtos/
├── Enums/
├── Migrations/
├── Models/
├── Profiles/
├── Services/
└── Program.cs / Startup.cs
```

## 🚀 Como executar o projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/t-arievilo/FuncionarioWebApiEstudo.git
   ```

2. Acesse a pasta do projeto:
   ```bash
   cd FuncionarioWebApiEstudo
   ```

3. Configure o banco de dados no `appsettings.json`.

4. Rode as migrations:
   ```bash
   dotnet ef database update
   ```

5. Execute o projeto:
   ```bash
   dotnet run
   ```

6. Acesse o Swagger:
   ```
   https://localhost:{porta}/swagger
   ```

## 📌 Observações

- Este projeto foi desenvolvido com fins educacionais.
- A exclusão de funcionários é lógica, mantendo o dado no banco.

## 🤝 Contribuição

Sinta-se livre para abrir issues ou enviar pull requests com melhorias.

## 🧑‍💻 Autor

- **Thiago** – [@t-arievilo](https://github.com/t-arievilo)
