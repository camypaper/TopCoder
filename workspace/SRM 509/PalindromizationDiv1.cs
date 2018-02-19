using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PalindromizationDiv1 {
    public int getMinimumCost(string word, string[] operations) {
        const long INF = 1L << 60;
        Array.Sort(operations, StringComparer.Ordinal);
        var add = Enumerate(26, x => INF);
        var rem = Enumerate(26, x => INF);
        var go = Enumerate(27, x => Enumerate(27, y => x == y ? 0 : INF));
        foreach (var x in operations) {
            Debug.WriteLine(x);
            var y = x.Split();
            var op = y[0];
            var c = y[1][0] - 'a';
            if (op == "add") { go[26][c] = Math.Min(go[26][c], int.Parse(y[2])); }
            else if (op == "erase") { go[c][26] = Math.Min(go[c][26], int.Parse(y[2])); }
            else { var d = y[2][0] - 'a'; go[c][d] = Math.Min(go[c][d], int.Parse(y[3])); }
        }
        for (int k = 0; k <= 26; k++)
            for (int i = 0; i <= 26; i++)
                for (int j = 0; j <= 26; j++)
                    go[i][j] = Math.Min(go[i][j], go[i][k] + go[k][j]);
        for (int i = 0; i < 26; i++) {
            add[i] = go[26][i];
            rem[i] = go[i][26];
        }
        var n = word.Length;
        var s = Enumerate(n, x => word[x] - 'a');
        var m = 150;
        var dp = Enumerate(m, x => new long[n + 1, n + 1]);
        for (int k = 0; k < m; k++)
            for (int i = 0; i <= n; i++)
                for (int j = 0; j <= n; j++)
                    dp[k][i, j] = INF;
        Func<int, int, int, long> dfs = null;
        dfs = (len, l, r) => {
            if (len < 0) return INF;
            if (l > r) return INF;
            if (dp[len][l, r] != INF) return dp[len][l, r];
            if (len == 0 && r - l == 0) return dp[len][l, r] = 0;
            if (len == 1 && r - l == 1) return dp[len][l, r] = 0;
            //Debug.WriteLine($"{len} [{l} {r})");

            var ret = INF - 1;
            //remove
            if (r - l > 0) {
                if (l != n)
                    ret = Math.Min(ret, dfs(len, l + 1, r) + rem[s[l]]);
                if (r != 0)
                    ret = Math.Min(ret, dfs(len, l, r - 1) + rem[s[r - 1]]);
                //add
                if (len >= 2) {
                    for (int c = 0; c < 26; c++) {
                        //L add
                        ret = Math.Min(ret, dfs(len - 2, l + 1, r) + add[c] + go[s[l]][c]);
                        //R add
                        ret = Math.Min(ret, dfs(len - 2, l, r - 1) + add[c] + go[s[r - 1]][c]);
                        //L R replace
                        ret = Math.Min(ret, dfs(len - 2, l + 1, r - 1) + go[s[l]][c] + go[s[r - 1]][c]);
                    }
                }
            }



            return dp[len][l, r] = ret;
        };

        var ans = INF;
        for (int i = 0; i < m; i++)
            ans = Math.Min(ans, dfs(i, 0, n));
        Debug.WriteLine(ans);
        return (int)(ans >= INF - 1 ? -1 : ans);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string word, string[] operations) {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX {
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester {
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run() {
        ManualTest("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaz", new string[] { "change o n 100000", "change q p 100000", "change g f 100000", "change k j 100000", "change s r 100000", "change n o 100000", "change n m 100000", "change g h 100000", "change w x 100000", "change h i 100000", "change r s 100000", "change u v 100000", "change c b 100000", "change b a 100000", "change q r 100000", "change x y 100000", "change w v 100000", "change x w 100000", "change h g 100000", "change r q 100000", "change j i 100000", "change f e 100000", "change l k 100000", "change k l 100000", "change a b 100000", "change i h 100000", "change v u 100000", "change t u 100000", "erase y 100000", "change s t 100000", "change e d 100000", "change y x 100000", "change c d 100000", "change p o 100000", "change m l 100000", "change u t 100000", "change o p 100000", "change j k 100000", "change f g 100000", "change m n 100000", "add y 100000", "change d c 100000", "change e f 100000", "change d e 100000", "change l m 100000", "change i j 100000", "change p q 100000", "change t s 100000", "change b c 100000", "change v w 100000" });
        ManualTest("aaaazzaazazaazzaazaazaazzaazzazzazzaazzazazzaazzzz", new string[] { "change h g 100000", "change y x 100000", "change p q 100000", "change s t 100000", "change h i 100000", "change r s 100000", "change g h 100000", "change s r 100000", "change i h 100000", "change o p 100000", "change m n 100000", "change n o 100000", "change u t 100000", "change x w 100000", "change c d 100000", "change x y 100000", "change y z 100000", "change w v 100000", "change r q 100000", "change q r 100000", "change d e 100000", "change l m 100000", "change m l 100000", "change a b 100000", "change v u 100000", "change l k 100000", "change j k 100000", "change k j 100000", "change t u 100000", "change d c 100000", "change o n 100000", "change j i 100000", "change t s 100000", "change b a 100000", "change n m 100000", "change b c 100000", "change v w 100000", "change c b 100000", "change f e 100000", "change z y 100000", "change w x 100000", "change e d 100000", "change i j 100000", "change q p 100000", "change e f 100000", "change p o 100000", "change f g 100000", "change g f 100000", "change u v 100000", "change k l 100000" });
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
