using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SixteenBricks
{
    public int maximumSurface(int[] height)
    {
        Array.Sort(height);
        var map = Enumerate(4, x => new int[4]);
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                map[i][j] = -1;

        var rem = new List<int>();
        for (int i = 8, j = 0; i < 16; i += 2, j += 4)
        {
            var d = ((j / 4) % 2 == 1) ? 1 : 0;
            map[j / 4][(j + d) % 4] = height[i];
            map[j / 4][(j + 2 + d) % 4] = height[i + 1];
        }
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                if (map[i][j] == -1) rem.Add(i * 4 + j);
        var max = 0;
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        do
        {
            var sum = 0;
            for (int i = 0; i < 8; i++)
                map[rem[i] / 4][rem[i] % 4] = height[i];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    for (int k = 0; k < 4; k++)
                    {
                        var nx = i + dx[k];
                        var ny = j + dy[k];
                        if (nx < 0 || nx >= 4 || ny < 0 || ny >= 4)
                            sum += map[i][j];
                        else
                        {
                            if (map[nx][ny] > map[i][j]) sum += map[nx][ny] - map[i][j];
                        }
                    }
            max = Math.Max(max, sum);

        } while (height.NextPermutation(0, 8));
        return max + 16;
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
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
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