// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using System.Diagnostics;
// using System.Collections;


// public class HashFunction
// {
//     public static void Main()
//     {
//         // List<string> hashfun = new List<string>();
//         int size = int.Parse(Console.ReadLine());
//         int NOQ = int.Parse(Console.ReadLine());
//         int q=0;
//         List<string>[] ArrayOfList = new List<string>[size];
//         for(int k=0 ;k<size ; k++)
//         {
//             ArrayOfList[k]=new List<string>();
//         }
//         while (q<NOQ)
//         {
//             string input = Console.ReadLine();
//             string[] toks = input.Split(' ');
//             string ToDo = toks[1];
//             int[] ascii_code = new int[ToDo.Length];        
//             int i =0;
//             foreach(char t in  ToDo)
//             {
//                 ascii_code[i]  = (Convert.ToInt32(t));
//                 i++;
//             }
//             long SumOfFirstMod = 0;
//             int c = ascii_code.Count();
//             for (int j=c-1 ; j>=0 ; j--)
//             {
//                 long d = ascii_code[j] * (long)(Math.Pow(263,j));
//                 SumOfFirstMod += (d%1000000007);
//                 SumOfFirstMod = SumOfFirstMod%1000000007;
//             }
//             int result =(int)(SumOfFirstMod%size);
//             if (input.StartsWith("add"))
//             {
//                 if (ArrayOfList[result].Contains(ToDo)==false)
//                 ArrayOfList[result].Insert(0,ToDo);
//             }
//             else if (input.StartsWith("del"))
//             {
//                 try
//                 {ArrayOfList[result].Remove(ToDo);}
//                 catch
//                 {continue;}
//             }
//             else if (input.StartsWith("check"))
//             {   
//                 int checknum = int.Parse(ToDo);
//                 int le = ArrayOfList[checknum].Count();
//                 if (le != 0)
//                 {
//                     string outstring = "";
//                     foreach(var l in ArrayOfList[checknum])
//                     {
//                         outstring += l;
//                         outstring +=" ";
//                     }
//                     outstring.Remove(ArrayOfList[checknum].Count()-1);
//                     Console.WriteLine(outstring);
//                 }
//                 else if(le==0)
//                 {
//                     Console.WriteLine("");
//                 }
//             }
//             else if (input.StartsWith("find"))
//             {
//                 if (ArrayOfList[result].Contains(ToDo))
//                 {
//                     Console.WriteLine("yes");
//                 }
//                 else
//                 {
//                     Console.WriteLine("no");
//                 }
//             }
//         q++;
//         }
//     }
// }
