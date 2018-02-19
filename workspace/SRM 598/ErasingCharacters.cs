using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class ErasingCharacters
{
    public string simulate(string s)
    {
        var stack = new Stack<char>();
        var erace = false;
        foreach (var x in s)
        {
            if (!stack.Any())
                stack.Push(x);
            else
            {
                if (stack.Peek() == x) stack.Pop();
                else stack.Push(x);
            }

        }
        var n = stack.Count;
        var ans = new char[n];
        for (int i = n - 1; i >= 0; i--)
        {
            ans[i] = stack.Pop();
        }
        return ans.AsString();
    }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e)
    {
        return new string(e.ToArray());
    }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ")
    {
        return string.Join(s, e);
    }
}
