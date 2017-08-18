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
        }

        static void Main(string[] args)
        {

            String number1 = Console.ReadLine();
            String number2 = Console.ReadLine();

            showResults(number1, number2);
        }
    }
}
