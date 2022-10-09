using System;

namespace MENU2022
{
    public class Zespolona
    {
        public double re { get; set; } = 0;

        //public float re { get; set; } = 0;
        public double im { get; set; } = 0;

        //public float re { get; set; } = 0;

        public Zespolona(double Re, double Im)
        {
            re = Re;
            im = Im;
        }

        public static Zespolona operator +(Zespolona z)
            => z;

        public static Zespolona operator -(Zespolona z)
            => new Zespolona(-z.re, -z.im);

        public static Zespolona operator +(Zespolona z1, Zespolona z2)
            => new Zespolona(z1.re + z2.re, z1.im + z2.im);

        public static Zespolona operator +(Zespolona z, int c)
            => new Zespolona(z.re + c, z.im);

        public static Zespolona operator *(Zespolona z1, Zespolona z2)
            => new Zespolona(z1.re * z2.re - z1.im * z2.im, z1.re * z2.im + z1.im * z2.re);

        public void Wypisz()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
             => $"{re} + {im}i";
    }

    internal class Silnia
    {
        public int Stopien { get; set; }

        public Silnia(int stopien)
        {
            Stopien = stopien;
        }

        public short ObliczSilnieShort()
        {
            short wynik = 1;
            if (Stopien != 0)
            {
                for (short i = Convert.ToInt16(Stopien); i > 1; i--)
                {
                    wynik *= i;
                }
            }
            if (Stopien < 0)
            {
                throw new ArgumentException();
            }
            return wynik;
        }

        public int ObliczSilnieInt()
        {
            int wynik = 1;
            if (Stopien != 0)
            {
                for (int i = Stopien; i > 1; i--)
                {
                    wynik *= i;
                }
            }
            if (Stopien < 0)
            {
                throw new ArgumentException();
            }
            return wynik;
        }

        public long ObliczSilnieLong()
        {
            long wynik = 1;
            if (Stopien != 0)
            {
                for (long i = Convert.ToInt64(Stopien); i > 1; i--)
                {
                    wynik *= i;
                }
            }
            if (Stopien < 0)
            {
                throw new ArgumentException();
            }
            return wynik;
        }
    }

    internal class Logarytm
    {
        public decimal ObliczSilnie(decimal stopien)
        {
            decimal wynik = 1;
            if (stopien != 0)
            {
                for (var i = stopien; i > 1; i--)
                {
                    wynik *= i;
                }
            }
            if (stopien < 0)
            {
                throw new ArgumentException();
            }
            return wynik;
        }

        public decimal ObliczLogarytm(decimal n)
        {
            decimal e = 1;
            if (n != 0)
            {
                while (n > 0)
                {
                    e += 1 / ObliczSilnie(n);
                    n--;
                }
            }
            return e;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Zespolona z1 = new Zespolona(1.23456789123456789, 4 / 3);
            Zespolona z2 = new Zespolona(1, 2);
            Silnia s1 = new Silnia(20);
            Logarytm l1 = new Logarytm();

            Console.WriteLine(z1 + z2);
            Console.WriteLine(z1 * z2);
            Console.WriteLine(s1.ObliczSilnieShort());
            Console.WriteLine(s1.ObliczSilnieInt());
            Console.WriteLine(s1.ObliczSilnieLong());

            Console.Write(l1.ObliczLogarytm(5));
        }
    }
}