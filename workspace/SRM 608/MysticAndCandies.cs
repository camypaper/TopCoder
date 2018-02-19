using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MysticAndCandies
{
    public int minBoxes(int C, int X, int[] low, int[] high)
    {
        var n = low.Length;
        Array.Sort(low);Array.Reverse(low);
        Array.Sort(high);
        var ans = n;
        var get = 0;
        var lost = 0;
        for (int i = 0; i < n; i++)
        {
            get += low[i];
            lost += high[i];
            if (get >= X) ans = Math.Min(ans, i + 1);
            if (C - lost >= X) ans = Math.Min(ans, n - 1 - i);
        }

        return ans;
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
        var C = 299222869;
        var X = 189215971;
        var low = new int[] { 4482204, 6164570, 3358242, 5096258, 6095914, 4113386, 7280155, 7172038, 3997506, 5259763, 3400621, 3515463, 3384414, 4395568, 4934092, 4606634, 6388699, 5154553, 5392870, 4998470, 3618283, 3800031, 6640813, 5181138, 5450833, 3666810, 7565864, 5457085, 4822052, 4177326, 5764832, 3968880, 3664552, 5441527, 5684994, 5662479, 4645505, 3577976, 3376584, 4427052, 3721599, 5981866, 5156011, 6703803, 6131600, 5741525, 6944386, 5567145, 5533592, 5207660 };
        var high = new int[] { 6557210, 6781683, 5317983, 7822494, 7076318, 7387241, 7428020, 7887490, 7321334, 5734539, 4407433, 7841525, 7816399, 5753144, 6572337, 6788171, 7428459, 6929192, 6300082, 6847340, 5800085, 6334866, 7396168, 8188768, 6552758, 6631996, 7884996, 6016316, 7107359, 8087719, 6361925, 5989696, 6122690, 8042213, 5854131, 8039081, 7090742, 5276088, 6774034, 6489262, 6886273, 7511815, 5343446, 7968248, 7603815, 6871153, 7365963, 7418721, 6234620, 7303918 };

        test.ManualTest(C, X, low, high);
    }
}
// CUT end

#region Compair
static public class Pair
{
    static public Pair<FT, ST> Create<FT, ST>(FT f, ST s)
        where FT : IComparable<FT>
        where ST : IComparable<ST>
    { return new Pair<FT, ST>(f, s); }
    static public Pair<FT, ST> Min<FT, ST>(Pair<FT, ST> p, Pair<FT, ST> q)
        where FT : IComparable<FT>
        where ST : IComparable<ST>
    { return (p.CompareTo(q) <= 0) ? p : q; }
    static public Pair<FT, ST> Max<FT, ST>(Pair<FT, ST> p, Pair<FT, ST> q)
        where FT : IComparable<FT>
        where ST : IComparable<ST>
    { return (p.CompareTo(q) >= 0) ? p : q; }
}
public struct Pair<FT, ST> : IComparable<Pair<FT, ST>>
    where FT : IComparable<FT>
    where ST : IComparable<ST>
{
    public FT x;
    public ST y;
    public Pair(FT f, ST s) : this() { x = f; y = s; }

    public int CompareTo(Pair<FT, ST> other)
    {
        var cmp = x.CompareTo(other.x);
        return cmp != 0 ? cmp : y.CompareTo(other.y);
    }
    public override string ToString() { return string.Format("{0} {1}", x, y); }
}
#endregion