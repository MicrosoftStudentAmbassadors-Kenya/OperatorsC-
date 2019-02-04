using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number1 = 45;
            Console.WriteLine(number1);
            int number2 = 80;
            Console.WriteLine(number2);
            bool compare = number1 >= number2;
            Console.WriteLine(compare);
            int multiplication = number1 * number2;
            Console.WriteLine(multiplication);
            int modulus = number2 % number1;
            Console.WriteLine(modulus);
            int lenth = 100;
            int width = 50;
            int perimeter = lenth * 2 + width * 2;
            Console.WriteLine($"the perimeter is{perimeter}");


            Console.WriteLine("enter lenght1");
            int length1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter width1");
            int width1 = Convert.ToInt32(Console.ReadLine());
            int perimeter1 = length1 * 2 + width1 * 2;
            Console.WriteLine("the perimeter is " + perimeter1);

            Console.WriteLine("enter radius");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = 3.142*radius*radius;
            Console.WriteLine("the area is"+area);
            bool condition1 = true;
            bool condition2 = false;
            bool result = condition2 && condition1;
            bool result2 = condition1 || condition2;
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(!condition2);
            Console.ReadKey();
        
        }
    }
}
