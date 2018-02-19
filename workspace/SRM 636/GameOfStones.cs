using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class GameOfStones
{
    public int count(int[] stones)
    {
        var sum = stones.Sum();
        var n = stones.Length;
        if (sum % n != 0) return -1;
        var need = 0;
        sum /= n;
        foreach(var x in stones)
        {
            var diff = Math.Abs(x - sum);
            if (diff % 2 != 0) return -1;
            need += diff/2;
        }
        if (need % 2 != 0) return -1;
        return need/2;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e,string s=" ") { return string.Join(s, e);}
}
// CUT begin
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand=new Random(0);
    public Tester()
    {
    }
}
// CUT end
