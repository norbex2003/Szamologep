using System;

namespace Szamologep
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("2.0 verzió esetében angol nyelv eltávolításra került! Később másik app lesz az angol nyelv");
            Console.WriteLine("Írj be egy számot!");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Írj be még egy számot!");
            double b = Convert.ToInt32(Console.ReadLine());
            double osszeadas = Math.Round(a + b, 4);
            double kivonas = Math.Round(a - b, 4);
            double szorzas = Math.Round(a * b, 4);
            double osztas = Math.Round(a / b, 4);

            //Változókkal való müveletek eredményének a kiiratása!
            Console.WriteLine($"Ez az A és B változó összeadásának eredménye: {osszeadas}");
            Console.WriteLine($"Ez az A és B változó kivonásának eredménye: {kivonas}");
            Console.WriteLine($"Ez az A és B változó szorzásának eredménye: {szorzas}");
            Console.WriteLine($"Ez az A és B változó osztásának eredménye: {osztas}");
            Console.ReadKey();
        }
    }
}
