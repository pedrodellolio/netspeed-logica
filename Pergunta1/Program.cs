using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo cultureInfo = new("pt-BR");

        double precoCarro, desconto, valorFinal;
        int anoCarro;
        int total2000 = 0, totalGeral = 0;
        string continuarCalculando = "S";

        while (continuarCalculando == "S")
        {
            Console.Write("Digite o preço do carro: ");
            precoCarro = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o ano do carro: ");
            anoCarro = Convert.ToInt32(Console.ReadLine());

            if (anoCarro > 2000)
            {
                desconto = precoCarro * 0.07;
            }
            else
            {
                desconto = precoCarro * 0.12;
                total2000++;
            }

            totalGeral++;
            valorFinal = precoCarro - desconto;
            Console.WriteLine($"Valor do desconto: {desconto:C}");
            Console.WriteLine($"Valor a ser pago: {valorFinal:C}");
            Console.Write("Deseja continuar calculando descontos? (S/N): ");
            continuarCalculando = Console.ReadLine().ToUpper();
        }

        Console.WriteLine($"Total de carros com ano até 2000: {total2000}");
        Console.WriteLine($"Total geral de carros: {totalGeral}");
    }
}