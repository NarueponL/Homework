using System;

namespace Final_2
{
    class Program
    {        
        enum name
        {
            ice,
            pp,
            arch,
            ohm

        }
        static void Main(string[] args)
        {
            int allnum = int.Parse(Console.ReadLine());
            int[] allnumdata = new int[allnum];
            for(int i = 0; i < allnum; i++)
            {
                allnumdata[i] = int.Parse(Console.ReadLine());
            }
            sort(allnumdata,allnum);
            output(allnumdata, allnum);
        }

        static void sort(int[] data,int num)
        {
            for (int i = num-1; i < num; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int x = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = x;
                    }
                }
            }
        }
        static void output(int[] data,int num)
        {
            for (int i = 0; i< 4; i++)
            {
                Console.Write("{0}'s Sort ", (name)i);
                for(int j = 0; j < num; j++)
                {
                    Console.Write("{0} ",data[j]);
                }
                Console.WriteLine();
            }
}
        
    }
}
