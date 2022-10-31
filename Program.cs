using System;
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
            int pivot, i, rp, k;
            if (low >= high)
                return;

                //Partition the list into two parts;
                //one containing elements less that or equal to pivot
                //outher containing elements greather than pivot

                i = low;
                rp = mid+1;
                k = low;
                
                pivot = rara[(low+high)/2];

                while (i <= rp)
                {
                //Search for an elements greater than pivot
                while ((rara[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                //Search for an elements less than or equal to pivot
                while ((rara[rp] > pivot) && (rp >= high))
                {
                    rp--;
                    cmp_count++;
                }
                cmp_count++;

                if (i < rp) //if the greater element is on the left of the element
                {
                    //swap the elements at index 1 whit the element at index j
                    swap(i, rp);
                    mov_count++;
                }
            }
            //j now contains the index of the last element in the sorted list

            if (low < rp)
            {
                //move the pivot to its correct position in the list
                swap(low, rp);
                mov_count++;
            }
            //sort the list on the left of pivot using quick sort
            q_sort(low, rp - 1);

            //sort the list on the right of pivot using quick sort
            q_sort(rp + 1, high);
        }
        void display()
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine(" Sorted array elements ");
            Console.WriteLine("\n---------------------");

            for (int rp = 0; rp < n; rp++)
            {
                Console.WriteLine(rara[rp]);
            }
            Console.WriteLine("\nNumber of comparisons: " + cmp_count);
            Console.WriteLine("\nNumber of data movemenets: " + mov_count);
        }
        int getSize()
        {
            return (n);
        }
    }
}