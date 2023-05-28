using System;
using System.Collections.Generic;

namespace program
{
    public class cyk
    {
                
        void Main()
        {
            Dictionary<string,List<string>> dic = new Dictionary<string, List<string>>(){
            {"AB",new List<string>(){"A","B"}} , 
            {"BB",new List<string>(){"A"}},
            {"a",new List<string>(){"A"}},
            {"b",new List<string>(){"B"}}
        };

            string input = Console.ReadLine();
            for (int l=1; l<=input.Count();l++)
            {
                for (int s=1;s<input.Count();s++)
                {
                    for (int j=1;j<input.Count()-s+1;j++)
                    {
                        
                    }
                }
            }
        }
    }
}


