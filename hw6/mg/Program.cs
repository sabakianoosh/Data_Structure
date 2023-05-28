using System.Collections.Generic;
using System.Linq;
using System;

class GFG {
	static int res=0;
	static int calc(int[] coins, int n, int m)
	{
        if(m==0)
        {
            return res;
        }
        for(int i=0;i<n;i++)
        {
            if(m-coins[i]>=0)
            {
                res++;
                m=m-coins[i];
                return calc(coins,n,m);
            }
            
        }
        return res;
        
    }

	public static void Main()
	{

		int[] coins = { 10, 5,1 };
		int n = coins.Length;
        int inp = int.Parse(Console.ReadLine());
		Console.Write(calc(coins, n, inp));
	}
}

