using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MappingABC
{
    public int countStrings(int[] t)
    {
        var xs = t.Distinct().ToList(); xs.Sort();
        var m = xs.Count;
        var n = t.Length;
        var g = Enumerate(m, x => new List<int>());
        for (int i = 0; i < n; i++)
        {
            t[i] = xs.BinarySearch(t[i]);
            g[t[i]].Add(i);
        }


        var used = new bool[m];
        ModInteger ans = 0;
        for (int i = 0; i < n; i++)
        {
            if (used[t[i]]) continue;

            used[t[i]] = true;

            var otaku = used.ToArray();
            var unko = 0;

            var map = new int[8];
            var flag = new int[m];
            for (int j = 0; j < m; j++)
            {
                flag[j] = 7;
                map[7]++;
            }

            for (int j = 0; j <= i; j++)
            {
                map[flag[t[j]]]--;
                flag[t[j]] &= 6;
                map[flag[t[j]]]++;
                if (g[t[j]][g[t[j]].Count - 1] < i)
                {
                    unko++;
                    map[flag[t[j]]]--;
                }
            }
            map[flag[t[i]]]--;
            for (int j = n - 1; j > i; j--)
            {
                if (otaku[t[j]]) continue;
                otaku[t[j]] = true;

                map[flag[t[j]]]--;

                var abc = map[7];
                var b = map[2];
                var ab_bc = map[3] + map[6];
                if (b > 0)
                    ans += ModInteger.Pow(2, unko) * ModInteger.Pow(2, ab_bc) * ModInteger.Pow(3, abc);
                else
                    ans += ModInteger.Pow(2, unko) * (ModInteger.Pow(2, ab_bc) * ModInteger.Pow(3, abc) - ModInteger.Pow(2, abc));
                flag[t[j]] &= 3;
                var pos = g[t[j]].BinarySearch(j);
                if (pos - 1 < 0 || g[t[j]][pos - 1] < i)
                    unko++;
                else map[flag[t[j]]]++;
            }

        }
        //Debug.WriteLine(a.AsJoinedString());


        return (int)(ans.num);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] t)
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

