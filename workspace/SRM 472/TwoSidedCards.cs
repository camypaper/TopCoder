using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TwoSidedCards
{
    public int theCount(int[] taro, int[] hanako)
    {
        var n = taro.Length;
        var s = new DisjointSet(n);
        for (int i = 0; i < n; i++)
            s.Unite(taro[i] - 1, hanako[i] - 1);
        var binomial = new ModCombinationTable(100);
        var dp = new ModInteger[n + 100];
        dp[0] = 1;
        for (int i = 0; i < n; i++)
        {
            if (s[i] != i) continue;
            var next = new ModInteger[n + 100];
            var size = s.Size(i);

            for (int j = 0; j * 2 <= size; j++)
            {
                var rem = size - j * 2;

                for (int k = 0; k <= n; k++)
                {
                    next[k + size - j] += binomial[size, 2 * j] * (j == 0 ? 1 : 2) * dp[k];
                }
            }
            dp = next;
        }
        ModInteger ans = 0;
        for (int i = 0; i <= n; i++)
        {
            var single = i;
            var paired = n - i;
            single -= paired;
            var add = dp[i];
            for (int j = 0; j < single; j++)
                add *= j + 1;
            for (int j = 0; j < paired; j++)
            {
                add *= binomial.RepeatedCombination(single + j * 2 + 1, 2);
            }
            ans += add;
        }
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
public class Tester: AbstractTester
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
    public static ModInteger operator ^(ModInteger l, long r) { return ModInteger.Pow(l, r); }
    public static implicit operator ModInteger(long n) { return new ModInteger(n); }
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
#region CombinationTable
public class ModCombinationTable
{
    ModInteger[][] nCr;
    public ModCombinationTable(int n)
    {
        nCr = new ModInteger[n + 1][];
        for (int i = 0; i <= n; i++)
            nCr[i] = new ModInteger[i + 2];
        nCr[0][0] = 1;
        for (int i = 0; i <= n; i++)
        {
            nCr[i][0] = 1;
            for (int j = 1; j <= i; j++)
                nCr[i][j] = nCr[i - 1][j - 1] + nCr[i - 1][j];
        }
    }
    public ModInteger this[int n, int r]
    {
        get
        {
            if (n < 0 || n >= nCr.Length)
            {
                Debug.WriteLine("n<=0 || n>N ");
                return 0;
            }
            if (r < 0 || r > n)
            {
                Debug.WriteLine("r<=0 ||r>n");
                return 0;
            }
            return nCr[n][r];
        }
    }
    public ModInteger RepeatedCombination(int n, int k)
    {
        if (k == 0) return 1;
        return this[n + k - 1, k];
    }
}
#endregion

#region DisjointSet
public class DisjointSet
{
    public int[] par, ranks, count;
    public DisjointSet(int n)
    {
        par = new int[n];
        count = new int[n];
        for (int i = 0; i < n; i++)
        {
            par[i] = i;
            count[i] = 1;
        }
        ranks = new int[n];
    }
    public int this[int id] { get { return (par[id] == id) ? id : this[par[id]]; } }
    public bool Unite(int x, int y)
    {
        x = this[x]; y = this[y];
        if (x == y) return false;
        if (ranks[x] < ranks[y])
        {
            par[x] = y;
            count[y] += count[x];
        }
        else
        {
            par[y] = x;
            count[x] += count[y];
            if (ranks[x] == ranks[y])
                ranks[x]++;
        }
        return true;
    }
    public int Size(int x) { return count[this[x]]; }
    public bool IsUnited(int x, int y) { return this[x] == this[y]; }

}
#endregion