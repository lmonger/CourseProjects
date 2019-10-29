/*GeometryCalculator.cs
 * Author: Lorrie Monger
 * PRG 205 Week2 Assignment
 * Date: October 11, 2019
 * Promts user for height and width then calculates the area and perimeter*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            int height = 0;
            int width = 0;
            int areaCalc = height * width;
            int perimeterCalc = height * 2 + width * 2;           

            GeometryCalculator calculateArea = new GeometryCalculator();
            GeometryCalculator calculatePerimeter = new GeometryCalculator();
            
            height = calculateArea.GetValue("\nPlease enter the height of the rectangle as a whole number: ");
            width = calculateArea.GetValue("\nPlease enter the width of the rectangle as a whole number: ");
            areaCalc = calculateArea.areaCalc(height, width);
            perimeterCalc = calculatePerimeter.areaCalc(height, width);
            calculatePerimeter.DisplayResult(height, width, areaCalc, perimeterCalc);
            Console.ReadLine();
            
        }
        //Gets user input and returns it.
         int GetValue(string message)

         {
            int height;           

            Console.Write(message);
            height = Convert.ToInt32(Console.ReadLine());

            return height;            
         }

        //Calculates Area
        int areaCalc(int h, int w)
         {
            int area = h * w;

            return area;
         }

        //Calculates Perimeter
         protected int perimeterCalc(int h, int w)
         {
            int perimeter = h * 2 + w * 2;

            return perimeter;
         }

        //Displays height, width, area and perimeter of a ractangle.
        protected void DisplayResult(int height, int width, int area, int perimeter)

        {            
            Console.WriteLine("\nThe Height, Width, Area and Perimeter of your rectangle are as follows:");
            Console.WriteLine("\n========================================");
            Console.WriteLine("\n= Height -- Width -- Area -- Perimeter =");
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("\n=   {0}  -- {1}   --  {2} --    {3}    =", height, width, area, perimeter);
            Console.WriteLine("\n========================================");
            
        }
    }
}
