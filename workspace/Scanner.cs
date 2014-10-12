using System;
public class Scanner
{
    readonly private System.Globalization.CultureInfo info;
    readonly System.IO.TextReader reader;
    string[] buffer = new string[0];
    int position;

    public char[] Separator { get; set; }
    public Scanner(System.IO.TextReader reader = null, string separator = null, System.Globalization.CultureInfo info = null)
    {

        this.reader = reader ?? Console.In;
        if (string.IsNullOrEmpty(separator))
            separator = " ,";
        this.Separator = separator.ToCharArray();
        this.info = info ?? System.Globalization.CultureInfo.InvariantCulture;
    }
    public string Scan()
    {
        if (this.position < this.buffer.Length)
            return this.buffer[this.position++];
        do this.buffer = this.reader.ReadLine().Split(this.Separator, StringSplitOptions.RemoveEmptyEntries);
        while (this.buffer.Length == 0);
        this.position = 0;
        return this.buffer[this.position++];
    }

    public string ScanLine()
    {
        if (this.position >= this.buffer.Length)
            return this.reader.ReadLine();
        else
        {
            var sb = new System.Text.StringBuilder();
            for (; this.position < buffer.Length; this.position++)
            {
                sb.Append(this.buffer[this.position]);
                sb.Append(' ');
            }
            return sb.ToString();
        }
    }
    public string[] ScanArray(int length)
    {
        var ar = new string[length];
        for (int i = 0; i < length; i++)
            ar[i] = this.Scan();
        return ar;
    }

    public int Integer()
    {
        return int.Parse(this.Scan(), info);
    }
    public long Long()
    {
        return long.Parse(this.Scan(), info);
    }
    public double Double()
    {
        return double.Parse(this.Scan(), info);
    }
    public double Double(string str)
    {
        return double.Parse(str, info);
    }

    public int[] IntArray(int length)
    {
        var a = new int[length];
        for (int i = 0; i < length; i++)
            a[i] = this.Integer();
        return a;
    }
    public long[] LongArray(int length)
    {
        var a = new long[length];
        for (int i = 0; i < length; i++)
            a[i] = this.Long();
        return a;
    }
    public double[] DoubleArray(int length)
    {
        var a = new double[length];
        for (int i = 0; i < length; i++)
            a[i] = this.Double();
        return a;
    }

}