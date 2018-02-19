using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CarrotJumping
{
    public int theJump(int init)
    {
        var dp = new HashMap<int>(200050);
        dp[init] = 0;
        var q = new Queue<int>();
        q.Enqueue(init);
        const int mod = 1000000007;
        while (q.Any())
        {
            var p = q.Dequeue();
            if (p == 100000) continue;

            var u = (int)((p * 4L + 3) % mod);
            var v = (int)((p * 8L + 7) % mod);
            if (dp[u] > dp[p] + 1)
            {
                dp[u] = dp[p] + 1;
                q.Enqueue(u);
            }
            if (dp[v] > dp[p] + 1)
            {
                dp[v] = dp[p] + 1;
                q.Enqueue(v);
            }
        }

        if (dp[0] > 100000) return -1;
        return dp[0];
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
        test.ManualTest(125000000);
    }
}
// CUT end
#region HashMap
public class HashMap<K> : Dictionary<K, int>
//where V : new()
{
    public HashMap() : base() { }
    public HashMap(int cap) : base(cap) { }
    new public int this[K i]
    {
        get
        {
            int v;
            return TryGetValue(i, out v) ? v :
                base[i] = 114514;
            //base[i] = new V();
        }
        set { base[i] = value; }
    }
}
#endregion