using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class TreeCutting
{
    const string posible = "POSSIBLE";
    const string impossible = "IMPOSSIBLE";
    public string can(int[] par, int[] num)
    {
        var n = num.Length;
        var G = new bool[n, n];
        Func<int, bool> dfs = null;
        Func<int, int, bool[], int> count = null;
        count = (prev, cur, used) =>
            {
                var ret = 1;
                for (int i = 0; i < n; i++)
                {
                    if (i == prev) continue;
                    if (G[cur, i])
                    {
                        used[i] = true;
                        ret += count(cur, i, used);
                    }
                }
                return ret;
            };
        dfs = (pos) =>
        {
            if (pos == n - 1)
            {
                var used = new bool[n];
                for (int i = 0; i < n; i++)
                {
                    if (num[i] <= 0) continue;
                    used[i] = true;
                    if (count(-1, i,used) != num[i]) return false;
                }
                for (int i = 0; i < n; i++)
                    if (!used[i])
                        return false;
                return true;
            }
            var ret = false;
            ret |= dfs(pos + 1);
            var p = par[pos];
            var ch = pos + 1;
            if (num[p] == -1 || num[ch] == -1)
            {
                G[p, ch] = true;
                G[ch, p] = true;
                ret |= dfs(pos + 1);
                G[p, ch] = false;
                G[ch, p] = false;
            }
            return ret;
        };
        if (dfs(0))
            return posible;
        return impossible;
    }

    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new TreeCutting();
        var u = new TreeCuttingTest();
        try
        {
            u.Example0();
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

    public void ManualTest(int[] par, int[] num)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("par:{0}", string.Join(" ", par))); Console.WriteLine(string.Format("num:{0}", string.Join(" ", num))); sw.Start();
        var ret = can(par, num);
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
