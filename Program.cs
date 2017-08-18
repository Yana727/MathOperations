using System;

namespace MathOperations
{
    class Program
    {
        public static void showResults(string number1, string number2)
        {
            double operand1 = double.Parse(number1);
            double operand2 = double.Parse(number2);
            double sum = operand1 + operand2;
            double difference = operand1 - operand2;
            double division = operand1 / operand2;
            double multiplication = operand1 * operand2;
            var isEven = false;
            if ((operand1 % operand2) == 0)
            {
                isEven = true;
            }
            Console.WriteLine($"The sum of {operand1} and {operand2} is {sum}");
            Console.WriteLine($"The difference of {operand1} and {operand2} is {difference}");
            Console.WriteLine($"The division of {operand1} and {operand2} is {division}");
            Console.WriteLine($"The product of {operand1} and {operand2} is {multiplication}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");
            String number1 = Console.ReadLine();
            String number2 = Console.ReadLine();

            showResults(number1, number2);
        }
    }
}
