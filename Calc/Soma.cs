using System;
namespace Calc;
public class Soma
{
    public static int CalcularSoma()
    {
        
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K = K + 1;  // Incrementa K
            SOMA = SOMA + K;  // Adiciona K à SOMA
        }

        return SOMA;  // Retorna o valor de SOMA
    }
}
