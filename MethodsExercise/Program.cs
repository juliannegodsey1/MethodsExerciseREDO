using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            int sum = Add(2, 3);
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine("-------");
            Console.WriteLine("");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi, {name}! What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine($"{color} is a cool color! What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine($"I like {animal} too! What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Cool! Here is your profile:");
            Console.WriteLine("");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine("");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine("");
            Console.WriteLine($"Favorite Band: {band}");
            Console.WriteLine("");
            Console.WriteLine($"Bye, {name}!");
            Console.WriteLine("");
        
           

        }

        public static int Add(int x,int y)
        {
            return x + y;

        }
    }
}
