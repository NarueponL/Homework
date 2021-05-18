using System;

namespace HomeWork5
{
    class Program
    {
        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }

        static double[,] WriteExpandedDataArray(double[,] imageDataArray,int expandedCollumn,int expandedRow,int dataArrayCollumn,int dataArrayRow,int convolutionCollumn,int convolutionRow)
        {
            double[,] expandedDataArray = new double[expandedCollumn, expandedRow];
            for(int i = 0; i < expandedCollumn; i++)
            {
                for(int j = 0; j < expandedRow; j++)
                {                    
                    expandedDataArray[i, j] = imageDataArray[(i+(dataArrayCollumn-(convolutionCollumn/2)))%dataArrayCollumn, (j + (dataArrayRow-(convolutionRow/2)))% dataArrayRow];
                }
            }
            return expandedDataArray;
        }

        static double[,] ConvolutionOp(double[,] expandedDataArray, double[,] convolutionArray, int dataArrayCollumn, int dataArrayRow)
        {
            double[,] outputImageArray = new double[dataArrayCollumn, dataArrayRow];

            for(int i=0;i< dataArrayCollumn; i++)
            {
                for (int j = 0; j < dataArrayRow; j++)
                {

                    for(int k = 0; k < convolutionArray.GetLength(0); k++)
                    {
                        for (int l = 0; l < convolutionArray.GetLength(1); l++)
                        {
                            
                            outputImageArray[i, j] += expandedDataArray[i+k,j+l] * convolutionArray[k, l];
                        }
                    }               
                }
            }
            return outputImageArray;
        }

        static void WriteImageDataToFile(string imageDataFilePath,double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i,
                                                imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }

            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }

        static void Main(string[] args)
        {
            //********  รับข้อมูล  ********
            Console.Write("Input Image data Address : ");
            string imageData = Console.ReadLine();
            double[,] imageDataArray = ReadImageDataFromFile(imageData);

            Console.Write("Input Convolution Kernel Address : ");
            string convolutionKernel = Console.ReadLine();
            ReadImageDataFromFile(convolutionKernel);
            double[,] convolutionArray = ReadImageDataFromFile(convolutionKernel);

            Console.Write("Output Address : ");
            string outputAddress = Console.ReadLine();

            //********  ขนาดของArrayที่ต่อเติม  ********
            int expandedArrayCollumn = imageDataArray.GetLength(0) + convolutionArray.GetLength(0) - 1;
            int expandedArrayRow = imageDataArray.GetLength(1) + convolutionArray.GetLength(1) - 1;

            //********  สร้างArrayที่ต่อเติม  ********
            double[,] expandedDataArray = WriteExpandedDataArray(imageDataArray, expandedArrayCollumn, expandedArrayRow, imageDataArray.GetLength(0), imageDataArray.GetLength(1), convolutionArray.GetLength(0), convolutionArray.GetLength(1));
            
            //********  การดำเนินการ Convolve  ********
            double[,] outputImageData = ConvolutionOp(expandedDataArray, convolutionArray, imageDataArray.GetLength(0), imageDataArray.GetLength(1));

            //********  ส่งออกไฟล์  ********
            WriteImageDataToFile(outputAddress, outputImageData);

        }
    }
}
