using System;

namespace Final_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInventory = int.Parse(Console.ReadLine());
            string[] itemName = new string[numInventory];
            string[] itemType = new string[numInventory];

            for (int i = 1; i < numInventory; i++)
            {
                itemName[i] = Console.ReadLine();
                itemType[i] = Console.ReadLine();
            }
        }
    }
}
