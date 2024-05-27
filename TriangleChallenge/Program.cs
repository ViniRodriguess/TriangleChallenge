using System;

namespace TrianguloMaximo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de linhas do triângulo:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] triangulo = new int[n][];

            for (int i = 0; i < n; i++)
            {
                triangulo[i] = new int[i + 1];

                Console.WriteLine($"Digite os {i + 1} números da linha {i + 1}, separados por vírgula:");
                string linha = Console.ReadLine();
                string[] numeros = linha.Split(',');

                if (numeros.Length != i + 1)
                {
                    Console.WriteLine($"Você deve fornecer exatamente {i + 1} números para a linha {i + 1}.");
                    i--; 
                    continue;
                }

                for (int j = 0; j < i + 1; j++)
                {
                    triangulo[i][j] = Convert.ToInt32(numeros[j]);
                }
            }

            Triangulo tri = new Triangulo();
            int resultado = tri.ResultadoTriangulo(triangulo);

            Console.WriteLine($"O resultado máximo é: {resultado}");

            Console.ReadLine(); 
        }
    }
}
