using System;

namespace bigestMatrixElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxElement = int.MinValue;
            int[,] matrixNumberes = new int[10, 10];
            int minValue = -100;
            int maxValue = 101;
            int maxElementChange = 0;

            Random random = new Random();

            for (int i = 0; i < matrixNumberes.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumberes.GetLength(1); j++)
                {
                    matrixNumberes[i, j] = random.Next(minValue, maxValue);
                    Console.Write(matrixNumberes[i,j] + "\t");

                    if(matrixNumberes[i,j] > maxElement)
                    {
                        maxElement = matrixNumberes[i,j];                       
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

            for (int i = 0; i < matrixNumberes.GetLength(0); i++)
            {
                for(int j = 0;  j < matrixNumberes.GetLength(1); j++)
                {                   
                    if(matrixNumberes[i,j] == maxElement)
                    {
                        matrixNumberes[i,j] = maxElementChange;
                    }

                    Console.Write(matrixNumberes[i,j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
