namespace AonExercise
{
    public static class StringUtility
    {
        /// <summary>
        /// Checks if input string has balanced brackets
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsBracketsBalanced(string input)
        {
            // if input is null or empty, return true
            if (string.IsNullOrEmpty(input))
                return true;

            // declare the empt stack of charss
            var stack = new Stack<char>();

            // loop through the input
            foreach (var c in input)
            {
                // if the char is an open bracket, push it to the stack
                if (c == '(' || c == '[' || c == '{')
                    stack.Push(c);

                // if the char is closed bracket check top of the stack if the same pop
                else if (c == ')' || c == ']' || c == '}')
                {
                    // if the stack is empty, return false
                    if (stack.Count == 0)
                        return false;

                    // if the top of the stack is not matching the current char, return false
                    else if ((c == ')' && stack.Peek() != '(') || (c == '}' && stack.Peek() != '{') || (c == ']' && stack.Peek() != '['))
                        return false;

                    // pop the top of the stack
                    stack.Pop();
                }

            }

            return stack.Count == 0;
        }
    }
}
