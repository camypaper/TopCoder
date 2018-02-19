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
        var L = Enumerate(m, x => 1000000000);
        var R = Enumerate(m, x => 0);
        for (int i = 0; i < n; i++)
        {
            t[i] = xs.BinarySearch(t[i]);
            L[t[i]] = Math.Min(L[t[i]], i);
            R[t[i]] = i;
        }


        ModInteger ans = 0;
        for (int l = 0; l < n; l++)
        {
            var x = t[l];
            if (L[x] != l) continue;

            var mask = new int[m];
            var flag = new int[8];
            for (int i = 0; i < m; i++)
                mask[i] = -1;
            var dame = 0;
            for (int i = 0; i < l; i++)
                if (L[t[i]] == i && R[t[i]] > l) dame++;

            for (int r = l + 1; r < n; r++)
            {
                var y = t[r];
                if (x == y) continue;
                if (R[y] == r)
                {
                    if (mask[y] == -1)
                    {
                        if (L[y] < l) dame--;

                        var b = flag[2];
                        var ab = flag[3];
                        var bc = flag[6];
                        var abc = flag[7];
                        var free = m - 2 - b - ab - bc - abc - dame;
                        if (b > 0)
                        {
                            ans += ModInteger.Pow(3, abc) * ModInteger.Pow(2, ab + bc + free);
                        }
                        else
                        {
                            ans += ModInteger.Pow(2, free) * (ModInteger.Pow(3, abc) * ModInteger.Pow(2, ab + bc) - ModInteger.Pow(2, abc));
                        }

                        var f = 7;
                        if (L[y] < l) f &= 6;
                        flag[f]++;
                    }
                    else
                    {
                        var f = mask[y];
                        flag[f]--;

                        var b = flag[2];
                        var ab = flag[3];
                        var bc = flag[6];
                        var abc = flag[7];
                        var free = m - 2 - b - ab - bc - abc - dame;
                        if (b > 0)
                        {
                            ans += ModInteger.Pow(3, abc) * ModInteger.Pow(2, ab + bc + free);
                        }
                        else
                        {
                            ans += ModInteger.Pow(2, free) * (ModInteger.Pow(3, abc) * ModInteger.Pow(2, ab + bc) - ModInteger.Pow(2, abc));
                        }




                        mask[y] |= 4;
                        flag[mask[y]]++;
                    }
                }
                else if (mask[y] == -1)
                {
                    var f = 3;
                    if (L[y] < l) { f &= 6; dame--; }
                    mask[y] = f;
                    flag[f]++;
                }
            }

        }

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