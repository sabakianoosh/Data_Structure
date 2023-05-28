using System;
using System.Collections.Generic;
using static System.Console;
namespace Assignment
{
    class Program
    {
        static int inversion = 0;
        static int[][] convert(int[] arr, int x)
        {
            int[] arr1 = new int[x];
            int[] arr2 = new int[arr.Length - x];
            for (int i = 0; i < arr.Length; i++)
            {
                if(i < x)
                {
                    arr1[i] = arr[i];
                }
                else
                {
                    arr2[i-x] = arr[i];
                }
            }
            return new int[][] {arr1, arr2};
        }
        static int[] MergeSort(int[] array)
        {
            if(array.Length == 1)
            {
                return array;
            }
            int mid = array.Length / 2;
            int[][] arrays = convert(array, mid);
            array = Merge(MergeSort(arrays[0]), MergeSort(arrays[1]));
            return array;
        }
        static int[] Merge(int[] arr1, int[] arr2)
        {
            int[] outarray = new int[arr1.Length + arr2.Length];
            int a = 0, b = 0, c = 0;
            while( outarray.Length != c)
            {
                if( arr1.Length <= a)
                {
                    outarray[c] = arr2[b];
                    b++;
                }
                else if( arr2.Length <= b)
                {
                    outarray[c] = arr1[a];
                    a++;
                }
                else if(arr1[a] <= arr2[b])
                {
                    outarray[c] = arr1[a];
                    a++;
                }
                else
                {
                    outarray[c] = arr2[b];
                    b++;
                    inversion += arr1.Length - a;
                }
                c++;
            }
            return outarray;
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(ReadLine());
            }
            MergeSort(arr);
            WriteLine(inversion);
        }
    }
}
