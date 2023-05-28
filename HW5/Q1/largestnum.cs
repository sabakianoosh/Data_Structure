using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
public class largestnumber
{
   

    public static List<Tuple<int,int>> findmsd(int[] arr,int n)
    {
        List<Tuple<int,int>> tp = new List<Tuple<int, int>>();
        
        for(int i=0 ; i<n ;i++)
        {
            int msd = -1;
            int currentnum = arr[i];
            while(currentnum!=0)
            {
                currentnum = currentnum/10;
                msd ++;
            }
            int p = (int)(arr[i]/(Math.Pow(10,msd)));
            var toadd = Tuple.Create(arr[i],p);
            tp.Add(toadd);
        }
        var result = tp.OrderBy(t => t.Item2).ToList();
        return result;
    }
    static void Main()
    {
        int c = int.Parse(Console.ReadLine());
        int[] num = new int[c];
        for (int a=0 ; a<c ;a++)
        {
            int inp =  int.Parse(Console.ReadLine());
            num[a] = inp;
        }
        var tp = findmsd(num,c);
        string st = "";
        for (int j=c-1 ;j>=0;j--)
        {
            st+=(tp[j].Item1).ToString();
        }
        Console.WriteLine(st);

    }
}