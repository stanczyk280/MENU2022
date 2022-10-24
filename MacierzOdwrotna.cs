using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MENU
{
    public class MacierzOdwrotna
    {
        public static double[,] StworzMacierz(int rows,int cols)
            => new double[rows,cols];

        public void WypiszMacierzKwadratowa(int[,] macierz)
        {
            var n = macierz.Length;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    Console.Write(macierz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static double[,] StworzMacierzJednostkowa(int n)
        {
            double[,] results = StworzMacierz(n,n);
            for(var i=0;i<n;i++)
            {
                results[i, i] = 1.0;
            }
            return results;
        }

        static double[,] PrzemnozMacierze(double[,] macierzA, double[,] macierzB)
        {
            int aRows = macierzA.GetLength(0);
            int aCols = macierzA.GetLength(1);
            int bRows = macierzB.GetLength(0);
            int bCols = macierzB.GetLength(1);

            try
            {
                double[,] results = StworzMacierz(aRows, bCols);
                for(var i=0; i<aRows;i++)
                {
                    for(var j=0; j<bCols;j++)
                    {
                        for (var k = 0; k < aCols; k++)
                        {
                            results[i, j] += macierzA[i, k] * macierzB[k, j];
                        }
                    }
                }
                return results;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new InvalidDataException();
            }
        }

        static double[,] KopiujMacierz(double[,] macierz)
        {
            double[,] results = StworzMacierz(macierz.GetLength(0), macierz.GetLength(1));
            for(var i=0;i<macierz.Length;i++)
            {
                for(var j=0;j<macierz.Length;j++)
                {
                    results[i, j] = macierz[i, j];
                }
            }
            return results;
        }

        static double[,] RozlozMacierz(double[,] macierz, out int[] perm, out int toggle)
        {
            int rows = macierz.GetLength(0);
            int cols = macierz.GetLength(1);
            
            if(rows!=cols)
            {
                throw new Exception("Nie mozna rozlozyc macierzy nie kwadratowej");
            }

            int n = rows;
            double[,] results = KopiujMacierz(macierz);
            perm = new int[n];
            for(var i=0; i<n;i++)
            {
                perm[i] = i;
            }
            toggle = 1;

            for(var i=0;i<n-1;i++)
            {
                double colMax = Math.Abs(results[i, i]);
                int pRow = i;
                for(var j=i+1;j<n;j++)
                {
                    if (Math.Abs(results[j,i]) > colMax)
                    {
                        colMax = Math.Abs(results[j,i]);
                        pRow = j;
                    }
                }
            }
            throw new NotImplementedException();
        }

        static double[,] OdwrocMacierz(double[,] macierz)
        {
            int n = macierz.Length;
            double[,] results = KopiujMacierz(macierz);
            throw new NotImplementedException();
        }
    }
}
