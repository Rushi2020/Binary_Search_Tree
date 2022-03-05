// Create Binary Search Tree

// Binary serach tree
using System;

namespace Binary_Search_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary search tree");

            MyBinaryTree<int> myBinaryTree = new MyBinaryTree<int>(56);
            myBinaryTree.Insert(56);
            myBinaryTree.Insert(30);
            myBinaryTree.Insert(70);

            myBinaryTree.Display();

        }
    }
}