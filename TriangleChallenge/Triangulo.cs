using System;

namespace TrianguloMaximo
{
    public class Triangulo
    {
        public int ResultadoTriangulo(int[][] dadosTriangulo)
        {
            if (dadosTriangulo == null || dadosTriangulo.Length == 0)
                return 0;

            int n = dadosTriangulo.Length;

            int[][] dp = new int[n][];
            for (int i = 0; i < n; i++)
            {
                dp[i] = new int[dadosTriangulo[i].Length];
            }

            for (int i = 0; i < dadosTriangulo[n - 1].Length; i++)
            {
                dp[n - 1][i] = dadosTriangulo[n - 1][i];
            }

            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = 0; j < dadosTriangulo[i].Length; j++)
                {
                    dp[i][j] = dadosTriangulo[i][j] + Math.Max(dp[i + 1][j], dp[i + 1][j + 1]);
                }
            }

            return dp[0][0];
        }
    }
}
