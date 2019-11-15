using System;

namespace ADSS_HW2

{
    class Program
    {
        static void Main(string[] args)
        {
            int i, numOfElements, counterOfPositive = 0, sumOfNegative = 0, userInput = 0;

            #region Exercise1

            Console.Write("Input the number of elements to store in the array: ");
            numOfElements = Convert.ToInt32(Console.ReadLine());

            int[] arrOfInts = new int[numOfElements];

            Console.Write($"Input {numOfElements} number of elements in the array:\n");
            for (i = 0; i < numOfElements; i++)
            {
                Console.Write($"arr[{i}] = ");
                arrOfInts[i] = Convert.ToInt32(Console.ReadLine());

                if (arrOfInts[i] >= 0)
                {
                    counterOfPositive++;
                }
                else
                {
                    sumOfNegative += arrOfInts[i];
                }
            }


            int[] b = new int[2];
            b[0] = counterOfPositive;
            b[1] = sumOfNegative;

            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            #endregion


            #region Exercise2

            do
            {
                Console.WriteLine("Enter an integer: ");
                userInput = Convert.ToInt32(Console.ReadLine());

            } while (userInput <= 10);

            Console.WriteLine("Integer greater than 10 detected.");


            #endregion
        }
    }
}