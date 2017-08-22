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

            int a = 1;
            int b = a + 4;
            int c = a - b;
            Console.WriteLine(b);

            //Remember, this is the same as 18%
            float totalCost = 22.54f;
            float tipPercent = .18f;
            float tipAmount = totalCost * tipPercent;
            Console.WriteLine(tipAmount);
        }
    }
}
