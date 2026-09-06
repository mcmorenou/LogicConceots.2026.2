namespace Shared;
    public class Matrix

    {
        public static int[,] CreateA(int m, int n)
        {
            int[,] A = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = (i + 1) * j;
                }
            }

            return A;
        }
        public static int[,] CreateB(int n, int p)
        {
            int[,] B = new int[n, p];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    B[i, j] = (j + 1) * i;
                }
            }

            return B;
        }

        public static int[,] Multiply(int[,] A, int[,] B)
        {

            int m = A.GetLength(0);
            int n = A.GetLength(1);
            int p = B.GetLength(1);

            int[,] C = new int[m, p];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            return C;
        }
        public static void Show(int[,] matrix)
        {
            int filas = matrix.GetLength(0);
            int columnas = matrix.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }



