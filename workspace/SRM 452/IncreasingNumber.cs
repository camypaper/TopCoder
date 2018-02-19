using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = ModInt;
public class IncreasingNumber
{
    public int countNumbers(long digits, int divisor)
    {
        if (divisor % 10 == 0) return 0;
        var cnt = new long[divisor];
        var dist = Enumerate(divisor, x => -1);
        var p = 1 % divisor;
        var d = 0;
        for (int i = 0; ; i++)
        {
            if (dist[p] == -1)
            {
                dist[p] = i;
                p = (p * 10 + 1) % divisor;
            }
            else { d = i - dist[p]; p = dist[p]; break; }
        }
        for (int i = 0; i < divisor; i++)
        {
            if (dist[i] == -1 || dist[i] >= digits) continue;
            if (dist[i] < p) cnt[i] = 1;
            else cnt[i] = (digits - dist[i] + d - 1) / d;
        }
        Debug.WriteLine(cnt.AsJoinedString());
        inv = new ModInt[20];
        inv[0] = 1;
        for (int i = 1; i < 20; i++)
            inv[i] = i * inv[i - 1];
        for (int i = 0; i < 20; i++)
            inv[i] = ModInt.Inverse(inv[i]);
        var dp = new ModInt[divisor, 10];
        dp[f(digits, divisor), 1] = 1;
        for (int i = 0; i < divisor; i++)
        {
            for (int j = 9; j >= 0; j--)
                for (int k = 0; k < divisor; k++)
                {
                    if (dp[k, j].num == 0) continue;
                    for (int l = 1; l + j <= 9; l++)
                    {
                        dp[(k + l * i) % divisor, j + l] += dp[k, j] * comb(cnt[i] + l - 1, l);
                    }
                }
        }
        ModInt ans = 0;
        for (int i = 1; i < 10; i++)
            ans += dp[0, i];
        return (int)ans.num;
    }
    long f(long d, long mod)
    {
        ModInt.Mod = mod;
        var mat = new Matrix(2, 2);
        mat[0, 0] = 10; mat[0, 1] = 1;
        mat[1, 1] = 1;
        var ret = Matrix.Pow(mat, d);
        ModInt.Mod = (long)1e9 + 7;
        return (ret[0, 1]).num;
    }
    ModInt[] inv;
    ModInt comb(long n, long k)
    {
        n %= ModInt.Mod;
        ModInt u = 1;
        for (int i = 0; i < k; i++)
            u *= n + i * (ModInt.Mod - 1);

        return u * inv[k];
    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(long digits, int divisor)
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
    public override void Run()
    {
        ManualTest(865199921304978104, 172);
        ManualTest(749886849151962303, 1);
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);

    }
}
// CUT end
#region ModInt
public struct ModInt
{
    public static long Mod = (long)1e9 + 7;
    public long num;
    public ModInt(long n) { num = n; }
    public override string ToString() { return num.ToString(); }
    public static ModInt operator +(ModInt l, ModInt r) { l.num += r.num; if (l.num >= Mod) l.num -= Mod; return l; }
    public static ModInt operator -(ModInt l, ModInt r) { l.num -= r.num; if (l.num < 0) l.num += Mod; return l; }
    public static ModInt operator *(ModInt l, ModInt r) { return new ModInt(l.num * r.num % Mod); }
    public static implicit operator ModInt(long n) { n %= Mod; if (n < 0) n += Mod; return new ModInt(n); }
    public static ModInt Pow(ModInt v, long k)
    {
        k %= Mod - 1;
        ModInt ret = 1;
        var n = k;
        for (; n > 0; n >>= 1, v *= v)
            if ((n & 1) == 1) ret = ret * v;
        return ret;
    }
    public static ModInt Inverse(ModInt v)
    {
        return Pow(v, Mod - 2);
    }
}
#endregion
#region Matrix
public class Matrix
{
    int row, col;
    public Number[] mat;
    public Number this[int r, int c]
    {
        get { return mat[r * col + c]; }
        set { mat[r * col + c] = value; }
    }
    public Matrix(int r, int c)
    {
        row = r; col = c;
        mat = new Number[row * col];
    }

    public static Matrix operator *(Matrix l, Matrix r)
    {
        var ret = new Matrix(l.row, r.col);
        for (int i = 0; i < l.row; i++)
            for (int k = 0; k < l.col; k++)
                for (int j = 0; j < r.col; j++)
                    ret.mat[i * r.col + j] = (ret.mat[i * r.col + j] + l.mat[i * l.col + k] * r.mat[k * r.col + j]);
        return ret;
    }
    public static Matrix Pow(Matrix m, long n)
    {
        var ret = new Matrix(m.row, m.col);
        for (int i = 0; i < m.row; i++)
            ret.mat[i * m.col + i] = 1;
        for (; n > 0; m *= m, n >>= 1)
            if ((n & 1) == 1)
                ret = ret * m;
        return ret;
    }
    public Number[][] Items
    {
        get
        {
            var a = new Number[row][];
            for (int i = 0; i < row; i++)
            {
                a[i] = new Number[col];
                for (int j = 0; j < col; j++)
                    a[i][j] = mat[i * col + j];
            }
            return a;
        }
    }
    public override string ToString()
    {
        return string.Format("{0}*{1}", row, col);
    }
}
#endregion