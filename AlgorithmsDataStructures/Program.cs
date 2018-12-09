using AlgorithmsDataStructures.DataStructures;
using AlgorithmsDataStructures.Sorts;
using System;
using System.Diagnostics;

namespace AlgorithmsDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            BinaryTree bst = new BinaryTree();
            int[] array = new int[] { 3, 8, 4, 1, 5, 2, 7, 9, 6 };
            for (int i = 0; i < array.Length; i++)
            {
                root = bst.Insert(root, array[i]);
            }
            bst.Traverse(root);
            Console.WriteLine("Hello World!");
            int SIZE = 20000;
            int[] a = new int[SIZE];

            Console.WriteLine("Generating random array with {0} values...", SIZE);

            Random random = new Random();

            Stopwatch watch = Stopwatch.StartNew();

            for (int i = 0; i < SIZE; i++)
            {
                a[i] = random.Next(10000);
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();
            Console.WriteLine("Filling the tree with {0} nodes...", SIZE);

            watch = Stopwatch.StartNew();

            for (int i = 0; i < SIZE; i++)
            {
                root = bst.Insert(root, a[i]);
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();
            Console.WriteLine("Traversing all {0} nodes in tree...", SIZE);

            watch = Stopwatch.StartNew();

            bst.Traverse(root);

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
