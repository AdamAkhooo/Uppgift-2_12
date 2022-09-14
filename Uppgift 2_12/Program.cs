using System;
namespace Uppgift_2_12
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur länge ska du hyra bilen?");
            string bilentext = Console.ReadLine();
            int dagar = int.Parse(bilentext);
            Console.WriteLine("Hur många kilometer ska du köra?");
            string kör = Console.ReadLine();
            int kilometer = int.Parse(kör);
            int kostnad = 300 + 500 * (dagar - 1) + kilometer;
            int summa = kilometer + kostnad;
            int produkt = kilometer + kostnad;
            Console.WriteLine("summan av talen är " + summa + " kr ");
            Console.WriteLine("Produkten av talen är " + produkt);
        }
    }
}
