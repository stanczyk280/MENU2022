public static class ControlMenu
{
    public static void DisplayMenu()
    {
        Console.WriteLine("Wybierz zadanie:");
        Console.WriteLine("1) Zespolona");
        Console.WriteLine("2) Silnia");
        Console.WriteLine("3) Logarytm");
        Console.WriteLine("4) Mnozenie Macierzy");
        Console.WriteLine("5) Wyznaczniki Macierzy");
        Console.WriteLine("6) Zakoncz");
    }

    public static bool MainMenu()
    {
        switch (Console.ReadLine())
        {
            case "1":
                Console.Clear();
                LaunchZespolona();
                ReturnToMenu();
                return true;

            case "2":
                Console.Clear();
                LaunchSilnia();
                ReturnToMenu();
                return true;

            case "3":
                Console.Clear();
                LaunchLogarytm_e();
                ReturnToMenu();
                return true;

            case "4":
                Console.Clear();
                LaunchMacierzMnozenie();
                ReturnToMenu();
                return true;

            case "5":
                Console.Clear();
                LaunchMacierzWyznacznik();
                ReturnToMenu();
                return true;

            case "6":
                Console.WriteLine("exiting...");
                return false;

            default:
                return true;
        }
    }

    public static void ReturnToMenu()
    {
        Console.WriteLine("\nKliknij dowolny przycisk aby powrócić do menu");
        Console.ReadLine();
        Console.Clear();
        ControlMenu.DisplayMenu();
    }

    public static void LaunchZespolona()
    {
        Zespolona z1 = new Zespolona(1.23456789123456789, 4 / 3);
        Zespolona z2 = new Zespolona(1, 2);
        Zespolona wynik = new Zespolona();

        wynik = z1 + z2;
        wynik.Wypisz();
        wynik = z1 * z2;
        wynik.Wypisz();
    }

    public static void LaunchSilnia()
    {
        Console.WriteLine("Wprowadz stopien silni: ");
        Silnia s1 = new Silnia(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("16b silnia: " + s1.ObliczSilnieShort());
        Console.WriteLine("32b silnia: " + s1.ObliczSilnieInt());
        Console.WriteLine("64b silnia: " + s1.ObliczSilnieLong());
    }

    public static void LaunchLogarytm_e()
    {
        Logarytm l1 = new Logarytm();
        Console.WriteLine("Wprowadz do ktorego n ma sie wykonac algorytm: ");
        Console.Write("Logarytm e =" + l1.ObliczLogarytm(Convert.ToInt32(Console.ReadLine())));
    }

    public static void LaunchMacierzMnozenie()
    {
        Macierz macierz = new Macierz();
        Console.WriteLine("Macierz a:");
        macierz.WypiszMacierz(macierz.mARows, macierz.mACols, macierz.macierzA);
        Console.WriteLine("Macierz b:");
        macierz.WypiszMacierz(macierz.mBRows, macierz.mBCols, macierz.macierzB);
        Console.WriteLine("Wynik mnozenia macierzy: ");
        macierz.PrzemnozMacierze(macierz.mARows, macierz.mACols, macierz.mBCols, macierz.macierzA, macierz.macierzB);
    }

    public static void LaunchMacierzWyznacznik()
    {
        MacierzWyznaczniki m = new MacierzWyznaczniki();
        Console.WriteLine("Macierz numer 1: ");
        m.WypiszMacierz(3, 3, m.macierz1);
        m.WyznaczWyznacznikSarrus(m.macierz1);
        Console.WriteLine("");
        Console.WriteLine("Macierz numer 2: ");
        m.WypiszMacierzDec(5, 5, m.macierz2);
        Console.WriteLine("Rozwiniecie Laplace= " + m.RozwiniecieLaplace(5, m.macierz2));
    }
}

internal static class Program
{
    private static void Main(string[] args)
    {
        ControlMenu.DisplayMenu();
        bool showMenu = true;
        while (showMenu)
        {
            showMenu = ControlMenu.MainMenu();
        }
    }
}