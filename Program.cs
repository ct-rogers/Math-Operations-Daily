using System;

namespace Math_Operations_Daily
{
    class Program
    {
        public static double Sum(double x, double y) => x + y;
        public static double Difference(double x, double y) => x - y;
        public static double Multiply(double x, double y) => x * y;
        public static double Division(double x, double y) => x / y;
        public static double Remainder(double x, double y) => x % y;

        public static void ShowResults(double operand1, double operand2, 
        double sum, double difference, double multiplication, double division, double remainder)
        {
            Console.WriteLine($"The result of {operand1} plus {operand2} was: {sum}.");
            Console.WriteLine($"The result of {operand1} minus {operand2} was: {difference}.");
            Console.WriteLine($"The result of {operand1} multiplied by {operand2} was: {multiplication}.");
            Console.WriteLine($"The result of {operand1} divided by {operand2} was: {division}.");
            Console.WriteLine($"The remainder of {operand1} divided by {operand2} was: {remainder}.");
        }
        static void Main(string[] args)
        {
            Console.Write("Hello, Please Enter Number 1: ");
            var operand1 = double.Parse(Console.ReadLine());
            Console.Write("Great! Please Enter Number 2: ");
            var operand2 = double.Parse(Console.ReadLine());

            var sum = Sum(operand1, operand2);
            var difference = Difference(operand1, operand2);
            var multiplication = Multiply(operand1, operand2);
            var division = Division(operand1, operand2);
            var remainder = Remainder(operand1, operand2);

            ShowResults(operand1, operand2, sum, difference, multiplication, division, remainder);
        }
    }
}

