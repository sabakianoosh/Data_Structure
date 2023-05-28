// // C# program to generate largest
// // possible number with given digits
// using System;

// public class GFG {
// 	// Function to generate largest
// 	// possible number with given digits
// 	static double findMaxNum(int[] arr, int n)
// 	{
// 		// sort the given array in
// 		// ascending order and then
// 		// traverse into descending
// 		Array.Sort(arr);

// 		double num = arr[0];

// 		// generate the number
       
// 		for (int i = n - 1; i > 0; i--) {
//             int c = 0;
//             int cn = arr[i];
//             while(cn!=0)
//             {
//                 cn = cn/10;
//                 c++;
//             }
// 			num = num * Math.Pow(10,c) + arr[i];
// 		}

// 		return num;
// 	}

// 	// Driver code
// 	static public void Main()
// 	{
// 		int[] arr = { 1000,9,56};
// 		int n = arr.Length;
// 		Console.WriteLine(findMaxNum(arr, n));
// 	}
// }

// // This code is contributed by Sachin..
