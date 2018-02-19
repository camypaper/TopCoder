using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SPartition {
    public long getCount(string s) {
        var ss = Enumerate(2, x => "");
        for (int i = 0; i < s.Length; i++)
            ss[i * 2 / s.Length] += s[i];
        ss[1] = ss[1].Reverse().AsString();
        var map = Enumerate(2, x => f(ss[x]));
        long ans = 0;
        foreach (var x in map[0]) {
            var y = x.Key.Reverse().AsString();
            if (y.Length > 0) {
                if (y.Last() == '$') y = y.Substring(0, y.Length - 1);
                else y = '$' + y;
            }
            int v;
            if (map[1].TryGetValue(y, out v)) ans += 1L * x.Value * map[1][y];
        }
        return ans;
    }
    HashMap<string, int> f(string s) {
        var ret = new HashMap<string, int>();
        var n = s.Length;
        for (int i = 0; i < 1 << n; i++) {
            var a = new StringBuilder();
            var b = new StringBuilder();
            for (int j = 0; j < n; j++)
                if ((i >> j & 1) == 0) a.Append(s[j]);
                else b.Append(s[j]);
            var aa = a.ToString();
            var bb = b.ToString();
            var min = Math.Min(aa.Length, bb.Length);
            if (aa.Substring(0, min) != bb.Substring(0, min)) continue;
            var sign = 1;
            if (aa.Length < bb.Length) { Swap(ref aa, ref bb); sign *= -1; }
            aa = aa.Substring(min);
            if (sign == -1) aa = '$' + aa;
            ret[aa]++;
        }


        return ret;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public long Naive_Test(string s) {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX {
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester {
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run() {
        ManualTest("oxxooooooooooooooooooooooooooooooooooooo", false);
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);

    }
}
// CUT end
#region HashMap<K,V>
public class HashMap<K, V>: Dictionary<K, V>
//where V : new()
{
    public HashMap() : base() { }
    public HashMap(int cap) : base(cap) { }
    new public V this[K i] {
        get {
            V v;
            return TryGetValue(i, out v) ? v :
                base[i] = default(V);
            //base[i] = new V();
        }
        set { base[i] = value; }
    }
}
#endregion