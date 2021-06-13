using System;

namespace Final_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] number = new int[3,3];
            int addNumber;
            //input
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    number[i, j] = int.Parse(Console.ReadLine());
                    
                }
            }
            //output
            addNumber = int.Parse(Console.ReadLine());
            bool end = false;
            foreach(int num in number)
            {                
                if (addNumber == num)
                {
                    Console.WriteLine("The number is available");
                    end = true;
                    break;
                }
                
            }
            if(end == false)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (number[i, j] != 0)
                        {
                            Console.Write(number[i, j]);
                        }
                        else if (number[i, j] == 0)
                        {
                            Console.Write(addNumber);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
        
        
    }
}
