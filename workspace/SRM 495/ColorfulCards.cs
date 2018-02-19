using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ColorfulCards
{
    public int[] theCards(int N, string colors)
    {
        var primes = MathEx.Sieve(10000);

        var n = colors.Length;
        var ok = new int[n, 1050];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < 1050; j++)
                ok[i, j] = -1;
        Func<int, int, int> dfs = null;

        dfs = (pos, val) =>
          {
              if (ok[pos, val] >= 0) return ok[pos, val];
              if (pos == n - 1) return ok[pos, val] = 1;
              for (int i = val + 1; i <= N; i++)
              {
                  if (colors[pos + 1] == 'R' && !primes[i]) continue;
                  if (colors[pos + 1] == 'B' && primes[i]) continue;
                  if (dfs(pos + 1, i) == 1) return ok[pos, val] = 1;
              }
              return ok[pos, val] = 0;
          };
        var ans = new int[n];
        var min = 0;
        for (int i = 0; i < n; i++)
        {
            var s = new List<int>();
            for (int j = min + 1; j <= N; j++)
            {
                if ((colors[i] == 'R' && primes[j]) || (colors[i] == 'B' && !primes[j]))
                    if (dfs(i, j) == 1)
                        s.Add(j);
            }
            ans[i] = s.Count == 1 ? s[0] : -1;
            min = s[0];
        }


        return ans;
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
#region sieve
static public partial class MathEx
{
    static public bool[] Sieve(int p)
    {
        var isPrime = new bool[p + 1];
        for (int i = 2; i <= p; i++) isPrime[i] = true;
        for (int i = 2; i * i <= p; i++)
            if (!isPrime[i]) continue;
            else
                for (int j = i * i; j <= p; j += i)
                    isPrime[j] = false;
        return isPrime;
    }
}
#endregion