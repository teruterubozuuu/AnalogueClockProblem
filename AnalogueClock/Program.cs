using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogueClock
{
    internal class Program
    {
          static double LesserAngle(int hours, int minutes)
        {
            //hour hand solution
            double angleHH = 0.5 * (hours * 60 + minutes);

            //minute hand solution
            double angleMH = 6* minutes;

            //difference between Angle of Minute Hand and Angle of Hour Hand
            double diffAngles = Math.Abs(angleMH - angleHH);

            return Math.Min(360 - diffAngles, diffAngles);
            
        }
        static void Main(string[] args)
        {
            int hours;
            int minutes;
            //do while loop that repeats the program if the input is wrong
            do { 
            //Prompts the user to input hours and minutes
            Console.Write("\nEnter no. of hours: ");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no. of minutes: ");
            minutes = Convert.ToInt32(Console.ReadLine());
                //validation code
                 if (hours < 0 || minutes < 0)
                {
                Console.WriteLine("Wrong Input. Please  Try again.");
                }
            }while ( hours < 0 || minutes < 0);

            //Output of the program
            Console.WriteLine("The time you entered is " + hours + ":" + minutes);
            Console.Write("The lesser angle between " + hours + " hour/s" + " and " + minutes + " minute/s" + " is " + LesserAngle(hours, minutes) + " degrees.");


            Console.ReadKey();
        }
    }
}
