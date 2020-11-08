using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ITEA_HW_1
{
    class Program
    {
        static double Calculate(double cat1, double cat2) //Calculates angles
        {
            double res = Asin((cat1 / Sqrt(cat1 * cat1 + cat2 * cat2))) * 180 / Math.PI;
            return res;
        }
        static void Correct(ref string name) //Corrects name input if it has problems with upper/lower case letters. E.g. pAvlO -> Pavlo
        {
            name = name.ToLower();
            string temp = name.Substring(0, 1);
            temp = temp.ToUpper();
            name = temp + name.Substring(1, name.Length - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of the student:");//task 1
            string name = Console.ReadLine();
            Correct(ref name);
            Console.WriteLine($"Entered name is: {name}.");
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Enter coeffitients of a square equation (A, B and C): ");//task 2
            double a = 0;
            double b = 0;
            double c = 0;
            double res_1 = 0;
            double res_2 = 0;
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);
            if (b * b - 4 * a * c < 0)
            {
                Console.WriteLine("Im not so clever for D < 0!");
            }
            else
            {
                double D = b * b - 4 * a * c;
                res_1 = (0 - b + Sqrt(D)) / (2 * a);
                res_2 = (0 - b - Sqrt(D)) / (2 * a);
                Console.WriteLine($"X1: {res_1}, X2: {res_2}.");
            }
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Enter two legs of a triangle:");//task 3
            double cat_1 = 0;
            double cat_2 = 0;
            double gip = 0;
            double.TryParse(Console.ReadLine(), out cat_1);
            double.TryParse(Console.ReadLine(), out cat_2);
            if(cat_1 <= 0 || cat_2 <= 0)
            {
                Console.WriteLine("Incorrect input data. Please, restart the program.");
                return;
            }
            else
            {
                gip = Sqrt(cat_1 * cat_1 + cat_2 * cat_2);
                Console.WriteLine("Your answer: " + gip + ".");
            }
            Console.WriteLine(new string('=', 50));
            double angle_1 = 0;//task 4
            double angle_2 = 0;
            angle_1 = Calculate(cat_1, cat_2);
            angle_2 = Calculate(cat_2, cat_1);
            Console.WriteLine($"Your angles are: {angle_1}, {angle_2} and 90.");
            Console.ReadKey();
        }
    }
}
