namespace WebAppLibrary
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            if (a > b)
            {
                return a - b;
            }
            else
            {
                return b - a;
            }
        }

        public int Multiply(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < b; i++)
            {
                result += a;
            }
            return result;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Division by zero is not allowed.");
            }
            return a / b;
        }

        public int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
