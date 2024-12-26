using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to input values for x and y
        Console.WriteLine("Enter the first number (x):");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number (y):");
        double y = Convert.ToDouble(Console.ReadLine());

        // Create an object of the Calculator class
        Calculator calculator = new Calculator(x, y);

        // Display the results of the operations
        Console.WriteLine($"Sum (x + y): {calculator.Add()}");
        Console.WriteLine($"Difference (x - y): {calculator.Subtract()}");
        Console.WriteLine($"Product (x * y): {calculator.Multiply()}");
        Console.WriteLine($"Quotient (x / y): {calculator.Divide()}");
    }
}
