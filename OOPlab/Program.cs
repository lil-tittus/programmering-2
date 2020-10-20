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
            Console.WriteLine("För att köpa kanelbullar, var god och tryck 2");
            Console.WriteLine("För att köpa katter, var god tryck 5");
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

                    case 5:
                        Console.WriteLine("Du vill köpa en katt; vilken katt?");
                        Console.WriteLine("Tryck 1 om du vill ha en naken katt, tryck 2 om du vill ha en tjock katt.");
                        int fatornaked = Convert.ToInt32(Console.ReadLine());
                        cats c = new cats();
                        switch (fatornaked)
                        {
                            case 1:

                                customer.cart.Add(c._productn);
                                Console.WriteLine("Du har köpt en naken katt grattis");
                                break;

                            case 2:

                                customer.cart.Add(c._productf);
                                Console.WriteLine("Du har köpt en fet katt grattis");
                                break;



                        }

                        break;
                    
                    default:
                        Console.WriteLine("Fel mannen");
                        break;

                }
            }


           



            
          

            

        }
    }
}
