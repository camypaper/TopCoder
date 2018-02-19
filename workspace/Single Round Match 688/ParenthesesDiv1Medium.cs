using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ParenthesesDiv1Medium
{
    public int minSwaps(string s, int[] L, int[] R)
    {
        var n = s.Length;
        var A = new int[n + 1];
        var m = L.Length;
        for (int i = 0; i < m; i++)
            R[i]++;
        for (int i = 0; i < m; i++)
        {
            A[L[i]]++;
            A[R[i]]--;
        }
        for (int i = 1; i <= n; i++)
            A[i] += A[i - 1];


        var xs = new List<int>();
        foreach (var x in L) xs.Add(x);
        foreach (var x in R) xs.Add(x);
        xs = xs.Distinct().ToList();
        xs.Sort();
        m = xs.Count;
        LL = new List<int>();
        RR = new List<int>();
        for (int i = 0; i < m - 1; i++)
        {
            if (A[xs[i]] == 0) continue;
            if ((xs[i + 1] - xs[i]) % 2 == 1)
                return -1;
            LL.Add(xs[i]);
            RR.Add(xs[i + 1]);
        }
        a = 0;
        b = 0;
        for (int i = 0; i < n; i++)
            if (A[i] == 0)
            {
                if (s[i] == '(') a++;
                else b++;
            }
        str = s.ToCharArray();
        return solve();
    }
    List<int> LL, RR;
    int a, b;
    char[] str;
    public int solve()
    {
        var ret = 0;
        var n = LL.Count;
        var needO = 0;
        var needC = 0;
        for (int _ = 0; _ < n; _++)
        {
            var l = LL[_];
            var r = RR[_];
            var close = new Queue<int>();
            var open = new Stack<int>();
            var k = (r - l) / 2;
            for (int i = l; i < r; i++)
            {
                if (str[i] == '(') open.Push(i);
                else close.Enqueue(i);
            }
            while (open.Count > k)
            {
                needC++;
                var pos = open.Pop();
                str[pos] = ')';
            }
            while (k < close.Count)
            {
                needO++;
                var pos = close.Dequeue();
                str[pos] = '(';
            }
            var min = 0;
            var val = 0;
            for (int i = l; i < r; i++)
            {
                if (str[i] == '(') val++;
                else val--;
                min = Math.Min(min, val);
            }
            if (min < 0)
            {
                ret += Math.Abs(min);
            }
            Debug.WriteLine("{0} {1} {2}", ret, needC, needO);
        }
        {
            var min = Math.Min(needC, needO);
            needC -= min;
            needO -= min;
            ret += min;
            if (a < needO) return -1;
            if (b < needC) return -1;
            ret += needC;
            ret += needO;
        }
        return ret;
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
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
