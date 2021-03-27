using System;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {                     
            Console.Write("Input a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input b : ");
            int b = int.Parse(Console.ReadLine());
            int x = a, y = b;

            while (x != y)
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }                
            }
            Console.WriteLine("X = " + x);            
        }
    }
}
