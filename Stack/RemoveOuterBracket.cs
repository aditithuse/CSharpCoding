using System;
using System.Collections.Generic;

namespace ProblemSolving.Stack
{
    public class RemoveOuterBracket
    {
        
        public static string RemoveOuterParentheses(string S)
        {
            Stack<char> stack = new Stack<char>();
            stack.Push(S[0]);
            String ans = "";
            for (int i = 1; i < S.Length; i++)
            {
                if (S[i] == '(' && stack.Count == 0)
                {
                    stack.Push(S[i]);
                }
                else if (S[i] == '(')
                {
                    stack.Push(S[i]);
                    ans += S[i];
                }
                else
                {
                    stack.Pop();
                    if (stack.Count != 0)
                        ans += S[i];
                }
            }
            return ans;

        }
    }
}
