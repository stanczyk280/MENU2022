public class MacierzWyznaczniki
{
    public int rows = 3;
    public int cols = 3;
    public int[,] macierz1 = { { 1, 3, 2 }, { 4, -1, 2 }, { 1, -1, 0 } };

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

    public void WyznaczWyznacznikSarrus(int[,] macierz)
    {
        double det = 0;
        for (var i = 0; i < 3; i++)
            det += macierz[0, i] * (macierz[1, (i + 1) % 3] * macierz[2, (i + 2) % 3]
                - macierz[1, (i + 2) % 3] * macierz[2, (i + 1) % 3]);
        Console.WriteLine("Wyznacznik macierzy metoda Sarrusa:\n detSarrus= " + det);
    }
}

internal static class Program
{
    private static void Main(string[] args)
    {
        MacierzWyznaczniki m = new MacierzWyznaczniki();
        Console.WriteLine("Macierz: ");
        m.WypiszMacierz(m.rows, m.cols, m.macierz1);
        m.WyznaczWyznacznikSarrus(m.macierz1);
    }
}