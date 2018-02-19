using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class IOIString
{
    public int countIOIs(string[] mask)
    {
        var s = mask.SelectMany(x => x).ToArray();
        var n = s.Length;
        var all = ModInteger.Pow(2, s.Count(x => x == '?'));
        for (int i = 0; i < n; i++)
            for (int j = 1; j <= n; j++)
            {
                if (i + 2 * j >= n) break;
                if (s[i] == 'I' && s[i + j] == 'O' && s[i + 2 * j] == 'I') return (int)all.num;
            }
        if (s.Count(x => x == 'I') == 0) all -= 1;

        var one = new int[n + 1];
        for (int i = 0; i < n; i++)
        {
            one[i + 1] += one[i];
            if (s[i] == 'I') one[i + 1]++;
        }


        for (int a = 0; a < n; a++)
        {
            if (s[a] == 'O') continue;
            if (one[n] - one[a + 1] == 0) all -= 1;
            for (int b = 1; b <= n; b += 2)
            {
                if (a + b >= n) break;
                var cnt = one[n] - one[a];
                for (var ptr = a; ptr < n; ptr += b)
                    if (s[ptr] == 'I') cnt--;
                if (cnt != 0) continue;
                for (var ptr = a + b; ptr < n; ptr += b)
                {
                    if (s[ptr] == 'O') break;
                    if (one[n] - one[ptr + 1] == 0)
                        all -= 1;
                }
            }
            if (s[a] == 'I') break;
        }
        return (int)all.num;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] mask)
    {
        return 0;
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
    public void OnInit()
    {
        //Tests.Add(null);
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
    public static ModInteger operator ^(ModInteger l, long r) { return ModInteger.Pow(l, r); }
    public static implicit operator ModInteger(long n) { return new ModInteger() { num = n }; }
    public static ModInteger Pow(ModInteger v, long k)
    {
        ModInteger ret = 1;
        var n = k;
        for (; n > 0; n >>= 1, v *= v)
        {
            if ((n & 1) == 1)
                ret = ret * v;
        }
        return ret;
    }
}
#endregion