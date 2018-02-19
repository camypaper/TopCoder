using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxAndGo4
{
    public int score(int[] p)
    {
        p = (new int[] { -1 }.Concat(p)).ToArray();
        var n = p.Length;
        var chsize = new int[n];
        var G = Enumerate(n, x => new List<int>());
        for (int i = n - 1; i > 0; i--)
        {
            chsize[p[i]] += chsize[i] + 1;
            G[p[i]].Add(i);
        }
        Debug.WriteLine(string.Join(" ", chsize));

        var dp = new HashMap<KeyValuePair<long, long>, int>();
        Func<long, long, int> dfs = null;
        dfs = (used, mask) =>
          {
              var key = new KeyValuePair<long, long>(used, mask);
              int ret = 0;
              if (dp.TryGetValue(key, out ret)) return ret;
              Debug.WriteLine("{0} {1}", used, mask);
              var can = false;
              for (int i = 1; i < n; i++)
              {
                  if ((used >> i & 1) == 1) continue;
                  if ((mask >> i & 1) == 1) continue;
                  if (G[i].Count == 0) continue;
                  if ((used >> p[i] & 1) == 1) can = true;
              }
              if (!can)
              {
                  ret = 0;
                  used |= mask;
                  for (int i = 0; i < n; i++)
                      if ((used >> i & 1) == 0)
                          ret++;
              }
              else
              {
                  ret = 114514;
                  for (int i = 1; i < n; i++)
                  {
                      if ((used >> i & 1) == 1) continue;
                      if ((mask >> i & 1) == 1) continue;
                      if (G[i].Count == 0) continue;
                      if ((used >> p[i] & 1) == 1)
                      {
                          var nused = used;
                          nused |= 1L << i;
                          foreach (var to in G[i])
                              if (G[to].Count == 0) nused |= 1L << to;
                          var nret = -1;
                          var kouho = new List<KeyValuePair<int, long>>();
                          for (int j = 1; j < n; j++)
                          {
                              if ((nused >> j & 1) == 1) continue;
                              if ((mask >> j & 1) == 1) continue;
                              if (G[j].Count == 0) continue;
                              if ((nused >> p[j] & 1) == 1)
                              {
                                  var nmask = mask;
                                  nmask |= 1L << j;
                                  kouho.Add(new KeyValuePair<int, long>(chsize[j], nmask));
                              }

                          }
                          kouho.Sort((l, r) => l.Key.CompareTo(r.Key));
                          var mi = Math.Min(4, kouho.Count);
                          for (int ii = 0; ii < mi; ii++)
                              nret = Math.Max(nret, dfs(nused, kouho[ii].Value));
                          if (nret < 0) nret = dfs(nused, mask);
                          ret = Math.Min(ret, nret);
                      }

                  }

              }

              return dp[key] = ret;
          };
        var s = 1L;
        foreach (var to in G[0]) if (G[to].Count == 0) s |= 1L << to;
        var ans = dfs(s, 0);
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
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
public class HashMap<K, V>: Dictionary<K, V>
{
    public HashMap() : base() { }
    new public V this[K i]
    {
        get
        {
            V v;
            return TryGetValue(i, out v) ? v :
                base[i] = default(V);
        }
        set { base[i] = value; }
    }
}
