using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class EllysChessboard
{
    public int minCost(string[] board)
    {
        if (board.SelectMany(x => x).All(x => x == '.')) return 0;
        //board[1] = "#.......";
        //board[0] = ".#......";
        //(i,j)=>(i+j,i-j + 8)
        const int N = 20;
        var dp = new int[N, N, N, N];
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
                for (int k = 0; k < N; k++)
                    for (int l = 0; l < N; l++)
                        dp[i, j, k, l] = -1;
        const int n = 8;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (board[i][j] == '#')
                    dp[i + j, i - j + n, i + j, i - j + n] = 0;
        Func<int, int, int, int, int> dfs = null;
        dfs = (x, y, X, Y) =>
          {
              if (x > X || y > Y) return 1 << 30;
              if (dp[x, y, X, Y] >= 0) return dp[x, y, X, Y];
              var a = new int[4];
              for (int i = 0; i < n; i++)
                  for (int j = 0; j < n; j++)
                  {
                      if (board[i][j] == '.') continue;
                      var u = (i + j);
                      var v = (i - j + n);
                      if (u == x && y <= v && v <= Y) a[0] += Math.Max(X - x, Math.Max(v - y, Y - v));
                      if (u == X && y <= v && v <= Y) a[2] += Math.Max(X - x, Math.Max(v - y, Y - v));
                      if (v == y && x <= u && u <= X) a[1] += Math.Max(Y - y, Math.Max(u - x, X - u));
                      if (v == Y && x <= u && u <= X) a[3] += Math.Max(Y - y, Math.Max(u - x, X - u));
                  }
              a[0] += dfs(x + 1, y, X, Y);
              a[1] += dfs(x, y + 1, X, Y);
              a[2] += dfs(x, y, X - 1, Y);
              a[3] += dfs(x, y, X, Y - 1);
              //Debug.WriteLine("{0} {1} {2} {3} {4}", x, y, X, Y, a.Min());
              return dp[x, y, X, Y] = a.Min();
          };
        var ans = dfs(0, 1, 14, 15);
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] board)
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
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
