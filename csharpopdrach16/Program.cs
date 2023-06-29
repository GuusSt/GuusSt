using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2;

        Console.Write("Enter the first number: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter the first number : ");
        }

        Console.Write("Enter the second number: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter the second number: ");
        }

        int operation = 0;
        while (operation != 1 && operation != 2 && operation != 3) 
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press 1 for addition and subtraction.");
            Console.WriteLine("Press 2 for addition and multiplication.");
            Console.WriteLine("Press 3 for addition and division.");

            if (!int.TryParse(Console.ReadLine(), out operation))
            {
                Console.WriteLine("Invalid input. Please enter a valid selection.");
            }
            else if (operation != 1 && operation != 2 && operation != 3)
            {
                Console.WriteLine("Invalid selection. Please enter 1, 2, or 3.");
            }
        }
// t4gt4gt fgrthyjukil
        switch (operation)
        {
            case 1:
                AddSubtract(num1, num2);
                break;
            case 2:
                AddMultiply (num1, num2);
                break;
            case 3:
                AddDivide(num1, num2);
                break;
        }
    }
static void AddSubtract(double num1, double num2)
    {
        double sum = num1 + num2;
        double difference = num1 - num2;
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
        Console.WriteLine($"The difference between {num1} and {num2} is {difference}");
    }

    static void AddMultiply(double num1, double num2)
    {
        double sum = num1 + num2;
        double product = num1 * num2;
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
        Console.WriteLine($"The product of {num1} and {num2} is {product}");
    }

    static void AddDivide(double num1, double num2)
    {
        double sum = num1 + num2;
        double quotient = num1 / num2;
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
        Console.WriteLine($"The quotient of {num1} divided by {num2} is {quotient}");
        
        
        
        
    }
}
 
      