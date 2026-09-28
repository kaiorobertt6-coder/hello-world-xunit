using MeuPrimeiroTeste.App;

namespace MeuPrimeiroTeste.Tests;

public class HelloWorldServiceTests
{
    [Fact]
    public void GerarSaudacao_DeveRetornarSaudacaoPadrao_QuandoNomeForNuloOuVazio()
    {
        // Arrange (Preparação)
        var service = new HelloWorldService();

        // Act (Ação)
        var resultado = service.GerarSaudacao(null);

        // Assert (Verificação)
        Assert.Equal("Olá, Mundo!", resultado);
    }

    [Theory]
    [InlineData("Ana", "Olá, Ana!")]
    [InlineData("Carlos", "Olá, Carlos!")]
    public void GerarSaudacao_DeveRetornarSaudacaoPersonalizada_QuandoNomeForFornecido(
        string nome, string resultadoEsperado)
    {
        // Arrange
        var service = new HelloWorldService();

        // Act
        var resultado = service.GerarSaudacao(nome);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}