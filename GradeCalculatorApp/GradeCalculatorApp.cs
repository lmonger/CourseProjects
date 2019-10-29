using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculatorApp
{
    class GradeCalculatorApp
    {
        static void Main(string[] args)
        {
            bool moreGrades = true;
            double gradeSum = 0;
            int numGrades = 0;
            double gradeAvg = 0;
            int grade = 0;            
            string usrInput = " ";

            while (moreGrades != false)
            {
                do
                {
                    if (grade < 0 || grade > 100)
                    {
                        Console.WriteLine("\n\n ERROR. You have entered an invalid grade.");
                    }

                    Console.Write("\n\n Please enter a grade between 0 and 100: ");
                    grade = Convert.ToInt32(Console.ReadLine());
                }
                while (grade < 0 || grade > 100);

                gradeSum = gradeSum + grade;

                numGrades++;

                Console.Write("\n Would you like to enter another grade?: ");
                usrInput = Console.ReadLine();

                if (usrInput == "n")
                {
                    moreGrades = false;
                }
            }

            gradeAvg = gradeSum / numGrades;

            Console.WriteLine("\n Your Average is: {0}.", gradeAvg);

            if (gradeAvg <= 60)
            {
                Console.WriteLine("\n Your final grade is F.");
            }
            else if (gradeAvg > 60 && gradeAvg <= 69) 
            {
                Console.WriteLine("\n Your final grade is D.");
            }
             else if (gradeAvg > 69 && gradeAvg <= 79)
            {
                Console.WriteLine("\n Your final grade is C.");
            }
             else if (gradeAvg > 79 && gradeAvg <= 89)
            {
                Console.WriteLine("\n Your final grade is B.");
            }
             else if (gradeAvg > 89 && gradeAvg <= 100)
            {
                Console.WriteLine("\n Your final grade is A.");
            }
            else
            {
                Console.WriteLine("\n No grades entered.");
            }

            Console.ReadLine();
        }
    }
}
