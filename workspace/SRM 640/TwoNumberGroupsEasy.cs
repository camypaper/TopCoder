using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class TwoNumberGroupsEasy
{
    public int solve(int[] A, int[] numA, int[] B, int[] numB)
    {
        var gcd = A[0];
        for (int i = 1; i < A.Length; i++)
            gcd = GCD(gcd, A[i]);
        for (int i = 0; i < B.Length; i++)
            gcd = GCD(gcd, B[i]);
        for (int i = 0; i < A.Length; i++)
            A[i] /= gcd;
        for (int i = 0; i < B.Length; i++)
            B[i] /= gcd;

        var min = 1 << 30;
        for (int mod = 2; mod <= (int)1e5; mod++)
        {
            var map = new HashMap<int, int>();
            for (int k = 0; k < A.Length; k++)
                map[A[k] % mod] += numA[k];
            for (int k = 0; k < B.Length; k++)
                map[B[k] % mod] -= numB[k];

            var sum = 0;
            foreach (var kv in map)
                sum += Math.Abs(kv.Value);
            if (sum < min)
                min = sum;
        }
        return min;
    }
    static public int GCD(int x, int y)
    {
        byte i = 0;
        while (x != 0 && y != 0)
        {
            if (i == 0)
                y %= x;
            else x %= y;
            i ^= 1;
        }
        return x == 0 ? y : x;
    }
    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new TwoNumberGroupsEasy();
        var u = new TwoNumberGroupsEasyTest();
        try
        {
            t.ManualTest(new int[] { 10000019 }, new int[] { 1000 }, new int[] { 20000038 }, new int[] { 1000 });
            var r = new Random(0);
            int A = 10, B = 10;
            while (true)
            {
                var setA = new HashSet<int>();
                var setB = new HashSet<int>();
                while (setA.Count < A)
                    setA.Add(1 + (r.Next() % 1000000000));
                while (setB.Count < B)
                    setB.Add(1 + (r.Next() % 1000000000));
                var numA = new int[A];
                var numB = new int[B];
                for (int i = 0; i < A; i++)
                    numA[i] = 1 + (r.Next() % 100000);
                for (int i = 0; i < A; i++)
                    numB[i] = 1 + (r.Next() % 100000);
                t.ManualTest(setA.ToArray(), numA, setB.ToArray(), numB);
            }
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

    public void ManualTest(int[] A, int[] numA, int[] B, int[] numB)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A))); Console.WriteLine(string.Format("numA:{0}", string.Join(" ", numA))); Console.WriteLine(string.Format("B:{0}", string.Join(" ", B))); Console.WriteLine(string.Format("numB:{0}", string.Join(" ", numB))); sw.Start();
        var ret = solve(A, numA, B, numB);
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
#region HashMap
class HashMap<K, V> : Dictionary<K, V>
{
    new public V this[K i]
    {
        get
        {
            V v;
            return TryGetValue(i, out v) ? v : base[i] = default(V);
        }
        set { base[i] = value; }
    }
}
#endregion