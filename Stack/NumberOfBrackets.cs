using System;
using System.Collections.Generic;

namespace CSharpPractice.Stack
{
    class NumberOfBrackets
    {
        public void CalculateBrackets(string str)
        {
            int i = 0;
            Stack<int> stack = new Stack<int>();
            int count = 1;
            while (i < str.Length)
            {
                if (str[i] == '(')
                {
                    stack.Push(count);
                    Console.Write(count+++" ");
                }
                else if (str[i] == ')')
                    Console.Write(stack.Pop()+" ");
                i++;
            }
        }
    }
}
