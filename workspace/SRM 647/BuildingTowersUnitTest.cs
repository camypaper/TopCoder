using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    [TestMethod]
    public void Example0()
    {
        int N = 10;
        Console.WriteLine("N:{0}",N);
        int K = 1;
        Console.WriteLine("K:{0}",K);
        int[] x = new int[] {
            3,
            8
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] t = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("t:{0}",string.Join(" ",t)));
        long __expected = 3L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new BuildingTowers().maxHeight(N, K, x, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int N = 1000000000;
        Console.WriteLine("N:{0}",N);
        int K = 1000000000;
        Console.WriteLine("K:{0}",K);
        int[] x = new int[] {
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] t = new int[] {
        };
        Console.WriteLine(string.Format("t:{0}",string.Join(" ",t)));
        long __expected = 999999999000000000L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new BuildingTowers().maxHeight(N, K, x, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int N = 20;
        Console.WriteLine("N:{0}",N);
        int K = 3;
        Console.WriteLine("K:{0}",K);
        int[] x = new int[] {
            4,
            7,
            13,
            15,
            18
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] t = new int[] {
            8,
            22,
            1,
            55,
            42
        };
        Console.WriteLine(string.Format("t:{0}",string.Join(" ",t)));
        long __expected = 22L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new BuildingTowers().maxHeight(N, K, x, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int N = 780;
        Console.WriteLine("N:{0}",N);
        int K = 547990606;
        Console.WriteLine("K:{0}",K);
        int[] x = new int[] {
            34,
            35,
            48,
            86,
            110,
            170,
            275,
            288,
            313,
            321,
            344,
            373,
            390,
            410,
            412,
            441,
            499,
            525,
            538,
            568,
            585,
            627,
            630,
            671,
            692,
            699,
            719,
            752,
            755,
            764,
            772
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] t = new int[] {
            89,
            81,
            88,
            42,
            55,
            92,
            19,
            91,
            71,
            42,
            72,
            18,
            86,
            89,
            88,
            75,
            29,
            98,
            63,
            74,
            45,
            11,
            68,
            34,
            94,
            20,
            69,
            33,
            50,
            69,
            54
        };
        Console.WriteLine(string.Format("t:{0}",string.Join(" ",t)));
        long __expected = 28495511604L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new BuildingTowers().maxHeight(N, K, x, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int N = 7824078;
        Console.WriteLine("N:{0}",N);
        int K = 2374;
        Console.WriteLine("K:{0}",K);
        int[] x = new int[] {
            134668,
            488112,
            558756,
            590300,
            787884,
            868112,
            1550116,
            1681439,
            1790994,
            1796091,
            1906637,
            2005485,
            2152813,
            2171716,
            2255697,
            2332732,
            2516853,
            2749024,
            2922558,
            2930163,
            3568190,
            3882735,
            4264888,
            5080550,
            5167938,
            5249191,
            5574341,
            5866912,
            5936121,
            6142348,
            6164177,
            6176113,
            6434368,
            6552905,
            6588059,
            6628843,
            6744163,
            6760794,
            6982172,
            7080464,
            7175493,
            7249044
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] t = new int[] {
            8,
            9,
            171315129,
            52304509,
            1090062,
            476157338,
            245,
            6,
            253638067,
            37,
            500,
            29060,
            106246500,
            129,
            22402,
            939993108,
            7375,
            2365707,
            40098,
            10200444,
            3193547,
            55597,
            24920935,
            905027,
            1374,
            12396141,
            525886,
            41,
            33,
            3692,
            11502,
            180,
            3186,
            5560,
            778988,
            42449532,
            269666,
            10982579,
            48,
            3994,
            1,
            9
        };
        Console.WriteLine(string.Format("t:{0}",string.Join(" ",t)));
        long __expected = 1365130725L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new BuildingTowers().maxHeight(N, K, x, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
