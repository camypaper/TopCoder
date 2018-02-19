using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class BoardFoldingDiv2
{
    public struct Rect
    {
        public int u, d, l, r;
        public Rect(int ue, int sita, int hidari, int migi) { u = ue; d = sita; l = hidari; r = migi; }
    }
    public int howMany(string[] paper)
    {
        var R = paper.Length;
        var C = paper[0].Length;
        var TR = new bool[R, R, C, C];
        var TC = new bool[C, C, R, R];
        #region
        for (int i = 0; i < R; i++)
        {
            for (int j = i + 1; j < R; j++)
            {
                var r = 0;
                var l = 0;
                while (l < C)
                {
                    if (paper[i][r] != paper[j][r])
                    {
                        l++; r++;
                        continue;
                    }
                    while (r < C && paper[i][r] == paper[j][r])
                    {
                        TR[i, j, l, r] = TR[j, i, l, r] = true;
                        r++;
                    }
                    while (l < r)
                    {
                        TR[i, j, l, r - 1] = TR[j, i, l, r - 1] = true;
                        l++;
                    }
                }

            }
        }
        for (int i = 0; i < C; i++)
        {
            for (int j = i + 1; j < C; j++)
            {
                var r = 0;
                var l = 0;
                while (l < R)
                {
                    if (paper[r][i] != paper[r][j])
                    {
                        l++; r++;
                        continue;
                    }
                    while (r < R && paper[r][i] == paper[r][j])
                    {
                        TC[i, j, l, r] = TC[i, j, l, r] = true;
                        r++;
                    }
                    while (l < r)
                    {
                        TC[i, j, l, r - 1] = TC[i, j, l, r - 1] = true;
                        l++;
                    }
                }
            }
        }
        #endregion

        var used = new bool[R, R, C, C];
        var q = new Queue<Rect>();
        q.Enqueue(new Rect(0, R - 1, 0, C - 1));
        while (q.Any())
        {
            var p = q.Dequeue();
            if (used[p.u, p.d, p.l, p.r]) continue;
            used[p.u, p.d, p.l, p.r] = true;
            for (int i = p.u; i < p.d - 1; i++)
            {
                var f = true;
                var u = i; var d = i + 1;
                while (u >= 0 || d < p.d)
                {
                    if (!TC[p.l, p.r, u, d])
                    {
                        f = false;
                        break;
                    }
                    u--;
                    d++;
                }
                if (f)
                {
                    var rem = p.d - i - 1;
                    if (i + 1 <= rem)
                        q.Enqueue(new Rect(i + 1, p.d, p.l, p.r));
                    else if (i + 1 >= rem)
                        q.Enqueue(new Rect(p.u, i, p.l, p.r));
                }
            }
            for (int i = p.l; i < p.r - 1; i++)
            {
                var f = true;
                var u = i; var d = i + 1;
                while (u >= 0 || d < p.d)
                {
                    if (!TR[u, d, p.u, p.d])
                    {
                        f = false;
                        break;
                    }
                    u--;
                    d++;
                }
                if (f)
                {
                    var rem = p.d - i - 1;
                    if (i + 1 <= rem)
                        q.Enqueue(new Rect(p.u, p.d, i + 1, p.r));
                    else if (i + 1 >= rem)
                        q.Enqueue(new Rect(p.u, p.d, p.l, i));
                }
            }



        }

        var ans = 0;
        for (int i = 0; i < R; i++)
            for (int j = 0; j < R; j++)
                for (int k = 0; k < C; k++)
                    for (int l = 0; l < C; l++)
                        if (used[i, j, k, l]) ans++;

        return ans;
    }

    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new BoardFoldingDiv2();
        var u = new BoardFoldingDiv2Test();
        try
        {
            var str = Enumerable.Repeat('1', 50).AsString();
            var input = Enumerable.Repeat(str, 50).AsJoinedString(",");
            //u.Example1();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        finally
        {
            System.Diagnostics.Debug.Close();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
        }
    }

    public void ManualTest(string[] paper)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("paper:{0}", string.Join(" ", paper))); sw.Start();
        var ret = howMany(paper);
        Console.WriteLine("Result:{0}", ret);
        sw.Stop();
        Console.WriteLine("Time:{0}ms", sw.ElapsedMilliseconds);

    }

    // CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e)
    {
        return new string(e.ToArray());
    }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ")
    {
        return string.Join(s, e);
    }
}
