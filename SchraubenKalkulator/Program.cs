using System;

namespace SchraubenKalkulator
{
    class Program
    {

        static void Main(string[] args)
        {
            Schrauben.calculateOrderTtl(schraubenAnzahl, mutterAnzahl, unterlegscheibeAnzahl);
        }

    class Schrauben
    {
            public int schraubenAnzahl = 0;
            public int mutterAnzahl;
            public int unterlegscheibeAnzahl;

            public static int schraubenPreis = 5;
        public static int mutterPreis = 3;
        public static int unterlegscheibePreis = 1;

        public static void getOrderAmounts(int a, int b, int c)
        {
            string amount;
            Console.WriteLine("Bitte geben Sie die Anzahl von Schrauben ein");
            amount = Console.ReadLine();
            a = Int32.Parse(amount);

            Console.WriteLine("Bitte geben Sie die Anzahl von Muttern ein");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie die Anzahl von Unterlegscheiben ein");
            c = Convert.ToInt32(Console.ReadLine());
        }

        public static void checkOrderAmount(int a, int b, int c)
        {
            Console.WriteLine($"Anzahl der Schrauben: {a}");
            Console.WriteLine($"Anzahl der Muttern: {b}");
            Console.WriteLine($"Anzahl der Unterlegscheiben: {c}");

            if (a > b)
            {
                Console.WriteLine("Kontrollieren Sie Ihre Bestellung");
            }
            else Console.WriteLine("Die Bestellung ist Okay");
        }

        public static void calculateOrderTtl(int a, int b, int c)
        {
            getOrderAmounts(a, b, c);
            checkOrderAmount(a, b, c);
            int totalPreis = a * schraubenPreis + b * mutterPreis + c * unterlegscheibePreis;
            Console.WriteLine($"Gesamtbetrag: {totalPreis} Cent");
            Console.ReadKey();
        }
    }
}
