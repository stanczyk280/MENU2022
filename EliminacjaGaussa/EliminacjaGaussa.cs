using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliminacjaGaussa
{
    public class EliminacjaGaussa
    {
        public double[] GaussElimination(double[,] macierz, double[] wektor, int n)
        {
            double[] results = new double[n];

            double[,] tmpA = new double[n, n + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tmpA[i, j] = macierz[i, j];
                }
                tmpA[i, n] = wektor[i];
            }

            double tmp = 0;

            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    tmp = tmpA[i, k] / tmpA[k, k];
                    for (int j = k; j < n + 1; j++)
                    {
                        tmpA[i, j] -= tmp * tmpA[k, j];
                    }
                }
            }

            for (int k = n - 1; k >= 0; k--)
            {
                tmp = 0;
                for (int j = k + 1; j < n; j++)
                {
                    tmp += tmpA[k, j] * results[j];
                }
                results[k] = (tmpA[k, n] - tmp) / tmpA[k, k];
            }

            return results;
        }
    }

    public static class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}