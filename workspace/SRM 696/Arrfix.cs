using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Arrfix
{
    public int mindiff(int[] A, int[] B, int[] F)
    {
        Debug.WriteLine(string.Join(" ", A));
        Debug.WriteLine(string.Join(" ", B));
        Debug.WriteLine(string.Join(" ", F));
        var n = A.Length;
        var gomi = 0;
        var used = new bool[n];

        for (int i = 0; i < F.Length; i++)
        {
            var p = -1;
            for (int j = 0; j < n; j++)
            {
                if (used[j]) continue;
                if (F[i] == B[j])
                {
                    p = j;
                    if (B[j] != A[j])
                    {
                        A[j] = F[i];
                        break;
                    }

                }
            }
            if (p == -1) gomi++;
            else
            {
                used[p] = true;
            }
        }
        var ans = 0;
        for (int i = 0; i < n; i++)
        {
            if (A[i] == B[i]) ans++;
            else if (!used[i]) gomi = Math.Max(0, gomi - 1);

        }
        return n - (ans - gomi);
    }
    // CUT begin
    public int Naive_Test(int[] A, int[] B, int[] F)
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
        var S = "{{261, 261, 464, 8, 8, 261, 8, 8, 261, 261, 464, 261, 261, 8, 261, 261, 261, 464, 8, 464}, {261, 464, 8, 8, 464, 261, 8, 8, 464, 8, 464, 464, 8, 261, 8, 261, 464, 261, 464, 464}, {261, 261, 261, 8, 261, 464, 464, 464, 464, 261, 261, 464, 8, 261, 261, 8, 8, 464, 261, 261}}";
        Tests.Add(() => ManualTestFromInput(S));
    }
}
// CUT end
