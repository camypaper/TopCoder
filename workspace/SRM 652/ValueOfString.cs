using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class ValueOfString
{
    public int findValue(string s)
    {
        var t = s.ToCharArray();
        var cnt = 0;
        var ans = 0;
        for (char i = 'a'; i <= 'z'; i++)
        {
            var sz = s.Count(x => x == i);
            if (sz == 0) continue;
            cnt += sz;
            ans += (i - 'a' + 1) * cnt * sz;
        }


        return ans;
    }
}
