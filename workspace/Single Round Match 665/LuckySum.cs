using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class LuckySum
{
    public long construct(string s)
    {
        var n = s.Length;
        var dp = new string[n + 1, 3, 2];
        for (int i = 0; i < n + 1; i++)
            for (int j = 0; j < 3; j++)
                for (int k = 0; k < 2; k++)
                    dp[i, j, k] = null;
        var vis = new bool[n + 1, 3, 2];
        Func<int, int, int, string> dfs = null;

        int[] a = { 8, 11, 14 };
        int[] b = { 4, 7 };
        dfs = (p, k, f) =>
          {
              if (p == n)
                  return f == 1 ? null : "";
              if (vis[p, k, f])
                  return dp[p, k, f];
              vis[p, k, f] = true;
              for (int i = 0; i < 10; i++)
              {
                  if (s[p] == '?' || s[p] - '0' == i)
                  {
                      if (p == 0 && i == 0)
                          continue;
                      var v = f * 10 + i;
                      if (k == 0 && p < n - 1)
                      {
                          foreach (var x in b)
                          {
                              if (v == 0 && dfs(p + 1, 0, 0) != null)
                              {
                                  return dp[p, k, f] = i.ToString() + dfs(p + 1, 0, 0);
                              }
                              if (v == 0 + 1 && dfs(p + 1, 0, 1) != null)
                              {
                                  return dp[p, k, f] = i.ToString() + dfs(p + 1, 0, 1);
                              }
                          }
                      }
                      if (k <= 1 && p < n - 1)
                      {
                          foreach (var x in b)
                          {
                              if (v == x && dfs(p + 1, 1, 0) != null)
                              {
                                  return dp[p, k, f] = i.ToString() + dfs(p + 1, 1, 0);
                              }
                              if (v == x + 1 && dfs(p + 1, 1, 1) != null)
                              {
                                  return dp[p, k, f] = i.ToString() + dfs(p + 1, 1, 1);
                              }
                          }

                      }
                      if (k <= 2)
                      {
                          foreach (var x in a)
                          {
                              if (v == x && dfs(p + 1, 2, 0) != null)
                              {

                                  return dp[p, k, f] = i.ToString() + dfs(p + 1, 2, 0);

                              }
                              if (v == x + 1 && dfs(p + 1, 2, 1) != null)
                              {
                                  return dp[p, k, f] = i.ToString() + dfs(p + 1, 2, 1);
                              }


                          }

                      }
                      
                     
                  }

              }


              return null;
          };
        var ans = dfs(0, 0, 0);
        if (ans == null)
            return -1;
        return long.Parse(ans);
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
    public override void Test()
    {
        //test.ManualTest("8?????????????");
        /*
        var rand = new Random(0);
        while (true)
        {
            var n = 1 + (rand.Next() % 14);
            var s = Enumerable.Repeat('?', n).ToArray();
            var k = rand.Next() % n;
            for (int i = 0; i < k; i++)
            {
                var x = rand.Next() % n;
                var v = rand.Next() % 10;
                s[x] = (char)(v + '0');
            }
            var str = s.AsString();
            test.ManualTest(str);
        }
        */
        base.Test();
    }
}
// CUT end
