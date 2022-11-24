using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozkladLU
{
    internal class LU
    {
        public double[,] MacierzJednostkowa(double[,] macierz)
        {
            int n = macierz.GetLength(0);
            double[,] result = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                result[i, i] = 1;
            }

            return result;
        }

        public void LUDec(double[,] macierz, double[,] macierzL, double[,] macierzU, int n)
        {
            //for (int i = 0; i < macierzL.GetLength(0); i++)
            //{
            //    macierzL[i, i] = 1;
            //}
            macierzL = MacierzJednostkowa(macierzL);

            double tmp;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    tmp = 0;
                    for (int k = 0; k < i; k++)
                    {
                        tmp += macierzL[i, k] * macierzU[k, j];
                    }
                    macierzU[i, j] = macierz[i, j] - tmp;
                }

                for (int j = i + 1; j < n; j++)
                {
                    tmp = 0;
                    for (int k = 0; k < i; k++)
                    {
                        tmp += macierzL[j, k] * macierzU[k, i];
                    }
                    macierzL[j, i] = (macierz[j, i] - tmp) / macierzU[i, i];
                }
            }
        }

        public double[] RozwiazDolnaMacierz(double[,] macierzL, double[] wektor, int n)
        {
            double[] x = new double[n];

            x[0] = wektor[0] / macierzL[0, 0];
            double tmp;
            for (int i = 1; i < n; i++)
            {
                tmp = 0;
                for (int j = 0; j < i; j++)
                {
                    tmp += macierzL[i, j] * x[j];
                }
                x[i] = wektor[i] - tmp;
            }

            return x;
        }

        public double[] RozwiazGornaMacierz(double[,] macierzU, double[] wektor, int n)
        {
            double[] x = new double[n];
            double tmp;

            for (int k = n - 1; k >= 0; k--)
            {
                tmp = 0;
                for (int j = k + 1; j < n; j++)
                {
                    tmp += macierzU[k, j] * x[j];
                }
                x[k] = (wektor[k] - tmp) / macierzU[k, k];
            }

            return x;
        }

        public double[] RozwiazLU(double[,] macierzL, double[,] macierzU, double[] wektor, int n)
        {
            double[] z = new double[n];
            double[] x = new double[n];

            z = RozwiazDolnaMacierz(macierzL, wektor, n);
            x = RozwiazGornaMacierz(macierzU, z, n);

            return x;
        }
    }
}
