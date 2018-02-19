using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class HexagonalBoard
{
    public int minColors(string[] board)
    {
        var size = board.Length * board[0].Length;


        if (board.SelectMany(x => x).Count(x => x == 'X') == 0) return 0;
        var max = 0;
        var checker = new BiparateGraphChecker(board.Length * board[0].Length);
        for (int i = 0, n = board.Length, m = board[0].Length; i < board.Length; i++)
            for (int j = 0; j < m; j++)
            {
                if (board[i][j] != 'X') continue;
                max = Math.Max(max, 1);
                var l = j - 1;
                var r = j + 1;
                if (l >= 0 && board[i][l] == 'X') checker.AddEdge(i * m + j, i * m + l);
                if (r < m && board[i][r] == 'X') checker.AddEdge(i * m + j, i * m + r);
                var d = i + 1;
                if (d < n && l >= 0 && board[d][l] == 'X') checker.AddEdge(i * m + j, d * m + l);
                if (d < n && board[d][j] == 'X') checker.AddEdge(i * m + j, d * m + j);
            }
        if (checker.called)
        {
            if (checker.OK)
                max = Math.Max(max, 2);
            else max = Math.Max(max, 3);
        }
        return max;
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
        var S = new string[] {
"XXXXXXXX--XX--XXXXXXX-XXXXXXXXX-XXXXXXXX-X-XXX-XXX",
 "XXXXXXX--XXX-XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX-XXXX",
  "XX-XXX---XXXXXXXXXXXXXXX-XXX--X-XXXX--XXXXXXXXXXX-",
"--X-XXXXXXXXXXXXXX--XXXXX-XXXXXXXXXXX--XX-XXXXX-X-", "-XXXXXX-XXXXX-X-XX--XX---X-XXXXXXXXX-XXXXX-XXX-X-X", "-XXXXXXXX---XXXXXXXXXXXXXXXXXXXXXXXXXXX-XXXXXXXX-X", "-XXXXXXXX-XXXXXXXXX-XXXX-X-XXXXXXXXXXXXXXXX-XXXXXX", "XXXXXXXX-XXXXXX-XXXXXXX-XXXXX-XXXXXXX--XXXXX-XXX--", "XXX--XX-XXXX-X-XX-X-XX-XXXXX--XX-XX--XXXXXX--XXXXX", "XXXXXXXXX-XXXXXXX-XX-X-XXXXXX-XX-XXXXXXX-XX-XXXX-X", "XXXXXXX-X-XXXXX--XXXXXXXXXXXXX-XXXXX-X-XXXXXXX--XX", "XX-XXXXXXX-XX--XXX-XXXXXXXXXXX----XXXX-XXXXXXXX-XX", "XXXX---XXXXXXXX-XXX--XXXX-XXXXXXXXXXXXXXXXXXXXX-X-", "XXXXXX-XXX-XXXXXXXXX-XXXXXXX-XXXXXX-X-XXXXXXXXXXXX", "-XXXXX-XXXXXXXXXXXXXXX-XX-XXXXXXXXXXXXXXXXXXXX-XX-", "XXX-XXX-XXXXXX-XXXXXXXXXXX-XX--XXXXXXXX-XXXXX--XX-", "XX-XXX-XXX-XXXXXXXXX-XX-XXXX-X-X-XX-XXX-X-XXX-XX-X", "XXXXXXXX-XXXXXX-XX-XX-XXX-XX-XXX-XXXXXXXX-X-XXXXXX", "XXXXX-XXXXXX-XXXXX--XXXXXXX-X-XXXX-XXXXXXXXXXXXXX-", "X-XXX--XXXXXX-X-XXXXX--XX-XXX-XXXXXX-X-XXXXXX-XXXX", "XXXXXXXXXX-XX-XXXXXXXX-XXXXXXXXXXXX-X-XXXXXXXXXXXX", "-X-XXXXXXXX--XXXXXXXXXXXXXXXXXXXXXXXX-XXXX--XXXXXX", "XX-XXXX-XXXXXXXXXXXXXXXX-X-XXXXXX-X-X-X-XXX-XXXXXX", "-XXX---XXXXX-X-XXXXXXXXX-XXXXXXXXXXXXX-XXX--XX-X-X", "-X-XXXXXXXXXXXXXXXXX-XXX-XXXX-XXXX--XXXXXX-X-XXXXX", "XXXXXXXX-X-XXXX---XXXXXXXXX--XX-X-XXXXXXXX-XXXXXXX", "-XXX-XXXXXXXXX-XXXXXXXXX-X-XXXXXXXXX-XXXX-XXXXXX-X", "XXXXXXXXXXXXXXXXXX-XX-XXX-XXXXXXXX---XXXXX-XXX--XX", "XXXX-XXXX-XXXX-X-XXX-XXXXXXXXXX-XX-XXXXXXXXXXXX--X", "--XX-XX-XXXX-XX-XXXXXXXXXXXXXX-XXXXXXXX-X-XXXXXXXX", "X-XXXXX-XXX-XXXXXXXXXXXX-XXX-XXXXXX-XX-XXXXXXX-XXX", "-XXXXXXXX-XXXXX-XXX--XXXXXXXXXX-XXXX-XXXXXXXXXXXXX", "X--XXX-XXXXX-XXXXXXXXXX-XXXXX-X-XXXXXXX--XXXXXXXXX", "XX--XXXX-X-XXXXX-XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX-XX", "X-X--XXXXXX--XXXX--XX-XXXXXXXXXXXX-XXXXXXXXXXX-XXX", "XXXXX-XXXXXXX-X--XXXXXXXXXXXX-XXXXXX--X-XXXXXXXXXX", "-X-XXXXXXXXXXXXXXX-XX-XXXXXXX-X-XXX--X-XX-XX-XXXXX", "XXXXXXXXXX-XXXX-XX-XXX-XXXX-XXXXXXX-XX--XXXXX-X---", "XXXXXXXXXXXXXXXX-XXXXXXX-XXXXXX-XXXXXXXXXXXXXXXXX-", "-X--X-XXXXXXX-X--XXX-XX-XXXXX-XXXXXXXXXXXXXXXXXXX-", "X-XXX-XXXXXX-XXXX-XX-XX-XXXXXX-X-XXXXXX-XXXXXXXXXX", "XXXXX--XXXXXXXXXXXXXXXX--XX-X--XXXXXXX-X-XXXXX-X-X", "XXXXXXXXXXXX--XXXX-XX--XXXXX-XXXXXXXXX--XX-XXX-XXX", "-XXXXXXX-XXXXX--X-XXXXX--XXX-XXXXXXXXXX-XX-XXXXXXX", "XXXX-XXXXXXXXXXX--XXXXXXXXXX-XXX-XXX-XXXXX-X-X-XX-", "XXX-XX--XXXXXXXXX--XX--XXXXXXX-XXXXX-XXXXXX-XXXXXX", "-XXXXXXXXXX-XXXXX--XXXXXXXXXXXXXXXXXXX-X-XXXX-XXXX", "XXXXXX-X--XXXXX-X-XXXXXXXXXXXXXX-XXXXXXX-XX-X-X--X", "XX-XXXX-XXXXX-XXXXXXXXXX-XXX-XXXXXX-XXXX-XXXXXXXXX", "XXXXXXX-XXXXX-XXXXXXX-XXX-XX--X-X-XXXXXXXX-XXX-XXX" };
        test.ManualTest(S);
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
#region BiparateGraphChecker
public class BiparateGraphChecker
{
    int n;
    bool ok = true;
    public DisjointSet set;
    public BiparateGraphChecker(int size)
    {
        n = size;
        set = new DisjointSet(2 * n);
    }
    public bool called = false;
    public void AddEdge(int f, int t)
    {
        called = true;
        set.Unite(f, t + n);
        set.Unite(t, f + n);
        if (set.IsUnited(f, f + n))
            ok = false;
        if (set.IsUnited(t, t + n))
            ok = false;
    }
    public bool OK { get { return ok; } }
}
#endregion