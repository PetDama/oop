using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A se introduce numar valori cerute din" +
                " sirul Fibonacci");
            int n;
            n = Int32.Parse(Console.ReadLine());

            int[] vector = ArrayHelper.Fibonacci(n);

            for (int i = 0; i < vector.Length; i++)
                Console.WriteLine(vector[i] + " ");

            Console.WriteLine("Să se introducă numărul de elemente din vector");

            int nr = Int32.Parse(Console.ReadLine());
            int[] vector1 = new int[nr];

            for (int i = 0; i < nr; i++)
            {
                Console.Write($"vector1[{i}]");
                vector1[i] = Int32.Parse(Console.ReadLine());

            }
            Console.WriteLine("Să se introducă valoarea căutată");
            int element = Int32.Parse(Console.ReadLine());

            Console.WriteLine(ArrayHelper.Frecventa(vector1, element));


            Console.WriteLine("Să se introducă numărul de linii din matrice");

            int n1 = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[n1, n1];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"matrix[{row},{col}]:");
                    matrix[row, col] = Int32.Parse(Console.ReadLine());

                }
            }
            if (ArrayHelper.Identitate(matrix) == true)
                Console.WriteLine("Este matrice identitate");
            else
                Console.WriteLine("Nu este matrice identitate");
        }
    }
}