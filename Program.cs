using System;

namespace HomeWork6
{
    class Program
    {
        struct Problem
        {
            public string Message;
            public int Answer;

            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }
        }

        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];

            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] = new Problem(String.Format("{0} + {1} = ?", x, y), x + y);                    
                else
                    randomProblems[i] = new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
            }
            return randomProblems;
        }

        enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }

        static int Setting()
        {
            bool checkDifficulty = false;
            int newDifficulty = 0;

            while (checkDifficulty == false)
            {
                Console.WriteLine("0 = Easy\t1 = Normal\t2 = Hard");
                Console.Write("Select difficulty : ");
                newDifficulty = int.Parse(Console.ReadLine());
                if (newDifficulty >= 0 && newDifficulty <= 2) 
                {
                    checkDifficulty = true;                   
                }
                else
                {
                    Console.WriteLine("Plese input 0 - 2");
                }
            }
            return newDifficulty;
        }

        static double Play(int difficulty)
        {
            double score = 0, startTime, finishTime;
            int allNumProblem = 0, correctAnswer = 0;
            Problem[] randomProblems = GenerateRandomProblems(0);
            
            //จน.ข้อตามความยาก
            switch (difficulty)
            {
                case 0:
                    allNumProblem = 3;
                    break;
                case 1:
                    allNumProblem = 5;
                    break;
                case 2:
                    allNumProblem = 7;
                    break;
            }
            randomProblems = GenerateRandomProblems(allNumProblem);
            //เริ่มนับเวลา
            startTime = DateTimeOffset.Now.ToUnixTimeSeconds();
            //โจทย์
            for (int i = 0; i < allNumProblem; i++)
            {
                Console.WriteLine(randomProblems[i].Message);
                int inputAnswer = int.Parse(Console.ReadLine());
                if(inputAnswer == randomProblems[i].Answer)
                {
                    correctAnswer += 1;
                }
            }
            //หยุดนับเวลา
            finishTime = DateTimeOffset.Now.ToUnixTimeSeconds();
            
            //คำนวณแต้ม
            score = ScoreCalculate(startTime,finishTime,allNumProblem,correctAnswer,difficulty);

            return score;
        }

        static double ScoreCalculate(double t1,double t2,double Qa,double Qc,double d)
        {
            double S;
            double dt = t2 - t1;

            //คำนวณแต้ม
            S = (Qc / Qa) * (25 - Math.Pow(d, 2)) / Math.Max(dt, 25 - (Math.Pow(d, 2))) * Math.Pow(2*d + 1, 2);
            
            return S;
        }

        static void Main(string[] args)
        {
            double score = 0;
            int difficulty = 0;
            bool checkOption = false;
            while (checkOption == false)
            {
                Console.WriteLine("Score : {0} , Difficulty : {1}", score, (Difficulty)difficulty);
                Console.WriteLine("0 = Play Game\t1 = Setting\t2 = Exit");
                //เลือกหน้า
                Console.Write("Select option : ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (option)
                {
                    case 0:
                        score = Play(difficulty);
                        break;
                    case 1:
                        difficulty =  Setting();
                        break;
                    case 2:
                        checkOption = true;
                        break;
                    default:
                        Console.WriteLine("Plese input 0 - 2");
                        break;
                }
                Console.WriteLine("********************************************************");
            }
        }
    }   
}
