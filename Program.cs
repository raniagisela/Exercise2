﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        //array of integers to hold values
        private int[] rara = new int[53];
        private int cmp_count = 0; //number of comparasion
        private int mov_count = 0; //number of movements

        //number of elements in array
        private int n;
        void read()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 53)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 53 elements \n");
            }
            Console.WriteLine("\n=======================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n=======================");

            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                rara[i] = Int32.Parse(s1);
            }
        }
        //swaps the elements at index x with the element at index y
        void swap(int x, int y)
        {
            int temp;

            temp = rara[x];
            rara[x] = rara[y];
            rara[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, j, k;
            if (low >= high)
            {
                int mid = (low + high) / 2;
                return;
            }
        }
    }
}