// See https://aka.ms/new-console-template for more information
using Assignment2._2._3;
using System.Diagnostics;

char userChoice;

do
{
    Console.WriteLine("Would you like to find the area of a circle or a square? ");
    Console.WriteLine("Press \"s\" for square: ");
    Console.WriteLine("Press \"c\" for circle: ");

    userChoice = Convert.ToChar(Console.ReadLine().ToLower());
    if (userChoice == 'c')
    {
        Console.WriteLine("Please enter the radius of the circle: ");
        double circleNum1 = Convert.ToDouble(Console.ReadLine());
        Circle circle1 = new Circle(circleNum1);
        Console.WriteLine();
        Console.WriteLine($"The area of a circle is {circle1.CalculateArea(circleNum1)}");
    }
    else if (userChoice == 's')
    {
        Console.WriteLine("Please enter the side one of the square: ");
        double squareSide1 = Convert.ToDouble(Console.ReadLine());
        Square square1 = new Square(squareSide1);
        Console.WriteLine();
        Console.WriteLine($"The area of the square is {square1.CalculateArea(squareSide1)}");
    }
}
while (userChoice != 'c' && userChoice != 's');




