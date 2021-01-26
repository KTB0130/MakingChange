using System;

namespace MakingChange
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string bob = Console.ReadLine();
            int num = Convert.ToInt32(bob);
            num = Quarters(num);
            Console.WriteLine(num);
            num = Dimes(num);
            Console.WriteLine(num);
            num = Nickels(num);
            Console.WriteLine(num);
            Pennies(num);  
        }
        static int Quarters(int x)
        {
            int y = x / 25;
            int z;
            int a;
           if (y >= 1) 
            {
                Console.WriteLine("Quarters = " + y);
                z = y * 25;
                x = x - z;
                a = x;
                return x;
            }
           else 
            {
                Console.WriteLine("Quarters = 0");
                return x;
            }
        }
        static int Dimes(int x)
        {
            int y = x / 10;
            int z;
           if (y >= 1)
            {
                Console.WriteLine("Dimes = " + x / 10);
                z = y * 10;
                x = x - z;
                return x;
            }
           else
            {
                Console.WriteLine("Dimes = 0");
                return x;
            }
        }
        static int Nickels(int x)
        {
            int y = x / 5;
            int z;
            if (x / 5 >= 1)
            {
                Console.WriteLine("Nickels = " + x / 5);
                z = y * 5;
                x = x - z;
                return x;
            }
            else
            {
                Console.WriteLine("Nickels = 0");
                return x;
            }
        }
        static int Pennies(int x)
        {
            int y = x / 1;
            int z;
            if (x / 1 == 0)
            {
                Console.WriteLine("Pennies = 0");
                z = y;
                x = x - z;
                return x;
            }
            else
            {
                Console.WriteLine("Pennies = " + x);
                return x;
            }
        }

    }
}
