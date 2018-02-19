using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class PairGame
{
    public struct Pair<T>
    {
        public T L, R;
        public Pair(T l, T r) : this() { L = l; R = r; }
        public Pair(params T[] arg) : this(arg[0], arg[1]) { }
        public override string ToString() { return string.Format("{0} {1}", L, R); }
    }
    public int maxSum(int a, int b, int c, int d)
    {
        var max = -1;
        var s = dfs(a, b);
        s.IntersectWith(dfs(c, d));
        foreach (var p in s)
            max = Math.Max(p.L + p.R, max);
        return max;
    }
    HashSet<Pair<int>> dfs(int x, int y)
    {
        var s = new HashSet<Pair<int>>();
        while (x>0 && y>0)
        {
            s.Add(new Pair<int>(x, y));
            if (x >= y) x -= y;
            else y -= x;
        }
        return s;
    }
    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new PairGame();
        var u = new PairGameTest();
        try
        {
            t.ManualTest(2, 1000000, 1, 6);
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

    public void ManualTest(int a, int b, int c, int d)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("a:{0}", a);
        Console.WriteLine("b:{0}", b);
        Console.WriteLine("c:{0}", c);
        Console.WriteLine("d:{0}", d);
        sw.Start();
        var ret = maxSum(a, b, c, d);
        Console.WriteLine("Result:{0}", ret);
        sw.Stop();
        Console.WriteLine("Time:{0}ms", sw.ElapsedMilliseconds);

    }

    // CUT end
}
