using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DivFree
{
    public int dfcount(int n, int k)
    {
        var hash = new List<int>();
        var X = new int[50050];
        for (int v = 1; v <= 50000; v++)
        {
            var p = new List<int>();
            var x = v;
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i != 0) continue;
                var y = 0;
                while (x % i == 0) { x /= i; y++; }
                p.Add(y);
            }
            if (x > 1) p.Add(1);
            p.Sort();
            var h = 0;
            foreach (var z in p) h = h * 16 + z;
            X[v] = h;
            hash.Add(h);
        }
        hash = hash.Distinct().ToList(); hash.Sort();
        for (int i = 1; i <= 50000; i++)
            X[i] = hash.BinarySearch(X[i]);
        Debug.WriteLine(hash.Count);
        var cnt = new int[132];
        var dame = new int[132, 132];
        var used = new bool[132];
        for (int v = 1; v <= 50000; v++)
        {
            if (used[X[v]]) continue;
            used[X[v]] = true;
            var x = v;
            for (int i = 1; i * i <= x; i++)
            {
                if (x % i != 0) continue;
                if (i != x)
                {
                    var xx = X[v];
                    var yy = X[i];
                    dame[xx, yy]++;
                }
                if (x / i != i && x / i != x)
                {

                    var xx = X[v];
                    var yy = X[x / i];
                    dame[xx, yy]++;
                }
            }

        }
        for (int i = 1; i <= k; i++)
            cnt[X[i]]++;
        const int SIZE = 132;
        var mat = new ModMatrix(SIZE, SIZE);
        for (int i = 0; i < SIZE; i++)
            for (int j = 0; j < SIZE; j++)
                mat[j, i] = cnt[j] - dame[i, j];
        var res = ModMatrix.Pow(mat, n);
        var vec = new ModMatrix(SIZE, 1);
        vec[X[1], 0] = 1;
        var ret = res * vec;
        ModInteger ans = 0;
        for (int i = 0; i < SIZE; i++)
            ans += ret[i, 0];

        return (int)(ans.num);
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
    public static ModMatrix operator +(ModMatrix l, ModMatrix r)
    {
        check(l, r);
        var ret = new ModMatrix(l.row, l.col);
        for (int i = 0; i < l.row; i++)
            for (int j = 0; j < l.col; j++)
            {
                ret.mat[i * ret.col + j] = l.mat[i * l.col + j] + r.mat[i * r.col + j];
                if (ret.mat[i * ret.col + j] >= ModInteger.Mod) ret.mat[i * ret.col + j] -= ModInteger.Mod;
            }
        return ret;

    }
    public static ModMatrix operator *(ModMatrix l, ModMatrix r)
    {
        checkMul(l, r);
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
    public static ModMatrix[] PowTable(ModMatrix m, int k)
    {
        var ret = new ModMatrix[k];
        ret[0] = m;
        for (int i = 1; i < k; i++)
            ret[i] = ret[i - 1] * ret[i - 1];
        return ret;
    }
    public static ModMatrix PowWithTable(ModMatrix m, long n, ModMatrix[] table)
    {
        var ret = new ModMatrix(m.row, m.col);
        for (int i = 0; i < m.row; i++)
            ret.mat[i * m.col + i] = 1;
        for (int i = 0; i < table.Length; i++)
        {
            if ((n & 1) == 1) ret = ret * table[i];
        }
        return ret;
    }
    public static ModMatrix Trans(ModMatrix m)
    {
        var ret = new ModMatrix(m.col, m.row);
        for (int i = 0; i < m.row; i++)
            for (int j = 0; j < m.col; j++)
                ret.mat[j * m.col + i] = m.mat[i * m.col + j];
        return ret;
    }
    [System.Diagnostics.Conditional("DEBUG")]
    static private void check(ModMatrix a, ModMatrix b)
    {
        if (a.row != b.row || a.col != b.col)
            throw new Exception("row and col have to be same.");

    }
    [System.Diagnostics.Conditional("DEBUG")]
    static private void checkMul(ModMatrix a, ModMatrix b)
    {
        if (a.col != b.row)
            throw new Exception("row and col have to be same.");

    }
    public ModInteger[][] Items
    {
        get
        {
            var a = new ModInteger[row][];
            for (int i = 0; i < row; i++)
            {
                a[i] = new ModInteger[col];
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
    public void Visualize()
    {
        var items = Items;
        foreach (var x in items)
            System.Diagnostics.Debug.WriteLine(x.AsJoinedString("\t"));
    }
}
#endregion