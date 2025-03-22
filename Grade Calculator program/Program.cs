using System;
using System.Security.Cryptography.X509Certificates;

namespace Grade_Calculator_program
{
    class Program
    {
        private static int grade;

        static void Main(string[] args)
        {
            // Set an inter array and ask the user to input marks for four subjects

            int[] marks = new int[4];

            Console.WriteLine("Enter marks for Maths: ");
            marks[0] = Convert.ToInt32(Console.ReadLine());

            //set marks maximum
            if (marks[0] > 100)
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
            Console.WriteLine($"The average marks are: {average}");

            // Calculate the grade
            CalculateGrade(average);
        }

        // Method for calculating average
        static double CalculateAverage(int[] marks)
        {
            double sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return sum / marks.Length;
        }

        // Method for calculating grade
        static void CalculateGrade(double average)
        {
            string grade;
            if (average >= 90)
            {
                grade = "A+";
                Console.WriteLine("Grade: A+");
            }
            else if (average >= 80)
            {
                grade = "A";
                Console.WriteLine("Grade: A");
            }
            else if (average >= 70)
            {
                grade = "B";
                Console.WriteLine("Grade: B");
            }
            else if (average >= 60)
            {
                grade = "C";
                Console.WriteLine("Grade: C");
            }
            else if (average >= 50)
            {
                grade = "D";
                Console.WriteLine("Grade: D");
            }
            else
            {
                grade = "F";
                Console.WriteLine("Grade: F");
            }

            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent! Your Grade is A");
                    break;
                case "B":
                    Console.WriteLine("Good Your Grade is B");
                    break;
                case "C":
                    Console.WriteLine("Satisfactory. Your Grade is C");
                    break;
                case "D":
                    Console.WriteLine("Pass Your Grade is D");
                    break;
                case "F":
                    Console.WriteLine("Fail Your Grade is F");
                    break;
            }
            Console.ReadLine();
        }
    }
}
            