using System;

namespace Binary_Search_Tree_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Display();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
