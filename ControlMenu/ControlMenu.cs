public static class ControlMenu
{
    public static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Wybierz zadanie:");
        Console.WriteLine("1) Zespolona");
        Console.WriteLine("2) Silnia");
        Console.WriteLine("3) Logarytm");
        Console.WriteLine("4) Mnozenie Macierzy");
        Console.WriteLine("5) Zakoncz");
    }

    public static bool MainMenu()
    {
        switch (Console.ReadLine())
        {
            case "1":
                Console.Clear();
                LaunchZespolona();
                Console.WriteLine("\nKliknij dowolny przycisk aby powrócić do menu");
                Console.ReadLine();
                ControlMenu.DisplayMenu();
                return true;

            case "2":
                Console.Clear();
                LaunchSilnia();
                Console.WriteLine("\nKliknij dowolny przycisk aby powrócić do menu");
                Console.ReadLine();
                ControlMenu.DisplayMenu();
                return true;

            case "3":
                Console.Clear();
                LaunchLogarytm_e();
                Console.WriteLine("\nKliknij dowolny przycisk aby powrócić do menu");
                Console.ReadLine();
                ControlMenu.DisplayMenu();
                return true;

            case "4":
                Console.Clear();
                LaunchMacierzMnozenie();
                Console.WriteLine("\nKliknij dowolny przycisk aby powrócić do menu");
                Console.ReadLine();
                ControlMenu.DisplayMenu();
                return true;

            case "5":
                Console.WriteLine("exiting...");
                return false;

            default:
                return true;
        }
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