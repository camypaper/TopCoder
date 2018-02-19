using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PalindromePrime
{
    public int count(int L, int R)
    {
        var primes = MathEx.Sieve(2000);
        var ans = 0;
        for (int i = L; i <= R; i++)
        {
            if (primes[i] && StringEx.IsPalindrome(i.ToString()))
                ans++;
        }
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
#region sieve
static public partial class MathEx
{
    static public bool[] Sieve(int p)
    {
        var isPrime = new bool[p + 1];
        for (int i = 2; i <= p; i++) isPrime[i] = true;
        for (int i = 2; i * i <= p; i++)
            if (!isPrime[i]) continue;
            else
                for (int j = i * i; j <= p; j += i)
                    isPrime[j] = false;
        return isPrime;
    }
}
#endregion
#region Palindrome
static public partial class StringEx
{
    /// <summary>âÒï∂Ç©Ç«Ç§Ç©í≤Ç◊ÇÈÅDO(|S|)</summary>
    static public bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            throw new Exception("null or empty");
        var t = s.ToCharArray();
        Array.Reverse(t);
        return s == new string(t);
    }

}
#endregion