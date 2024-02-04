namespace MathClass
{
    public class MathClassExample
    {
        // Addition
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Subtraction
        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        // Multiplication
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        // Division
        public static double Divide(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                throw new System.DivideByZeroException("Cannot divide by zero");
            }
        }
    }
}

