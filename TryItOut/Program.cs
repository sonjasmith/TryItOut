using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //int score;
            //score = 0;
            //Console.WriteLine(score);

            //int number = 3;
            //Console.WriteLine(number); //Console.WriteLine prints lots of things not just text.

            //int a = 5;
            //int b = 2;

            //b = a;
            //a = -3;
            //Console.WriteLine("-3");
            //Console.WriteLine("a");

            //Declaring the variable a.
            //int a;

            //Assigning a value to a, using some math.
            //a = 9 - 2;

            //Another assignment.
            //a = 3 + 3;

            //Declaring b and assigning a value to b all at once.
            //int b = 3 + 1;

            //Assigning a second value to b.
            //b = 1 + 2;
            //Console.WriteLine(b);

            //int a = 1;
            //int b = a + 4;
            //int c = a - b;
            //Console.WriteLine(b);

            //Remember, this is the same as 18% $4.0572
            float totalCost = 22.54f;
            float tipPercent = .18f;
            float tipAmount = totalCost * tipPercent;
            Console.WriteLine(tipAmount);

            //Note that you DO NOT put commas in the number, C# won't know what to do with it.
            double moneyMadeFromGame = 100000;
            double totalProgrammers = 4;
            double moneyPerPerson = moneyMadeFromGame / totalProgrammers; //We're rich!
            Console.WriteLine(moneyPerPerson);

            //The formula for the area of a circle is pi * r ^ 2
            //float radius = 4;
            //float pi = 3.1415926536f;
            //float area = pi * radius * radius;

            ////Using the + operator with strings in "concatenation".
            //Console.WriteLine("The area of the circle is " + area + "."); 

            //The formula for the area of a triangle is 1.5 * b * h 
            //int b = 5;
            //int h = 6;
            //double area = 1/2d * b * h;
            //Console.WriteLine("The area of the triangle is " + area);

            //The formula for the area of a triangle is 1.5 * b * h 
            double b = 1.5d;
            int h = 4;
            double area = 1 / 2d * b * h;
            Console.WriteLine("The area of the triangle is " + area);

        }
    }
}
