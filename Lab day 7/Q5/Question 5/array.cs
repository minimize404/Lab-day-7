using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class arrayClass
    {
        private int[] array;

        public arrayClass(int arraySize)
        {
            array = new int[arraySize + 1];
        }

        public void GetUserInputs()
        {
            for (int i = 0; i < array.Length; i = i+2)
            {
                int value = Convert.ToInt32((Console.ReadLine()));
                array[i] = value;
                array[i+1] = 0;
            }
        }

        public void DisplayArray()
        {
            Console.WriteLine();

            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
