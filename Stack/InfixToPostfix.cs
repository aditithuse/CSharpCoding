using System;
using System.Collections.Generic;

namespace CSharpPractice.Stack
{
    class InfixToPostfix
    {
        public int Precedence(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
            }
            return -1;
        }
        public bool IsOperand(char ch)
        {
            return ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'));
        }

        public void InfixToPostfixConversion(string str)
        {
            Stack<char> stack = new Stack<char>();
            string postfixExpression = "";
            for(int i = 0; i<str.Length; i++) 
            {
                if (IsOperand(str[i]))
                    postfixExpression += str[i];
                else if (str[i] == '(')
                    stack.Push(str[i]);
                else if (str[i] == ')')
                {
                    while (stack.Count != 0 && stack.Peek()!= '(')
                        postfixExpression += stack.Pop();
                    if (stack.Count != 0 && stack.Peek() != '(')
                        return;
                    else
                        stack.Pop();
                }
                else
                {
                    while (stack.Count != 0 && Precedence(str[i]) <= Precedence(stack.Peek()))
                        postfixExpression += stack.Pop();
                    stack.Push(str[i]);
                }
            }
            while (stack.Count != 0)
                postfixExpression += stack.Pop();

            Console.WriteLine(postfixExpression);

        }
    }
}
