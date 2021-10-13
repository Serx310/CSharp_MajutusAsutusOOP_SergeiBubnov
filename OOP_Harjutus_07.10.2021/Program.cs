using System;

namespace OOP_Harjutus_07._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotell hotell = new Hotell(10, 5);
            int reserve = hotell.Reserveeri(2);
            Console.WriteLine($"{reserve}");
        }
    }
}
