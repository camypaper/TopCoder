using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using SB = System.Text.StringBuilder;
public class BrokenChessboard {
    public int minimumFixes(string[] board) {
        var s = "BW".ToCharArray();
        var n = board.Length;
        var m = board[0].Length;
        var min = int.MaxValue;
        for (int k = 0; k < 2; k++)
        {
            var cnt = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (board[i][j] != s[(i + j) % 2]) cnt++;
            min = Math.Min(min, cnt);
            Swap(ref s[0], ref s[1]);
        }
        return min;
    }

    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] board) {
        return 0;
    }

    // CUT end
}
// CUT begin
public partial class Tester: AbstractTester {

    public override void Run() {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
