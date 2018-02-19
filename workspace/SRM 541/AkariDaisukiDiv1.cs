using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = ModInt;
public class AkariDaisukiDiv1 {
    public int countF(string Waai, string Akari, string Daisuki, string s, string F, int k) {
        const long MOD = (long)1e9 + 7;
        long ans = 0;
        for (int _ = 0; _ < Math.Min(60, k); _++) {
            //Debug.WriteLine(ans);
            //Debug.WriteLine(s);
            var sb = new StringBuilder();
            sb.Append(Waai);
            sb.Append(s);
            sb.Append(Akari);
            sb.Append(s);
            sb.Append(Daisuki);
            var ns = sb.ToString();
            if (ns.Contains('$')) {
                ans *= 2;
                var nadd = 0;
                //Debug.WriteLine(s);
                for (int i = 0; i < ns.Length; i++) {
                    if (i + F.Length > ns.Length) break;
                    var ok = true;
                    for (int j = 0; j < F.Length; j++)
                        if (ns[i + j] != F[j]) ok = false;
                    if (ok)
                        nadd++;
                }
                for (int i = 0; i < s.Length; i++) {
                    if (i + F.Length > s.Length) break;
                    var ok = true;
                    for (int j = 0; j < F.Length; j++)
                        if (s[i + j] != F[j]) ok = false;
                    if (ok)
                        nadd -= 2;
                }
                ans += nadd;
                ans %= MOD;
                //Debug.WriteLine($"{ans} {nadd}");
                if (_ == 59) {
                    k -= 60;
                    var a = 2;
                    var b = nadd;
                    var mat = new Matrix(2, 2);
                    mat[0, 0] = a;
                    mat[0, 1] = b;
                    mat[1, 1] = 1;
                    var pow = Matrix.Pow(mat, k);
                    ans *= pow[0, 0].num;
                    ans += pow[0, 1].num;
                    ans %= MOD;
                    return (int)ans;
                }
            }
            else {
                ans = 0;
                for (int i = 0; i < ns.Length; i++) {
                    if (i + F.Length > ns.Length) break;
                    var ok = true;
                    for (int j = 0; j < F.Length; j++)
                        if (ns[i + j] != F[j]) ok = false;
                    if (ok) ans++;
                }
            }
            if (s.Contains('$') || ns.Length > 50) {
                s = ns.Substring(0, 50);
                s += '$';
                s += ns.Substring(ns.Length - 50, 50);
            }
            else s = ns;
        }
        return (int)ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string Waai, string Akari, string Daisuki, string S, string F, int k) {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX {
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester {
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run() {
        //Tests.Add(null);
        Test(Example5);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example6);

    }
}
// CUT end

#region Matrix
public class Matrix {
    int row, col;
    public Number[] mat;
    public Number this[int r, int c] {
        get { return mat[r * col + c]; }
        set { mat[r * col + c] = value; }
    }
    public Matrix(int r, int c) {
        row = r; col = c;
        mat = new Number[row * col];
    }
    public static Matrix operator +(Matrix l, Matrix r) {
        var ret = new Matrix(l.row, l.col);
        for (int i = 0; i < l.row; i++)
            for (int j = 0; j < l.col; j++)
                ret.mat[i * ret.col + j] = l.mat[i * l.col + j] + r.mat[i * r.col + j];
        return ret;

    }
    public static Matrix operator *(Matrix l, Matrix r) {
        var ret = new Matrix(l.row, r.col);
        for (int i = 0; i < l.row; i++)
            for (int k = 0; k < l.col; k++)
                for (int j = 0; j < r.col; j++)
                    ret.mat[i * r.col + j] = (ret.mat[i * r.col + j] + l.mat[i * l.col + k] * r.mat[k * r.col + j]);
        return ret;
    }
    public static Matrix Pow(Matrix m, long n) {
        var ret = new Matrix(m.row, m.col);
        for (int i = 0; i < m.row; i++)
            ret.mat[i * m.col + i] = 1;
        for (; n > 0; m *= m, n >>= 1)
            if ((n & 1) == 1)
                ret = ret * m;
        return ret;

    }
    public static Matrix Trans(Matrix m) {
        var ret = new Matrix(m.col, m.row);
        for (int i = 0; i < m.row; i++)
            for (int j = 0; j < m.col; j++)
                ret.mat[j * m.col + i] = m.mat[i * m.col + j];
        return ret;
    }
    public Number[][] Items {
        get {
            var a = new Number[row][];
            for (int i = 0; i < row; i++) {
                a[i] = new Number[col];
                for (int j = 0; j < col; j++)
                    a[i][j] = mat[i * col + j];
            }
            return a;
        }
    }
    public override string ToString() {
        return string.Format("{0}*{1}", row, col);
    }
}
#endregion

//è—]ŠÂ
#region ModInt
public struct ModInt {
    public const long Mod = (int)1e9 + 7;
    public long num;
    public ModInt(long n) { num = n; }
    public override string ToString() { return num.ToString(); }
    public static ModInt operator +(ModInt l, ModInt r) { l.num += r.num; if (l.num >= Mod) l.num -= Mod; return l; }
    public static ModInt operator -(ModInt l, ModInt r) { l.num -= r.num; if (l.num < 0) l.num += Mod; return l; }
    public static ModInt operator *(ModInt l, ModInt r) { return new ModInt((int)(l.num * (long)r.num % Mod)); }
    public static implicit operator ModInt(long n) { n %= Mod; if (n < 0) n += Mod; return new ModInt(n); }
    //public static implicit operator ModInt(int n) { n %= Mod; if (n < 0) n += Mod; return new ModInt((int)n); }
    public static ModInt Pow(ModInt v, long k) { return Pow(v.num, k); }
    public static ModInt Pow(int v, long k) {
        int ret = 1;
        for (k %= Mod - 1; k > 0; k >>= 1, v = (int)(v * (long)v % Mod))
            if ((k & 1) == 1) ret = (int)(ret * (long)v % Mod);
        return new ModInt(ret);
    }
    public static ModInt Inverse(ModInt v) { return Pow(v, Mod - 2); }
}
#endregion