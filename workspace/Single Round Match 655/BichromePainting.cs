using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class BichromePainting
{
    public string isThatPossible(string[] board, int k)
    {
        var n = board.Length;
        var map = new char[n][];
        for (int i = 0; i < n; i++)
            map[i] = new char[n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                map[i][j] = 'W';
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                if (map[i][j] != board[i][j])
                {
                    var c = board[i][j];
                    for (int t = i; t < i + k; t++)
                        for (int s = j; s < j + k; s++)
                        {
                            if (t >= n || s >= n)
                                return "Impossible";
                            map[t][s] = c;
                        }

                }

            }


        return "Possible";
    }
}
