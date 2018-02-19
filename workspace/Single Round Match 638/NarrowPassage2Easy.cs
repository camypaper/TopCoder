using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
using BitVector = System.Collections.Specialized.BitVector32;
public class NarrowPassage2Easy
{
    public int count(int[] size, int maxSizeSum)
    {
        var n = size.Length;
        var enable = new bool[n, n];
        for (int i = 0; i < n; i++)
            enable[i, i] = true;
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                if (size[i] + size[j] <= maxSizeSum)
                    enable[i, j] = enable[j, i] = true;
        Func<int[], int, int, bool> NextPermutation = null;
        NextPermutation = (array, first, last) =>
            {
                if (first == last)
                    return false;
                var i = last;
                if (--i == first)
                    return false;
                while (true)
                {
                    var ii = i--;
                    if (array[i].CompareTo(array[ii]) < 0)
                    {
                        var j = last;
                        while (array[i].CompareTo(array[--j]) >= 0) { }
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        Array.Reverse(array, ii, last - ii);
                        return true;
                    }
                    if (i == first)
                    {
                        Array.Reverse(array, first, last - first);
                        return false;
                    }
                }
            };
        var ans = 0;
        var perm = Enumerable.Range(0, n).ToArray();
        do
        {
            var b = new int[n];
            for (int i = 0; i < n; i++)
                b[perm[i]] = i;
            var f = true;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                {
                    if (enable[i, j]) continue;
                    var p = b[i];
                    var q = b[j];
                    if (p > q)
                        f = false;
                }
            if (f) ans++;

        } while (NextPermutation(perm, 0, n));
        return ans;

    }
    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new NarrowPassage2Easy();
        var u = new NarrowPassage2EasyTest();
        try
        {
            t.ManualTest(new int[] { 1, 1, 1, 2, 1, 1, 1 }, 2);
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

    public void ManualTest(int[] size, int maxSizeSum)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("size:{0}", string.Join(" ", size))); Console.WriteLine("maxSizeSum:{0}", maxSizeSum);
        sw.Start();
        var ret = count(size, maxSizeSum);
        Console.WriteLine("Result:{0}", ret);
        sw.Stop();
        Console.WriteLine("Time:{0}ms", sw.ElapsedMilliseconds);

    }

    // CUT end
}
