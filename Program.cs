using System;

namespace Midterm_Exam
{
    class Program
    {
        static double modefLength(out double fLength)
        {            
            bool checkfLength = false;
            do
            {
                fLength = double.Parse(Console.ReadLine());
                if (fLength < 0) 
                {
                    Console.WriteLine("Invalid fLength Please input again");
                }
                else
                {
                    checkfLength = true;                    
                }
            } while (checkfLength == false);
            return fLength;
        }
        static double modeFov(out double fov)
        {            
            bool checkFov = false;
            do
            {
                fov = double.Parse(Console.ReadLine());
                if (fov < 0.1 && fov >6.28)
                {
                    Console.WriteLine("Invalid fLength Please input again");
                }
                else
                {
                    checkFov = true;                    
                }
            } while (checkFov == false);
            return fov;
        }
        static void Main(string[] args)
        {
            bool checkFlimBW = false;
            double FLength, Fov, flimBackWidth;
            string mode = Console.ReadLine();

            do
            {
                flimBackWidth = double.Parse(Console.ReadLine());
                if (flimBackWidth<0)
                {
                    Console.WriteLine("Invalid filmBlackWidth Please input again");
                }
                else
                {
                    checkFlimBW = true;
                }
            } while (checkFlimBW == false);     

            switch (mode)
            {
                case "fLength":
                    FLength = modefLength(out FLength);
                    Fov = 2 * Math.Atan(flimBackWidth/(2*FLength));
                    Console.WriteLine("fLength = " + FLength);
                    Console.WriteLine("fov = " + Fov);
                    break;
                case "fov":
                    Fov = modeFov(out Fov);
                    FLength = flimBackWidth / (2 * Math.Tan(Fov / 2));
                    Console.WriteLine("fLength = " + FLength);
                    Console.WriteLine("fov = " + Fov);
                    break;
            }
            

        }
    }
}
