using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_0
{
    internal class Program
    {
        static double LowValidation(string prompt)
        {
            double number;
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? "";
                if (!double.TryParse(input, out number) || number <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            } while (number <= 0);

            return number;
        }

        static double HighValidation(string prompt, double lowNumber)
        {
            double number = lowNumber - 1; 
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? string.Empty;
                if (input == null || !double.TryParse(input, out number) || number <= lowNumber)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number that is greater than {0}.", lowNumber);
                }
            } while (number <= lowNumber);

            return number;
        } 

        static void SumNumbersFromFile(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    double sum = 0;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (double.TryParse(line, out double number))
                        {
                            sum += number;
                        }
                        else
                        {
                            Console.WriteLine($"'{line}' is not a valid number and will be skipped.");
                        }
                    }
                    Console.WriteLine($"The sum of the numbers in the file is {sum}.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        static bool IsPrime(double number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (double)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }


        static void Main(string[] args)
        {
            double lowNumber = LowValidation("Please enter a number (positive): ");
            double highNumber = HighValidation("Please enter a number greater than the low number: ", lowNumber);

            double difference = highNumber - lowNumber;
            Console.WriteLine(string.Format("The difference between {0} and {1} is {2}", highNumber, lowNumber, difference));

            List<double> rangeList = new List<double>();
            for (double i = lowNumber; i <= highNumber; i++)
            {
                rangeList.Add(i);
            }

            Console.WriteLine("The prime numbers are: ");
            foreach (double number in rangeList)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number);
                }
            }

            using (StreamWriter writer = new StreamWriter("numbers.txt"))
            {
                for (int i = rangeList.Count - 1; i >= 0; i--)
                {
                    writer.WriteLine(rangeList[i]);
                }
            }

            string filePath = "numbers.txt";
            SumNumbersFromFile(filePath);

            Console.WriteLine();
        }
    }
}
