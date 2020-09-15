using SortingAlgorithmsLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTask
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the Size of Array");
                int ArraySize = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select The Algorithm you want to Perform");
                Console.WriteLine("1.QuickSort \t2.BubbleSort  \t3.MergeSort \t4.InsertionSort \t5.CountSort");
                int specificNumberOfAlgorithm = Convert.ToInt32(Console.ReadLine());
                switch (specificNumberOfAlgorithm)
                {
                    case 1:
                        PerformQuickSort(ArraySize);
                        break;
                    case 2:
                        PerformBubbleSort(ArraySize);
                        break;
                    case 3:
                        PerformMergeSort(ArraySize);
                        break;
                    case 4:
                        PerformInsertionSort(ArraySize);
                        break;
                    case 5:
                        PerformCountSort(ArraySize);
                        break;
                }
            }
        }
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]); Console.Write(' ');
            }
            Console.WriteLine();
        }
        static void PerformQuickSort(int sizeArray)
        {
            SortingAlgorithms sorting = new QuickSort(sizeArray);
            sorting.FillArray();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            sorting.SortArray();
            watch.Stop();
            var arr = sorting.GetSortedArray;
            Print(arr);
            Console.WriteLine($"Total Execution Time: {watch.ElapsedMilliseconds} ms");
        }
        static void PerformBubbleSort(int sizeArray)
        {
            SortingAlgorithms sorting = new BubbleSort(sizeArray);
            sorting.FillArray();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            sorting.SortArray();
            watch.Stop();
            var arr = sorting.GetSortedArray;
            Print(arr);
            Console.WriteLine($"Total Execution Time: {watch.ElapsedMilliseconds} ms");
        }
        static void PerformMergeSort(int sizeArray)
        {
            SortingAlgorithms sorting = new MergeSort(sizeArray);
            sorting.FillArray();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            sorting.SortArray();
            watch.Stop();
            var arr = sorting.GetSortedArray;
            Print(arr);
            Console.WriteLine($"Total Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        static void PerformCountSort(int sizeArray)
        {
            SortingAlgorithms sorting = new InsertSort(sizeArray);
            sorting.FillArray();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            sorting.SortArray();
            watch.Stop();
            var arr = sorting.GetSortedArray;
            Print(arr);
            Console.WriteLine($"Total Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        static void PerformInsertionSort(int sizeArray)
        {
            SortingAlgorithms sorting = new CountSort(sizeArray);
            sorting.FillArray();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            sorting.SortArray();
            watch.Stop();
            var arr = sorting.GetSortedArray;
            Print(arr);
            Console.WriteLine($"Total Execution Time: {watch.ElapsedMilliseconds} ms");
        }        
    }
}
