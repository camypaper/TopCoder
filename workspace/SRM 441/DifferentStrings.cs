using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
using BitVector = System.Collections.Specialized.BitVector32;
public class DifferentStrings
{
    public int minimize(string A, string B)
    {
        var ret = Math.Min(A.Length, B.Length);
        for (int i = 0; i < A.Length; i++)
        {
            var count = 0;
            for (int j = 0; j < B.Length; j++)
            {
                if (i + j >= A.Length)
                {
                    count = 1 << 30;
                    break;
                }
                if (A[i + j] != B[j])
                    count++;

            }
        }
        for (int i = 0; i < B.Length; i++)
        {
            var count = 0;
            for (int j = 0; j < A.Length; j++)
            {
                if (i + j >= B.Length)
                {
                    count = 1 << 30;
                    break;
                }
                if (B[i + j] != A[j])
                    count++;

            }
            ret = Math.Min(count, ret);
        }
        return ret;
    }

    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new DifferentStrings();
        var u = new DifferentStringsTest();
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

    public void ManualTest(string A, string B)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("A:{0}", A);
        Console.WriteLine("B:{0}", B);
        sw.Start();
        var ret = minimize(A, B);
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
