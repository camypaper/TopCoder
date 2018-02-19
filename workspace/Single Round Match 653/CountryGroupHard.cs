using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class CountryGroupHard
{
    public string solve(int[] a)
    {
        const string ok = "Sufficient";
        const string no = "Insufficient";
        var l = new List<int>();
        var cnt = new List<int>();
        foreach (var x in a)
        {
            if (l.Count == 0)
            {
                l.Add(x);
                cnt.Add(1);
            }
            else if (l[l.Count - 1] == x)
            {
                cnt[l.Count - 1]++;
            }
            else
            {
                l.Add(x);
                cnt.Add(1);
            }
        }
        var n = l.Count;
        for (int i = 0; i < n; i++)
        {
            if (l[i] == 0 && cnt[i] == 1)
            {
                if (i > 0 && cnt[i - 1] != l[i - 1])
                    continue;
                if (i < n - 1 && cnt[i + 1] != l[i + 1])
                    continue;
                l[i] = 1;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (l[i] == 0)
                continue;
            if (l[i] == cnt[i])
                continue;
            if (i > 0 && l[i - 1] == 0)
            {
                cnt[i] += cnt[i - 1];
                cnt[i - 1] = 0;
            }
            if (i < n - 1 && l[i + 1] == 0)
            {
                var diff = l[i] - cnt[i];
                cnt[i] = l[i];
                cnt[i + 1] -= diff;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (cnt[i] != l[i])
                return no;
        }


        return ok;
    }
}

