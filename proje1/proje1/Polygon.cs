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
    internal class Polygon
    {
        public Point2D center { get; set; } //Properties
        public double length { get; set; }
        public int numberOfEdges { get; set; }

        private double inangle;
        private List<Point2D> corners; //List to store corner points

        public Polygon()  //Constructor with default values
        {
            center = new Point2D(0, 0);
            length = 4;
            numberOfEdges = 5;
            corners = new List<Point2D>();

        }

        public Polygon(Point2D incenter, double inlength,int innumberOfEdges) //Constructor with parameters
        {
            center = incenter;
            length = inlength;
            numberOfEdges = innumberOfEdges;
            this.inangle = 0;  //Start form 0 degree
           corners=new List<Point2D>();  
        }

        public List<Point2D> calculateEdgeCoordinates() // Method to calculate edge coordinates
        {

            if (corners.Count == 0) // If edge points have not been calculated yet
            {
                double angleincrease = 360.0 / numberOfEdges;
                double inangle = 0; // Constant starting angle

                for (int i = 0; i < numberOfEdges; i++)
                {
                    double angle = inangle + i * angleincrease;
                    double radyan = angle * (Math.PI / 180);  // Degree to radian
                    double X = center.x + length * Math.Cos(radyan);
                    double Y = center.y + length * Math.Sin(radyan);
                    corners.Add(new Point2D(X, Y)); // Add the edge points to list
                }
            }

            return corners; 
        }

        public void rotatePolygon(double angle) // Method to rotate polygon by a specified angle
        {
            inangle = angle * Math.PI / 180.0; // Angle to radian
            for (int i = 0; i < corners.Count; i++)
            {
                var corner = corners[i];
                double xNew = center.x + (corner.x - center.x) * Math.Cos(inangle) - (corner.y - center.y) * Math.Sin(inangle);
                double yNew = center.y + (corner.x - center.x) * Math.Sin(inangle) + (corner.y - center.y) * Math.Cos(inangle);
                corners[i] = new Point2D(xNew, yNew); //Add new corner coordinates to list
            }
        }
       public void ResetRotation()
        {
            inangle=0; // Reset the angle
        }
    }
}
