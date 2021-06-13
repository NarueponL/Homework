using System;

namespace Final_3
{
    class Program
    {
        static double FindMax(double[] data)
        {
            double maxValue = 0; 
            for(int i = 0; i< data.Length-1; i++)
            {
                maxValue = Math.Max(data[i], data[i + 1]);
            }
            return maxValue;

        }
        static double FindMin(double[] data)
        {
            double minValue = 0;
            for (int i = 0; i < data.Length-1 - 1; i++)
            {
                minValue = (int)Math.Min(data[i], data[i + 1]);
            }
            return minValue;
        }
        static double FindMean(double[] data)
        {
            double meanValue = 0;
            for(int i = 0; i < data.Length; i++)
            {
                meanValue += data[i];
            }
            meanValue /= data.Length;
            return meanValue;
        }
        static void Main(string[] args)
        {
            bool checkInput = false;
            bool checkFind = false;
            double[] inputData =new double[0];
            //inputnumber
            do
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    checkInput = true;
                }
                else
                {
                    double[] collection = new double[inputData.Length + 1];
                    for(int i = 0; i < inputData.Length; i++)
                    {
                        collection[i] = inputData[i];
                    }
                    collection[collection.Length - 1] = double.Parse(input);
                    inputData = collection;
                }
            } while (checkInput == false);
            //inputmethod
            do
            {
                string inputFind = Console.ReadLine();
                switch (inputFind)
                {
                    case "FindMax":
                        Console.WriteLine(FindMax(inputData));
                        checkFind = true;
                        break;
                    case "FindMin":
                        Console.WriteLine(FindMin(inputData));
                        checkFind = true;
                        break;
                    case "FindMean":
                        Console.WriteLine(FindMean(inputData));
                        checkFind = true;
                        break;
                    default:
                        Console.WriteLine("Invalid mode");
                        break;
                }
            } while (checkFind == false);
        }
    }
}
