using System;

namespace Midterm_Exam_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int breakfast = 5,weekend = 2,coffee=3;
            int day = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            bool checkOrder = false;
            do
            {                
                Console.WriteLine("breakfast = {0}, weekend = {1}, coffee = {2}",breakfast,weekend,coffee);
                string foodOrder = Console.ReadLine();
                switch (foodOrder)
                {
                    case "Breakfast Set":
                        //เช็คเวลา
                        if (time > 11)
                        {
                            Console.WriteLine("Sorry your order is not available");
                            break;
                        }
                        //เช็คจน.
                        if (breakfast > 0)
                        {
                            breakfast--;
                        }
                        else
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        
                        break;

                    case "Weekend Set":
                        //เช็ควัน
                        if (day < 6) 
                        {
                            Console.WriteLine("Sorry your order is not available");
                            break;
                        }
                        //เช็คจน.
                        if (weekend > 0)
                        {
                            weekend--;
                        }
                        else
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        break;

                    case "Coffee":
                        //เช็คจน.
                        if (coffee > 0)
                        {
                            coffee--;
                        }
                        else
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        break;

                    case "End":
                        checkOrder = true;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid menu");
                        break;                    
                }
                //เช็คอาหารทั้งหมด
                int checkFood = breakfast + weekend + coffee;
                if (checkFood == 0)
                {
                    checkOrder = true;
                }
            } while (checkOrder == false); 
        }
    }
}
