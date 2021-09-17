using System;

namespace FindingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method FindIntType that uses the Math.Abs method to determine the sign of an integer. 
            //The method should take an integer argument and return 1 if it is positive, -1 if it is negative and 0 otherwise.
            //Use an app that inputs a sequence of five integers one at a time and determines whether each is positive, negative or zero.

            //Console.WriteLine("Hello World!");

            //1. Display instructions to users
            Console.WriteLine("Please enter a sequence of numbers: ");
            Console.WriteLine("Press Enter to determine if the number entered are positive, negative or zero");

            //2. Store values
            string line = Console.ReadLine();

            //3. Processing
            int counter = 1;
            while (line != null && counter < 5)
            {
                int num = Convert.ToInt32(line);    //"44" -> 44
                int value = FindIntType(num);       //44 -> 1
                //Console.WriteLine(value);

                switch (value)                       //0,1,-1
                {
                    case 1:
                        Console.WriteLine($"The number {num} is positive");
                        break;

                    case -1:
                        Console.WriteLine($"The number {num} is negative");
                        break;

                    case 0:
                        Console.WriteLine($"The number {num} is zero");
                        break;
                }
                line = Console.ReadLine();
                counter++;
            }                      
        }
        static int FindIntType(int num)
        {
            int value;
            if (num == 0)
            {
                value = 0;
            }
            else if (num == Math.Abs(num))
            {
                value = 1;
            }
            else
            {
                value = -1;
            }
            return value;
        }
    }
}
