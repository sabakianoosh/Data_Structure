
using System;
using System.Collections.Generic;
using System.Linq;

class GFG{


static int []coin = { 1,3,4};
static int n = coin.Length;

static void calcoin(int V)
{
	List<int> res = new List<int>();

	for(int i = n - 1; i >= 0; i--)
	{

		while (V >= coin[i])
		{
			V -= coin[i];
			res.Add(coin[i]);
		}
	}
    Console.Write(res.Count());
	}

public static void Main(String[] args)
{
	int input = int.Parse(Console.ReadLine());		
	calcoin(input);
}
}


