using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class SquareScores
{
    public double calcexpectation(int[] p, string s)
    {
        var P = new double[1010, 26];
        var dpl = new double[1010, 26];
        var dpp = new double[1010, 26];
        var len = s.Length;
        var ret = 1.0;
        for (int i = 0; i < len; i++)
        {
            if (s[i] != '?') P[i, s[i] - 'a'] = 1;
            else for (int j = 0; j < p.Length; j++)
                    P[i, j] = p[j] / 100.0;
        }
        for (int i = 0; i < 26; i++)
        {
            dpl[0, i] = 1; dpp[0, i] = P[0, i];
        }
        for (int i = 1; i < len; i++)
        {
            for (int j = 0; j < 26; j++)
                for (int k = 0; k < 26; k++)
                {
                    var tp = dpp[i - 1, j] * P[i, k];
                    dpp[i, k] += tp;
                    dpl[i, k] += tp * (1 + ((j == k) ? dpl[i - 1, j] : 0));
                    ret += tp * (1 + ((j == k) ? dpl[i - 1, j] : 0));
                }
            for (int j = 0; j < 26; j++)
                if (dpp[i, j] > 0) dpl[i, j] /= dpp[i, j];
        }

        return ret;
    }
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
