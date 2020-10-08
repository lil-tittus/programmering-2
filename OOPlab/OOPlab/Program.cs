using System;
using System.Dynamic;
using System.Reflection.Metadata;

namespace OOPlab
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Product product = new Product();

            Console.WriteLine("Hallo min kära kund. Här är menyn för dagens handel: glizzy, kanelbullar");
            Console.WriteLine("För att köpa glizzy, var god och tryck 1");
            Console.WriteLine("För att kpa kanelbullar, var god och tryck 2");
            Console.WriteLine("För att kolla på vagnen, var god och tryck 3");
            Console.WriteLine("För att lämna, var god och tryck 4");

           

            Boolean f = true;
            while (f)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Glizzy");
                        customer.cart.Add(product._product1);
                        break;

                    case 2:
                        Console.WriteLine("kanelbullar");
                        customer.cart.Add(product._product2);
                        break;

                    case 3:
                        Console.WriteLine("Du har handlat:");
                       
                        string items = "";
                        foreach(var order in customer.cart)
                        {
                            items += order + " , ";
                        }
                        Console.WriteLine(items);
                        break;

                    case 4:
                        Console.WriteLine("Tack för att du handlat min broder.");
                        f = false;
                        break;
                    
                    default:
                        Console.WriteLine("Fel mannen");
                        break;

                }
            }


           



            
          

            

        }
    }
}
