using System;
public class _Scanner
{
    readonly private System.Globalization.CultureInfo info;
    readonly System.IO.TextReader reader;
    string[] buffer = new string[0];
    int position;

    public char[] Separator { get; set; }
    public _Scanner(System.IO.TextReader reader, string separator = null, System.Globalization.CultureInfo info = null)
    {
        if (reader == null)
            throw new ArgumentNullException("reader");
        this.reader = reader;
        if (string.IsNullOrEmpty(separator))
            separator = " ,";
        this.Separator = separator.ToCharArray();
        this.info = info ?? System.Globalization.CultureInfo.InvariantCulture;
    }
    public string Scan()
    {
        if (this.position < this.buffer.Length)
            return this.buffer[this.position++];
        this.buffer = this.reader.ReadLine().Split(this.Separator, StringSplitOptions.RemoveEmptyEntries);
        this.position = 0;
        return this.buffer[this.position++];
    }

    public string[] ScanToEndLine()
    {
        if (this.position >= this.buffer.Length)
            return this.reader.ReadLine().Split(this.Separator, StringSplitOptions.RemoveEmptyEntries);
        var size = this.buffer.Length - this.position;
        var ar = new string[size];
        Array.Copy(this.buffer, position, ar, 0, size);
        return ar;

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
        {
            ar[i] = this.Scan();
        }
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