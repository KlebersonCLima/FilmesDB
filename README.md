# FilmesDB

API REST em ASP.NET Core para cadastro de filmes, séries e atores.

## Tecnologias

- .NET 8 (ASP.NET Core Web API)
- Entity Framework Core 8
- MySQL (Pomelo)
- Swagger (Swashbuckle)

## Arquitetura

Organização em camadas dentro do projeto `FilmesDB/`:

| Camada | Responsabilidade |
|---|---|
| `Api` | Controllers (`Filmes`, `Series`, `Atores`) |
| `Aplicacao` | Serviços e regras de aplicação |
| `Dominio` | Entidades (`Filme`, `Serie`, `Ator`) e enumeradores |
| `Infra` | Contexto do EF Core e repositórios |

## Executar

Requisitos: .NET SDK 8 e MySQL.

1. Ajuste a connection string `DefaultConnection` em `FilmesDB/appsettings.json` (servidor, usuário e senha).
2. Execute:

```bash
cd FilmesDB
dotnet restore
dotnet run
```

3. Acesse a documentação interativa em `/swagger`.
