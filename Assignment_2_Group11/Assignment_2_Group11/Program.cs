
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment02;

internal class Program
{
    public static void Main(string[] args)
    {

        var rectangle = new Rectangle();


        ShowRectangleDetail("Dimensions of a Default Rectangle", rectangle);

        Console.WriteLine("\nEnter Length and Width of a new rectangle:");

        Console.WriteLine("Enter the Length of a Rectangle: ");

        // Input validation for length
        int userRectangleLength = Convert.ToInt32(Console.ReadLine());

         if (userRectangleLength <=0)
         {
             Console.WriteLine("Invalid input.");
        }

        rectangle.SetLength(userRectangleLength);


        Console.WriteLine("Enter the Width of a Rectangle: ");

        // Input validation for width
        int userRectangleWidth = Convert.ToInt32(Console.ReadLine());

        if (userRectangleWidth <= 0)
        {
            Console.WriteLine("Invalid input.");
        }
        rectangle.SetWidth(userRectangleWidth);

        ShowRectangleDetail("Rectangle According to  User's Dimensions", rectangle);
    }

    static void ShowRectangleDetail(string title, Rectangle rectangle)
    {
        Console.WriteLine("\n" + title + " - Length: " + rectangle.GetLength() + ", Width: " + rectangle.GetWidth());
        Console.WriteLine("Perimeter: " + rectangle.GetPerimeter() + ", Area: " + rectangle.GetArea());
    }

}