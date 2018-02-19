using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MakingTournament
{
    public int howManyWays(long N, int K)
    {
        var mat = new ModMatrix(1 << K, 1 << K);
        for (int i = 0; i < 1 << K; i++)
        {
            var ni = i;
            for (int j = 0; j <= K; j++)
            {
                if ((ni >> j & 1) == 0)
                {
                    if (j != K)
                        ni |= 1 << j;
                    mat[ni, i] = 1;
                    break;
                }
                else
                {
                    mat[ni, i] = 1;
                    ni ^= 1 << j;
                }
            }
        }
        var ret = ModMatrix.Pow(mat, N);
        ModInteger ans = ret[0, 0];
        return (int)ans.num;
    }
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
#region ModMatrix
public class ModMatrix
{
    int row, col;
    public long[] mat;
    public ModInteger this[int r, int c]
    {
        get { return mat[r * col + c]; }
        set { mat[r * col + c] = value.num; }
    }
    public ModMatrix(int r, int c)
    {
        row = r; col = c;
        mat = new long[row * col];
    }
   
    public static ModMatrix operator *(ModMatrix l, ModMatrix r)
    {
        var ret = new ModMatrix(l.row, r.col);
        for (int i = 0; i < l.row; i++)
            for (int k = 0; k < l.col; k++)
                for (int j = 0; j < r.col; j++)
                    ret.mat[i * r.col + j] = (ret.mat[i * r.col + j] + l.mat[i * l.col + k] * r.mat[k * r.col + j]) % ModInteger.Mod;
        return ret;
    }
    public static ModMatrix Pow(ModMatrix m, long n)
    {
        var ret = new ModMatrix(m.row, m.col);
        for (int i = 0; i < m.row; i++)
            ret.mat[i * m.col + i] = 1;
        for (; n > 0; m *= m, n >>= 1)
            if ((n & 1) == 1)
                ret = ret * m;
        return ret;

    }
  
}
#endregion