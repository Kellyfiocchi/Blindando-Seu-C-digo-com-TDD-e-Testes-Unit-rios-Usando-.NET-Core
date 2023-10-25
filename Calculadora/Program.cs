using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int num1 = 10;
int num2 = 5;

Console.WriteLine($"A soma de {num1} + {num2} = {c.Somar(num1, num2)}");

Console.WriteLine($"A subtração de {num1} - {num2} = {c.Subtrair(num1, num2)}");

Console.WriteLine($"A multiplicação de {num1} * {num2} = {c.Multiplicar(num1, num2)}");

Console.WriteLine($"A divisão de {num1} / {num2} = {c.Dividir(num1, num2)}");