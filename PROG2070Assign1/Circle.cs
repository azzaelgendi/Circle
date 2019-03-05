/*Prog 2070-Quality Assurance 
 * Winter 2019
 * Assignment 1 ,Circle Class
 * Revision History :Azza Elgendy
 * Febrauary 3rd,2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Simple class for circle 
/// </summary>
namespace PROG2070Assign1
{
    public class Circle
    {
        //Class Variable and constant 
        private int radius;
        private double circumference;
        private const double pi = Math.PI;
        private double area;
        ////defult constructor set radius to 1
        public Circle()
        {
            this.radius = 1;
        }
        //non defult constructor set radius to user input
        public Circle(int radius)
        {
            this.radius = radius;
        }
        //Methods to work with the circle
        public int GetRadius()
        {
            
            return radius;
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
            return radius;
        }
        //Calculate the circle Circumferance
        public double GetCircumference()
        {
            circumference = pi * 2 * radius;
            return circumference;
        }
        //Calculate the circle area
        public double GetArea()
        {
            area = pi * radius * radius;
            return area;
        }
    }
}
