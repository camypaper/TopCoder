using System;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Globalization;

static class Local {
    static void Main() {
        Debug.Listeners.Add(new TextWriterTraceListener(
            new MultiOutputStream(
                new FileStream(@"out.out", FileMode.Create, FileAccess.Write, FileShare.ReadWrite),
                new ColorizeOutputStream(Console.OpenStandardError(), ConsoleColor.Green)))
            );
        Debug.AutoFlush = true;
        var tester = new Tester();
        tester.Run();
    }
}

#region component
public abstract class AbstractTester {
    int cnt = 1;
    public StreamScanner sc = new StreamScanner(new FileStream(@"in.in", FileMode.Open, FileAccess.Read, FileShare.ReadWrite));

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rnd = new Random(0);
    public int ri => sc.Integer();
    public long rl => sc.Long();
    public double rd => sc.Double();
    public string rs => sc.Scan();
    public void Test(Func<bool, bool> f, bool fast = false) {
        Console.Error.WriteLine("Test:{0}", cnt++);
        var sw = new Stopwatch(); sw.Start();
        var ok = true;
        try
        {
            if (!f(fast)) ok = false;
        }
        catch
        {
            ok = false;
        }
        sw.Stop();
        if (!ok)
        {
            Console.Error.WriteLine();
            Console.Error.Write("Retry?:");
            var res = Console.ReadLine();
            string[] go = { "ok", "y", "yes", "true", "t", "go", "1" };
            if (go.Contains(res))
                f(false);
        }
        var time = sw.ElapsedMilliseconds;
        var memory = GC.GetTotalMemory(false) / 1024;
        Console.Error.Write("Test: ");
        Console.ForegroundColor = ok ? ConsoleColor.Green : ConsoleColor.Red;
        Console.Error.Write(ok ? "OK" : "FAIL");
        Console.ResetColor();
        Console.Error.Write(",Time: ");
        Console.ForegroundColor = time <= 1000 ? ConsoleColor.Green : time <= 2000 ? ConsoleColor.Magenta : ConsoleColor.Red;
        Console.Error.Write($"{time} ms");
        Console.ResetColor();
        Console.Error.Write(",Memory: ");
        Console.ForegroundColor = memory <= 64000 ? ConsoleColor.Green : memory <= 256000 ? ConsoleColor.Magenta : ConsoleColor.Red;
        Console.Error.WriteLine($"{memory} KB");
        Console.ResetColor();
        if (!fast)
            Console.ReadKey(true);
    }
    public abstract void Run();

}
public class MultiOutputStream: Stream {
    readonly Stream[] outStream;
    public MultiOutputStream(params Stream[] args) {
        if (args == null) throw new ArgumentNullException("args is null.");
        for (int i = 0; i < args.Length; i++)
            if (args[i] == null) throw new ArgumentNullException("args contains null.");
            else if (!args[i].CanWrite) throw new ArgumentException("args contains unwritable stream.");
        outStream = args;

    }
    public override bool CanRead { get { return false; } }
    public override bool CanSeek { get { return false; } }
    public override bool CanWrite { get { return true; } }
    public override void Flush() {
        foreach (var x in outStream)
            x.Flush();
    }
    public override void Write(byte[] buffer, int offset, int count) {
        foreach (var x in outStream)
            x.Write(buffer, offset, count);
    }
    public override long Length { get { throw new NotSupportedException(); } }
    public override long Position { get { throw new NotSupportedException(); } set { throw new NotSupportedException(); } }
    public override int Read(byte[] buffer, int offset, int count) { throw new NotSupportedException(); }
    public override long Seek(long offset, SeekOrigin origin) { throw new NotSupportedException(); }
    public override void SetLength(long value) { throw new NotSupportedException(); }
}


public class ColorizeOutputStream: Stream {
    readonly Stream outStream;
    readonly ConsoleColor outColor;
    public ColorizeOutputStream(Stream stream, ConsoleColor color) {
        if (stream == null) throw new ArgumentNullException("args is null.");
        if (!stream.CanWrite) throw new ArgumentException("args contains unwritable stream.");
        outStream = stream;
        outColor = color;

    }
    public override bool CanRead { get { return false; } }
    public override bool CanSeek { get { return false; } }
    public override bool CanWrite { get { return true; } }
    public override void Flush() {
        outStream.Flush();
    }
    public override void Write(byte[] buffer, int offset, int count) {
        var temp = Console.ForegroundColor;
        Console.ForegroundColor = outColor;
        outStream.Write(buffer, offset, count);
        Console.ForegroundColor = temp;
    }
    public override long Length { get { throw new NotSupportedException(); } }
    public override long Position { get { throw new NotSupportedException(); } set { throw new NotSupportedException(); } }
    public override int Read(byte[] buffer, int offset, int count) { throw new NotSupportedException(); }
    public override long Seek(long offset, SeekOrigin origin) { throw new NotSupportedException(); }
    public override void SetLength(long value) { throw new NotSupportedException(); }
}



#endregion

#region Ex
public class StreamScanner {
    public StreamScanner(Stream stream) { str = stream; }

    public readonly Stream str;
    private readonly byte[] buf = new byte[1024];
    private int len, ptr;
    public bool isEof = false;
    public bool IsEndOfStream { get { return isEof; } }

    private byte read() {
        if (isEof) return 0;
        if (ptr >= len)
        {
            ptr = 0;
            if ((len = str.Read(buf, 0, 1024)) <= 0)
            {
                isEof = true;
                return 0;
            }
        }
        return buf[ptr++];
    }

    public char Char() {
        byte b = 0;
        do b = read(); while ((b < 33 || 126 < b) && !isEof);
        return (char)b;
    }
    public string Scan() {
        var sb = new StringBuilder();
        for (var b = Char(); b >= 33 && b <= 126; b = (char)read()) sb.Append(b);
        return sb.ToString();
    }
    public string ScanLine() {
        var sb = new StringBuilder();
        for (var b = Char(); b != '\n' && b != 0; b = (char)read()) if (b != '\r') sb.Append(b);
        return sb.ToString();
    }
    public long Long() { return isEof ? long.MinValue : long.Parse(Scan()); }
    public int Integer() { return isEof ? int.MinValue : int.Parse(Scan()); }
    public double Double() { return isEof ? double.NaN : double.Parse(Scan(), CultureInfo.InvariantCulture); }
}
#endregion

