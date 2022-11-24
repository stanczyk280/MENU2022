public static class MacierzWyznaczniki
{
    public static int[,] macierz1 = { { 1, 3, 2 }, { 4, -1, 2 }, { 1, -1, 0 } };
    public static double[,] macierz2 = { { 2, 7, -1, 3, 2 }, { 0, 0, 1, 0, 1 }, { -2, 0, 7, 0, 2 }, { -3, -2, 4, 5, 3 }, { 1, 0, 0, 0, 1 } };

    public static void WypiszMacierz(int rows, int cols, int[,] macierz)
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

    public static void WypiszMacierzDec(int rows, int cols, double[,] macierz)
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

    public static void WyznaczWyznacznikSarrus(int[,] macierz)
    {
        double det = 0;
        for (var i = 0; i < 3; i++)
            det += macierz[0, i] * (macierz[1, (i + 1) % 3] * macierz[2, (i + 2) % 3]
                - macierz[1, (i + 2) % 3] * macierz[2, (i + 1) % 3]);
        Console.WriteLine("Wyznacznik macierzy metoda Sarrusa:\n detSarrus= " + det);
    }

    public static double RozwiniecieLaplace(double[,] macierz)
    {
        int sizeN = macierz.GetLength(0);
        double det = 0;
        double[,] macierzHelper = new double[sizeN - 1, sizeN - 1];

        if (sizeN == 1)
        {
            //Console.WriteLine("Wyznacznik macierzy rozwinieciem Laplace = " + macierz[0, 0]);
            return macierz[0, 0];
        }
        if (sizeN == 2)
        {
            det = macierz[0, 0] * macierz[1, 1] - macierz[1, 0] * macierz[0, 1];
            //Console.WriteLine("Wyznacznik macierzy rozwinieciem Laplace = " + det);
            return det;
        }
        for (var i = 0; i < sizeN; i++)
        {
            for (var j = 1; j < sizeN; j++)
            {
                for (var k = 0; k < i; k++)
                {
                    macierzHelper[j - 1, k] = macierz[j, k];
                }
                for (var k = i + 1; k < sizeN; k++)
                {
                    macierzHelper[j - 1, k - 1] = macierz[j, k];
                }
            }
            //double temp_det = RozwiniecieLaplace(sizeN - 1, macierzHelper);
            double temp_det = RozwiniecieLaplace(macierzHelper);
            det += (Convert.ToBoolean(i & 1) ? -1 : 1) * macierz[0, i] * temp_det;
        }
        return det;
    }
}

internal static class Program
{
    private static void Main(string[] args)
    {
        
    }
}