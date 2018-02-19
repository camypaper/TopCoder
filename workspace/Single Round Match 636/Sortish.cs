using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
using BitVector = System.Collections.Specialized.BitVector32;
public class Sortish
{
    public long ways(int sortedness, int[] seq)
    {
        long sorted = 0;
        var eraced = new List<int>();
        var n = seq.Length;
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                if (seq[i] < seq[j]) sorted++;
        var used = new bool[2050];
        for (int i = 0; i < n; i++)
            if (seq[i] == 0)
                eraced.Add(i);
            else used[seq[i]] = true;
        var enable = new List<int>(eraced.Count);
        for (int i = 1; i <= n; i++)
            if (!used[i])
                enable.Add(i);
        var from = 0;
        var segment = new int[enable.Count + 1, 2];
        for (int i = 0; i < eraced.Count; i++)
        {
            var sep = eraced[i];
            segment[i, 0] = from;
            segment[i, 1] = sep;
            Array.Sort(seq, from, sep - from);
            from = sep + 1;
        }
        segment[eraced.Count, 0] = eraced[eraced.Count - 1];
        segment[eraced.Count, 0] = n;
        //ˆÊ’ui‚Éj”Ô–Ú‚ÌÁ‚³‚ê‚½”’l‚ð“ü‚ê‚½
        var dic = new long[eraced.Count, eraced.Count];
        for (int k = 0; k < eraced.Count; k++)
        {
            for (int j = 0; j < enable.Count; j++)
            {
                var v = enable[j];
                for (int seg = 0; seg <=eraced.Count; seg++)
                {
                    var l = segment[seg, 0];
                    var r = segment[seg, 1];
                    if (r <= eraced[k])
                    {
                        var num = Algorithm.LowerBound(seq, l, r - l, v) - l;
                        dic[k, j] += num;
                    }
                    else
                    {
                        var num = r - Algorithm.LowerBound(seq, l, r - l, v);
                        dic[k, j] += num;
                    }


                }
            }
        }
        return 0;
    }

    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new Sortish();
        var u = new SortishTest();
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

    public void ManualTest(int sortedness, int[] seq)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("sortedness:{0}", sortedness);
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq))); sw.Start();
        var ret = ways(sortedness, seq);
        Console.WriteLine("Result:{0}", ret);
        sw.Stop();
        Console.WriteLine("Time:{0}ms", sw.ElapsedMilliseconds);

    }

    // CUT end
}
static public partial class EnumerableEX
{
    static public string AsString(this IEnumerable<char> source)
    {
        return new string(source.ToArray());
    }
    static public string AsJoinedString<T>(this IEnumerable<T> source, string s = " ")
    {
        return string.Join(s, source);
    }
}
#region BinarySearch for Array
static public partial class Algorithm
{

    static private int InternalBinarySearch<T>(this T[] array, int index, int length, T value, IComparer<T> comparer, bool isLowerBound)
    {
        int lower = index;
        int higher = index + length - 1;
        while (lower <= higher)
        {
            int i = lower + ((higher - lower) >> 1);
            int order;
            if (array[i] == null || value == null)
                return -1;
            else
                order = comparer.Compare(array[i], value);

            if (order < 0)
                lower = i + 1;
            else if (order == 0)
            {
                if (!isLowerBound)
                    lower = i + 1;
                else
                    higher = i - 1;
            }
            else
                higher = i - 1;
        }

        return lower;
    }


    static public int UpperBound<T>(this T[] list, int index, int length, T value, IComparer<T> comparer)
    {
        return InternalBinarySearch(list, index, length, value, comparer, false);
    }
    static public int UpperBound<T>(this T[] list, int index, int length, T value)
        where T : IComparable<T>
    {
        return UpperBound(list, index, length, value, Comparer<T>.Default);
    }
    static public int UpperBound<T>(this T[] list, T value)
        where T : IComparable<T>
    {
        return UpperBound(list, 0, list.Length, value, Comparer<T>.Default);
    }

    static public int UpperBound<T>(this T[] list, T value, IComparer<T> comparer)
    {
        return UpperBound(list, 0, list.Length, value, comparer);
    }

    static public int LowerBound<T>(this T[] list, int index, int length, T value, IComparer<T> comparer)
    {
        return InternalBinarySearch(list, index, length, value, comparer, true);
    }
    static public int LowerBound<T>(this T[] list, int index, int length, T value)
        where T : IComparable<T>
    {
        return LowerBound(list, index, length, value, Comparer<T>.Default);
    }
    static public int LowerBound<T>(this T[] list, T value)
        where T : IComparable<T>
    {
        return LowerBound(list, 0, list.Length, value, Comparer<T>.Default);
    }

    static public int LowerBound<T>(this T[] list, T value, IComparer<T> comparer)
    {
        return LowerBound(list, 0, list.Length, value, comparer);
    }


}
#endregion