using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace q1
{
    public class Node
    {
        public int key;
        
        public Node left;
        public Node right;
        public Node(int item)
	    {
		key = item;
		left = right = null;
	    }
    }
    public class binarytree
    {
        Node root ;
        
        binarytree(){root = null;}
        public static void preorder(int idroot,List<Node> nodes,List<Tuple<int,string>> tplist)
        {
            if (nodes[idroot] == null)
                return;
            Console.Write(tplist[idroot].Item2);
            try
            {
                preorder(nodes[idroot].left.key,nodes,tplist);
                
            }
            catch(NullReferenceException)
            {
                return;
            }
            try
            {
                preorder(nodes[idroot].right.key,nodes,tplist);
            }
            catch(NullReferenceException)
            {
                return;
            }
            
        }
        public static void indorder(int idroot,List<Node> nodes,List<Tuple<int,string>> tplist)
        {
            if (nodes[idroot] == null)
                return;
            try
            {
                indorder(nodes[idroot].left.key,nodes,tplist);
            }
            catch(NullReferenceException)
            {
                Console.Write(tplist[idroot].Item2);
                return;
            }

            Console.Write(tplist[idroot].Item2);
            
            try
            {
            indorder(nodes[idroot].right.key,nodes,tplist);
            }
            catch(NullReferenceException)
            {
                Console.Write(tplist[idroot].Item2);
                return;
            }
        }
        public static StringBuilder postorder(int idroot,List<Node> nodes,List<Tuple<int,string>> tplist,StringBuilder sb)
        {
            if (nodes[idroot] == null)
                return sb;
            try
            {
            postorder(nodes[idroot].left.key,nodes,tplist,sb);
            }
            catch(NullReferenceException)
            {
                sb.Append(tplist[idroot].Item2);
                return sb;
            }
            try
            {
            postorder(nodes[idroot].right.key,nodes,tplist,sb);
            }
            catch(NullReferenceException)
            {
                sb.Append(tplist[idroot].Item2);
                return sb;
            }
           sb.Append(tplist[idroot].Item2);
            return sb;
        }

        public static void calculate(string st)
        { int l = st.Length;
            Stack<double> mystack = new Stack<double>();
            string[] ma = new string[st.Length];
            for (int j=0 ; j<l ; j++)
            {
                ma[j] = st[j].ToString();
            }
            for (int i=0 ; i<l ; i++ )
            {   
                try
                {
                    mystack.Push(int.Parse(ma[i]));
                }
                catch
                {
                    if (ma[i]=="+")
                    {
                        double current = mystack.Peek();
                        mystack.Pop();
                        double current2 = mystack.Peek();
                        mystack.Pop();
                        mystack.Push(current+current2);
                    }
                    else if (ma[i]=="-")
                    {
                        double current = mystack.Peek();
                        mystack.Pop();
                        double current2 = mystack.Peek();
                        mystack.Pop();
                        mystack.Push(current2-current);
                    }
                    else if (ma[i]=="*")
                    {
                        double current = mystack.Peek();
                        mystack.Pop();
                        double current2 = mystack.Peek();
                        mystack.Pop();
                        mystack.Push(current*current2);
                    }
                    else if (ma[i]=="^")
                    {
                        double current = mystack.Peek();
                        mystack.Pop();
                        double current2 = mystack.Peek();
                        mystack.Pop();
                        mystack.Push(Math.Pow(current2,current));
                    }
                    else if (ma[i]=="/")
                    {
                        double current = mystack.Peek();
                        mystack.Pop();
                        double current2 = mystack.Peek();
                        mystack.Pop();
                        mystack.Push(current2/current);
                    }

                }
                
            }
            double resl = mystack.Peek();
            Console.Write(resl.ToString("N2"));
        }
         
       public static void Main()
        {
            binarytree BT = new binarytree();
            List<Node> nodes = new List<Node>();
            List<Tuple<int,string>> tplist  = new List<Tuple<int,string>>();
            List<Tuple<int,int>> lp = new List<Tuple<int,int>>();
            int v = int.Parse(Console.ReadLine());
            for (int i =0 ; i<v ; i++)
            {   
                var tok = Console.ReadLine().Split(' ');
                var tup = Tuple.Create(int.Parse(tok[0]),tok[1]);
                tplist.Add(tup);
            }
            int rootid = int.Parse(Console.ReadLine());
            for (int j =0 ;j< v-1 ; j++)
            {
                var tok =Console.ReadLine().Split(' ');
                var tup = Tuple.Create(int.Parse(tok[0]),int.Parse(tok[1]));
                lp.Add(tup);
            }
            for (int b=0 ; b<v ; b++)
            {
                Node nn = new Node(tplist[b].Item1);
                nodes.Add(nn);

            }
            
            for (int t=0 ; t<v-1 ; t++)
            {
                if (nodes[lp[t].Item1].left==null)
                {
                    nodes[lp[t].Item1].left = nodes[lp[t].Item2];
                }
                else
                {
                    nodes[lp[t].Item1].right = nodes[lp[t].Item2];
                }
            }
            BT.root = nodes[rootid];
            StringBuilder sb = new StringBuilder();
            StringBuilder result = postorder(rootid,nodes,tplist,sb);
            Console.Write(result);
            Console.WriteLine("");
            indorder(rootid,nodes,tplist);
            Console.WriteLine("");
            preorder(rootid,nodes,tplist);
            Console.WriteLine("");
            calculate(result.ToString());
            

        }
    }   
    
    
}