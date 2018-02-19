using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Point = System.Numerics.Complex;

public class CoastGuard
{
    public int count(int[] d, int[] x, int[] y)
    {
        Array.Sort(d);
        var n = x.Length;
        var p = Enumerate(n, i => new Complex(x[i], y[i]));
        Array.Sort(p, (l, r) =>
         {
             var cmp = r.Imaginary.CompareTo(l.Imaginary);
             if (cmp != 0) return cmp;
             return l.Real.CompareTo(r.Real);
         });
        return (int)f(d, p).num;

    }
    ModInteger f(int[] x, Complex[] p)
    {
        var n = x.Length;
        var dp = new ModInteger[n * n + 2, n * n + 2];
        for (int i = 0; i < n * n + 2; i++)
            for (int j = 0; j < n * n + 2; j++)
                dp[i, j].num = -1;
        Func<int, int, List<int>, List<int>, ModInteger> dfs = null;
        dfs = (a, b, xs, ps) =>
          {
              if (dp[a, b].num != -1) return dp[a, b];
              if (xs.Count == 0 && ps.Count == 0) return 1;
              if (xs.Count != ps.Count) return 0;
              //Debug.WriteLine("DP: {0} {1}", a, b);
              //Debug.WriteLine(xs.AsJoinedString());
              //Debug.WriteLine(ps.AsJoinedString());
              ModInteger ret = 0;

              var t = ps[0];// ps.RemoveAt(0);
              for (int i = 0; i < xs.Count; i++)
              {
                  var u = xs[i];
                  var lxs = new List<int>();
                  var rxs = new List<int>();

                  var lps = new List<int>();
                  var rps = new List<int>();

                  for (int j = 0; j < xs.Count; j++)
                      if (j < i) lxs.Add(xs[j]);
                      else if (i < j) rxs.Add(xs[j]);
                  var pass = false;
                  for (int j = 1; j < ps.Count; j++)
                  {
                      if (Geometry.CCW(x[u], p[t], p[ps[j]]) == 1) lps.Add(ps[j]);
                      else if (Geometry.CCW(x[u], p[t], p[ps[j]]) == -1) rps.Add(ps[j]);
                      else pass = true;
                  }
                  if (!pass)
                  {
                      ret += dfs(a, u * n + t, lxs, lps) * dfs(u * n + t, b, rxs, rps);
                  }
              }

              return dp[a, b] = ret;
          };
        var ans = dfs(n * n, n * n + 1, Enumerate(n, i => i).ToList(), Enumerate(n, i => i).ToList());
        
        return (int)ans.num;
    }
    ModInteger check(int[] x, Point[] p)
    {
        var n = x.Length;
        var id = Enumerate(n, i => i);
        var ans = 0;
        do
        {
            var ok = true;
            for (int i = 0; i < n && ok; i++)
                for (int j = i + 1; j < n && ok; j++)
                {
                    var l = new Line(x[i], p[id[i]]);
                    var r = new Line(x[j], p[id[j]]);
                    if (Geometry.IntersectSegmentSegment(l, r)) ok = false;
                }
            if (ok)
            {
                //Debug.WriteLine(id.AsJoinedString());
                ans++;
            }
        } while (id.NextPermutation(0, n));
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] d, int[] x, int[] y)
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
        while (false)
        {
            var n = 4;
            var a = Enumerate(n, x => rand.Next(1, 100));
            var b = Enumerate(n, x => rand.Next(1, 100));
            var c = Enumerate(n, x => rand.Next(1, 100));
            Test(f => ManualTest(a, b, c),true);
        }
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);

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
#region Line
public struct Line
{
    public Point P, Q;
    public Point this[int index]
    {
        get
        {
            if (index == 0) return P;
            if (index == 1) return Q;
            throw new IndexOutOfRangeException("0 or 1");
        }
        set
        {
            if (index == 0) P = value;
            if (index == 1) Q = value;
            throw new IndexOutOfRangeException("0 or 1");
        }
    }
    public Line(Point a, Point b) : this() { P = a; Q = b; }
}
#endregion
#region Functions
static public partial class Geometry
{
    public const double EPS = 1e-12;
    static public double Cross(Point a, Point b)
    {
        return (Point.Conjugate(a) * b).Imaginary;
    }
    static public double Dot(Point a, Point b)
    {
        return (Point.Conjugate(a) * b).Real;
    }
    static public int CCW(Point a, Point b, Point c)
    {
        b -= a; c -= a;
        if (Cross(b, c) > 0) return 1;//CCW
        if (Cross(b, c) < 0) return -1;//CW
        if (Dot(b, c) < 0) return 2;//C-A-B
        if (b.Magnitude < c.Magnitude) return -2;//A-B-C
        return 0;
    }
    static public int Compare(Point a, Point b)
    {
        if (a.Real != b.Real)
            return (a.Real > b.Real) ? 1 : -1;
        else if (a.Imaginary != b.Imaginary)
            return a.Imaginary > b.Imaginary ? 1 : -1;
        return 0;
    }
    static public double Norm(Point p)
    {
        return p.Magnitude * p.Magnitude;
    }
    static public bool IntersectSegmentSegment(Line a, Line b)
    {
        return CCW(a.P, a.Q, b.P) * CCW(a.P, a.Q, b.Q) <= 0 && CCW(b.P, b.Q, a.P) * CCW(b.P, b.Q, a.Q) <= 0;
    }
}
#endregion
#region next_permutation
static public partial class Algorithm
{

    static public bool NextPermutation<T>(this T[] array, int first, int last) where T : IComparable<T>
    {
        if (first == last)
            return false;
        var i = last;
        if (--i == first)
            return false;
        while (true)
        {
            var ii = i--;
            if (array[i].CompareTo(array[ii]) < 0)
            {
                var j = last;
                while (array[i].CompareTo(array[--j]) >= 0) { }
                var temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                Array.Reverse(array, ii, last - ii);
                return true;
            }
            if (i == first)
            {
                Array.Reverse(array, first, last - first);
                return false;
            }
        }
    }

}
#endregion