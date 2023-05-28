using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using System;

namespace Q1
{
    
    public class bst
    {
        public bst(Node n)
        {
            root = n;
        }
        public class Node
        {
            public int data;
            public Node right;
            public Node left;
            public Node(int data)
            {
                this.data = data;
                this.right = this.left = null;
            }
        }
        
        public Node root;

        public static Node insert(Node root , int nd)
        {
            if(root==null)
            {
                root  = new Node(nd);
            }
            if(nd > root.data)
            {
                
                root.right = insert(root.right,nd);
            }
            else if(nd<root.data)
            {
                root.left = insert(root.left,nd);
                
            }
            return root;

        }

        public static bool Search(Node root, int ts)

        {
            if (root == null)
                {Console.WriteLine("False");
                return false;}

            if (root.data==ts)
            {
                Console.WriteLine("True");
                return true;

            }
        
            if (ts<root.data)          
            {
                return Search(root.left,ts);       
            }
            else if(ts>root.data)      
            {
                return Search(root.right,ts);                       
            }
            Console.WriteLine("False");
            return false;
            
        }

        
        public int traverse(Node root, int t)
        {
            
            if(root.left.data==t || root.right.data==t)
                return root.data;
            else
            {
                try
                {
                    traverse(root.left, t);
                }
                catch
                {
                    return 0;
                }
                try
                {
                     traverse(root.right, t);
                }
                catch
                {
                     return 0;
                }
            }
            return 0;
        }
        
        public static int Successor(Node root) {
        int min = root.data;
        while (root.right != null)
         {
            min = root.right.data;
            root = root.right;
        }
        return min;
        }
        
        public static Node delete(Node root,int td)
        {
            
            if(root == null)
            {
                return root;
            }
            else if(td>root.data)
            {
                root.right = delete(root.right,td);
            }
            else if(td<root.data)
            {
                root.left = delete(root.left,td);
            }
             else
            {
                if(root.left == null)
                {
                    return root.right;
                }
                else if(root.right == null)
                {
                    return root.left;
                }
                root.data = Successor(root.left);
                root.left = delete(root.left,root.data);
            }
            
            return root;

        }

        public static void preorder(Node root)
        {
            // if (root == null)
            // {
            //     return;
            // }
            if (root != null)
            {
                Console.Write(root.data + " ");
                try
                {
                    preorder(root.left);
                }
                catch
                {
                    return;
                }

                try
                {
                    preorder(root.right);
                }
                catch
                {
                    return;
                }
            }
        }
        public static void Main()
        {
            int v = int.Parse(Console.ReadLine());
            string[] postorder = Console.ReadLine().Split(' ');
            int[] list = Array.ConvertAll(postorder, int.Parse);
            Node node = new Node(list[list.Length - 1]);
            bst mybst = new bst(node);

            for (int i=v-1; i >= 0 ;i--)
            {
                insert(mybst.root,int.Parse(postorder[i]));
            }

            int todelete = int.Parse(Console.ReadLine());
            delete(mybst.root,todelete);
            int toinsert = int.Parse(Console.ReadLine());
            insert(mybst.root,toinsert);
            int tosearch = int.Parse(Console.ReadLine());
            Search(mybst.root,tosearch);
            preorder(mybst.root);
        }

    }
}