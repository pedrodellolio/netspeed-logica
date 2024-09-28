using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo cultureInfo = new("pt-BR");
        Console.Write("Digite o código do aluno e suas três notas: ");
        string input = Console.ReadLine();

        while (input != "0")
        {
            string[] partes = input.Split(' ');

            int numAluno = int.Parse(partes[0]);

            // Monta um array de notas
            double[] notas = new double[3];
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = double.Parse(partes[i + 1]);
            }

            // Procura a maior nota e seu index
            double maiorNota = notas[0];
            int indexMaior = 0;
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > maiorNota)
                {
                    maiorNota = notas[i];
                    indexMaior = i;
                }
            }

            // Coloca a maior nota em primeiro lugar no array
            if (indexMaior != 0)
            {
                double aux = notas[0];
                notas[0] = notas[indexMaior];
                notas[indexMaior] = aux;
            }

            double mediaPonderada = (notas[0] * 4 + notas[1] * 3 + notas[2] * 3) / (4 + 3 + 3);
            Console.WriteLine($"Número do aluno: {numAluno}");
            Console.WriteLine($"Notas: {notas[0]}; {notas[1]}; {notas[2]}");
            Console.WriteLine($"Média do aluno: {mediaPonderada:0.0}");
            Console.WriteLine($"{(mediaPonderada >= 6 ? "APROVADO" : "REPROVADO")}");


            Console.Write("Digite o código do aluno e suas três notas: ");
            input = Console.ReadLine();
        }

    }
}