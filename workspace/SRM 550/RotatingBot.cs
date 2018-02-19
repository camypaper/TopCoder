using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RotatingBot
{
    public int minArea(int[] moves)
    {
        if (moves.Length == 1)
            return moves[0] + 1;
        if (moves.Length == 2)
            return (moves[0] + 1) * (moves[1] + 1);
        if (moves.Length == 3)
            return (Math.Max(moves[0], moves[2]) + 1) * (moves[1] + 1);
        if (moves[0] > moves[2]) return -1;
        var W = moves[2] + 1;
        var H = Math.Max(moves[1], moves[3]) + 1;
        if (!check(W, H, moves))
            return -1;
        else return W * H;
    }
    public bool check(int W, int H, int[] moves)
    {
        var s = new HashSet<KeyValuePair<int, int>>();
        for (int i = -1; i <= W; i++)
        {
            s.Add(new KeyValuePair<int, int>(i, -1));
            s.Add(new KeyValuePair<int, int>(i, H));
        }
        for (int i = -1; i <= H; i++)
        {
            s.Add(new KeyValuePair<int, int>(-1, i));
            s.Add(new KeyValuePair<int, int>(W, i));
        }
        int[] dx = { 1, 0, -1, 0 };
        int[] dy = { 0, 1, 0, -1 };
        var p = new int[] { W - moves[0] - 1, H - moves[1] - 1 };
        s.Add(new KeyValuePair<int, int>(p[0], p[1]));
        var d = 0;

        for (int _ = 0; _ < moves.Length; _++)
        {
            var X = moves[_];
            for (int i = 0; i < X; i++)
            {
                p[0] += dx[d];
                p[1] += dy[d];
                //Debug.WriteLine(p.AsJoinedString());
                if (!s.Add(new KeyValuePair<int, int>(p[0], p[1])))
                    return false;

            }
            {
                var np = new int[] { p[0] + dx[d], p[1] + dy[d] };

                if (_ != moves.Length - 1)
                    if (!s.Contains(new KeyValuePair<int, int>(np[0], np[1])))
                        return false;

            }

            d = (d + 1) % 4;
        }
        return true;
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
