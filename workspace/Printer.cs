using System;
using System.Collections.Generic;
static public class Printer
{
    static readonly private System.IO.TextWriter writer;
    static readonly private System.Globalization.CultureInfo info;
    static string Separator { get; set; }
    static Printer()
    {
        writer = Console.Out;
        info = System.Globalization.CultureInfo.InvariantCulture;
        Separator = " ";
    }

    static public void Print(int num) { writer.Write(num.ToString(info)); }
    static public void Print(int num, string format) { writer.Write(num.ToString(format, info)); }
    static public void Print(long num) { writer.Write(num.ToString(info)); }
    static public void Print(long num, string format) { writer.Write(num.ToString(format, info)); }
    static public void Print(double num) { writer.Write(num.ToString(info)); }
    static public void Print(double num, string format) { writer.Write(num.ToString(format, info)); }
    static public void Print(string str) { writer.Write(str); }
    static public void Print(string format, params object[] arg) { writer.Write(format, arg); }
    static public void Print(IEnumerable<char> sources) { writer.Write(sources.AsString()); }
    static public void Print(params object[] arg)
    {
        var res = new System.Text.StringBuilder();
        foreach (var x in arg)
        {
            res.AppendFormat(info, "{0}", x);
            if (!string.IsNullOrEmpty(Separator))
                res.Append(Separator);
        }
        writer.Write(res.ToString(0, res.Length - Separator.Length));
    }
    static public void Print<T>(IEnumerable<T> sources)
    {
        var res = new System.Text.StringBuilder();
        foreach (var x in sources)
        {
            res.AppendFormat(info, "{0}", x);
            if (string.IsNullOrEmpty(Separator))
                res.Append(Separator);
        }
        writer.Write(res.ToString(0, res.Length - Separator.Length));
    }
    static public void PrintLine(int num) { writer.WriteLine(num.ToString(info)); }
    static public void PrintLine(int num, string format) { writer.WriteLine(num.ToString(format, info)); }
    static public void PrintLine(long num) { writer.WriteLine(num.ToString(info)); }
    static public void PrintLine(long num, string format) { writer.WriteLine(num.ToString(format, info)); }
    static public void PrintLine(double num) { writer.WriteLine(num.ToString(info)); }
    static public void PrintLine(double num, string format) { writer.WriteLine(num.ToString(format, info)); }
    static public void PrintLine(string str) { writer.WriteLine(str); }
    static public void PrintLine(string format, params object[] arg) { writer.WriteLine(format, arg); }
    static public void PrintLine(IEnumerable<char> sources) { writer.WriteLine(sources.AsString()); }
    static public void PrintLine(params object[] arg)
    {
        var res = new System.Text.StringBuilder();
        foreach (var x in arg)
        {
            res.AppendFormat(info, "{0}", x);
            if (!string.IsNullOrEmpty(Separator))
                res.Append(Separator);
        }
        writer.WriteLine(res.ToString(0, res.Length - Separator.Length));
    }
    static public void PrintLine<T>(IEnumerable<T> sources)
    {
        var res = new System.Text.StringBuilder();
        foreach (var x in sources)
        {
            res.AppendFormat(info, "{0}", x);
            if (!string.IsNullOrEmpty(Separator))
                res.Append(Separator);
        }
        writer.WriteLine(res.ToString(0, res.Length - Separator.Length));
    }
}