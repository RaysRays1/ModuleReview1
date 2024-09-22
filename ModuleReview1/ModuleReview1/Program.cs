using System;
using System.Collections.Generic;



namespace Module1
{
    public class program
    {
        static void Main(string[] args)
        {
            //AreaOfSquare();
            //AreaOfRectangle();
            //TriangelArea();
            //RadiusOfCircle();
            
            
            


            static void RadiusOfCircle()
            {
                
                // find the radius of circle
                // prompt
                Console.WriteLine("Enter in a radius");
                
                // user input into a string
                string userInput = Console.ReadLine();
                
                // parse sting into a double
                double parseRadius = double.Parse(userInput);
                
                // asking for the radius of circle
                // double radius = AreaOfCircle
                // console.writeline(answer);
                
                Console.WriteLine("please input the radius value for a circle");
                double radius = double.Parse(Console.ReadLine());
                double answer = AreaOfCircle(radius);
                Console.WriteLine($"The value of the area of the circle is {answer}");
            }
        }

        public static double AreaOfCircle(double radius) 
        {
            // Math.PI * Math.Pow(radius, 2);
            return (Math.PI * Math.Pow(radius, 2));
        }



        static void TriangelArea()
        {
            // input base and height
            Console.WriteLine("Enter the base of the Triangle");
            double baseOfTrianle = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the height of the Triangle");
            double heightOfTriangle = Convert.ToDouble(Console.ReadLine());
            
            // calculate the area
            double area = baseOfTrianle * heightOfTriangle / 2;
            
            // output the area
            Console.WriteLine($"The area of the Triangle is: {area}");

        }

        static void AreaOfRectangle()
        {
            //input length and width
            Console.WriteLine("Enter the length of Rectangle");
            double lengthOfRectangle = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the width of Rectangle");
            double widthOfRectangle = Convert.ToDouble(Console.ReadLine());
            
            // calculate the area
            double area = lengthOfRectangle * widthOfRectangle;
            
            // output
            Console.WriteLine($"The area of Rectangle is: {area}");
        }

        
        static void AreaOfSquare()
        {
            
            // input area of square
            Console.WriteLine("Enter the area of Square");
            double areaOfSquare = Convert.ToDouble(Console.ReadLine());
            
            // calculate the area
            double area = areaOfSquare * 2;
            
            // output
            Console.WriteLine($"The area of Square is: {area}");
        }

    }
}

