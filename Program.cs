using System;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            MyBinaryTree<int> MyBinaryTree = new MyBinaryTree<int>(56);
            MyBinaryTree.Insert(30);
            MyBinaryTree.Insert(70);
            MyBinaryTree.Insert(22);
            MyBinaryTree.Insert(40);
            MyBinaryTree.Insert(60);
            MyBinaryTree.Insert(95);
            MyBinaryTree.Insert(15);
            MyBinaryTree.Insert(65);
            .Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(65);
            binarySearch.Insert(69);
            binarySearch.Display();
        }
    }
}