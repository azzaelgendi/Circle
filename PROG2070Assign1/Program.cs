/*Prog 2070-Quality Assurance 
 * Winter 2019
 * Assignment 1 ,Circle App
 * Revision History :Azza Elgendy
 *February 3rd,2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// this program to create and work with single circle object
/// </summary>

namespace PROG2070Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            //program variables
            int radius = 0;
            int menu = 0;
            bool correct = true;
            bool menueBool = true;
            //circle new object
            Circle circle = new Circle();
            do
            {
                //Ask user for entry
                Console.WriteLine("Please Enter the radius of your circle and press Enter afterwards: ");
                Console.WriteLine("___________________________________________");
                try
                {
                    //read the user entry
                    radius = int.Parse(Console.ReadLine());

                    if (radius < 0)
                    {
                        //error message
                        Console.WriteLine("Please Enter an integer greater than zero");
                    }
                    else
                    {
                        correct = false;

                    }
                }
                catch (FormatException ex)
                {
                    //error message
                    Console.WriteLine("Error:Please Enter an integer ");
                }
            } while (correct);




            do
            {
                //showing a menu to work with the circle
                Console.WriteLine("___________________________________________");
                Console.WriteLine("Please Choose from the menu");
                Console.WriteLine("Enter the correct menu number");
                Console.WriteLine("1-Get Circle Radius");
                Console.WriteLine("2-Change Circle Radius");
                Console.WriteLine("3-Get Circle Circumference");
                Console.WriteLine("4-Get Circle Area");
                Console.WriteLine("5-Exit");
                Console.WriteLine("___________________________________________");
                try
                {
                    //read the menu
                    menu = int.Parse(Console.ReadLine());
                    menueBool = false;
                }
                catch (Exception)
                {
                    //error message
                    Console.WriteLine(" menu number must be from 1-5");

                }
                //switch the menu 
                switch (menu)
                {
                    case 1:
                        circle.GetRadius();
                        Console.WriteLine("The Radius is-----" + radius);
                        break;
                    case 2:
                        circle.SetRadius(radius);
                        Console.WriteLine("The Radius is-----" + radius);
                        break;
                    case 3:
                        circle.GetCircumference();
                        Console.WriteLine("The Circumference is-----" + circle.GetCircumference());
                        break;
                    case 4:
                        circle.GetArea();
                        Console.WriteLine("The area is-----" + circle.GetArea());
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        //error message
                        Console.WriteLine("Error Please choose from 1-5");
                        break;
                }
            } while (menueBool == false);
            Console.Read();
        }
    }
}
}
