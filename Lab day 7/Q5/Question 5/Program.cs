using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array size: ");
            int arraySize = Convert.ToInt32((Console.ReadLine()));

            arrayClass ArrayClass = new arrayClass(arraySize);

            ArrayClass.GetUserInputs();

            ArrayClass.DisplayArray();

            Console.ReadLine();
        }
    }
}
