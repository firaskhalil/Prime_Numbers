using System;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ch = true;
            int co = 0;

            for (int i = 2; i < 10000; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        ch = false;
                        break;
                    }
                }
                if (ch)
                {
                    Console.WriteLine(i);
                    co++;
                }
                ch = true;
            }
            Console.WriteLine("Count of Prime Numbers is " + co);

            //--------------------------------------

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Enter Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
             ch = true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    ch = false;
                    break;
                }
            }

            if (ch)
            {
                Console.WriteLine(n + ": is a prime number ");
            }
            else
            {
                Console.WriteLine(n + ": is not a prime number ");
            }
        }
    }
}
