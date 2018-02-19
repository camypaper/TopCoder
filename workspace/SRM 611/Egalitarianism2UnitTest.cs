using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);    }
    public void ManualTest(int[] x, int[] y)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        double __result = new Egalitarianism2().minStdev(x, y);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            0,
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            1,
            0,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        double __expected = 0.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Egalitarianism2().minStdev(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            9,
            10
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        double __expected = 0.5;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Egalitarianism2().minStdev(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            12,
            46,
            81,
            56
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            45,
            2,
            67
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        double __expected = 6.102799971320928;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Egalitarianism2().minStdev(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            2,
            3,
            9,
            10,
            15,
            16
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        double __expected = 0.9428090415820632;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Egalitarianism2().minStdev(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
            167053,
            536770,
            -590401,
            507047,
            350178,
            -274523,
            -584679,
            -766795,
            -664177,
            267757,
            -291856,
            -765547,
            604801,
            -682922,
            -404590,
            468001,
            607925,
            503849,
            -499699,
            -798637
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            -12396,
            -66098,
            -56843,
            20270,
            81510,
            -23294,
            10423,
            24007,
            -24343,
            -21587,
            -6318,
            -7396,
            -68622,
            56304,
            -85680,
            -14890,
            -38373,
            -25477,
            -38240,
            11736
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        double __expected = 40056.95946451828;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Egalitarianism2().minStdev(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example5()
    {
        int[] x = new int[] {
            -306880,
            169480,
            -558404,
            -193925,
            654444,
            -300247,
            -456420,
            -119436,
            -620920,
            -470018,
            -914272,
            -691256,
            -49418,
            -21054,
            603373,
            -23656,
            891691,
            258986,
            -453793,
            -782940
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            -77318,
            -632629,
            -344942,
            -361706,
            191982,
            349424,
            676536,
            166124,
            291342,
            -268968,
            188262,
            -537953,
            -70432,
            156803,
            166174,
            345128,
            58614,
            -671747,
            508265,
            92324
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        double __expected = 36879.15127634308;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Egalitarianism2().minStdev(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
