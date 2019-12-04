using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public static class ArrayKeeper
    {
        public static List<int[,]> Matrices = new List<int[,]>();

        public static void Add(int[,] arr)
        {
            Matrices.Add(arr);
        }
        public static void PrintListArray()
        {
            Console.WriteLine("\nTotal number of items in the collection: {0}\n", Matrices.Count);
            foreach (var arr in Matrices)
            {
                Console.WriteLine("================================");
                int rows = arr.GetUpperBound(0) + 1;
                int columns = arr.Length / rows;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{arr[i, j]} \t");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void PrintTriangularMatrix()
        {
            foreach(var arr in Matrices)
            {
                Console.WriteLine("================================");
                Console.WriteLine("Lower triangular matrix:");
               
                int rows = arr.GetUpperBound(0) + 1;
                int columns = arr.Length / rows;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (i < j)
                        {
                            Console.Write($"0 \t");
                        }
                        else Console.Write($"{arr[i, j]} \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("================================");
                Console.WriteLine("Upper triangular matrix:");
                
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (i>j)
                        {
                            Console.Write($"0 \t");
                        }
                        else Console.Write($"{arr[i, j]} \t");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void TransposeMatrices()
        {
            Console.WriteLine("\nTotal number of items in the collection: {0}\n", Matrices.Count);
            foreach (var arr in Matrices)
            {
                Console.WriteLine("================================");
                
                int rows = arr.GetLength(0);
                int columns = arr.GetLength(1);
                var result = new int[columns, rows];
                for (int i = 0; i < columns; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        result[i, j] = arr[j, i];
                        Console.Write($"{result[i, j]} \t");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void Delete(int target)
        {
            for (int i = 0; i < Matrices.Count; ++i)
            {
                if (i + 1 == target)
                {
                    Matrices.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public class ArrayTwoDimensional
    {
        public int n;
        public int[,] array;
        public ArrayTwoDimensional(int n)
        {
            this.n = n;
        }

        public static void CreateANewArray(int n)
        {
            int[,] array = new int[n, n];
            Random rand = new Random();
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rand.Next(100);
                    
                }
            }
            ArrayKeeper.Add(array);
        }
        
            
        public static void PrintArray(int[,] array)
        {
            var n = array.Length-1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }

        }

    }
}
