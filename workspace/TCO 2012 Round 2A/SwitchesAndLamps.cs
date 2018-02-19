using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SwitchesAndLamps
{
    public int theMin(string[] switches, string[] lamps)
    {
        var n = switches.Length;
        var m = switches[0].Length;
        for (int i = 0; i < n; i++)
        {
            var a = switches[i].Count(x => x == 'Y');
            var b = lamps[i].Count(x => x == 'Y');
            if (a != b) return -1;
        }
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
            {
                if (switches[i] == switches[j] && lamps[i] != lamps[j])
                    return -1;
                if (lamps[i] == lamps[j] && switches[i] != switches[j])
                    return -1;
            }
        var S = Enumerate(m, x => new HashSet<int>(Enumerable.Range(0, m)));
        var s = Enumerate(n, x => switches[x].ToCharArray());
        var t = Enumerate(n, x => lamps[x].ToCharArray());
        var used = new bool[m];
        for (int k = 0; k < 100; k++)
            for (int i = 0; i < m; i++)
            {
                if (used[i]) continue;

                for (int j = 0; j < n; j++)
                {
                    if (s[j][i] == 'N')
                    {
                        for (int l = 0; l < m; l++)
                        {
                            if (t[j][l] == 'Y')
                                S[i].Remove(l);
                        }
                    }
                    else
                    {
                        for (int l = 0; l < m; l++)
                        {
                            if (t[j][l] == 'N')
                                S[i].Remove(l);
                        }
                    }
                }
                if (S[i].Count == 0) return -1;
                else if (S[i].Count == 1)
                {
                    var to = S[i].First();
                    used[i] = true;
                    for (int j = 0; j < m; j++)
                    {
                        if (i != j) S[j].Remove(to);
                    }
                    for (int j = 0; j < n; j++)
                    {
                        s[j][i] = 'N';
                        t[j][to] = 'N';
                    }
                }
            }

        var map = new HashMap<long, int>();
        foreach (var ss in S)
        {
            var v = 0L;
            foreach (var x in ss)
                v |= 1L << x;
            map[v]++;
        }
        var max = 0;
        foreach (var kv in map)
        {
            var k = kv.Key;
            var v = kv.Value;
            var cnt = 0;
            for (int i = 0; i < 60; i++)
                if ((k >> i & 1) == 1) cnt++;
            if (cnt != v) return -1;

            for (int i = 0; i < 30; i++)
                if (cnt <= 1 << i)
                {
                    max = Math.Max(max, i);
                    break;
                }
        }
        return max;
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
        var S = new string[] { "NYYYYNYYYNYNYYNYYYYYYNNYNNYNNNN", "NYNYNYNNNNYNYYNNNYYNYNNNNYYNNNY", "NNNNYNYNNYNYNNYYNNNNNNYYYNNYNNN", "NNYNNYNYYYYYYYYNYNNYNNYNYYYYNNY", "NYYYYYYYYNNNNNNYYNNYNNNYNYNNNNY", "NNYNNNNYYYNYNNYNYYYYYNYNYNNYNNN", "NNNNNYNNNNYNYYNNNNNNNNNNNYYNNNY", "NNNNNYNNNYYYYYYNNYYNYNYNYYYYNNY", "YYYYNYNYYNNNNNNNYNNYNYNNNYNNYYY", "NNNNYNYNNNYNYYNYNNNNNNNYNNYNNNN", "YYNYYYYNNNNNNNNYNYYNYYNYNYNNYYY", "YYYYYNYYYYYYYYYYYYYYYYYYYNYYYYN", "YNNNNNNNNYNYNNYNNYYNYYYNYNNYYYN", "YNNNNNNNNYNYNNYNNNNNNYYNYNNYYYN", "YNYNNYNYYNYNYYNNYNNYNYNNNYYNYYY", "NNYNNNNYYYNYNNYNYNNYNNYNYNNYNNN", "NYYYYNYYYYYYYYYYYYYYYNYYYNYYNNN", "YNYNYYYYYYYYYYYYYNNYNYYYYYYYYYY", "NYNYNNNNNNNNNNNNNNNNNNNNNNNNNNN", "NNYNYNYYYYYYYYYYYYYYYNYYYNYYNNN", "YNNNNNNNNNYNYYNNNNNNNYNNNNYNYYN", "YNYNYNYYYNYNYYNYYNNYNYNYNNYNYYN", "YNNNNNNNNNYNYYNNNYYNYYNNNNYNYYN", "YYYYYYYYYYNYNNYYYNNYNYYYYYNYYYY", "NYNYYYYNNNYNYYNYNYYNYNNYNYYNNNY", "YYYYNYNYYNYNYYNNYYYYYYNNNYYNYYY", "YNNNYYYNNYNYNNYYNNNNNYYYYYNYYYY", "YNYNYNYYYNYNYYNYYNNYNYNYNNYNYYN", "YNYNYNYYYYYYYYYYYYYYYYYYYNYYYYN", "NNYNNNNYYNNNNNNNYNNYNNNNNNNNNNN", "YYYYNYNYYNYNYYNNYNNYNYNNNYYNYYY", "NYYYYNYYYNYNYYNYYNNYNNNYNNYNNNN", "NYNYYNYNNYYYYYYYNNNNNNYYYNYYNNN", "NYNYYNYNNYYYYYYYNYYNYNYYYNYYNNN", "YYYYYNYYYNYNYYNYYYYYYYNYNNYNYYN", "YNYNNYNYYYYYYYYNYNNYNYYNYYYYYYY", "NYYYYYYYYYYYYYYYYNNYNNYYYYYYNNY", "YNYNYYYYYNNNNNNYYNNYNYNYNYNNYYY", "YYYYNYNYYNNNNNNNYYYYYYNNNYNNYYY", "NNNNNYNNNNYNYYNNNYYNYNNNNYYNNNY", "NNNNYNYNNYYYYYYYNYYNYNYYYNYYNNN", "NNYNNYNYYYYYYYYNYNNYNNYNYYYYNNY", "NYNYYNYNNYNYNNYYNYYNYNYYYNNYNNN", "YYYYNNNYYNNNNNNNYYYYYYNNNNNNYYN" };
        var T = new string[] { "NYNYYYYNYNNYYNYYNNNYYYYNYNYYYNN", "NYNYNYNNYNNNNYYNNNYYYYNNNNYNNYN", "NNYNNNNYNNNNYNNYYYNNNNYYNYNNYNN", "NNYYYNYYNNNYNYYNYYYNYNNYYYYYNYN", "NNNNYNYNNNNYYYNYNNYYNYYNYNNYYYN", "NYYNYYYYYNNYNNNNYYNNNNNYYYNYNNN", "NNNYNNNNNNNNNYYNNNYNYNNNNNYNNYN", "NYYYNYNYYNNNNYYNYYYNYNNYNYYNNYN", "YNNNYNYNNYYYNNNYNNYYNYNNYNNYNYY", "NNNYNNNNNNNNYNYYNNNNYNYNNNYNYNN", "YYNNNYNNYYYNYYNYNNYYNYYNNNNNYYY", "YYYYYYYYYYYYYNYYYYNYYYYYYYYYYNY", "YYYNNYNYYYYNNNNNYYNNNNNYNYNNNNY", "YNYNNNNYNYYNNNNNYYNNNNNYNYNNNNY", "YNNYYNYNNYYYNYYNNNYNYNNNYNYYNYY", "NNYNYNYYNNNYNNNNYYNNNNNYYYNYNNN", "NYYYYYYYYNNYYNYYYYNYYYYYYYYYYNN", "YNYYYNYYNYYYYYYYYYYNYNYYYYYYYYY", "NNNNNNNNNNNNNNNNNNNYNYNNNNNNNNN", "NYYYYYYYYNNYYNYYYYNNYNYYYYYYYNN", "YNNYNNNNNYYNNNYNNNNNYNNNNNYNNNY", "YNNYYNYNNYYYYNYYNNNNYNYNYNYYYNY", "YYNYNYNNYYYNNNYNNNNNYNNNNNYNNNY", "YNYNYNYYNYYYYYNYYYYYNYYYYYNYYYY", "NYNYNYNNYNNNYYYYNNYYYYYNNNYNYYN", "YYNYYYYNYYYYNYYNNNYYYYNNYNYYNYY", "YNYNNNNYNYYNYYNYYYYNNNYYNYNNYYY", "YNNYYNYNNYYYYNYYNNNNYNYNYNYYYNY", "YYYYYYYYYYYYYNYYYYNNYNYYYYYYYNY", "NNNNYNYNNNNYNNNNNNNNNNNNYNNYNNN", "YNNYYNYNNYYYNYYNNNYYYYNNYNYYNYY", "NNNYYNYNNNNYYNYYNNNYYYYNYNYYYNN", "NNYYNNNYNNNNYNYYYYNYYYYYNYYNYNN", "NYYYNYNYYNNNYNYYYYNYYYYYNYYNYNN", "YYNYYYYNYYYYYNYYNNNYYYYNYNYYYNY", "YNYYYNYYNYYYNYYNYYYNYNNYYYYYNYY", "NNYYYNYYNNNYYYYYYYYYYYYYYYYYYYN", "YNNNYNYNNYYYYYNYNNYNNNYNYNNYYYY", "YYNNYYYNYYYYNYNNNNYYNYNNYNNYNYY", "NYNYNYNNYNNNNYYNNNYNYNNNNNYNNYN", "NYYYNYNYYNNNYNYYYYNNYNYYNYYNYNN", "NNYYYNYYNNNYNYYNYYYNYNNYYYYYNYN", "NYYNNYNYYNNNYNNYYYNYNYYYNYNNYNN", "YYNNYYYNYYYYNNNNNNNYNYNNYNNYNNY" };
        test.ManualTest(S, T);
    }
}
// CUT end
#region HashMap
public class HashMap<K, V> : Dictionary<K, V>
//where V : new()
{
    public HashMap() : base() { }
    public HashMap(int cap) : base(cap) { }
    new public V this[K i]
    {
        get
        {
            V v;
            return TryGetValue(i, out v) ? v :
                base[i] = default(V);
            //base[i] = new V();
        }
        set { base[i] = value; }
    }
}
#endregion