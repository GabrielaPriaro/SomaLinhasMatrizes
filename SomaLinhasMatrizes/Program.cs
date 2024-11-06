//Utilizando Matrizes:
//Problema "soma_linhas"
//Fazer um programa para ler dois números inteiros M e N (máximo = 10). Em seguida, ler uma matriz
//de M linhas e N colunas contendo números reais. Gerar um vetor de modo que cada elemento do vetor
//seja a soma dos elementos da linha correspondente da matriz. Mostrar o vetor gerado. 

using System.Globalization;

namespace SomaLinhasMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Qual a quantidade de colunas da matriz? ");
            n = int.Parse(Console.ReadLine());

            double[,] mat = new double[m, n];
            double[] vetGerado = new double[m];

            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Digite os elementos da {i + 1}a. linha:");

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = double.Parse(Console.ReadLine(), CI);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"VETOR GERADO:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    vetGerado[i] += mat[i, j];
                }
                Console.WriteLine(vetGerado[i].ToString("F1", CI));
            } 
        }
    }
}
