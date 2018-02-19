using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MagicBoard {
    public string ableToUnlock(string[] board) {
        var n = board.Length;
        var m = board[0].Length;
        var map = Enumerate(n, x => new char[m]);
        var cnt = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++) {
                map[i][j] = board[i][j];
                if (map[i][j] == '#') cnt++;
            }

        if (cnt == 1) return "YES";

        return solve(map, n, m) ? "YES" : "NO";
    }
    bool solve(char[][] map, int n, int m) {
        var k = new int[2];
        k[0]++;
        k[map.SelectMany(x => x).Count(x => x == '#') % 2]++;
        var s = new DisjointSet(n * m);
        for (int i = 0; i < n; i++) {
            var cnt = map[i].Count(x => x == '#');
            if (cnt % 2 == 1) k[1]--;
            if (cnt > 0) {
                var id = -1;
                for (int j = 0; j < m; j++)
                    if (map[i][j] == '#') { id = id == -1 ? j : id; s.Unite(i * m + j, i * m + id); }
            }

        }
        for (int j = 0; j < m; j++) {
            var cnt = 0;
            for (int i = 0; i < n; i++)
                if (map[i][j] == '#') cnt++;
            if (cnt % 2 == 1) k[0]--;
            if (cnt > 0) {
                var id = -1;
                for (int i = 0; i < n; i++)
                    if (map[i][j] == '#') { id = id == -1 ? i : id; s.Unite(i * m + j, id * m + j); }
            }
        }
        if (k.Min() < 0) return false;
        var all = map.SelectMany(x => x).Count(x => x == '#');
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (map[i][j] == '#' && s.Size(i * m + j) != all) return false;
        return true;

    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(string[] board) {
        return "";
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
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);
        Test(Example6);

    }
}
// CUT end
#region DisjointSet
public class DisjointSet {
    int[] par;
    byte[] rank;
    public DisjointSet(int n) {
        par = new int[n];
        for (int i = 0; i < n; i++)
            par[i] = -1;
        rank = new byte[n];
    }
    public int this[int id] {
        get {
            if ((par[id] < 0)) return id;
            return par[id] = this[par[id]];
        }
    }
    public bool Unite(int x, int y) {
        x = this[x]; y = this[y];
        if (x == y) return false;
        if (rank[x] < rank[y]) { var z = x; x = y; y = z; }
        par[x] += par[y];
        par[y] = x;
        if (rank[x] == rank[y])
            rank[x]++;
        return true;
    }
    public int Size(int x) { return -par[this[x]]; }
    public bool IsUnited(int x, int y) { return this[x] == this[y]; }

}
#endregion