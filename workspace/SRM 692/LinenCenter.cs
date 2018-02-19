using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class LinenCenter
{
    public int countStrings(string s, int N, int K)
    {
        var dp = Enumerate(N + s.Length + 1, x => new ModInteger[s.Length + 1]);
        dp[0][0] = 1;
        var go = StringEx.GetLink(s);
        for (int i = 0; i < N + s.Length; i++)
        {
            for (int p = 0; p < s.Length; p++)
            {
                if (dp[i][p].num == 0) continue;
                for (int c = 0; c < 26; c++)
                {
                    var j = go[p][c];
                    dp[i + 1][j] += dp[i][p];
                }
            }
        }
        var op = new ModInteger[N + 1];
        var ed = new ModInteger[N + 1];
        for (int i = 0; i <= N + s.Length; i++)
            for (int j = 0; j <= s.Length; j++)
            {
                if (j == s.Length)
                {
                    if (i >= s.Length && i - s.Length <= N) ed[i - s.Length] += dp[i][j];
                }
                else
                {
                    if (i <= N)
                        op[i] += dp[i][j];
                }
            }
        Debug.WriteLine(op.AsJoinedString());
        Debug.WriteLine(ed.AsJoinedString());
        var res = conv(pow(ed, K, N, ModInteger.Mod), op, N);
        ModInteger ans = 0;
        foreach (var x in res) ans += x;
        return (int)ans.num;

    }

    static public ModInteger[] conv(ModInteger[] x, ModInteger[] y, int n)
    {
        var ret = new ModInteger[n + 1];
        for (int i = 0; i <= n; i++)
            for (int j = 0; i + j <= n; j++)
                ret[i + j] += x[i] * y[j];
        return ret;
    }
    static public ModInteger[] pow(ModInteger[] x, long n, int m, long mod)
    {
        var ret = new ModInteger[m + 1];
        ret[0] = 1;
        while (n > 0)
        {
            if ((n & 1) == 1)
                ret = conv(ret, x, m);
            x = conv(x, x, m);
            n >>= 1;
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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        test.ManualTest("aa", 2, 2);
    }
}
// CUT end
#region KMP
static public partial class StringEx
{
    /// <summary>KMPテーブルを構築する．O(|S|)</summary>
    /// <returns>ret[i]=s[0,i-1]の接頭辞と接尾辞の最大一致数</returns>
    static public int[] CreateKMPTable(string s)
    {
        var ret = new int[s.Length + 1]; ret[0] = -1;
        int j = -1;
        for (int i = 0; i < s.Length;)
        {
            while (j >= 0 && s[i] != s[j]) j = ret[j];
            i++; j++;
            if (i < s.Length && s[i] == s[j]) ret[i] = ret[j];
            else ret[i] = j;
        }
        return ret;
    }

    /// <summary>
    /// i文字一致しているときに c をくっつけたときに，どこにいくか？
    /// O(N|C|logN)
    /// </summary>
    /// <returns>ret[i][c]=s[0,i)+cはどこに行くべきか？</returns>
    static public int[][] GetLink(string s)
    {
        var kmp = CreateKMPTable(s);
        var ret = new int[s.Length][];
        for (int i = 0; i < s.Length; i++)
            ret[i] = new int[26];
        for (int i = 0; i < s.Length; i++)
            for (int c = 0; c < 26; c++)
            {
                var j = i;
                while (j >= 0 && c != s[j] - 'a') j = kmp[j];
                ret[i][c] = j + 1;
            }
        return ret;
    }
    /// <summary>sからtをKMPテーブルを使って探す．O(|S|+|T|)</summary>
    /// <returns>isok[i]=s[i,]にtと一致するようなものがある</returns>
    static public bool[] KMPResult(string s, string t, out int[] table)
    {
        table = CreateKMPTable(t);
        var isok = new bool[s.Length];
        int p = 0;
        for (int i = 0; i < s.Length; i++)
        {
            while (p >= 0 && t[p] != s[i]) p = table[p];
            if (++p == t.Length)
            {
                isok[i - t.Length + 1] = true;
                p = table[p];
            }
        }
        return isok;
    }
}
#endregion
#region ModNumber
public partial struct ModInteger
{
    public const long Mod = (long)1e9 + 9;
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