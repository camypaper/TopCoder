using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MagicalMatrix
{
    public double MagicalInspection(int n, int m, int[] prob)
    {
        var P = Enumerate(m, x => new double[n]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                P[j][i] = prob[i * m + j] / 100.0;
        //all one
        var p = new double[m];
        var e = new double[m];
        for (int i = 0; i < m; i++)
        {
            Array.Sort(P[i]);
            var pp = 1.0;
            for (int j = 0; j < n; j++)
            {
                e[i] += pp;
                pp *= P[i][j];
            }
            p[i] = 1 - pp;
        }
        var ids = Enumerate(m, x => x);
        var val = 0.0;
        var q = 1.0;
        Array.Sort(ids, (l, r) => (e[l] + p[l] * e[r]).CompareTo(e[r] + p[r] * e[l]));
        foreach (var id in ids)
        {
            val += q * e[id];
            q *= p[id];
        }
        return val;
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
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
#region next_permutation
static public partial class MathEx
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