using System;
namespace Calc;
public class InverterCaracteres
{
    public static string Inverter(string original)
    {
        // Convertemos a string original para um array de caracteres
        char[] caracteres = original.ToCharArray();

        // Inverter manualmente o array de caracteres
        for (int i = 0, j = caracteres.Length - 1; i < j; i++, j--)
        {
            // Troca os caracteres de posição
            char temp = caracteres[i];
            caracteres[i] = caracteres[j];
            caracteres[j] = temp;
        }

        // Converte o array de caracteres de volta para uma string
        string invertida = new string(caracteres);

        return invertida;
    }
}
