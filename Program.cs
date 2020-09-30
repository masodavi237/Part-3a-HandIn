using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3a_HandIn
{
    class Program
    {

        static void Greeting()
        {
            int year = System.DateTime.Now.Year;
            string name;
            int age;
            int yearOfBirth;

            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            yearOfBirth = year - age;

            Console.WriteLine($"Good morning {name}, we know everything about you. You were born in {yearOfBirth}");

            Console.ReadLine();

        }


        static void Adder()
        {

            int numberOne;
            int numberTwo;
            int numberThree;
            int sum;

            Console.WriteLine("Please enter a number.");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number.");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number.");
            numberThree = Convert.ToInt32(Console.ReadLine());

            sum = numberOne + numberTwo + numberThree;

            Console.WriteLine($"The sum of the three numbers is {sum}");

            Console.ReadLine();

        }

        static void Distance()
        {
            decimal distanceOne;
            decimal distanceTwo;
            decimal distanceThree;

            decimal answer;
            decimal roundedAnswer;

            Console.WriteLine("Please enter the first distance in km.");
            distanceOne = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the second distance in km.");
            distanceTwo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the third distance in km.");
            distanceThree = Convert.ToDecimal(Console.ReadLine());

            answer = (distanceOne + distanceTwo + distanceThree) / 3;
            roundedAnswer = Math.Round(answer, 2);

            Console.WriteLine($"The average distance is {roundedAnswer}km.");
            Console.ReadLine();

        }

        static void Hypotenuse()
        {

            double legOne;
            double legTwo;
            decimal answer;
            decimal roundedAnswer;

            Console.WriteLine("Please enter the length of the first leg in cm.");
            legOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the length of the second leg in cm.");
            legTwo = Convert.ToDouble(Console.ReadLine());

            answer = Convert.ToDecimal(Math.Sqrt((legOne * legOne) + (legTwo * legTwo)));
            roundedAnswer = Math.Round(answer, 2);

            Console.WriteLine($"The hypotenuse of a triangle with side lengths {legOne}cm and {legTwo}cm is {roundedAnswer}cm");

            Console.ReadLine();

        }

        static void Main(string[] args)
        {

            Greeting();

            Adder();

            Distance();

            Hypotenuse();

        }
    }
}
