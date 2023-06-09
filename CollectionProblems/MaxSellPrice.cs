﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProblems
{
    public class MaxSellPrice
    {
        public void MaxSell()
        {
            Console.WriteLine("Enter N and K value seprated by white space ");
            var obj = Console.ReadLine().Split();
            int n = Convert.ToInt32(obj[0]);
            int k = Convert.ToInt32(obj[1]);

            Console.WriteLine("Enter {0} value for basket A of fruit seprated by white space ", n);
            string[] data = Console.ReadLine().Split();
            int[] basket_A = data.Select(int.Parse).ToArray();

            Console.WriteLine("Enter {0} value for basket B of fruit seprated by white space ", n);
            data = Console.ReadLine().Split();
            int[] basket_B = data.Select(int.Parse).ToArray();

            //swap
            for (int i = 0; i < k; i++)
            {
                int temp;
                temp = basket_A[i];
                basket_A[i] = basket_B[i];
                basket_B[i] = temp;
            }

            Console.WriteLine("\nafter swaping basket A value is ");
            foreach (int value in basket_A)
            {
                Console.Write(" " + value);
            }

            Console.WriteLine("\nafter swaping basket B value is ");
            foreach (int value in basket_B)
            {
                Console.Write(" " + value);
            }
            int maxPriceInBaslet_A = 0;
            foreach (int value in basket_A)
            {
                maxPriceInBaslet_A += value;
            }
            Console.WriteLine("\n ---------*****---------\n Max Selling Price of basket A is " + maxPriceInBaslet_A);

        }
    }
}
