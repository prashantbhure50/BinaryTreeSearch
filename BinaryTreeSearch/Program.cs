using System;

namespace BinaryTreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Binary Search Tree Problem");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(1);
            binarySearch.Insert(31);
            binarySearch.Insert(42);
            binarySearch.Insert(54);
            binarySearch.Display();
            binarySearch.GetSize();
            bool result = binarySearch.IfExist(1, binarySearch);
            Console.WriteLine(result);

        }
    }
}
