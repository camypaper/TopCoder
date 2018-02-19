using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MultiplicationTable3
{
    public int[] construct(int X)
    {

        var A = new List<int>();
        while (X > 0)
        {
            if (X % 2 != 0) A.Add(1);
            else A.Add(0);
            X /= 2;
        }
        A.Reverse();
        var B = new List<int>();
        for (int i = 0; i < A.Count; i++)
        {
            B.Add(0);
            if (i > 0 && A[i] == 1)
            {
                B.Add(B.Count - 1);
            }
        }
        var n = B.Count;
        var mat = Enumerate(n, x => new int[n]);
        for (int i = 0; i < n; i++)
        {
            if (B[i] != 0)
            {
                for (int j = 0; j < i; j++)
                    mat[i][j] = mat[j][i] = (j + 1) % i;
            }
            mat[i][i] = B[i];
        }
        foreach (var x in mat)
            Console.WriteLine(string.Join(" ", x));
        return mat.SelectMany(x => x).ToArray();
    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
