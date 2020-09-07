using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new String[5];

            Console.WriteLine("Type 5 names aqnd yeehaa");

            for (int i = 0; i < name.Length; i++)
            {
                name[i] = Console.ReadLine();
            }
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
            
           
            
            
        }
    }
}
