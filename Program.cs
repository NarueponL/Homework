using System;

namespace HomeWork4_1
{
    class Program
    {
        static void pascalNum(int N)
        {
            for (int i = 0; i <= N; i++) 
            {
                for(int j = 0; j <= N; j++)
                {
                    if (j <= i) //ไม่คิด j ที่มากกว่า i
                    {
                        pascalFomula(i, j);
                    }
                }
                Console.WriteLine();
            }
        }

        static void pascalFomula(int n , int r)
        {
            
            int a = factorial(n)/(factorial(r)*factorial(n-r));

            Console.Write(" {0}",a);
            
        }

        static int factorial(int n)
        {
            int x = 1;
            for(int i=n;i>=1; i--)
            {
                x = x * i;
            }
            return x;
        }

        static void Main(string[] args)
        {
            int Input;
            bool checkInput = false;
            do
            {
                Input = int.Parse(Console.ReadLine());
                if (Input < 0) 
                {
                    Console.WriteLine("Invalid Pascal’s triangle row number.");
                }
                else
                {
                    checkInput = true;
                }
                
            } while (checkInput == false);
            pascalNum(Input);
        }

    }
}
