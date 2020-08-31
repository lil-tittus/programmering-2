using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ditt användarnamn:");

           
            string userName = Console.ReadLine();

           
            Console.WriteLine("Ditt namn är: " + userName);

            Console.WriteLine("Din ålder:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Din ålder är: " + age);

            Console.WriteLine("Lever du? ja eller nej");

            var svar = Console.ReadLine();

            if (svar == "ja")
            {
                Console.WriteLine("Bra pee pee poo poo");
            }
            else
            {
                Console.WriteLine("stinky pope");
            }
        }
    }
}
