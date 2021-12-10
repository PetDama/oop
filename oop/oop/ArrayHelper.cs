namespace OOP1
{
    public class ArrayHelper
    {
        public static int[] Fibonacci(int n)
        {
            int[] F = new int[n];
            F[0] = 0;
            if (n == 0) return F;
            F[1] = 1;
            if (n == 1) return F;
            int i = 1;

            while (i < n - 1)
            {
                i++;
                F[i] = F[i - 1] + F[i - 2];

            }
            return F;
        }

        public static int Frecventa(int[] vector, int element)
        {
            int frecventa = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == element) frecventa++;

            }
            return frecventa;
        }

        public static bool Identitate(int[,] matrix)
        {
            bool esteIdentitate = true;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    if (row != col)
                    {
                        if (matrix[row, col] != 0)
                        {
                            esteIdentitate = false;
                        }
                    }
                    else if (matrix[row, col] != 1)
                    {
                        esteIdentitate = false;
                    }
                }
            }
            if (esteIdentitate == true)
                return true;
            else
                return false;
        }
    }
}