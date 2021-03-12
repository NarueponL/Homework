using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            double t, p, t1, t2;
            string inputmode = Console.ReadLine();
            double mousepositionX = double.Parse(Console.ReadLine());
            double mousepositionY = double.Parse(Console.ReadLine());
            if (mousepositionX >= 0)
            {
                switch (inputmode)
                {
                    case "time":
                        t = mousepositionX;
                        p = Math.Pow((t - 1), 2);
                        Console.WriteLine("{0} , {1}", t, p);
                        break;
                    case "price":
                        p = mousepositionY;
                        if (mousepositionY <= 1)
                        {
                            t1 = 1 - Math.Sqrt(p);
                            t2 = 1 + Math.Sqrt(p);
                            if (Math.Abs(mousepositionX - t1) < Math.Abs(mousepositionX - t2))
                            {
                                Console.WriteLine("{0} , {1}", t1, p);
                            }
                            else if (Math.Abs(mousepositionX - t1) >= Math.Abs(mousepositionX - t2))
                            {
                                Console.WriteLine("{0} , {1}", t2, p);
                            }
                        }
                        else if (mousepositionY > 1)
                        {
                            t = 1 + Math.Sqrt(p);
                            Console.WriteLine("{0} , {1}", t, p);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid mode");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Mouse Position");
            }
        }
    }
}
