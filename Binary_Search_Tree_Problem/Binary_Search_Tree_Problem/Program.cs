using System;

namespace Binary_Search_Tree_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BST1
            //BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            //bst.Insert(30);
            //bst.Insert(70);
            //bst.Display();
            //Console.ReadLine();
            //Console.ReadLine();

            //BST2
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(11);
            bst.Insert(65);
            bst.Insert(3);
            bst.Insert(16);
            bst.Insert(63);
            bst.Insert(67);
            bst.Display();
            Console.WriteLine("Size Of Binary Search Tree Is:" + bst.size());
            Console.ReadLine();
        }
    }
}
