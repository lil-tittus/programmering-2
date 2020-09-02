using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
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
                Console.WriteLine("Du lever men inte länge till haha. Nu dör du");
                for (int i = 5; i > -1; i--)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Nu kan du välja om du kom till himlen eller helvetet. Skriv Nirvana om du vill träffa gud, Inferno om du vill träffa Djävulen.");

                string god = Console.ReadLine();
                
                switch (god)
                {
                    case "Nirvana":
                        Console.WriteLine("Hallå det är Gud");
                        break;
                    case "Inferno":
                        Console.WriteLine("Hallå det är Djävulen");

                        break;
                    default:
                        Console.WriteLine("Skit i det då!");
                        break;
                }



                break;
            }
        }
    }
}
