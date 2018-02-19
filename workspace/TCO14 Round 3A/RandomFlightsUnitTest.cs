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
        double __result = new RandomFlights().expectedDistance(parser.Items[0], parser.Items[1], parser.Items[2]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] x, int[] y, string[] flight)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        Console.WriteLine(string.Format("flight:{0}", string.Join(" ",flight)));
        double __expected = new RandomFlights().expectedDistance(x, y, flight);
        
        double __result = new RandomFlights().Naive_Test(x, y, flight);

        Assert.AreEqual(__expected, __result, 1e-9);
    }
    public void ManualTest(int[] x, int[] y, string[] flight)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        Console.WriteLine(string.Format("flight:{0}", string.Join(" ",flight)));
        double __result = new RandomFlights().expectedDistance(x, y, flight);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            7,
            10,
            9
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            3,
            3
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string[] flight = new string[] {
            "000",
            "001",
            "010"
        };
        Console.WriteLine(string.Format("flight:{0}", string.Join(" ", flight)));
        double __expected = 3.7169892001050897;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomFlights().expectedDistance(x, y, flight);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            4,
            1,
            5,
            6,
            6
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            5,
            10,
            3,
            4
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string[] flight = new string[] {
            "00110",
            "00101",
            "11000",
            "10001",
            "01010"
        };
        Console.WriteLine(string.Format("flight:{0}", string.Join(" ", flight)));
        double __expected = 8.927446638338974;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomFlights().expectedDistance(x, y, flight);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            7,
            10,
            9,
            7,
            7
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            3,
            3,
            6,
            4
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string[] flight = new string[] {
            "00001",
            "00000",
            "00010",
            "00100",
            "10000"
        };
        Console.WriteLine(string.Format("flight:{0}", string.Join(" ", flight)));
        double __expected = 6.2360162308285005;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomFlights().expectedDistance(x, y, flight);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            97,
            27,
            20,
            34,
            30,
            37,
            65,
            21,
            74,
            27,
            84,
            79,
            15,
            78,
            16,
            7,
            11,
            24
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            72,
            20,
            73,
            58,
            55,
            45,
            19,
            48,
            4,
            33,
            22,
            25,
            95,
            100,
            85,
            65,
            53
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string[] flight = new string[] {
            "000000000000000100",
            "001010000001000000",
            "010010000000000000",
            "000000000000100001",
            "011000000001000000",
            "000000001000000010",
            "000000000000010000",
            "000000000000000100",
            "000001000100001010",
            "000000001000000010",
            "000000000000100000",
            "010010000000000000",
            "000100000010000001",
            "000000100000000000",
            "000000001000000010",
            "100000010000000000",
            "000001001100001000",
            "000100000000100000"
        };
        Console.WriteLine(string.Format("flight:{0}", string.Join(" ", flight)));
        double __expected = 255.25627726422454;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomFlights().expectedDistance(x, y, flight);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
            35,
            8,
            71,
            81,
            43,
            76,
            55,
            15,
            72,
            39,
            99,
            23,
            14,
            77,
            47,
            43,
            60,
            67
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            68,
            96,
            98,
            16,
            7,
            74,
            52,
            63,
            98,
            77,
            52,
            93,
            52,
            4,
            56,
            11,
            75,
            63
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string[] flight = new string[] {
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000",
            "000000000000000000"
        };
        Console.WriteLine(string.Format("flight:{0}", string.Join(" ", flight)));
        double __expected = 138.0804889521365;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomFlights().expectedDistance(x, y, flight);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
