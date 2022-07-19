# DotnetTemplate
Template para projetos dotnet. Padrão para ser utilizado com aplicações web

## Localize
* [Instalação](#Instalação)
* [Execução](#Execução)
* [Tecnologias](#Tecnologias)

# Instalação
Para executar os algoritmos dese repositório siga os seguintes passos:

## 📦 Passos para instalar os pacotes

1. Clone este repositório.
2. Apague a pasta .git
3. Execute o comando RenameProject NomeDoSeuProjeto

```
RenameProject NomeDoSeuProjeto
```

# Execução

## 🚀 Como executar o aplicativo

Essa solução ja vem com uma API configurada com o Identity Framework
Para executa-la execute os comandos abaixo:

```
dotnet ef migrations add "Adding authentication to our Api"
dotnet ef database update
dotnet run
```

# Tecnologias

## 💻 Tecnologias utilizadas no projeto

* [Dotnet Core](https://docs.microsoft.com/pt-br/dotnet/core/introduction)
* [Entity Framework Core](https://docs.microsoft.com/pt-br/ef/core/)
* [postgres](https://www.postgresql.org/)
* [Identity ASP.NET core](https://docs.microsoft.com/pt-br/aspnet/core/security/authentication/identity?view=aspnetcore-6.0&tabs=visual-studio)