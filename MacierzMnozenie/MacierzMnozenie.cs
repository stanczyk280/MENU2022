public class Macierz
{
    public int mARows = 3;
    public int mACols = 4;
    public int mBRows = 4;
    public int mBCols = 2;
    public int[,] macierzA = { { -1, 4, 2, -2 }, { 1, 2, -3, 0 }, { -1, 0, 0, 5 } };
    public int[,] macierzB = { { 2, -1 }, { 1, 3 }, { -2, 0 }, { 0, -4 } };

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
        catch
        {
            Console.WriteLine("Mnozenie macierzy jest niemozliwe");
            throw new InvalidOperationException();
        }
    }
}

internal static class Program
{
    private static void Main(string[] args)
    {
        Macierz macierz = new Macierz();
        Console.WriteLine("Macierz a:");
        macierz.WypiszMacierz(macierz.mARows, macierz.mACols, macierz.macierzA);
        Console.WriteLine("Macierz b:");
        macierz.WypiszMacierz(macierz.mBRows, macierz.mBCols, macierz.macierzB);
        Console.WriteLine("Wynik mnozenia macierzy: ");
        macierz.PrzemnozMacierze(macierz.mARows, macierz.mACols, macierz.mBCols, macierz.macierzA, macierz.macierzB);
    }
}