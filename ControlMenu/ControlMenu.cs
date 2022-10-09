public class ControlMenu
{
    public static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Wybierz zadanie:");
        Console.WriteLine("1) Zespolona");
        Console.WriteLine("2) Silnia");
        Console.WriteLine("3) Logarytm");
        Console.WriteLine("4) Zakoncz");
    }

    public static bool MainMenu()
    {
        switch (Console.ReadLine())
        {
            case "1":
                LaunchZespolona();
                return true;

            case "2":
                LaunchSilnia();
                return true;

            case "3":
                LaunchLogarytm_e();
                return true;

            case "4":
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
        Console.WriteLine("\nKliknij dowolny przycisk aby powrócić do menu");
    }

    public static void LaunchSilnia()
    {
        Console.WriteLine("Wprowadz stopien silni: ");
        Silnia s1 = new Silnia(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("16b silnia: " + s1.ObliczSilnieShort());
        Console.WriteLine("32b silnia: " + s1.ObliczSilnieInt());
        Console.WriteLine("64b silnia: " + s1.ObliczSilnieLong());
        Console.WriteLine("\nKliknij dowolny przycisk aby powrócić do menu");
    }

    public static void LaunchLogarytm_e()
    {
        Logarytm l1 = new Logarytm();
        Console.WriteLine("Wprowadz do ktorego n ma sie wykonac algorytm: ");
        Console.Write("Logarytm e =" + l1.ObliczLogarytm(Convert.ToInt32(Console.ReadLine())));
        Console.WriteLine("\nKliknij dowolny przycisk aby powrócić do menu");
        Console.ReadLine();
        ControlMenu.DisplayMenu();
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