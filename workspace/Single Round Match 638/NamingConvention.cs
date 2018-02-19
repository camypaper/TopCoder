using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
using BitVector = System.Collections.Specialized.BitVector32;
public class NamingConvention
{
	public string toCamelCase(string variableName)
    {
        var n = variableName.Length;
        var sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            if (variableName[i] == '_')
            {
                sb.Append(char.ToUpperInvariant(variableName[i + 1]));
                i++;
            }
            else sb.Append(variableName[i]);

        }
        
		return sb.ToString();
	}

// CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc= new Scanner(Console.In);
        var t = new NamingConvention();
        var u = new NamingConventionTest();
        try
        {
            u.Example0();
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

    public void ManualTest(string variableName)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("variableName:{0}",variableName);
                sw.Start();
        var ret = toCamelCase(variableName);
        Console.WriteLine("Result:{0}",ret);
        sw.Stop();
        Console.WriteLine("Time:{0}ms",sw.ElapsedMilliseconds);

    }
    
// CUT end
}
