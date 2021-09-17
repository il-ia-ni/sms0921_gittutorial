using System;

namespace SchraubenKalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string amount;
            Console.WriteLine("Bitte geben Sie die Anzahl von Schrauben ein");
            amount = Console.ReadLine();
            Schrauben.schraubenAnzahl = Int32.Parse(amount);

            Console.WriteLine("Bitte geben Sie die Anzahl von Muttern ein");
            Schrauben.mutterAnzahl = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie die Anzahl von Unterlegscheiben ein");
            Schrauben.unterlegscheibeAnzahl = Convert.ToInt32(Console.ReadLine());


            Schrauben.calculateOrderTtl();
        }
    }

    class Schrauben
    {
        public static int schraubenPreis = 5;
        public static int mutterPreis = 3;
        public static int unterlegscheibePreis = 1;

        public static int schraubenAnzahl;
        public static int mutterAnzahl;
        public static int unterlegscheibeAnzahl;

        public static void calculateOrderTtl()
        {
            checkOrderAmount(schraubenAnzahl, mutterAnzahl, unterlegscheibeAnzahl);

            int totalPreis = schraubenAnzahl * schraubenPreis + mutterAnzahl * mutterPreis + unterlegscheibeAnzahl * unterlegscheibePreis;
            Console.WriteLine($"Gesamtbetrag: {totalPreis} Cent");
            Console.ReadKey();
        }

        //public void getOrderAmounts(int a, int b, int c)
        //{
            
        //}

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
    }
}
