using System;

namespace HomeWork4_2
{
    class Program
    {
        static bool checkProcess = false;
        static bool replicateCheck = false;
        static bool checkInput = false;
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach(char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach(char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
        static void replicatePart(string input)
        {
            do
            {
                Console.WriteLine("Do you want to replicate it ? (Y/N)");
                char replicate = char.Parse(Console.ReadLine());
                switch (replicate)
                {
                    case 'Y':                        
                        Console.WriteLine("Replicates half DNA sequence : "+ ReplicateSeqeunce(input));
                        replicateCheck = true;
                        break;
                    case 'N':
                        replicateCheck = true;
                        break;
                    default:
                        Console.WriteLine("Please Input Y or N");
                        break;
                }
            } while (replicateCheck == false);
        }

        static void Main(string[] args)
        {            
            do
            {
                string input = Console.ReadLine();
                if (IsValidSequence(input) == false)
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                }
                else 
                {
                    Console.WriteLine("Current half DNA sequence : "+input);
                    replicatePart(input);
                }

                Console.WriteLine("Do you want to process another sequence ? (Y/N)");
                char process = char.Parse(Console.ReadLine());
                do
                {
                    switch (process)
                    {
                        case 'Y':
                            checkInput = true;
                            break;
                        case 'N':
                            checkInput = true;
                            checkProcess = true;

                            break;
                        default:
                            Console.WriteLine("Please Input Y or N");
                            break;
                    }
                } while (checkInput == false);
                
            } while (checkProcess == false);            
        }
    }
}
