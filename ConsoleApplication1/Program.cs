using System;

namespace PrimerNumbers
{
    class Program
    {
        void prime_num(long num)
        {
           
            for (int i = 0; i <= num; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= num; j++)
                {
                    if (i != j && i % j == 0 || i == 1)  
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    
                    Console.WriteLine(i);
                }
                isPrime = true;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers between 1 and 1,000:");
            Program p = new Program();
            p.prime_num(1000);
            Console.ReadLine();
        }
    }
}
