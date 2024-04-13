namespace Lambda
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //prompt user to enter 2 double value numbers
            Console.WriteLine("Enter a number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double num2 = double.Parse(Console.ReadLine());

            //lambda expression that adds the numbers
            static double sum(double x, double y)
            {
                return x + y;
            }
            //lambda expression that multiplies the numbers
            static double product(double x, double y)
            {
                return x * y;
            }
            //lambda statement that compares the 2 numbers and returns the smaller value
            static double smallerValue(double a, double b)
            {
                return a < b ? a : b;
            }
            //use each of the lambda expressions in a Console.WriteLine statement
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum(num1, num2)}");
            Console.WriteLine();
            Console.WriteLine($"The product of {num1} and {num2} is: {product(num1, num2)}");
            Console.WriteLine();
            Console.WriteLine($"The smaller value between {num1} and {num2} is: {smallerValue(num1, num2)}");
            Console.WriteLine();
        }
    }
}