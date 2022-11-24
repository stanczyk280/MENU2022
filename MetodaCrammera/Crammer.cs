namespace MetodaCrammera
{
    public class Crammer
    {
        public static void RozwiazCrammer(double[,] wspl)
        {
            //deklaruje w ten sposób dla wygody i przejrzystości 
        double[,] d = {
        { wspl[0,0], wspl[0,1], wspl[0,2] },
        { wspl[1,0], wspl[1,1], wspl[1,2] },
        { wspl[2,0], wspl[2,1], wspl[2,2] },
    };

        double[,] d1 = {
        { wspl[0,3], wspl[0,1], wspl[0,2] },
        { wspl[1,3], wspl[1,1], wspl[1,2] },
        { wspl[2,3], wspl[2,1], wspl[2,2] },
    };
        double[,] d2 = {
        { wspl[0,0], wspl[0,3], wspl[0,2] },
        { wspl[1,0], wspl[1,3], wspl[1,2] },
        { wspl[2,0], wspl[2,3], wspl[2,2] },
    };

            double[,] d3 = {
        { wspl[0,0], wspl[0,1], wspl[0,3] },
        { wspl[1,0], wspl[1,1], wspl[1,3] },
        { wspl[2,0], wspl[2,1], wspl[2,3] },
    };
            int n = d.Length;
            double D = MacierzWyznaczniki.RozwiniecieLaplace(d);
            int n1 = d1.Length;
            double D1 = MacierzWyznaczniki.RozwiniecieLaplace(d1);
            int n2 = d2.Length;
            double D2 = MacierzWyznaczniki.RozwiniecieLaplace(d2);
            int n3 = d3.Length;
            double D3 = MacierzWyznaczniki.RozwiniecieLaplace(d3);
            Console.Write("D = {0:F6} \n", D);
            Console.Write("D1 = {0:F6} \n", D1);
            Console.Write("D2 = {0:F6} \n", D2);
            Console.Write("D3 = {0:F6} \n", D3);

            if (D != 0)
            {
                double x = D1 / D;
                double y = D2 / D;
                double z = D3 / D;
                Console.Write("x = {0:F6}\n", x);
                Console.Write("y = {0:F6}\n", y);
                Console.Write("z = {0:F6}\n", z);
            }

            // Case 2
            else
            {
                if (D1 == 0 && D2 == 0 && D3 == 0)
                    Console.Write("Nieskonczona ilosc rozwiazan\n");
                else if (D1 != 0 || D2 != 0 || D3 != 0)
                    Console.Write("Brak rozwiazan\n");
            }
        }
    }

    internal static class Program
    {
        private static void Main(string[] args)
        {
            double[,] wspl = {
                { 5, -2, 3, 21 },
                { -2, 3, 1, -4 },
                { -1, 2, 3, 5 }};
            Crammer.RozwiazCrammer(wspl);
        }
    }
}


