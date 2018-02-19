using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);        
    }
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int __result = new AncientGameRecord().minimalRemove(parser.Items[0], parser.Items[1], parser.Items[2], parser.Items[3], parser.Items[4]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int n, int m, int[] x, int[] y, string d)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("m:{0}", m);
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        Console.WriteLine("d:{0}", d);
        int __expected = new AncientGameRecord().minimalRemove(n, m, x, y, d);
        
        int __result = new AncientGameRecord().Naive_Test(n, m, x, y, d);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int n, int m, int[] x, int[] y, string d)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("m:{0}", m);
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        Console.WriteLine("d:{0}", d);
        int __result = new AncientGameRecord().minimalRemove(n, m, x, y, d);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int[] x = new int[] {
            0,
            1,
            1,
            0
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string d = "DRUL";
        Console.WriteLine("d:{0}", d);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AncientGameRecord().minimalRemove(n, m, x, y, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int[] x = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string d = "LU";
        Console.WriteLine("d:{0}", d);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AncientGameRecord().minimalRemove(n, m, x, y, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int m = 3;
        Console.WriteLine("m:{0}", m);
        int[] x = new int[] {
            0,
            0,
            0,
            1,
            2,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            1,
            1,
            1,
            1,
            2
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string d = "RLDDRL";
        Console.WriteLine("d:{0}", d);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AncientGameRecord().minimalRemove(n, m, x, y, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int m = 3;
        Console.WriteLine("m:{0}", m);
        int[] x = new int[] {
            0,
            0,
            2,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            0,
            2,
            2
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string d = "ULDR";
        Console.WriteLine("d:{0}", d);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AncientGameRecord().minimalRemove(n, m, x, y, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 6;
        Console.WriteLine("n:{0}", n);
        int m = 6;
        Console.WriteLine("m:{0}", m);
        int[] x = new int[] {
            0,
            5,
            4,
            1,
            3,
            2,
            5,
            4,
            2,
            2,
            5,
            4,
            1,
            3,
            2,
            5
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            5,
            4,
            1,
            1,
            1,
            2,
            3,
            5,
            4,
            2,
            0,
            2,
            0,
            0,
            2,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string d = "DRULLLUDRUDLRUDL";
        Console.WriteLine("d:{0}", d);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AncientGameRecord().minimalRemove(n, m, x, y, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
