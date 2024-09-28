using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo cultureInfo = new("pt-BR");

        double jurosPorDia = 0.03;
        double multaFixa = 2.00;
        double totalJuros = jurosPorDia;

        Console.Write("Digite a data de vencimento original: ");
        var dataVencimentoOriginal = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.Write("Digite a data de vencimento nova: ");
        var dataPagamento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.Write("Digite o valor do boleto: ");
        var valorBoletoOriginal = double.Parse(Console.ReadLine());


        if (VerificaValidade(dataVencimentoOriginal, dataPagamento))
        {
            int diasAtraso = (dataPagamento - dataVencimentoOriginal).Days;
            totalJuros *= diasAtraso;
        }
        else
        {
            totalJuros = 0;
            multaFixa = 0;
        }

        double valorTotal = valorBoletoOriginal + totalJuros + multaFixa;

        Console.WriteLine($"Valor do boleto recalculado: {valorTotal:C}");
        Console.WriteLine($"Valor total de juros: {totalJuros:C}");
        Console.WriteLine($"Valor total da multa: {multaFixa:C}");
    }


    private static bool VerificaValidade(DateTime dataVencimento, DateTime dataPagamento)
    {
        bool vencimentoNoFeriadoOuFimDeSemana = VerificaFeriado(dataVencimento) || VerificaFimDeSemana(dataVencimento);
        DateTime proximoDiaUtil = ObterProximoDiaUtil(dataVencimento);

        // Casos que não devem cobrar juros e multa
        if (vencimentoNoFeriadoOuFimDeSemana && dataPagamento == proximoDiaUtil) return false;
        if (dataPagamento <= dataVencimento) return false;
        if (!vencimentoNoFeriadoOuFimDeSemana && dataPagamento == dataVencimento) return false;

        return true;
    }

    private static bool VerificaFeriado(DateTime data)
    {
        List<DateTime> feriadosFixos = new()
        {
            new (data.Year, 1, 1),     // Ano Novo
            new (data.Year, 4, 7),     // Paixão de Cristo
            new (data.Year, 4, 21),    // Tiradentes
            new (data.Year, 5, 1),     // Dia do Trabalho
            new (data.Year, 6, 8),     // Corpus Christi
            new (data.Year, 9, 7),     // Independência do Brasil
            new (data.Year, 10, 12),   // Nossa Senhora Aparecida
            new (data.Year, 11, 2),    // Finados
            new (data.Year, 11, 15),   // Proclamação da República
            new (data.Year, 12, 25)    // Natal
        };

        return feriadosFixos.Contains(data);
    }

    private static bool VerificaFimDeSemana(DateTime data)
    {
        return data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday;
    }

    private static DateTime ObterProximoDiaUtil(DateTime data)
    {
        DateTime proximoDia = data.AddDays(1);

        while (VerificaFimDeSemana(proximoDia) || VerificaFeriado(proximoDia))
        {
            proximoDia = proximoDia.AddDays(1);
        }

        return proximoDia;
    }
}