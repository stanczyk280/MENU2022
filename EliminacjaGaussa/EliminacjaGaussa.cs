using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliminacjaGaussa
{
    internal class EliminacjaGaussa
    {
        public static double[,] StworzMacierz(double[,] macierz)
            => new double[macierz.Length, macierz.Length];
        public static double[,] KopiujMaicerz(double[,] macierz)
        {
            var n = macierz.Length;
            double[,] macierzWynikowa = StworzMacierz(macierz);
            for(var i=0; i<n;i++)
            {
                for(var j=0; j<n; j++)
                {
                    macierzWynikowa[i, j] = macierz[i, j];
                }
            }
            return macierzWynikowa;
        }

        public static double[] KopiujWektor(double[] wektor)
        {
            double[] kopiaWektor = new double[wektor.Length];
            for(int i=0; i<wektor.Length; i++)
            {
                kopiaWektor[i] = wektor[i];
            }
            return kopiaWektor;
        }

        public static void Wyswietl(double[,] macierz)
        {
            var n = macierz.Length;
            for (var i = 0; i < n; i++)
            {
                for (var k = 0; k < n; k++)
                {
                    Console.Write(macierz[i, k] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static double[] Eliminacja(double[,] macierz, double[] wektor)
        {
            var n = macierz.Length;
            double[,] macierzWynikowa = KopiujMaicerz(macierz);
            double[] wektorKopia = KopiujWektor(wektor);

            for(int i=1;i<=n-1;i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    for (int k = i + 1; k <= n; k++)
                    {
                        macierzWynikowa[j,k] = macierz[j,k] - (macierz[i,k] * (macierz[j,i] / macierz[i,i]));
                    }
                    wektorKopia[j] = wektor[j] - (wektor[i] * (macierz[j,i] / macierz[i,i]));
                    for (int ii = 0; ii < macierzWynikowa.Length; ii++)
                    {
                        for (int jj = 0; jj < macierzWynikowa.Length; jj++)
                        {
                            macierz[ii,jj] = macierzWynikowa[ii,jj];
                        }
                        wektor[ii] = wektorKopia[ii];
                    }
                }
            }
            return wektor;
        }
    }
}
