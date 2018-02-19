using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Sortish
{
    public long ways(int sortedness, int[] seq)
    {
        var n = seq.Length;
        var v = new List<int>();
        var p = new List<int>();
        for (int i = 0; i < n; i++)
            if (seq[i] == 0) p.Add(i);
        for (int i = 1; i <= n; i++)
            if (!seq.Contains(i)) v.Add(i);
        val = v.ToArray();
        var pp = new List<int>();
        var qq = new List<int>();
        for (int i = 0; i < p.Count; i++)
        {
            if (i < p.Count / 2) pp.Add(p[i]);
            else qq.Add(p[i]);
        }
        posA = pp.ToArray();
        posB = qq.ToArray();
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
            {
                if (seq[i] == 0) continue;
                if (seq[j] == 0) continue;
                if (seq[i] < seq[j]) sortedness--;

            }
        sotA = Enumerate(posA.Length, x => new int[val.Length]);
        sotB = Enumerate(posB.Length, x => new int[val.Length]);
        for (int i = 0; i < posA.Length; i++)
        {
            for (int j = 0; j < val.Length; j++)
            {
                for (int k = 0; k < posA[i]; k++)
                {
                    if (seq[k] == 0) continue;
                    if (seq[k] < val[j]) sotA[i][j]++;
                }
                for (int k = posA[i] + 1; k < n; k++)
                {
                    if (seq[k] == 0) continue;
                    if (val[j] < seq[k]) sotA[i][j]++;
                }
            }
        }

        for (int i = 0; i < posB.Length; i++)
        {
            for (int j = 0; j < val.Length; j++)
            {
                for (int k = 0; k < posB[i]; k++)
                {
                    if (seq[k] == 0) continue;
                    if (seq[k] < val[j]) sotB[i][j]++;
                }
                for (int k = posB[i] + 1; k < n; k++)
                {
                    if (seq[k] == 0) continue;
                    if (val[j] < seq[k]) sotB[i][j]++;
                }
            }
        }

        this.n = val.Length;
        this.sortedness = sortedness;
        ordA = Enumerate(posA.Length, x => x);
        ordB = Enumerate(posB.Length, x => x);
        {
            var a = Enumerate(posA.Length, x => x);
            do
            {
                var cnt = 0;
                for (int i = 0; i < a.Length; i++)
                    for (int j = i + 1; j < a.Length; j++)
                        if (a[i] < a[j]) cnt++;
                var h = 0;
                for (int i = 0; i < a.Length; i++)
                    h = h * 10 + a[i];
                ordhashA[h] = cnt;
            } while (MathEx.NextPermutation(a, 0, a.Length));
        }
        {
            var a = Enumerate(posB.Length, x => x);
            do
            {
                var cnt = 0;
                for (int i = 0; i < a.Length; i++)
                    for (int j = i + 1; j < a.Length; j++)
                        if (a[i] < a[j]) cnt++;
                var h = 0;
                for (int i = 0; i < a.Length; i++)
                    h = h * 10 + a[i];
                ordhashB[h] = cnt;
            } while (MathEx.NextPermutation(a, 0, a.Length));
        }

        return dfs(0, new List<int>(8), new List<int>(8), 0);
    }
    int sortedness;
    int n;
    int[] posA;
    int[] posB;
    int[] val;
    int[][] sotA;
    int[][] sotB;
    int[] ordA;
    int[] ordB;
    HashMap<int, int> ordhashA = new HashMap<int, int>();
    HashMap<int, int> ordhashB = new HashMap<int, int>();
    public long dfs(int p, List<int> A, List<int> B, int c)
    {
        if (p == n)
        {
            var ans = 0L;

            var map = new HashMap<int, int>();
            do
            {
                var h = 0;
                var v = 0;
                for (int i = 0; i < ordA.Length; i++)
                {
                    h = h * 10 + ordA[i];
                    var pos = ordA[i];
                    v += sotA[pos][A[i]];
                }
                v += ordhashA[h];
                map[v]++;
            } while (MathEx.NextPermutation(ordA, 0, ordA.Length));
            do
            {
                var h = 0;
                var v = 0;
                for (int i = 0; i < ordB.Length; i++)
                {
                    h = h * 10 + ordB[i];
                    var pos = ordB[i];
                    v += sotB[pos][B[i]];
                }
                v += ordhashB[h];
                int add;
                if (map.TryGetValue(sortedness - c - v, out add)) ans += add;

            } while (MathEx.NextPermutation(ordB, 0, ordB.Length));
            return ans;

        }
        else
        {
            var ans = 0L;
            if (A.Count < posA.Length)
            {
                A.Add(p);
                ans += dfs(p + 1, A, B, c + posB.Length - B.Count);
                A.RemoveAt(A.Count - 1);
            }
            if (B.Count < posB.Length)
            {
                B.Add(p);
                ans += dfs(p + 1, A, B, c);
                B.RemoveAt(B.Count - 1);
            }
            return ans;
        }
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
    }
}
// CUT end
#region next_permutation
static public partial class MathEx
{

    static public bool NextPermutation<T>(this T[] array, int first, int last) where T : IComparable<T>
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
    }

}
#endregion
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