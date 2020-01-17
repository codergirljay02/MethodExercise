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

            Console.WriteLine(Sum(8, 7));

            Console.WriteLine(Sum(6, 5));


            Console.WriteLine(Add(40, 9));







        }

        public static int Sum(int first, int second)

        {
            return first + second;


        }
        public static int Add(int one, int two)
        {
            return one + two;

        }
        public static double Add(double one, double two)
        {
            return one + two;
        }

        public static string Add(int one, int two, bool value)
        {
            var answer = one + two;

            if (value == true)
            {
                return $"{answer}dollars";
            }
            else
            {
                return $"{answer}dollar";





            }












        }
    }
}
               

               
