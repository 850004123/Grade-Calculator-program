using System;
using System.Security.Cryptography.X509Certificates;

namespace Grade_Calculator_program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set an inter array and ask the user to input marks for four subjects

            int[] marks = new int[3];

            Console.WriteLine("Enter marks for Maths: ");
            marks[0] = Convert.ToInt32(Console.ReadLine());
            
            //set marks maximum
            if (marks[0] >100)
            {
                Console.WriteLine("Marks cannot be greater than 100");
                return;
            }
                Console.WriteLine("Enter marks for Physics: ");
            marks[1] = Convert.ToInt32(Console.ReadLine());

            if (marks[1] > 100)
            {
                Console.WriteLine("Marks cannot be greater than 100");
                return;
            }

            Console.WriteLine("Enter marks for Chemistry: ");
            marks[2] = Convert.ToInt32(Console.ReadLine());
            if (marks[2] > 100)
            {
                Console.WriteLine("Marks cannot be greater than 100");
                return;
            }

            Console.WriteLine("Enter marks for Computer Science: ");
            marks[3] = Convert.ToInt32(Console.ReadLine());
            if (marks[3] > 100)
            {
                Console.WriteLine("Marks cannot be greater than 100");
                return;
            }

            // Calculate the average of the marks

            double average = CalculateAverage(marks);
            Console.WriteLine($"The average marks are: ");

            // Method for calculating average

            double CalculateAverage(int[] marks);



            
        }
    }
}