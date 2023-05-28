 using System;
 
 namespace trees
{
    public class find_tree
    {
        
        public static int findtree(int first,int last,int[] trees,int distance)
        {
            int mid = ((last-first)/2) + first;

           if (trees[mid+1] - trees[mid] != distance)
           {Console.WriteLine(trees[mid]+distance);
           return 0;}

           if (mid>0 && trees[mid] - trees[mid-1] != distance)
           {
            Console.WriteLine(trees[mid-1]+distance);
            return 0;
           }

           if (trees[mid]==trees[0]+ (mid*distance))
           {
            findtree(mid+1,last,trees,distance);
            return 0;
           }
           
           else
           {
            findtree(first,mid-1,trees,distance);
            return 0;
           }



           

        }
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
        int distance = (input[count-1]-input[0])/count;
        findtree(0,count,input,distance);
    }
    }

}