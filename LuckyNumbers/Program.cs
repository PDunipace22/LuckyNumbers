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
            int lowNum = 0;
            int highNum = 0;
            Console.WriteLine("Please select the lowest number.");
            lowNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select the highest number.");
            highNum = int.Parse(Console.ReadLine());
            //int[] pickNum = new int[6];
            //for (int i = 0; i < pickNum.Length; i++)
            //{
            //    Console.WriteLine("Please pick six numbers.");
            //    if (pickNum[i] > lowNum && pickNum[i] < highNum)
            //    {
            //        pickNum[i] = int.Parse(Console.ReadLine());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please pick another number.");
            //    }

            Random drawingNum = new Random();
            int[] number = new int[6];
            for(int i = 0; i < number.Length; i++)
            {
                number[i] = drawingNum.Next(lowNum, highNum);
                Console.WriteLine("Lucky number: " + number[i]);
            }
            }
        }
    }
