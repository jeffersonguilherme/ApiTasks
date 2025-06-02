ApiTasks

Um projeto de API para gerenciamento de tarefas, desenvolvido com .NET 8 e seguindo uma arquitetura em camadas.

Sobre o Projeto

Este repositório contém o código-fonte de uma API RESTful projetada para gerenciar tarefas. A aplicação permite realizar operações básicas de CRUD (Criar, Ler, Atualizar, Deletar) para tarefas, além de possivelmente incluir funcionalidades relacionadas a usuários e autenticação (inferido pela estrutura de pastas como UserCQ e menções a RefreshToken nos commits).

A arquitetura do projeto é dividida em camadas distintas para melhor organização e manutenibilidade:

•
API: Camada de apresentação, responsável por expor os endpoints RESTful e lidar com as requisições HTTP. Utiliza Swagger para documentação da API.

•
Application: Contém a lógica de aplicação, orquestrando as operações e possivelmente implementando o padrão CQRS (Command Query Responsibility Segregation), como sugerido pelas pastas CardCQ e UserCQ.

•
Domain: Camada central que define as entidades de negócio (como Task, User), enums e regras de domínio.

•
Infra: Camada de infraestrutura, responsável pela persistência de dados (utilizando Entity Framework Core e SQL Server) e outras dependências externas.

•
Services: Pode conter serviços compartilhados ou lógica de integração.

Tecnologias Utilizadas

•
C#: Linguagem de programação principal.

•
.NET 8: Framework de desenvolvimento.

•
ASP.NET Core: Framework para construção da API Web.

•
Entity Framework Core 9: ORM para interação com o banco de dados.

•
SQL Server: Sistema de gerenciamento de banco de dados.

•
Swashbuckle (Swagger): Ferramenta para geração de documentação interativa da API.

•
Arquitetura em Camadas / CQRS (potencialmente): Padrões de arquitetura de software.

Começando

Siga as instruções abaixo para configurar e executar o projeto em seu ambiente local.

Pré-requisitos

Antes de começar, certifique-se de ter instalado:

•
.NET 8 SDK: Download .NET 8

•
SQL Server: Uma instância do SQL Server (Express, Developer, etc.) acessível localmente ou na rede.

•
Git: Para clonar o repositório.

Instalação

1.
Clone o repositório para sua máquina local:

2.
Navegue até o diretório raiz do projeto clonado:

Configuração

1.
Banco de Dados:

•
Abra o arquivo API/appsettings.json.

•
Localize a seção ConnectionStrings.

•
Atualize o valor de DefaultConnection com a string de conexão correta para sua instância do SQL Server. Exemplo:

•
Certifique-se de que o banco de dados TasksDatabase (ou o nome que preferir) exista em sua instância do SQL Server ou que o usuário configurado tenha permissão para criá-lo.



2.
Aplicar Migrations:

•
Abra um terminal ou prompt de comando na pasta raiz do projeto (ApiTasks).

•
Execute o comando do Entity Framework Core para aplicar as migrações e criar/atualizar o esquema do banco de dados. Certifique-se de ter as ferramentas do EF Core instaladas (dotnet tool install --global dotnet-ef).

•
Este comando utiliza o projeto Infra (onde o DbContext provavelmente está definido) e o projeto API (que contém a configuração e a string de conexão) para aplicar as migrações.



Uso

1.
Executar a API:

•
Ainda no terminal, na pasta raiz do projeto, execute o seguinte comando para iniciar a API:

•
A API estará em execução e ouvindo em um endereço local (geralmente https://localhost:xxxx e http://localhost:yyyy, verifique o output do console).



2.
Acessar a Documentação (Swagger):

•
Abra seu navegador e navegue até a URL da interface do Swagger UI (geralmente /swagger adicionado à URL base da sua API, por exemplo: https://localhost:xxxx/swagger).

•
Você poderá visualizar todos os endpoints disponíveis, seus parâmetros e testá-los diretamente pela interface.



Estrutura do Projeto

Plain Text


ApiTasks/
├── API/                # Camada de Apresentação (Endpoints, Configuração)
├── Application/        # Camada de Aplicação (Lógica, CQRS?)
├── Domain/             # Camada de Domínio (Entidades, Regras)
├── Infra/              # Camada de Infraestrutura (Persistência, DBContext, Migrations)
├── Services/           # Camada de Serviços (Serviços compartilhados?)
└── TasksApp.sln        # Arquivo da Solução Visual Studio


Contribuição

Contribuições são bem-vindas! Se você tiver sugestões para melhorar este projeto, sinta-se à vontade para abrir uma issue ou enviar um pull request.

