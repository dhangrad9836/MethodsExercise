using System.Xml.Schema;

namespace MethodsExercise
{
    public class Program
    {
        //methods to add, subtract, multiply, divide
        //Using the params functionality to allow multiple values inserted into an array
        public static int Add(params int[] numbers) 
        {   
            //declare total variable
            int total = 0;
            //loop through numbers array
            for (int i = 0; i < numbers.Length; i++)
            {
                //add up all the number in the numbers array
                total += numbers[i];
                
            }
            //return the total
            return total;
        }

        //Subtraction
        public static int Subtract(int num1, int num2)
        {
            //declare a difference variable
            int difference = 0;

            //return the difference
            return difference = num1 - num2;
        }

        //Multiplication
        public static int Multiply(int num1, int num2)
        {
            //declare a product variable
            int product = 0;

            //return the product
            return product = num1 * num2;
        }

        //Division
        public static int Divide(int num1, int num2)
        {
            //declare a quotient variable
            int quotient = 0;

            //return the quotient
            return quotient = num1 / num2;
        }

        static void Main(string[] args)
        {
            //Ask the user for things like a name, color, an animal, etc.
            //Make up a story and be creative.
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            string favoriteFood = Console.ReadLine();

            Console.WriteLine("What is your favorite movie?");
            string favoriteMovie = Console.ReadLine();

            Console.WriteLine($"Your name is {userName} and your favorite food to eat is " +
                $"{favoriteFood}.\nWhen you are sleeping you dream of your favorite color" +
                $" which is: {favoriteColor}.\nYou've always wanted to star in {favoriteMovie}, " +
                $"but ended up being a software developer.");

            Console.WriteLine("Exercise 2");
            //-----------------------------------------------------------------

            //Addition
            Console.WriteLine($"The Total is: " + Add(1,2,4,7,3));

            //Subtract
            Console.WriteLine($"The Difference is: " + Subtract(5,4));

            //Multiply
            Console.WriteLine($"The Product is: " + Multiply(5, 4));

            //Divide
            Console.WriteLine($"The Quotient is: " + Divide(10, 5));



            Console.ReadLine();
        }
    }
}
