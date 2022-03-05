using System;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            MyBinaryTree<int> myBinaryTree = new MyBinaryTree<int>(56);
            myBinaryTree.Insert(30);
            myBinaryTree.Insert(70);
            myBinaryTree.Insert(22);
            myBinaryTree.Insert(40);
            myBinaryTree.Insert(60);
            myBinaryTree.Insert(95);
            myBinaryTree.Insert(15);
            myBinaryTree.Insert(65);
            myBinaryTree.Insert(3);
            myBinaryTree.Insert(16);
            myBinaryTree.Insert(65);
            myBinaryTree.Insert(69);
            myBinaryTree.Display();

            bool result = myBinaryTree.IfExists(63, myBinaryTree);
            Console.WriteLine(result);
        }
    }
}