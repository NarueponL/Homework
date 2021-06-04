using System;

namespace HomeWork6_2
{
    class Program
    {
        struct Namefood
        {
            public string Name;
            public Namefood(string foodName)
            {
                Name = foodName;
            }
        }
        static void Main(string[] args)
        {
            Namefood[] product = new Namefood[5] ;
            bool stopInputFood = false;
            bool stopBunsChoice = false;
            bool stopAllMember = false;
            bool checkBuyBunChoice = false;
            int numProductMain = 0;
            int numProductMore = 0;

            //สั่งสินค้า
            Console.Write("Input Food Name : ");
            product[numProductMain].Name = Console.ReadLine();
            numProductMain ++;
            do
            {
                Console.Write("Want more food ? (Y/N) : ");
                char moreFoodChoice = char.Parse(Console.ReadLine());
                if (numProductMain == 5)
                {
                    Console.WriteLine("Sorry you bought too much");
                    stopInputFood = true;
                    break;
                }
                else
                {
                    switch (moreFoodChoice)
                    {
                        case 'Y':
                            Console.Write("Input Food Name : ");
                            product[numProductMain].Name = Console.ReadLine();
                            numProductMain++;
                            break;
                        case 'N':
                            stopInputFood = true;
                            break;
                        default:
                            Console.WriteLine("Select Again?");
                            break;
                    }
                }                
            } while (stopInputFood == false);

            //รับขนมจีบซาลาเปาเพิ่มไหมคะ
            Console.Write("Would you like more dumpling and buns? (Y/N) : ");
            char bunsChoice = char.Parse(Console.ReadLine());
            char buyBunsChoice = '-' ;
            do
            {
                switch (bunsChoice)
                {
                    case 'Y':
                        do
                        {
                            Console.Write("Get dumplings or buns(D = dumbling / B = bun) : ");
                            buyBunsChoice = char.Parse(Console.ReadLine());
                            switch (buyBunsChoice)
                            {
                                case 'D':                                          
                                    checkBuyBunChoice = true;
                                    break;
                                case 'B':                                                                      
                                    checkBuyBunChoice = true;
                                    break;
                                default:
                                    break;
                            }                            
                        } while (checkBuyBunChoice == false);
                        numProductMore++;
                        stopBunsChoice = true;
                        break;
                    case 'N':
                        stopBunsChoice = true;
                        break;
                    default:
                        Console.WriteLine("Select Again?");
                        break;
                }
            } while (stopBunsChoice == false);

            //มี All member ไหม
            Console.Write("Do you have all members? (Y/N) : ");
            char allMemberChoice = char.Parse(Console.ReadLine());
            int allmemberNum = 0;
            do
            {
                switch (allMemberChoice)
                {
                    case 'Y':
                        Console.WriteLine("Please enter All member number : ");
                        allmemberNum = int.Parse(Console.ReadLine());
                        stopAllMember = true;                       
                        break;
                    case 'N':
                        stopAllMember = true;
                        break;
                    default:
                        Console.WriteLine("Select Again?");
                        break;
                }
            } while (stopAllMember == false);

            //outputสลิป
            Console.WriteLine("*************************************************");
            Console.WriteLine("Receipt");
            int NumProductTotal = numProductMain + numProductMore;
            if (allMemberChoice == 'Y')
            {
                Console.WriteLine("All member : "+allmemberNum);
            }
            Console.WriteLine("Total number of items : " + NumProductTotal);

            for (int i = 0; i < numProductMain; i++)
            {
                Console.WriteLine(product[i].Name);
            }
            switch (buyBunsChoice)
            {
                case 'D':
                    Console.WriteLine("dumpling");
                    break;
                case 'B':
                    Console.WriteLine("buns");
                    break;
                default:
                    break;
            }
            Console.WriteLine("Thankyou for using service");
        }
    }
}
