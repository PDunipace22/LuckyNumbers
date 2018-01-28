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
            do
            {
                Console.WriteLine("Welcome to Lucky Numbers!");
                Console.WriteLine("You pick six numbers. we will generate six numbers and see if any of those numbers match.");
                Console.WriteLine("The more you match, the more you win!");
                int jackPot = 3000000;
                Console.WriteLine("The jack pot is {0:c}", jackPot);
                Console.WriteLine("Good Luck");
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
                    Console.WriteLine("Please pick a number ({0}).", i + 1);
                    do
                    {
                        dupes = false;
                        pickNum[i] = int.Parse(Console.ReadLine());
                        if (pickNum[i] < lowNum || pickNum[i] > highNum)
                        {
                            Console.WriteLine("Number out of range. Please pick another number ({0}).", i + 1);
                        }
                        else
                        {
                            for (int j = 0; j < i; j++)
                            {
                                if (pickNum[i] == pickNum[j])
                                {
                                    dupes = true;
                                    Console.WriteLine("Duplicate number. Please pick another number ({0}).", i + 1);
                                }
                            }
                        }
                    } while (pickNum[i] < lowNum || pickNum[i] > highNum || dupes);
                }
                Random drawingNum = new Random();
                int[] number = new int[6];
                for (int i = 0; i < number.Length; i++)
                {
                    do
                    {
                        dupes = false;
                        number[i] = drawingNum.Next(lowNum, highNum + 1);
                        for (int j= 0; j < i; j++)
                        {
                            if(number[i] == number[j])
                            {
                                dupes = true;
                            }
                        }
                    } while (dupes);
                    Console.WriteLine("Lucky number: " + number[i]);
                }
                int match = MatchCount(pickNum, number);
                Console.WriteLine("You correctly matched {0} numbers.", match);
                double totalWon = (jackPot / 6) * match;
                Console.WriteLine("You won {0:c}!", totalWon);
            } while (Play());
            Console.WriteLine("Thanks for playing!");
        }

        static int MatchCount(int[] pickNum,int[] number)
        {
            int counter = 0;
            for(int p = 0; p < pickNum.Length; p++)
            {
                for(int n = 0; n < number.Length; n++)
                {
                    if (pickNum[p] == number[n])
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        static bool Play()
        {
            Console.WriteLine("Do you wish to play again?");
            string playAgain = Console.ReadLine();
            if(playAgain.ToLower() == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
            
