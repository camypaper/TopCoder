using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class GameOfInterval
{
    public string construct(int n)
    {
        init();
        var ans = new List<int>();
        const int B = 6;
        for (int i = 0; i < n; i += B)
        {
            for (int j = i + 1; j < Math.Min(n, i + B); j++)
            {
                var ll = i;
                var lr = j - 1;
                var rl = j;
                var rr = j;
                //Console.WriteLine("[{0}, {1}] [{2}, {3}]", ll, lr, rl, rr);
                Console.WriteLine("{0} {1}", ll, rr);
                ans.Add(ll);
                ans.Add(rr);
            }
            {
                var rr = Math.Min(i + B, n) - 1;
                for (int j = Math.Min(i + B, n) - 2; j > i; j--)
                {
                    var ll = j;
                    var lr = j;
                    var rl = j + 1;
                    //Console.WriteLine("[{0}, {1}] [{2}, {3}]", ll, lr, rl, rr);
                    Console.WriteLine("{0} {1}", ll, rr);
                    ans.Add(ll); ans.Add(rr);
                }
            }
        }
        Debug.WriteLine(ans.Count / 2);
        for (int k = 0; k < 7; k++)
        {
            Debug.WriteLine(k);
            for (int i = 0; i < n; i += B)
            {
                var j = i + B * (2 << k);
                if (j > n) continue;
                Console.WriteLine("{0} {1}", i, j - 1);
                ans.Add(i); ans.Add(j - 1);
            }
        }
        var sb = new StringBuilder();
        Debug.WriteLine(ans.Count / 2);
        Debug.WriteLine(ans.Count / 2 + 4 * 1000);
        foreach (var x in ans) sb.Append(encode(x));
        return sb.ToString();
    }
    void init()
    {
        for (int i = 0; i < 10; i++)
            hex += (char)(i + '0');
        for (int i = 0; i < 26; i++)
            hex += (char)(i + 'A');
    }
    string hex;
    string encode(int x)
    {
        var u = x / 36;
        var v = x % 36;
        var s = "";
        s += hex[u]; s += hex[v];
        return s;
    }




    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(int n)
    {
        return "";
    }

    // CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run()
    {
        ManualTest(23);
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);

    }
}
// CUT end
