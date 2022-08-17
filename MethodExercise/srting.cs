namespace MethodExcersice
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is you favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"Once upon a time there was a man named {name}. He was a very old man.");
            Console.WriteLine($"This old man loved the color {color}. He loved {color} so much, that it was the only color he ever wore.");
            Console.WriteLine($"He also wanted to go and get a pet {animal}. Since he loved {color} so much, of course the {animal} was {color}.");
            Console.WriteLine($"{name}, did everything with his pet {animal}. He even would take his {animal} to concerts with him.");
            Console.WriteLine($"His favorite band to go see was {band}. {name}, would go see {band} so often, that the members of {band} got to know {name} and his {animal} very well.");
            Console.WriteLine($"{band} and {name} became such good friends that when {band} did there last tour, they invited {name} and his pet {animal} on stage for the last song they would ever play on a tour.");


            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number to add");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The answer is {sum}");



            Console.WriteLine("Give me a number to subtract");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number to subtract");
            int num4 = int.Parse(Console.ReadLine());

            int sub = Subtract(num3, num4);
            Console.WriteLine($"The answer is {sub}");



            Console.WriteLine("Give me a number to multiply");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number to multiply");
            int y = int.Parse(Console.ReadLine());

            int product = Multiply(x, y);
            Console.WriteLine($"The answer is {x * y}");


            Console.WriteLine("Give me a number to divide");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number to divide by");
            int w = int.Parse(Console.ReadLine());

            int divide = Divide(x, y);
            Console.WriteLine($"The answer is {z / w}");


            Console.WriteLine("Give me a number");
            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number for modulus");
            int num6 = int.Parse(Console.ReadLine());

            int modulus = Modulus(num5, num6);
            Console.WriteLine($"The answer is {num5 % num6}");
        }

        public static int Sum(int num1, int num2)
        { 

            int sum = num1 + num2;

            return sum;

        }
        public static int Subtract(int num3, int num4)
        {

            int sub = num3 - num4;

            return sub;

        }

        public static int Multiply(int x, int y)
        {

            return x * y;


        }

        public static int Divide(int z, int w)
        {

            return z / w;

        }

        public static int Modulus(int num5, int num6)
        {

            return num5 % num6;

        }

    }
}