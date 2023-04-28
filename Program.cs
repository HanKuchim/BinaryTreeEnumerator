using BinaryTreeNew;
using System;
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var tree = new Tree();
        tree.Add(5);
        tree.Add(3);
        tree.Add(7);
        tree.Add(1);
        tree.Add(4);
        tree.Add(6);
        tree.Add(8);
        tree.Add(11);
        tree.Add(2);
        tree.Add(9);
        tree.Add(12);

        Console.WriteLine("Tree:");
        tree.PrintTree();

        Console.WriteLine("Nodes with data 4:");
        foreach (var node in tree.Search(4))
        {
            Console.WriteLine(node);
        }

        Console.ReadKey();
    }
}