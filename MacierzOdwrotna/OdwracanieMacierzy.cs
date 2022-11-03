using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacierzOdwrotna
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OdwracanieMacierzy oM = new OdwracanieMacierzy();
            double[][] m = new double[][] { new double[] { 1, 3, 2 }, new double[] { 4, -1, -2 }, new double[] { 1, -1, 0 } };
            double[][] inv = oM.OdwrocMacierz(m);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(Math.Round(inv[i][j], 1).ToString().PadLeft(5, ' ') + "");
                Console.WriteLine();
            }
        }
    }

    public class OdwracanieMacierzy
    {
        public double[][] StworzMacierz(int rows, int cols)
        {
            double[][] result = new double[rows][];
            for (int i = 0; i < rows; ++i)
                result[i] = new double[cols];
            return result;
        }

        public double[][] MacierzJednostkowa(int n)
        {
            double[][] result = StworzMacierz(n, n);
            for (int i = 0; i < n; ++i)
                result[i][i] = 1.0;

            return result;
        }

        public double[][] MnozenieMacierzy(double[][] matrixA, double[][] matrixB)
        {
            int aRows = matrixA.Length; int aCols = matrixA[0].Length;
            int bRows = matrixB.Length; int bCols = matrixB[0].Length;
            if (aCols != bRows)
                throw new Exception("Nie mozna przeprowadzic mnozenia");

            double[][] result = StworzMacierz(aRows, bCols);

            for (int i = 0; i < aRows; ++i)
                for (int j = 0; j < bCols; ++j)
                    for (int k = 0; k < aCols; ++k)
                        result[i][j] += matrixA[i][k] * matrixB[k][j];

            return result;
        }

        public double[][] OdwrocMacierz(double[][] matrix)
        {
            int n = matrix.Length;
            double[][] result = SkopiujMacierz(matrix);

            int[] perm;
            int toggle;
            double[][] lum = RozlozMacierz(matrix, out perm,
              out toggle);
            if (lum == null)
                throw new Exception("Nie mozna odwrocic macierzy");

            double[] b = new double[n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == perm[j])
                        b[j] = 1.0;
                    else
                        b[j] = 0.0;
                }

                double[] x = Helper(lum, b);

                for (int j = 0; j < n; ++j)
                    result[j][i] = x[j];
            }
            return result;
        }

        public double[][] SkopiujMacierz(double[][] matrix)
        {
            double[][] result = StworzMacierz(matrix.Length, matrix[0].Length);
            for (int i = 0; i < matrix.Length; ++i)
                for (int j = 0; j < matrix[i].Length; ++j)
                    result[i][j] = matrix[i][j];
            return result;
        }

        public double[] Helper(double[][] luMacierz, double[] b)
        {
            int n = luMacierz.Length;
            double[] x = new double[n];
            b.CopyTo(x, 0);

            for (int i = 1; i < n; ++i)
            {
                double sum = x[i];
                for (int j = 0; j < i; ++j)
                    sum -= luMacierz[i][j] * x[j];
                x[i] = sum;
            }

            x[n - 1] /= luMacierz[n - 1][n - 1];
            for (int i = n - 2; i >= 0; --i)
            {
                double sum = x[i];
                for (int j = i + 1; j < n; ++j)
                    sum -= luMacierz[i][j] * x[j];
                x[i] = sum / luMacierz[i][i];
            }

            return x;
        }

        public double[][] RozlozMacierz(double[][] matrix, out int[] perm, out int toggle)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length; // assume square
            if (rows != cols)
                throw new Exception("Nie mozna rozlozyc macierzy nie kwadratowej");

            int n = rows;

            double[][] result = SkopiujMacierz(matrix);

            perm = new int[n];
            for (int i = 0; i < n; ++i) { perm[i] = i; }

            toggle = 1;

            for (int j = 0; j < n - 1; ++j)
            {
                double colMax = Math.Abs(result[j][j]);
                int pRow = j;

                for (int i = j + 1; i < n; ++i)
                {
                    if (Math.Abs(result[i][j]) > colMax)
                    {
                        colMax = Math.Abs(result[i][j]);
                        pRow = i;
                    }
                }

                if (pRow != j)
                {
                    double[] rowPtr = result[pRow];
                    result[pRow] = result[j];
                    result[j] = rowPtr;

                    int tmp = perm[pRow];
                    perm[pRow] = perm[j];
                    perm[j] = tmp;

                    toggle = -toggle;
                }

                if (result[j][j] == 0.0)
                {
                    int goodRow = -1;
                    for (int row = j + 1; row < n; ++row)
                    {
                        if (result[row][j] != 0.0)
                            goodRow = row;
                    }

                    double[] rowPtr = result[goodRow];
                    result[goodRow] = result[j];
                    result[j] = rowPtr;

                    int tmp = perm[goodRow];
                    perm[goodRow] = perm[j];
                    perm[j] = tmp;

                    toggle = -toggle;
                }

                for (int i = j + 1; i < n; ++i)
                {
                    result[i][j] /= result[j][j];
                    for (int k = j + 1; k < n; ++k)
                    {
                        result[i][k] -= result[i][j] * result[j][k];
                    }
                }
            }

            return result;
        }
    }
}