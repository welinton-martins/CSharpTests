using System;
using Calc;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Digite
1 para somar dois números:
2 para verificar se um número pertence à sequência de Fibonacci:
3 para calcular o faturamento mensal:
4 para calcular o percentual de representação por estado:
5 para inverter uma string:");
        int numero = int.Parse(Console.ReadLine() ?? "0");
        switch (numero) {
            case 1:
                // Chama o método CalcularSoma da classe Soma
                int resultado = Soma.CalcularSoma();
        
                // Imprime o resultado
                Console.WriteLine("Resultado da soma: " + resultado);
                break;
            case 2:
                // Chama o método PertenceFibonacci da classe PertenceFibonacci
                Console.WriteLine("Digite o número para verificar se pertence à sequência de Fibonacci:");
                int numeroFibonacci = int.Parse(Console.ReadLine() ?? "0");
                string resultadoFibonacci = PertenceFibonacci.Fibonacci(numeroFibonacci);

                // Imprime o resultado
                Console.WriteLine(resultadoFibonacci);
                break;
            case 3:
                // Chama o método Faturamento da classe Faturamento
                Console.WriteLine("Calculando faturamento...");
                string resultadoFaturamento = Faturamento.CalcularFaturamento();
                Console.WriteLine(resultadoFaturamento);
                break;
            case 4:
                // Chama o método PercentualEstado da classe PercentualEstado
                Console.WriteLine("Calculando percentual de representação por estado...");
                PercentualEstado.CalcularPercentual();
                break;
            case 5:
                // Chama o método InverterCaracteres da classe InverterCaracteres
                Console.WriteLine("Digite a string para inverter:");
                string stringParaInverter = Console.ReadLine() ?? "";
                string resultadoInverter = InverterCaracteres.Inverter(stringParaInverter);
                Console.WriteLine("String invertida: " + resultadoInverter);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

    }
}
