using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize 2D Array
            int[,] myArray = new int[,] {{1,5},
                                         {4,8},
                                         {33,33},
                                         {43,1},
                                         {8,87},
                                         {41,8},
                                         {3,1},
                                         {32,10}};

            //get number of rows and columns
            int numOfRows = myArray.GetLength(0);
            int numOfColumns = myArray.GetLength(1);

            //assign index to both lowest and highest
            int lowest = myArray[0, 0];
            int highest = myArray[0, 0];

            //loop through outer loop = number of rows
            for (int i = 0; i < numOfRows; i++)
            {
                //loop through inner loop = number of columns
                for (int c = 0; c < numOfColumns; c++)
                {
                    //get current number e are on
                    int number = myArray[i, c];

                    //check if the number is lower; if so, replace lowest with number

                    if (number < lowest)
                        lowest = number;

                    //check if the number is higher; if so, replace highest with number

                    if (number > highest)
                        highest = number;
                }
            }

            Console.WriteLine("Lowest number is {0}", lowest);
            Console.WriteLine("Highest number is {0}", highest);

            Console.ReadKey();
        }
    }
}
