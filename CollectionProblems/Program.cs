using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to collection practice Problem ");
            Console.WriteLine("Select any one option for Respective task\n" +
                 "1. Count Of Remaining Chapters\n" +
                 "2. Max Selling Price ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ChaptersCount chaptersCount = new ChaptersCount();
                    chaptersCount.RemainingChapters();
                    break;

                case 2:
                    MaxSellPrice maxSellPrice = new MaxSellPrice();
                    maxSellPrice.MaxSell();
                    break;

                default:
                    Console.WriteLine("Please Enter valid option");
                    break;
            }
        }
    }
}
