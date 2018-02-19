using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RabbitNumbering
{
    public int theCount(int[] maxNumber)
    {
        Array.Sort(maxNumber);
        const int MAX = 1050;
        var n = maxNumber.Length;
        var dp = Enumerate(n + 1, x => new ModInteger[MAX]);
        for (int i = 1; i <= maxNumber[0]; i++)
            dp[1][i] = 1;
        var pre = maxNumber[0];
        for (int i = 1; i < n; i++)
        {
            var max = maxNumber[i];
            ModInteger sum = 0;
            for (int j = 1; j <= max; j++)
            {
                var rem = j - i;
                dp[i + 1][j] += rem * dp[i][j] + sum;
                sum += dp[i][j];
            }
            pre = max;
        }
        ModInteger ans = 0;
        for (int i = 0; i < MAX; i++)
            ans += dp[n][i];
        return (int)ans.num;
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
#region ModNumber
public partial struct ModInteger
{
    public const long Mod = (long)1e9 + 7;
    public long num;
    public ModInteger(long n) : this() { num = n % Mod; if (num < 0) num += Mod; }
    public override string ToString() { return num.ToString(); }
    public static ModInteger operator +(ModInteger l, ModInteger r) { var n = l.num + r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator -(ModInteger l, ModInteger r) { var n = l.num + Mod - r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator *(ModInteger l, ModInteger r) { return new ModInteger(l.num * r.num); }
    public static implicit operator ModInteger(long n) { return new ModInteger(n); }
}
#endregion
