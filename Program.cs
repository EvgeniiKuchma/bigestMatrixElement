using System;

namespace bigestMatrixElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxElement = int.MinValue;
            int[,] matrixA = new int[10, 10];

            Random random = new Random();

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = random.Next(-100, 101);
                    Console.Write(matrixA[i,j] + "\t");

                    if(matrixA[i,j] >= maxElement)
                    {
                        maxElement = matrixA[i,j];                       
                    }
                }

                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            Console.WriteLine(maxElement + " - max element");

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            for (int i = 0;i < matrixA.GetLength(0); i++)
            {
                for(int j = 0;  j < matrixA.GetLength(1); j++)
                {                   
                    if(matrixA[i,j] == maxElement)
                    {
                        matrixA[i,j] = 0;
                    }

                    Console.Write(matrixA[i,j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
