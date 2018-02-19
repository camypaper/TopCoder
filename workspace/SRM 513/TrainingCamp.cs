using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class TrainingCamp
{
    public string[] determineSolvers(string[] attendance, string[] problemTopics)
    {
        var n = attendance.Length;
        var m = problemTopics.Length;
        var len=attendance[0].Length;
        var a = new char[n][];
        for (int i = 0; i < n; i++)
            a[i] = new char[m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i][j] = 'X';
                for (int k = 0; k < len; k++)
                {
                    if (attendance[i][k] == '-' && problemTopics[j][k] == 'X')
                        a[i][j] = '-';
                }
            }
        }
        var ans = new string[n];
        for (int i = 0; i < n; i++)
            ans[i] = a[i].AsString();
        return ans;
    }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e)
    {
        return new string(e.ToArray());
    }
    static public string AsJoinedString<T>(this IEnumerable<T> e,string s=" ")
    {
        return string.Join(s, e);
    }
}
