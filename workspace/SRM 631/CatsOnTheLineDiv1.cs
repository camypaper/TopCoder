using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CatsOnTheLineDiv1
{
    public int getNumber(int[] pos, int[] count, int time)
    {
        Array.Sort(pos, count);
        var ans = 0;
        var p = int.MinValue;
        var r = int.MinValue;
        var n = pos.Length;
        for (int i = 0; i < n; i++)
        {
            if (r >= pos[i] - time) continue;
            var q = Math.Max(p + 1, pos[i] - time) - 1 + count[i];
            if (q > pos[i] + time)
            {
                r = pos[i] + time;
                ans++;
            }
            else p = q;
        }
        return ans;
    }

    // CUT begin
    public int Naive_Test(int[] position, int[] count, int time)
    {
        return 0;
    }

    // CUT end
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public void OnInit()
    {
        var s = "{{779, -417, 553, 841, 904, -249, 326, -709, 362, -617, 560, 381, -850, 303, 255, -15, -532, 402, 322, -291, -169, 307, -815, 280, -28, -148, 141, -140, -569, 651, -58, -105, 159, 375, 12, -971, 987, 435, 681, 496, -466, 331, 981, -193, -780, -303, -918, 73, -16, 34}, {718, 1016, 85, 307, 42, 148, 487, 1210, 1219, 823, 674, 46, 1030, 604, 772, 1175, 333, 1056, 3, 498, 574, 366, 426, 794, 384, 71, 9, 649, 662, 134, 940, 1103, 1273, 482, 720, 932, 655, 667, 637, 1325, 23, 556, 139, 53, 93, 7, 213, 245, 317, 874}, 859}";
        Tests.Add(() => ManualTestFromInput(s));
    }
}
// CUT end
