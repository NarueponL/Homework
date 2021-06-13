using System;

namespace Final_4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Input1: ");
            int numCity = int.Parse(Console.ReadLine()); //กรอกจำนวนเมืองทั้งหมด
            string[] cityID = new string[numCity];
            int[] nearbyCityID = new int[numCity];
            int[] covid19Level = new int[numCity];


            for (int i = 0; i < numCity; i++) //กรอกชื่อเมือง
            {
                Console.Write("Input2: ");
                cityID[i] = Console.ReadLine();
                Console.Write("Input3: ");
                int numNearbyCity = int.Parse(Console.ReadLine()); //กรอกจำนวนเมืองที่อยู่ติดกัน
                
                for (int j = 0; j < numNearbyCity; j++) //กรอกเลขเมืองที่อยู่ติดกัน
                {
                    int addNearbyID;
                    bool checkNearbyCityID = false;
                    do //เช็คกรอกผิด
                    {
                        Console.Write("Input4: ");
                        addNearbyID = int.Parse(Console.ReadLine()); 
                        
                            if (addNearbyID > numCity || addNearbyID == i)
                            {
                                Console.WriteLine("Invalid ID");

                            }
                            else
                            {
                                checkNearbyCityID = true;
                            }
                        
                            
                        
                    } while (checkNearbyCityID == false);
                    Console.WriteLine("+");
                    nearbyCityID[i] = addNearbyID;
                }
            }
            for (int i = 0; i < numCity; i++)
            {
                covid19Level[i] = 0;
            }
            bool checkEnd = false;
            do
            {
                for (int i = 0; i < numCity; i++)
                {
                    Console.WriteLine("{0} {1} {2}", i, cityID[i], covid19Level[0]);
                }
                string situation = Console.ReadLine();
                switch (situation)
                {
                    case "Outbreak":

                        break;
                    case "Vaccinate":

                        break;
                    case "Lockdown":

                        break;
                    case "Exit":
                        checkEnd = true;
                        break;
                }

            } while (checkEnd==false);


            
        }
    }
}

