using System;

namespace OOP_Harjutus_07._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            MajutusAsutus maja = new MajutusAsutus(5.55m, 5);
            Console.WriteLine(maja);
            Console.WriteLine(maja.Reserveeri(2));
            Console.WriteLine(maja);
            Console.WriteLine(maja.Reserveeri(2));
            Console.WriteLine(maja);
        }
    }
}
