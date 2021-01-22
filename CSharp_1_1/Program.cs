using System;

namespace CSharp_1_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Module 1");
            Console.WriteLine("Please select which task you want to run (1-8), to run all, simply press enter");
            string chosenTask = Console.ReadLine();
            if (chosenTask == "1")
            {
                Task1();
            }
            else if (chosenTask == "2")
            {
                Task2();
            }
            else if (chosenTask == "3")
            {
                Task3();
            }
            else if (chosenTask == "4")
            {
                Task4();
            }
            else if (chosenTask == "5")
            {
                Task5();
            }
            else if (chosenTask == "6")
            {
                Task6();
            }
            else if (chosenTask == "7")
            {
                Task7();
            }
            else if (chosenTask == "8")
            {
                Task8();
            }
            else
            {
                Task1();
                Task2();
                Task3();
                Task4();
                Task5();
                Task6();
                Task7();
                Task8();
            }


        }

        public static void Task1()
        {
            //Task 1.
            Console.WriteLine("Task 1");
            //Asks the user for their first name, and stores it in the firstName variable
            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();

            //Asks the user for their last name, and stores it in the lastName variable
            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();

            //Outputs and concatenates the 2 strings
            Console.WriteLine($"Your fist name is: {firstName} and your last name is: {lastName}");
            Console.ReadLine();
        }

        public static void Task2()
        {
            //Task 2.
            Console.WriteLine("Task 2");
            //Asks the user to input a number. ToInt32 function converts the string to an integer
            Console.WriteLine("Please input a number");
            int number = Convert.ToInt32(Console.ReadLine());

            
            //Determine whether the number is even or odd using the remainder operator. If 0 remains, the number was even, else, it was odd. 
            if (number % 2 == 0)
            {
                Console.WriteLine("Your number was even");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your number was odd");
                Console.ReadLine();
            }
        }

        public static void Task3()
        {
            //Task 3.
            Console.WriteLine("Task 3");
            //Asks the user to input 3 numbers
            Console.WriteLine("Please input the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the third number");
            int number3 = Convert.ToInt32(Console.ReadLine());

            //Outputs the nuadsad, with the escape sequence in order to put a space in between the numbers
            Console.WriteLine($"{number1} \t {number2} \t {number3}");
            Console.ReadLine();
        }

        public static void Task4()
        {
            //Task 4.
            Console.WriteLine("Task 4");

        }

        public static void Task5()
        {
            //Task 5.
            Console.WriteLine("Task 5");
            //Asks the user to input 2 numbers. Variables are stored as floats, as the quota of 2 integers can be a float value
            Console.WriteLine("Please input a value for X");
            float x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input a value for Y");
            float y = Convert.ToInt32(Console.ReadLine());

            //Compute the different math actions and store them into variables
            float sum = x + y;

            float difference = x - y;

            float product = x * y;

            float quota = x / y;

            float remainder = x % y;

            //Writes out the results
            Console.WriteLine($"The sum of X and Y is {sum}," +
                              $"\nThe difference between X and Y is {difference}," +
                              $"\nThe product of X and Y is {product}," +
                              $"\nThe quota of X and Y is {quota}" +
                              $"\nThe remainer of X and Y is {remainder},");
            Console.ReadLine();
        }

        public static void Task6()
        {
            //Task 6.
            Console.WriteLine("Task 6");
            //Asks the user to input a radius of a circle
            Console.WriteLine("Please input a radius for a circle");
            int radius = Convert.ToInt32(Console.ReadLine());

            //Calculates the diameter, circumference and area of the circle
            int diameter = 2 * radius;

            double circumference = 2 * (Math.PI * radius);

            double area = Math.Pow(Math.PI * radius, 2);

            //Display the result to the user
            Console.WriteLine($"The diamter of your circle is: {diameter}" +
                $"\nThe circumference is {circumference}" +
                $"\nThe area is {area}");
            Console.ReadLine();


        }

        public static void Task7()
        {
            //Task 7. NOT DONE
            Console.WriteLine("Task 7");
            //Asks the user to input a 4 digit integer
            Console.WriteLine("Please input a 4 digit number");
            int number4 = Convert.ToInt32(Console.ReadLine());

            //Display the integer with the numbers separated from eachother
            if (number4 < 10)
            {
                Console.WriteLine("{0} ", number4);
                Console.ReadLine();
            }
            else
            {
                int splitNumber4 = number4 % 10;

                Console.WriteLine("{0} ", splitNumber4);
                Console.ReadLine();
                splitNumber4 = splitNumber4 / 10;
            }
        }

        public static void Task8()
            {
            //Task 8.
            Console.WriteLine("Task 8");
            //Asks the user to input a number
            Console.WriteLine("Please input a number");
            int number5 = Convert.ToInt32(Console.ReadLine());

            //Square and cube the number and displaythe result
            int squared = (int)Math.Pow(number5, 2);

            int cubed = (int)(Math.Pow(number5, 3));

            Console.WriteLine($"Number: {number5}" +
                              $"\nSquared: {squared} " +
                              $"\nCubed: {cubed}");
            Console.ReadLine();
        }


        }

    }
    

