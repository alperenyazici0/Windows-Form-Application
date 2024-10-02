//**********************************************************************
//**                                                                  **
//**             STUDENT NAME: ALPEREN YAZICI                         **
//**             STUDENT NUMBER: B221202019                           **
//**********************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    internal class Point2D
    {
        public double x { get; set; } //Declaring variables
        public double y { get; set; }
        public Point2D()  //Default constructor
        {
            x = 0;
            y = 0;
        }
        public Point2D(double X,double Y)  //Constructor with parameters
        {
            x=X; y=Y;   
            
        }
        public void printCoordinates() //Method to print cartesian coordinates
        {
            Console.WriteLine("Coordinates of 2D point : ("+x+","+y+")");
        }

        public (double,double) calculatePolarCoordinates() //Method to calculate polar coordinates
        {
           double r = Math.Sqrt((x * x) + (y * y)); // Radius
          double  angle = Math.Atan2(y,x)*(180/Math.PI); //Angle in degrees
            return (r, angle);
        }
        public void calculateCartesianCoordinates(double r,double angle) //Method to calculate cartesian coordinates
        {
            double radyangle = angle * (Math.PI / 180);
            x=r*Math.Cos(radyangle);
            y=r*Math.Sin(radyangle);
        }
        public void printPolarCoordinates() { //Method to print polar coordinates
     
           var polar= calculatePolarCoordinates();
            Console.WriteLine("Polar Coordinates of 2D point: ("+polar.Item1+", "+polar.Item2+ "°)");

        }
       

    }
}
