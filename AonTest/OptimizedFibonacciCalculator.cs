using AonExercise.Interfaces;

namespace AonExercise
{
    public class OptimizedFibonacciCalculator : IFibonacciCalculator
    {
        /// <summary>
        /// Calculates the nth fibonacci number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int Calculate(int n)
        {
            if (n < 0)
                throw new ArgumentException("n should be greater than or equal to 0");

            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            // initialize an array to store the fibonacci numbers
            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;

            // store the fibonacci numbers in the array so you can use them later
            for (int i = 2; i <= n; i++)
                fib[i] = fib[i - 1] + fib[i - 2];

            // return the nth fibonacci number
            return fib[n];
        }
    }
}
