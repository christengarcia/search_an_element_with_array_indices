/*
 *  C# Program to Search an element with Array Indices
 */

using System;

namespace search_an_element_with_array_indices
{
    class ArrayBinarySearch
    {
        static void Main(string[] args)
        {
            int[] ints = { 0, 10, 100, 1000, 1000000 };
            Console.WriteLine("Array indices and elements: ");
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("[{0}]={1, -5}", i, ints[i]);
            }
            Console.WriteLine();
            FindObject(ints, 25);
            FindObject(ints, 1000);
            FindObject(ints, 2000000);
            Console.ReadLine();
        }
    }
}
