# Hello World xUnit

Projeto desenvolvido para a disciplina **Gestão e Qualidade de Software**, com o objetivo de praticar a criação de uma solução .NET, implementação de código de produção, testes unitários com xUnit e versionamento utilizando Git e GitHub.

## 🎯 Objetivo

Desenvolver uma aplicação simples em **C# com .NET 10**, contendo um serviço responsável por gerar saudações e uma suíte de testes unitários para verificar o comportamento do código.

O projeto também tem como objetivo aplicar conceitos de **Test-Driven Development (TDD)** e testes automatizados como forma de documentação viva do comportamento esperado da aplicação.


## Código de produção

A classe `HelloWorldService` possui o método `GerarSaudacao()`, responsável por gerar uma mensagem de saudação.

Quando nenhum nome é informado, o método retorna:

```text
Olá, Mundo!
```

Quando um nome é informado, retorna uma saudação personalizada. Por exemplo:

```text
Olá, Ana!
```

### Exemplo

```csharp
var service = new HelloWorldService();

var resultado = service.GerarSaudacao("Ana");

Console.WriteLine(resultado);
```

Resultado:

```text
Olá, Ana!
```

## Testes unitários

Os testes foram desenvolvidos utilizando o **xUnit**.

Foram implementados testes para verificar:

### Saudação padrão

Verifica se, quando o nome é `null`, o método retorna:

```text
Olá, Mundo!
```

### Saudação personalizada

Foram utilizados testes com diferentes nomes por meio do atributo `[Theory]` e `[InlineData]`:

```text
Ana    → Olá, Ana!
Carlos → Olá, Carlos!
```

Os testes utilizam `Assert.Equal()` para comparar o resultado obtido com o resultado esperado.

## TDD e testes como documentação viva

O projeto utiliza conceitos relacionados ao **TDD (Test-Driven Development)**.

O ciclo do TDD é composto por:

1. **RED** — criar um teste que inicialmente falha;
2. **GREEN** — implementar a solução mínima necessária para o teste passar;
3. **REFACTOR** — melhorar o código mantendo os testes passando.

Os testes também funcionam como uma forma de **documentação viva**, pois demonstram por meio de código quais comportamentos são esperados do método `GerarSaudacao()`.

Por exemplo:

```csharp
[InlineData("Ana", "Olá, Ana!")]
[InlineData("Carlos", "Olá, Carlos!")]
```

Esses casos documentam diretamente o comportamento esperado para diferentes entradas.

## Como executar a aplicação

Com o .NET 10 instalado, abra o terminal na pasta do projeto e execute:

```bash
dotnet run --project MeuPrimeiroTeste.App
```

A aplicação será executada pelo projeto `MeuPrimeiroTeste.App`.

## Como executar os testes

Para executar a suíte de testes, utilize:

```bash
dotnet test
```

O comando executará os testes automatizados do projeto `MeuPrimeiroTeste.Tests`.

Todos os testes devem ser executados com sucesso.

## Criando a solução via .NET CLI

A estrutura inicial da solução pode ser criada utilizando os seguintes comandos:

```bash
dotnet new sln -n MeuPrimeiroTeste

dotnet new console -n MeuPrimeiroTeste.App -f net10.0

dotnet new xunit -n MeuPrimeiroTeste.Tests -f net10.0

dotnet sln add MeuPrimeiroTeste.App/MeuPrimeiroTeste.App.csproj

dotnet sln add MeuPrimeiroTeste.Tests/MeuPrimeiroTeste.Tests.csproj

dotnet add MeuPrimeiroTeste.Tests/MeuPrimeiroTeste.Tests.csproj reference MeuPrimeiroTeste.App/MeuPrimeiroTeste.App.csproj
```

## Autores
**Kaio Moreira - 32510906**

**Erick Mello - 326211590**

**Icaro Ferreira - 325111358**

Projeto acadêmico desenvolvido para a disciplina de **Gestão e Qualidade de Software**.
