using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ColorfulParentheses
{
    public long count(int[] color)
    {
        var n = color.Length / 2;

        var a = new int[n];
        var b = new int[n];
        var cnt = new int[50];
        foreach (var x in color)
            cnt[x]++;
        var xs = new List<int>();
        for (int i = 0; i < n; i++)
            for (int j = n; j < 2 * n; j++)
                if (color[i] == color[j]) xs.Add(color[i]);
        xs = xs.Distinct().ToList(); xs.Sort();
        var ma = Enumerate(n, x => -1);
        var mb = Enumerate(n, x => -1);
        for (int i = 0; i < n; i++)
        {
            a[i] = color[i];
            b[i] = color[i + n];
            var p = xs.BinarySearch(a[i]);
            if (p >= 0) ma[i] = p;
            var q = xs.BinarySearch(b[i]);
            if (q >= 0) mb[i] = q;
        }
        Array.Reverse(b);
        Array.Reverse(mb);
        var U = solve(a, ma, cnt, xs.Count, false);
        var V = solve(b, mb, cnt, xs.Count, true);
        long ans = 0;

        var count = new int[1 << xs.Count];
        for (int i = 0; i <= n; i++)
        {
            foreach (var kv in U[i])
            {
                var k = kv.Key;
                count[k] += kv.Value;
            }
            foreach (var kv in V[i])
                ans += Math.BigMul(kv.Value, count[kv.Key]);

            foreach (var kv in U[i])
            {
                var k = kv.Key;
                count[k] -= kv.Value;
            }
        }
        return ans;
    }
    HashMap<int, int>[] solve(int[] color, int[] mask, int[] cnt, int C, bool otaku)
    {
        var n = color.Length;
        var ret = Enumerate(n + 1, x => new HashMap<int, int>());
        var used = new int[50];
        Func<int, int, int, int, int, int> dfs = null;
        dfs = (p, v, x, A, B) =>
          {
              if (A > n) return 0;
              if (B > n) return 0;
              if (v < 0) return 0;
              if (p == n)
              {
                  ret[v][x]++;
                  return 0;
              }
              var c = color[p];
              if (used[c] != 0)
                  dfs(p + 1, v + used[c], x, A, B);
              else
              {
                  used[c] = 1;
                  var nx = x;
                  if (mask[p] != -1) nx |= 1 << mask[p];
                  if (!otaku)
                  {
                      used[c] = 1;
                      dfs(p + 1, v + used[c], nx, A + cnt[c], B);
                      used[c] = -1;
                      dfs(p + 1, v + used[c], x, A, B + cnt[c]);
                      used[c] = 0;
                  }
                  else
                  {
                      used[c] = 1;
                      dfs(p + 1, v + used[c], x, A, B + cnt[c]);
                      used[c] = -1;
                      dfs(p + 1, v + used[c], nx, A + cnt[c], B);
                      used[c] = 0;
                  }
              }
              return 0;
          };
        dfs(0, 0, 0, 0, 0);
        return ret;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public long Naive_Test(int[] color)
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
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
#region HashMap<K,V>
public class HashMap<K, V>: Dictionary<K, V>
//where V : new()
{
    public HashMap() : base() { }
    public HashMap(int cap) : base(cap) { }
    new public V this[K i]
    {
        get
        {
            V v;
            return TryGetValue(i, out v) ? v :
                base[i] = default(V);
            //base[i] = new V();
        }
        set { base[i] = value; }
    }
}
#endregion