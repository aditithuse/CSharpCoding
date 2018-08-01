using System;
using System.Collections.Generic;

namespace CSharpPractice.Stack
{
    class EasyString
    {
        static public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                string afterStr = "";
                Stack<char> stack = new Stack<char>();
                int k = 0;
                while (k < str.Length)
                {
                    if (stack.Count == 0 || Char.ToLower(str[k]) == stack.Peek())
                        stack.Push(Char.ToLower(str[k]));
                    else
                    {
                        AppendStr(stack, ref afterStr);
                        stack.Push(Char.ToLower(str[k]));
                    }
                    k++;
                }
                AppendStr(stack, ref afterStr);
                Console.WriteLine(afterStr);
            }
        }
        public static void AppendStr(Stack<char> stack, ref string afterStr)
        {
            afterStr += stack.Count.ToString() + stack.Peek();
            stack.Clear();
        }
    }
}
