namespace MethodsExercise
{
    public class Program
    {
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

           


            Console.ReadLine();
        }
    }
}
