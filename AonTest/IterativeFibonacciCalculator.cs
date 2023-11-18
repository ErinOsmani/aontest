using AonExercise.Interfaces;

namespace AonExercise
{
    public class IterativeFibonacciCalculator : IFibonacciCalculator
    {
        /// <summary>
        /// Calculates the nth fibonacci number
        /// </summary>
        /// <param name="n">is the n number in the fibonacci series</param>
        /// <returns>the calculated number</returns>
        /// <exception cref="ArgumentException"></exception>
        public int Calculate(int n)
        {
            if (n < 0)
                throw new ArgumentException("n should be greater than or equal to 0");

            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            return Calculate(n - 1) + Calculate(n - 2);
        }
    }
}
