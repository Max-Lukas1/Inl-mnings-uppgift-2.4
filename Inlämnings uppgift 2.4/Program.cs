using System;
namespace inlämningsuppgift_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur hög är din lön användare1?");
            string använder1=Console.ReadLine();
            int använders1 = int.Parse(använder1);
            Console.WriteLine("Hur hög är din lön användare 2?");
            string använder2 = Console.ReadLine();
            int använders2 = int.Parse(använder2);

            Console.WriteLine("Hur hög är din lön användare 3?");
            string använder3 = Console.ReadLine();
            int använders3 = int.Parse(använder3);
            int summan = (använders1 + använders2 + använders3) / 3;
            Console.WriteLine("medellönen är "+summan+ "kr");
        }
    }
}

