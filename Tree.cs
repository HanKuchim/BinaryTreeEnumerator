using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeNew
{
    public class Tree
    {
        private Node Root;

        public Tree()
        {
            Root = null;
        }

        public void Add(int data)
        {
            Root = Insert(Root, data);
        }

        private Node Insert(Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);
            }
            else if (data < node.Data)
            {
                node.Left = Insert(node.Left, data);
            }
            else
            {
                node.Right = Insert(node.Right, data);
            }

            return node;
        }

        public IEnumerable<Node> Search(int data)
        {
            foreach (var node in this)
            {
                if (node.Data == data)
                {
                    yield return node;
                }
            }
        }

        private Node Find(Node node, int data)
        {
            if (node == null || node.Data == data)
            {
                return node;
            }

            if (data < node.Data)
            {
                return Find(node.Left, data);
            }

            return Find(node.Right, data);
        }
        
        public void PrintTree()
        {
            DrawTree(Root, "");
        }

        private void DrawTree(Node node, string prefix)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(prefix + "+--" + node.Data);
            DrawTree(node.Left, prefix + "|  ");
            DrawTree(node.Right, prefix + "|  ");
        }
        public IEnumerator<Node> GetEnumerator()
        {
            return new TreeEnumerator(Root);
        }
    }
}
