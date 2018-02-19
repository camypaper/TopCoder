using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);Tests.Add(Example7);Tests.Add(Example8);        
    }
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int __result = new WinterAndShopping().getNumber(parser.Items[0], parser.Items[1], parser.Items[2], parser.Items[3]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] first, int[] red, int[] green, int[] blue)
    {
        Console.WriteLine(string.Format("first:{0}", string.Join(" ",first)));
        Console.WriteLine(string.Format("red:{0}", string.Join(" ",red)));
        Console.WriteLine(string.Format("green:{0}", string.Join(" ",green)));
        Console.WriteLine(string.Format("blue:{0}", string.Join(" ",blue)));
        int __expected = new WinterAndShopping().getNumber(first, red, green, blue);
        
        int __result = new WinterAndShopping().Naive_Test(first, red, green, blue);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] first, int[] red, int[] green, int[] blue)
    {
        Console.WriteLine(string.Format("first:{0}", string.Join(" ",first)));
        Console.WriteLine(string.Format("red:{0}", string.Join(" ",red)));
        Console.WriteLine(string.Format("green:{0}", string.Join(" ",green)));
        Console.WriteLine(string.Format("blue:{0}", string.Join(" ",blue)));
        int __result = new WinterAndShopping().getNumber(first, red, green, blue);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] first = new int[] {
            1
        };
        Console.WriteLine(string.Format("first:{0}", string.Join(" ", first)));
        int[] red = new int[] {
            1
        };
        Console.WriteLine(string.Format("red:{0}", string.Join(" ", red)));
        int[] green = new int[] {
            1
        };
        Console.WriteLine(string.Format("green:{0}", string.Join(" ", green)));
        int[] blue = new int[] {
            1
        };
        Console.WriteLine(string.Format("blue:{0}", string.Join(" ", blue)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndShopping().getNumber(first, red, green, blue);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] first = new int[] {
            1
        };
        Console.WriteLine(string.Format("first:{0}", string.Join(" ", first)));
        int[] red = new int[] {
            3
        };
        Console.WriteLine(string.Format("red:{0}", string.Join(" ", red)));
        int[] green = new int[] {
            0
        };
        Console.WriteLine(string.Format("green:{0}", string.Join(" ", green)));
        int[] blue = new int[] {
            0
        };
        Console.WriteLine(string.Format("blue:{0}", string.Join(" ", blue)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndShopping().getNumber(first, red, green, blue);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] first = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("first:{0}", string.Join(" ", first)));
        int[] red = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("red:{0}", string.Join(" ", red)));
        int[] green = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("green:{0}", string.Join(" ", green)));
        int[] blue = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("blue:{0}", string.Join(" ", blue)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndShopping().getNumber(first, red, green, blue);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] first = new int[] {
            47,
            47
        };
        Console.WriteLine(string.Format("first:{0}", string.Join(" ", first)));
        int[] red = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("red:{0}", string.Join(" ", red)));
        int[] green = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("green:{0}", string.Join(" ", green)));
        int[] blue = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("blue:{0}", string.Join(" ", blue)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndShopping().getNumber(first, red, green, blue);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] first = new int[] {
            1,
            100,
            200
        };
        Console.WriteLine(string.Format("first:{0}", string.Join(" ", first)));
        int[] red = new int[] {
            100,
            1,
            0
        };
        Console.WriteLine(string.Format("red:{0}", string.Join(" ", red)));
        int[] green = new int[] {
            100,
            3,
            7
        };
        Console.WriteLine(string.Format("green:{0}", string.Join(" ", green)));
        int[] blue = new int[] {
            100,
            2,
            4
        };
        Console.WriteLine(string.Format("blue:{0}", string.Join(" ", blue)));
        int __expected = 79290907;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndShopping().getNumber(first, red, green, blue);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] first = new int[] {
            1,
            3
        };
        Console.WriteLine(string.Format("first:{0}", string.Join(" ", first)));
        int[] red = new int[] {
            3,
            4
        };
        Console.WriteLine(string.Format("red:{0}", string.Join(" ", red)));
        int[] green = new int[] {
            4,
            4
        };
        Console.WriteLine(string.Format("green:{0}", string.Join(" ", green)));
        int[] blue = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("blue:{0}", string.Join(" ", blue)));
        int __expected = 840;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndShopping().getNumber(first, red, green, blue);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int[] first = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("first:{0}", string.Join(" ", first)));
        int[] red = new int[] {
            100,
            100
        };
        Console.WriteLine(string.Format("red:{0}", string.Join(" ", red)));
        int[] green = new int[] {
            100,
            100
        };
        Console.WriteLine(string.Format("green:{0}", string.Join(" ", green)));
        int[] blue = new int[] {
            99,
            100
        };
        Console.WriteLine(string.Format("blue:{0}", string.Join(" ", blue)));
        int __expected = 412784747;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndShopping().getNumber(first, red, green, blue);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example7()
    {
        int[] first = new int[] {
            1,
            220,
            150
        };
        Console.WriteLine(string.Format("first:{0}", string.Join(" ", first)));
        int[] red = new int[] {
            70,
            70,
            50
        };
        Console.WriteLine(string.Format("red:{0}", string.Join(" ", red)));
        int[] green = new int[] {
            70,
            70,
            50
        };
        Console.WriteLine(string.Format("green:{0}", string.Join(" ", green)));
        int[] blue = new int[] {
            70,
            70,
            50
        };
        Console.WriteLine(string.Format("blue:{0}", string.Join(" ", blue)));
        int __expected = 291495139;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndShopping().getNumber(first, red, green, blue);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example8()
    {
        int[] first = new int[] {
            2,
            2,
            70,
            159
        };
        Console.WriteLine(string.Format("first:{0}", string.Join(" ", first)));
        int[] red = new int[] {
            100,
            20,
            21,
            52
        };
        Console.WriteLine(string.Format("red:{0}", string.Join(" ", red)));
        int[] green = new int[] {
            100,
            20,
            29,
            45
        };
        Console.WriteLine(string.Format("green:{0}", string.Join(" ", green)));
        int[] blue = new int[] {
            100,
            22,
            39,
            30
        };
        Console.WriteLine(string.Format("blue:{0}", string.Join(" ", blue)));
        int __expected = 139586270;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndShopping().getNumber(first, red, green, blue);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
