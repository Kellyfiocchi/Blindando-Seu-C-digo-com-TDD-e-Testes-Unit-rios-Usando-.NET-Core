using Calculadora.Services;

namespace CalculadoraTests;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);

    }

    [Fact]
    public void DeveSubtrair5Com10ERetornarMenos5()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(-5, resultado);

    }

    [Fact]
    public void DeveMultiplicar5Com10ERetornar50()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(50, resultado);

    }

    [Fact]
    public void DeveDividir5Com10ERetornar0()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Dividir(num1, num2);

        // Assert
        Assert.Equal(0, resultado);

    }
}