using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MethodsExercise
{
    public class Program
    {

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;

        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }

        public static int Modulus(int x, int y)
        {
            
            if(y == 0)
            {
                throw new ArgumentException("Cannot divide by zero");
            }
            
            return x % y;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please give a number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Give another number to add to the first number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            var sum = Add(num1, num2);

            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine("");
            Console.WriteLine("-------");
            Console.WriteLine("");

            Console.WriteLine("Please give a number:");
            int numX = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Give another number to multiply by the first number:");
            int numY = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            var product = Multiply(numX, numY);
            
            Console.WriteLine($"The product of your two numbers is {product}");
            Console.WriteLine("");
            Console.WriteLine("-------");
            Console.WriteLine("");

            Console.WriteLine("Please give a number:");
            int numA = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Give another number to subtract from the first number:");
            int numB = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            var difference = Subtract(numA, numB);

            Console.WriteLine($"The difference is {difference}");
            Console.WriteLine("");
            Console.WriteLine("-------");
            Console.WriteLine("");

            Console.WriteLine("Please give a number:");
            int numC = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Give another number to divide by the first number:");
            int numD = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            var remainder = Modulus(numC, numD);

            Console.WriteLine($"The remainder after dividing {numC} and {numD} is {remainder}");
            Console.WriteLine("");
            Console.WriteLine("-------");
            Console.WriteLine("");


            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hi, {name}! What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is a cool color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"I like {animal} too! What is your favorite band?");
            var band = Console.ReadLine();
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

       
    }
}
