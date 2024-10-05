using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
namespace Calc;
public class Faturamento
{
    public int Dia { get; set; }
    public double Valor { get; set; }

    public static string CalcularFaturamento()
    {
        // Caminho do arquivo JSON (assumindo que o arquivo está na mesma pasta do executável)
        string caminhoArquivo = "faturamento.json";

        // Verifica se o arquivo existe
        if (!File.Exists(caminhoArquivo))
        {
            return "Arquivo JSON não encontrado.";
        }

        // Lê o conteúdo do arquivo JSON
        string json = File.ReadAllText(caminhoArquivo);

        // Converte o JSON para uma lista de objetos Faturamento
        List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(json);

        // Filtra os dias com faturamento maior que 0
        var diasComFaturamento = faturamentos.Where(f => f.Valor > 0).ToList();

        // Calcula o menor e maior valor de faturamento
        double menorFaturamento = diasComFaturamento.Min(f => f.Valor);
        double maiorFaturamento = diasComFaturamento.Max(f => f.Valor);

        // Calcula a média mensal (ignorando os dias com faturamento 0)
        double mediaMensal = diasComFaturamento.Average(f => f.Valor);

        // Conta o número de dias com faturamento superior à média mensal
        int diasAcimaDaMedia = diasComFaturamento.Count(f => f.Valor > mediaMensal);

        // Exibe os resultados
        return $"Menor faturamento: {menorFaturamento:F2}\nMaior faturamento: {maiorFaturamento:F2}\nNúmero de dias com faturamento acima da média mensal: {diasAcimaDaMedia}";
    }
}