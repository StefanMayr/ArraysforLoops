using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Declaration of an array with fixed values
            double[] Numbers = { 3.4, 1.2, 5.6 };

            // Access to the arrays parts (0,1,2)
            Console.WriteLine(Numbers[0]);
            Console.WriteLine(Numbers[1]);
            Console.WriteLine(Numbers[2]);

            // Dynamic array on the basis of an input
            Console.WriteLine("Please enter the size of the array:");
            string Input = Console.ReadLine();
            int ArraySize = int.Parse(Input);

            double[] OtherNumbers = new double[ArraySize];

            OtherNumbers[0] = 32;
            OtherNumbers[1] = 59;
            OtherNumbers[2] = 31;
            OtherNumbers[3] = 5;
            OtherNumbers[4] = 9;
            OtherNumbers[29] = 100;

            // Finding a Max value in an array ****************************************
            double BiggestValue = OtherNumbers[0];
            for (int i = 0; i < OtherNumbers.Length; i++)
            {
                if (BiggestValue < OtherNumbers[i])
                {
                    BiggestValue = OtherNumbers[i];
                }

                Console.WriteLine("Number at {0} is {1}",i,OtherNumbers[i]);
            }
            Console.WriteLine("The largest value = " + BiggestValue);

        // Summing up all values in an array **************************************

            // Array with numbers to sum up
            double[] NumbersToSum = { 1, 2, 3, 4, 5, 6, 7 };

            // Variable for storing the sum
            double Sum = 0.0;

            // For loop to fetch one number after each other
            for (int i = 0; i < NumbersToSum.Length; i++)
            {
                // Add current number at NumbersToSum[i] to variable Sum
                // and store the sum in the Variable Sum
                Sum = Sum + NumbersToSum[i];
            }
            Console.WriteLine("Sum = {0}",Sum);

            // Reverse output of an array *********************************************
            for (int i = OtherNumbers.Length-1; i >= 0 ; i--)
            {
                Console.WriteLine("Number at {0} is {1}", i, OtherNumbers[i]);
            }

            // Array with texts / strings
            string[] Texts = { "Hello", "World" };

        }
    }
}
