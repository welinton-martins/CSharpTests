using System;
using System.Collections.Generic;
namespace Calc;
public class PertenceFibonacci
{
    public static string Fibonacci(int numero)
    {
        // Número a ser verificado
        int numeroParaVerificar = numero; // Você pode alterar este número conforme necessário

        // Gera a sequência de Fibonacci e verifica se o número pertence a ela
        bool pertence = VerificarFibonacci(numeroParaVerificar);

        // Imprime o resultado  
        if (pertence)
        {
            return $"{numeroParaVerificar} pertence à sequência de Fibonacci.";
        }
        else
        {
            return $"{numeroParaVerificar} não pertence à sequência de Fibonacci.";
        }
    }

    public static bool VerificarFibonacci(int numero)
    {
        // Lista para armazenar a sequência de Fibonacci
        List<int> fibonacci = new List<int> { 0, 1 };

        // Gera a sequência de Fibonacci até o número informado
        while (true)
        {
            int proximo = fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2];
            if (proximo > numero)
            {
                break; // Para quando o próximo número exceder o número informado
            }
            fibonacci.Add(proximo);
        }

        // Verifica se o número informado está na lista
        return fibonacci.Contains(numero);
    }
}
