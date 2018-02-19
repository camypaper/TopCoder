using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SkolemBinaryTree
{
    public int[] construct(int k)
    {
        var a = new List<int>();
        for (int i = 1; i <= k; i += 2)
        {
            a.Insert(0, i * 2 - 2);
            a.Add(i * 2 - 1);
        }
        for (int j = 0; j < a.Count - 1; j++)
            add(a[j], a[j + 1]);
        var last = a.Count - 1;
        var pos = a.Count - 1 - 3;
        for (int i = 2; i <= k; i += 2)
        {
            if (i == 2)
            {
                add(a[last], i * 2 - 2);
                add(a[last], i * 2 - 1);
                last = a[last - 1];
            }
            else
            {
                add(last, i * 2 - 2);
                add(a[pos], i * 2 - 1);
                last = i * 2 - 2;
                pos--;
            }
        }
        for (int i = 0; i < E.Count; i += 2)
            Console.WriteLine("{0} {1}", E[i], E[i + 1]);


        return E.ToArray();

    }
    List<int> E = new List<int>();
    void add(int i, int j)
    {
        E.Add(i); E.Add(j);
    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int[] Naive_Test(int k)
    {
        return new int[] { };
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
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);

    }
}
// CUT end
