using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace program
{
    public class stack
    {
    public static int Main()
    {
        char[] input = Console.ReadLine().ToArray();
        Stack<Char> mystack = new Stack<char>();
        Stack<int> index = new Stack<int>();
        int len = input.Count();
        for (int i =0 ;i<len ; i++)
        {
            if (input[i] == '[' || input[i]=='{' || input[i]=='(')
            {
                mystack.Push(input[i]);
                index.Push(i);
            }
            
            else if (input[i] == ']' || input[i]=='}' || input[i]==')')
            {
                if ( (mystack.Count()!=0) && (( (input[i]=='}') &&(mystack.Peek() == '{') ) ||  (input[i]==']') && (mystack.Peek()=='[' ) || (input[i]==')') && (mystack.Peek()=='(' )))
                {
                    mystack.Pop();
                    index.Pop();
                }

                else
                {
                    Console.WriteLine(i+1);
                    return 0;
                }
            }
        }

        if (mystack.Count()== 0 && index.Count()==0) 
            {
                Console.WriteLine(-1);
                return 0;
            }
           
        if (index.Count()>0)
        {
            for (int k=0 ; k< index.Count()-1 ; k++)
            {
                index.Pop();
            }
            Console.WriteLine(index.Peek()+1);
            return 0;
        }

            return 0;
}
    }
}

