using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class HexagonPuzzle
{
    public int theCount(string[] board)
    {
        var n = board.Length;
        var id = Enumerate(n, x => new int[x + 1]);

        var size = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
                id[i][j] = size++;
        }
        var set = new DisjointSet(size);
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                var p = id[i][j];
                var q = id[i + 1][j];
                var r = id[i + 1][j + 1];
                if (board[i][j] != 'X' && board[i + 1][j] != 'X' && board[i + 1][j + 1] != 'X')
                {
                    set.Unite(p, q);
                    set.Unite(q, r);
                }
            }
            for (int j = 0; j < i; j++)
            {
                var p = id[i][j];
                var q = id[i][j + 1];
                var r = id[i + 1][j + 1];
                if (board[i][j] != 'X' && board[i][j + 1] != 'X' && board[i + 1][j + 1] != 'X')
                {
                    set.Unite(p, q);
                    set.Unite(q, r);
                }
            }
        }
        var fact = new ModInteger[100000];
        fact[0] = fact[1] = fact[2] = 1;
        for (int i = 3; i < 100000; i++)
            fact[i] = fact[i - 1] * i;
        ModInteger ans = 1;
        for (int i = 0; i < size; i++)
            if (set[i] == i) ans *= fact[set.Size(i)];
        return (int)ans.num;
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
        var board = new string[] { ".", "X.", "...", "....", ".....", "......", ".......", "..X.....", "X........", "..X.......", "...........", "............", ".....X.......", "..............", "..X............", "................", ".............X..X", "..........XX......", "..X....XX..........", "...X.......X........", "..........XX.....X.X.", "....................X.", "XX..X..................", "........................", "..XX........X............", ".....X.......X............", "............X....X..X....X.", "....X........X..X...........", ".............................", "........X..............X...X..", "X....X........X....X......X....", ".............X..................", "...........................X.....", ".......X........................X.", "......X.........X.............X...X", "...XX..X...................X..X.X...", "...................................X.", "...........................X.....X....", ".......X..X......X...X.X..X.X.....X....", ".X.....X..X.....................X.......", "....X.X...X............X.................", "...XX..X............X.......X.............", "...................X..........X............", "..X..X.X...................X.....X....X.....", "X...X..X.........X.....X....X................", ".....................X.............X..........", ".......................X......................." };
        test.ManualTest(board);
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

#region ModNumber
public partial struct ModInteger
{
    public const long Mod = (long)1e9 + 7;
    public long num;
    public ModInteger(long n) : this() { num = n % Mod; if (num < 0) num += Mod; }
    public override string ToString() { return num.ToString(); }
    public static ModInteger operator +(ModInteger l, ModInteger r) { var n = l.num + r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator -(ModInteger l, ModInteger r) { var n = l.num + Mod - r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator *(ModInteger l, ModInteger r) { return new ModInteger(l.num * r.num); }
    public static implicit operator ModInteger(long n) { return new ModInteger(n); }
}
#endregion