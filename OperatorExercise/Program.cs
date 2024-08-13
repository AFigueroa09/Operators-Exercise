namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}+{b} is {sum}.");
            Console.WriteLine($"{a}-{b} is {difference}.");
            Console.WriteLine($"{a}*{b} is {product}.");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

            Console.WriteLine($"Let's calculate the area of your circle. Please provide a radius value:");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
        }

        static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow( radius, 2 );
        }
        // Thought Exercise
        // i is incremented before the operation while j is incremented afterwards.
        // 4*4 = 16
        // Result is i = 4; j = 5; and k = 16;
    }
}
