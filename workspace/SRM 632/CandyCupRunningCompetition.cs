using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CandyCupRunningCompetition
{
    public int findMaximum(int N, int[] A, int[] B)
    {
        const long MOD = (long)1e9 + 7;
        var m = A.Length;
        var powed = new long[m + 1];
        powed[0] = 1;
        for (int i = 1; i <= m; i++)
            powed[i] = (powed[i - 1] * 3) % MOD;
        long ans = 0;
        var used = new bool[m];
        for (int i = m - 1; i >= 0; i--)
        {
            var s = new DisjointSet(N);
            for (int j = i; j < m; j++)
            {
                if (used[j]) continue;
                s.Unite(A[j], B[j]);
            }
            if (s.IsUnited(0, N - 1))
            {
                ans = (ans + powed[i]) % MOD;
                used[i] = true;
            }
        }

        return (int)ans;
    }
    // CUT begin
    public int Naive_Test(int N, int[] A, int[] B)
    {
        return 0;
    }

    // CUT end
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