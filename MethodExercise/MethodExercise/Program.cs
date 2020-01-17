using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var firstName = Console.ReadLine();

            Console.WriteLine($"Hello, {firstName}");



            Console.WriteLine("What is your favorite color?");
            var favoriteColor = Console.ReadLine();

            Console.WriteLine($"My favorite color is {favoriteColor}.");

            Console.WriteLine("What is your favorite animal?");
            var favoriteAnimal = Console.ReadLine();

            Console.WriteLine($"My favorites animal is a {favoriteAnimal}.");

            Console.WriteLine("What's the name of your favorite band?");
            var favoriteBand = Console.ReadLine();

            Console.WriteLine($"The name of my favorite band is {favoriteBand}.");
               

               
        }
    }
}
