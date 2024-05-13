namespace Prog120_Assignment_Arrays
{
    internal class Program
    {
        static double[] assignmentArray;

        static void Main(string[] args)
        {
            // Name: Vicky Le
            // Class: Programming 120
            // Date: 5/11/24
            // Assignment: Arrays

            Console.WriteLine("Enter the desired size of the array: ");
            int arraySize = int.Parse(Console.ReadLine());

            // Initialize array with user-defined size
            assignmentArray = new double[arraySize];
            Random random = new Random();

            // Populate array with random numbers between 1 and 100
            for (int i = 0; i < arraySize; i++)
            {
                assignmentArray[i] = random.Next(1, 101);
            }

            // Display array elements
            Console.Write("The array elements are: ");
            DisplayArray(assignmentArray);

            // Perform calculations and display results
            Console.WriteLine($"The sum of the array elements is: {CalculateSum(assignmentArray)}");
            Console.WriteLine($"The average of the array elements is: {CalculateAverage(assignmentArray):F2}");
            Console.WriteLine($"The largest number in the array is: {FindLargest(assignmentArray)}");
            Console.WriteLine($"The smallest number in the array is: {FindSmallest(assignmentArray)}");
            Console.WriteLine($"There are {CountEvenNumbers(assignmentArray)} even numbers in the array.");
            Console.WriteLine($"There are {CountOddNumbers(assignmentArray)} odd numbers in the array.");


        } // Main
        public static void DisplayArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length -1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        // Calculate sum of array elements
        static double CalculateSum(double[] array)
        {
            double sum = 0;
            foreach (var num in array)
            {
                sum += num;
            }
            return sum;
        }

        // Calculate average of array elements
        static double CalculateAverage(double[] array)
        {
            double sum = CalculateSum(array);
            return sum / array.Length;
        }

        // Find the largest number in the array
        static double FindLargest(double[] array)
        {
            double max = array[0];
            foreach (var num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        // Find the smallest number in the array
    static double FindSmallest(double[] array)
        {
            double min = array[0];
            foreach (var num in array)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        // Count even numbers in the array
        static int CountEvenNumbers(double[] array)
        {
            int count = 0;
            foreach (var num in array)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        // Count odd numbers in the array
        static int CountOddNumbers(double[] array)
        {
            int count = 0;
            foreach (var num in array)
            {
                if (num % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    } // Class
} // Namespace
