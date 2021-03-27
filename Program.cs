using System;

namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("Input Number In Box A : ");
            int numberBoxA = int.Parse(Console.ReadLine());
            Console.Write("Input Number In Box B : ");
            int numberBoxB = int.Parse(Console.ReadLine());
            Console.Write("Input Number In Box C : ");
            int numberBoxC = int.Parse(Console.ReadLine());
            int turnCount = 1;
            bool gameOverCheck = false;
            while (gameOverCheck == false)
            {
                Console.WriteLine("\n----------------------------------------------------------------------\n");
                Console.WriteLine("Turn : " + turnCount);
                //status a
                Console.WriteLine("Box A = {0}\tBox B = {1}\tBox C = {2}", numberBoxA, numberBoxB, numberBoxC);
                
                //player a
                Console.WriteLine("\tTurn PlayerA");
                Console.Write("Choose Box : ");
                string chooseBox = Console.ReadLine();
                Console.Write("How many Box Remove? : ");
                int removeBox = int.Parse(Console.ReadLine());
                switch (chooseBox)
                {
                    case "A":
                        numberBoxA -= removeBox;
                        break;
                    case "B":
                        numberBoxB -= removeBox;
                        break;
                    case "C":
                        numberBoxC -= removeBox;
                        break;
                    default:
                        break;
                }
                
                //check player a
                if(numberBoxA == 0 && numberBoxB == 0 && numberBoxC == 0)
                {
                    gameOverCheck = true;
                    Console.WriteLine("**********    Game Over Player B Win    **********");
                    break;
                }
                turnCount++;
                Console.WriteLine("\n----------------------------------------------------------------------\n");

                //status b
                Console.WriteLine("Turn : " + turnCount);
                Console.WriteLine("Box A = {0}\tBox B = {1}\tBox C = {2}", numberBoxA, numberBoxB, numberBoxC);

                //player b
                Console.WriteLine("\tTurn PlayerB");
                Console.Write("Choose Box : ");
                chooseBox = Console.ReadLine();
                Console.Write("How many Box Remove? : ");
                removeBox = int.Parse(Console.ReadLine());
                switch (chooseBox)
                {
                    case "A":
                        numberBoxA -= removeBox;
                        break;
                    case "B":
                        numberBoxB -= removeBox;
                        break;
                    case "C":
                        numberBoxC -= removeBox;
                        break;
                    default:
                        break;
                }
                
                //check player b
                if (numberBoxA == 0 && numberBoxB == 0 && numberBoxC == 0)
                {
                    gameOverCheck = true;
                    Console.WriteLine("**********     Game Over Player A Win    **********");
                    break;
                }
                turnCount++;

            }



        }
    }
}
