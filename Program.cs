using System;

namespace Midterm_Exam_4
{
    class Program
    {
        
        static void Main(string[] args)
        {

            char write = char.Parse(Console.ReadLine());
            int widh = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            for (int i = 1; i <= step; i++)
            {
               
                for (int j = 1; j <= widh*i; j++)
                {
                    for(int k = 1; k <= height; k++)
                    {
                        Console.Write(write);
                        if (k == widh)
                        {
                            Console.WriteLine();
                        }
                    }
                }
                Console.WriteLine();
            }

/*
            */










        }
    }
}
