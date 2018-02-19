using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class KingdomXCitiesandVillages
{
    public double determineLength(int[] X, int[] Y, int[] U, int[] V)
    {
        var n = X.Length;

        var m = U.Length;
        var D = Enumerate(m, x => 1L << 60);
        var d = Enumerate(m, x => new List<long>());

        var comb = Enumerate(55, x => new long[55]);
        comb[0][0] = 1;
        for (int i = 0; i < 52; i++)
            for (int j = 0; j < 52; j++)
            {
                comb[i + 1][j] += comb[i][j];
                comb[i + 1][j + 1] += comb[i][j];
            }

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                long dx = U[i] - X[j];
                long dy = V[i] - Y[j];
                D[i] = Math.Min(D[i], dx * dx + dy * dy);
            }
        for (int i = 0; i < m; i++)
            for (int j = 0; j < m; j++)
            {
                if (i == j) continue;
                long dx = U[i] - U[j];
                long dy = V[i] - V[j];
                d[i].Add(dx * dx + dy * dy);
            }
        var E = 0.0;
        for (int i = 0; i < m; i++)
        {
            d[i].Sort();
            foreach (var x in d[i].Distinct())
            {
                if (x >= D[i]) continue;
                var mi = d[i].Count(y => y < x);
                var miq = d[i].Count(y => y == x);
                var rem = m - 1 - mi - miq;
                for (int u = 1; u <= miq; u++)
                    for (int v = 0; v <= rem; v++)
                    {
                        var pat = 1.0;
                        pat *= comb[miq][u];
                        pat *= comb[rem][v];
                        var f = u + v;
                        var t = m - 1 - f;
                        pat /= comb[m - 1][f];
                        pat /= m;
                        E += Math.Sqrt(x) * pat;

                    }
            }
            {
                var mi = d[i].Count(y => y < D[i]);
                var rem = m - 1 - mi;
                for (int v = 0; v <= rem; v++)
                {
                    var pat = 1.0;
                    pat *= comb[rem][v];
                    var f = v;
                    var t = m - 1 - f;
                    pat /= comb[m - 1][f];
                    pat /= m;
                    E += Math.Sqrt(D[i]) * pat;
                }
            }
        }
        return E;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public double Naive_Test(int[] cityX, int[] cityY, int[] villageX, int[] villageY)
    {
        return 0.0;
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
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);

    }
}
// CUT end
