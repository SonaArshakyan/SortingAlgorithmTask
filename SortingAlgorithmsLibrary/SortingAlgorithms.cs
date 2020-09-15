using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsLibrary
{
    abstract public class SortingAlgorithms
    {
        protected int[] arr;
        protected int sizeArray;

        public SortingAlgorithms(int size)
        {
            sizeArray = size;
            arr = new int[sizeArray];
        }
        public void FillArray()
        {
            int Min = 10;
            int Max = 100;
            Random randNum = new Random();
            for (int i = 0; i < sizeArray; i++)
            {
                arr[i] = randNum.Next(Min, Max);
            }
        }
        public int[] GetSortedArray { get { return arr; } }
        public abstract void SortArray();
        public virtual void Exchange(int[] arr, int i, int j)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
    public class QuickSort : SortingAlgorithms
    {
        public QuickSort(int size) : base(size)
        {
        }
        public override void SortArray()
        {
            int left = 0;
            int right = base.arr.Length - 1;
            QucikSortArray(base.arr, left, right);
        }
        private void QucikSortArray(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int pivot = Partition(arr, l, r);
                QucikSortArray(arr, l, pivot);
                QucikSortArray(arr, pivot + 1, r);
            }
        }
        private int Partition(int[] arr, int l, int r)
        {
            int Pivot = arr[l];
            int i = l; int j = r;
            while (true)
            {
                while (arr[i] < Pivot)
                    i++;
                while (arr[j] > Pivot)
                    j--;
                if (i < j)
                {
                    Exchange(arr, i, j);
                    i++;
                    j--;
                }
                else
                {
                    return j;
                }
            }
        }
    }
    public class BubbleSort : SortingAlgorithms
    {
        public BubbleSort(int size) : base(size) { }
        public override void SortArray()
        {
            BubleSortArray(base.arr);
        }
        private void BubleSortArray(int[] arr)
        {
            int n = base.sizeArray;
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] < arr[j]) Exchange(arr, i, j);
                }
            }
        }
    }
    public class MergeSort : SortingAlgorithms
    {
        public MergeSort(int size) : base(size) { }

        public override void SortArray()
        {
            int left = 0;
            int right = base.arr.Length - 1;
            MergeSortArray(base.arr, left, right);
        }
        private void MergeSortArray(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (right + left) / 2;
                MergeSortArray(arr, left, middle);
                MergeSortArray(arr, middle + 1, right);
                Merge(arr, left, middle, right);
            }
        }
        private void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int ii = 0; ii < n1; ii++)
                L[ii] = arr[l + ii];
            for (int jj = 0; jj < n2; jj++)
                R[jj] = arr[m + 1 + jj];
            int i = 0;
            int j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

    }
    public class CountSort : SortingAlgorithms
    {
        public CountSort(int size) : base(size) { }

        public override void SortArray()
        {
            CountSortArray(base.arr);
        }
        private void CountSortArray(int[] arr)
        {
            int size = base.sizeArray;
            int maxValueOfArray = arr.Max();
            int[] Count = new int[maxValueOfArray + 1];
            int[] sortedArr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Count[arr[i]]++;
            }
            for (int i = 1; i <= maxValueOfArray; i++)
            {
                Count[i] = Count[i] + Count[i - 1];
            }
            for (int i = size - 1; i >= 0; i--)
            {
                sortedArr[--Count[arr[i]]] = arr[i];
            }
            base.arr = sortedArr;
        }
    }
    public class InsertSort : SortingAlgorithms
    {
        public InsertSort(int size) : base(size)
        {
        }
        public override void SortArray()
        {
            InsertSortArray(base.arr);
        }
        private void InsertSortArray(int[] arr)
        {
            int n = base.sizeArray;
            for (int i = 1; i < n; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j]; j--;
                }
                arr[j + 1] = temp;
            }
        }
    }



}
