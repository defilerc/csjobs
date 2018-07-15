using System.Collections.Generic;

namespace CodeFights
{
    public class BalancedParentheses
    {
        public bool IsBalanced(string sentence) 
        {
            var stack = new Stack<char>();

            foreach (var c in sentence) {
                if (c == '[' || c == '{' || c == '(') {
                    stack.Push(c);
                }

                if (c == ']' || c == '}' || c == ')') {
                    if (stack.Count == 0) {
                        return false;
                    }

                    var prev = stack.Pop();

                    if ( (c == ']' && prev != '[') ||
                      (c == '}' && prev != '{') ||
                      (c == ')' && prev != '(') ) {
                          return false;
                      } 
                }
            }

            return stack.Count == 0;
        }
    }
}