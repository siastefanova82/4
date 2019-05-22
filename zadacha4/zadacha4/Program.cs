using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree a = new BinaryTree();
            int[] num = new int[] { 10, 4, 2, 4, 8, 2, 4, 77, 8, 0, 1, 6 };
            Node b = null;
            for (int i = 0; i < num.Length - 1; i++)
            {
                b = a.put(b, num[i]);
            }
            Console.WriteLine(a.MinValue(b));
            Console.WriteLine(a.MaxValue(b));
        }
    }
    public class Node
    {
        public int value;
        public Node min, max;

        public Node(int integer)
        {
            value = integer;
            min = max = null;
        }
    }
    public class BinaryTree
    {
        public Node put(Node root, int v)
        {
            if (root == null)
            {
                root = new Node(v);
            }
            else if (v < root.value)
            {
                root.min = put(root.min, v);
            }
            else
            {
                root.max = put(root.max, v);
            }

            return root;
        }

        public int MinValue(Node node)
        {
            Node rNode = node;

            while (rNode.min != null)
            {
                rNode = rNode.min;
            }
            return rNode.value;
        }
        public int MaxValue(Node node)
        {
            Node rNode = node;

            while (rNode.max != null)
            {
                rNode = rNode.max;
            }
            return rNode.value;
        }
    }
}