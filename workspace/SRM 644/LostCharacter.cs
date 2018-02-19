using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class LostCharacter
{
	public int[] getmins(string[] str)
    {
        var n=str.Length;
        var ans = new int[n];
        for (int i = 0; i < n; i++)
        {
            var a = str[i].ToCharArray();
            for (int j = 0; j < a.Length; j++)
                if (str[i][j] == '?') a[j] = 'a';
            var count = 0;
            for (int k = 0; k < n; k++)
            {
                if (i == k) continue;
                var len = Math.Min(a.Length, str[k].Length);
                var f = 0;
                for (int j = 0; j < len; j++)
                {
                    var c = str[k][j];
                    if (c == '?') c = 'z';
                    if(c<a[j]){f=1;break;}
                    if (c > a[j]) { f = -1; break; }
                }
                if (f == 1 || (f == 0 && str[k].Length < a.Length))
                    count++;
            }
            ans[i] = count;
        }
        return ans;
	}

// CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc= new Scanner(Console.In);
        var t = new LostCharacter();
        var u = new LostCharacterTest();
        try
        {
            u.Example2();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        finally
        {
            System.Diagnostics.Debug.Close();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
        }
    }

    public void ManualTest(string[] str)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("str:{0}",string.Join(" ",str)));        sw.Start();
        var ret = getmins(str);
        Console.WriteLine("Result:{0}",ret);
        sw.Stop();
        Console.WriteLine("Time:{0}ms",sw.ElapsedMilliseconds);

    }
    
// CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e)
    {
        return new string(e.ToArray());
    }
    static public string AsJoinedString<T>(this IEnumerable<T> e,string s=" ")
    {
        return string.Join(s, e);
    }
}
