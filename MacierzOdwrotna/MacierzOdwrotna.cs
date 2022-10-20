using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacierzOdwrotna
{
    internal class MacierzOdwrotna
    {
        public static double[,] StworzMacierz(int rows, int cols)
            => new double[rows, cols];

        public void WypiszMacierz(int rows, int cols, int[,] macierz)
        {
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    Console.Write(macierz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void PrzemnozMacierze(int m1Rows, int m1Cols, int m2Cols, int[,] macierz1, int[,] macierz2)
        {
            try
            {
                int[,] macierzWynikowa = new int[m1Rows, m2Cols];
                for (var i = 0; i < m1Rows; i++)
                {
                    for (var j = 0; j < m2Cols; j++)
                    {
                        macierzWynikowa[i, j] = 0;
                        for (var k = 0; k < m1Cols; k++)
                        {
                            macierzWynikowa[i, j] += macierz1[i, k] * macierz2[k, j];
                        }
                    }
                }
                WypiszMacierz(m1Rows, m2Cols, macierzWynikowa);
            }
            catch(Exception ex)
            {
                ex = new InvalidOperationException();
                Console.WriteLine("Mnozenie macierzy jest niemozliwe",ex);
            }
        }

        //public static double[,] OdwrocMacierz(double[,] macierz)
        //{
        //    int n = macierz.Length;
        //    double[,] wynik = StworzMacierz(n, n);
        //    for(var i = 0; i < n; i++)
        //    {
        //        for(var j = 0; j < n; j++)
        //        {
        //            wynik[i, j] = macierz[i, j];
        //        }
        //    }    
        //}
    }
}
