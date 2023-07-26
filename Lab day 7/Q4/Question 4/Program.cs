using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            int size = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] array1 = new int[size];
            int[] array2 = new int[size];

            for (int i = 0; i < size; i++)
            {
                array1[i] = random.Next(0, 100);
                array2[i] = random.Next(0, 100);
            }

            int scalarSum = 0;
            for (int i = 0; i < size; i++)
            {
                scalarSum += array1[i];
            }

            int[] vectorSum = new int[size];
            for (int i = 0; i < size; i++)
            {
                vectorSum[i] = array1[i] + array2[i];
            }

            int[] vectorProduct = new int[size];
            for (int i = 0; i < size; i++)
            {
                vectorProduct[i] = array1[i] * array2[i];
            }

            int scalarProduct = 0;
            for (int i = 0; i < size; i++)
            {
                scalarProduct += vectorProduct[i];
            }

            Console.WriteLine("Scalar sum: " + scalarSum);
            Console.Write("Vector sum: ");
            foreach (int value in vectorSum)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();

            Console.Write("Vector product: ");

            foreach (int value in vectorProduct)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Scalar product: " + scalarProduct);

            Console.ReadLine();
        }
    }
}
