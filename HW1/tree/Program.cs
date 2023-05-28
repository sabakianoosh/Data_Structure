using System;

namespace program
{
    public class tree
    {
        public static void returntree(int count , int[]trees , int dis)
        {
            for (int j=1 ; j<count-1 ; j++)
            {
                if (trees[j+1] - trees[j] != dis)
                {
                    Console.WriteLine(trees[j]+dis);
                }
            }

        }

        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            string[] trees = Console.ReadLine().Split(' ');
            int[] eachTree = new int[count];
            for(int i=0 ;i<count ; i++)
            {
                eachTree[i] = int.Parse(trees[i]);
            }
            int distance = (eachTree[count-1] - eachTree[0])/count;
            returntree(count,eachTree,distance);
            
        }
    }
}