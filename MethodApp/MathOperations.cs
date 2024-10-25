using System;

namespace MethodApp
{
    public class MathOperations
    {
        // Create a void method that takes two integers as parameters
        public void PerformOperation(int num1, int num2)
        {
            // Perform a simple math operation on the first integer, such as multiplying it by 2
            int result = num1 * 2;

            // Display the result of the math operation
            Console.WriteLine($"The result of the math operation on the first number is: {result}");

            // Display the second integer
            Console.WriteLine($"The second number is: {num2}");
        }
    }
}
