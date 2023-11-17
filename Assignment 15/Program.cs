using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_15
{
    internal class Program
    {

        public static void bubblesort(int[] arr)
        {
            int n = arr.Length;
            int noswap = 0;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;

                        noswap++;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        public static int binarysearch(int[] arr, int n)
        {
            int left = 0;
            int right = arr.Length - 1;
            int pass = 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                Console.WriteLine($"Pass{pass}: checking index {mid}");
                if (arr[mid] == n)
                {
                    return mid;
                }
                else if (arr[mid] < n)
                {
                    Console.WriteLine($"Pass{pass}: Search item is greater then element at index {mid} Ignoring the  left half");
                    left = mid + 1;
                }
                else
                {
                    Console.WriteLine($"Pass{pass}: Search item is greater then element at index {mid} Ignoring the  right half");
                    right = mid - 1;
                }
                pass++;
            }
            return -1;
        }
        public static void print(int[] arr)
        {
            for(int i=0;i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("1.search\n2.sort\nenter your choice");
            int ch=int.Parse(Console.ReadLine());
            if (ch == 1)
            {
                int[] arr = { 1, 2, 3, 4, 5 };
                Console.WriteLine("enter number to be searched");
                int num = int.Parse(Console.ReadLine());

                // int res=linsearch(arr,num);
                int res = binarysearch(arr, num);

                if (res == -1)
                {
                    Console.WriteLine("Element not found");
                }
                else
                {
                    Console.WriteLine("element found at index:" + res);
                }
            }
            else
            {
                int[] arr = { 5, 2, 9, 3, 1 };
                Console.WriteLine("before sorting");
                print(arr);
                Console.WriteLine("after sorting");
                bubblesort(arr);
                print(arr);
            }
           
        }
    }
}
