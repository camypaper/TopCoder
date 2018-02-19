using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CubeColoring
{
    public long theCount(string[] colors)
    {
        var n = colors[0].Length;
        var special = new int[] { 0, 2, 5, 7 };
        var other = new int[] { 1, 3, 4, 6 };
        var adj = new int[][] {
            new int[] {0,1,2},
            new int[] {0,1,3},
            new int[] {0,2,3},
            new int[] {1,2,3}};
        var count = new long[4];
        for (int i = 0; i < 4; i++)
        {
            var id = other[i];
            for (int j = 0; j < n; j++)
                if (colors[id][j] == 'Y') count[i] |= 1L << j;
        }
        var ALL = (1L << n) - 1;
        Func<int, int[], long> dfs = null;
        dfs = (pos, col) =>
          {
              if (pos == 4)
              {
                  long ret = 1;
                  for (int i = 0; i < 4; i++)
                  {
                      var id = other[i];
                      var mask = count[i];
                      foreach(var x in adj[i])
                      {
                          var c = col[x];
                          mask &= (ALL ^ (1L << c));
                      }
                      ret *= BitOperation.PopCount(mask);
                  }
                  return ret;
              }
              else
              {
                  var id = special[pos];
                  var ret = 0L;
                  for (int i = 0; i < n; i++)
                  {
                      if (colors[id][i] != 'Y') continue;

                      col[pos] = i;
                      ret += dfs(pos + 1, col);
                      col[pos] = -1;
                  }

                  return ret;
              }
          };
        return dfs(0, Enumerate(4, x => -1));
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
#region BitOperation
static public partial class BitOperation
{
    static public int PopCount(ulong i)
    {
        i = i - ((i >> 1) & 0x5555555555555555UL);
        i = (i & 0x3333333333333333ul) + ((i >> 2) & 0x3333333333333333ul);
        return (int)(unchecked(((i + (i >> 4)) & 0xF0F0F0F0F0F0F0Ful) * 0x101010101010101ul) >> 56);
    }
    static public int PopCount(long i)
    {
        unchecked
        {
            i = i - ((i >> 1) & 0x5555555555555555);
            i = (i & 0x3333333333333333) + ((i >> 2) & 0x3333333333333333);
            return (int)(((i + (i >> 4)) & 0xF0F0F0F0F0F0F0F) * 0x101010101010101) >> 56;
        }
    }
}
#endregion