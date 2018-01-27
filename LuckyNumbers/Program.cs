using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jackPot = 1000000;
            Console.WriteLine("The jack pot is $" + jackPot + " dollars.");
            int lowNum = 0;
            int highNum = 0;
            Console.WriteLine("Please select the lowest number.");
            lowNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select the highest number.");
            highNum = int.Parse(Console.ReadLine());
            int[] pickNum = new int[6];
            bool dupes = false;
            for (int i = 0; i < pickNum.Length; i++)
            {
                Console.WriteLine("Please pick a number ({0}).", i+1);
                do
                {
                    dupes = false;
                    pickNum[i] = int.Parse(Console.ReadLine());
                    if (pickNum[i] < lowNum || pickNum[i] > highNum)
                    {
                        Console.WriteLine("Number out of range. Please pick another number ({0}).", i+1);
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (pickNum[i] == pickNum[j])
                            {
                                dupes = true;
                                Console.WriteLine("Duplicate number. Please pick another number ({0}).", i+1);
                            }
                        }
                    }
                } while (pickNum[i] < lowNum || pickNum[i] > highNum || dupes);
                
            }
            Random drawingNum = new Random();
            int[] number = new int[6];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = drawingNum.Next(lowNum, highNum);
                Console.WriteLine("Lucky number: " + number[i]);
            }
            int totalWon = (jackPot / 6);
            Console.WriteLine("You won $" + " " + totalWon + " " + "!");
        }
    }
}
            
