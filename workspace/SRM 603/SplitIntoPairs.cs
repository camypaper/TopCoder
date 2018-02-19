using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SplitIntoPairs
{
    public int makepairs(int[] A, int X)
    {
        Array.Sort(A);
        var n = A.Length;
        var cnt = 0;
        var used = new bool[n];
        for (int i = 0; i < n; i++)
        {
            if (used[i])
                continue;
            if (A[i] < 0)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (used[j]) continue;
                    if (Math.BigMul(A[i], A[j]) >= X)
                    {
                        cnt++;
                        used[i] = used[j] = true; break;
                    }
                }
            }
            else
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (used[j]) continue;
                    if (Math.BigMul(A[i], A[j]) >= X)
                    {
                        cnt++;
                        used[i] = used[j] = true; break;
                    }
                }
            }
        }
        return cnt;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public class Tester : AbstractTester
{
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
