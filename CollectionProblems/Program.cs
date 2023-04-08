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
            Console.WriteLine("Select any one option for Respective task\n" + "1. Count Of Remaining Chapters");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ChaptersCount chaptersCount = new ChaptersCount();
                    chaptersCount.RemainingChapters();
                    break;

                default:
                    break;
            }
        }
    }
}
