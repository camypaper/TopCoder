using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);        
    }
	public void ManualTest(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int __result = new CatchTheBeat().maxCatched(parser.Items[0], parser.Items[1], parser.Items[2], parser.Items[3], parser.Items[4], parser.Items[5], parser.Items[6], parser.Items[7], parser.Items[8], parser.Items[9]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void ManualTest(int n, int x0, int y0, int a, int b, int c, int d, int mod1, int mod2, int offset)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("x0:{0}", x0);
        Console.WriteLine("y0:{0}", y0);
        Console.WriteLine("a:{0}", a);
        Console.WriteLine("b:{0}", b);
        Console.WriteLine("c:{0}", c);
        Console.WriteLine("d:{0}", d);
        Console.WriteLine("mod1:{0}", mod1);
        Console.WriteLine("mod2:{0}", mod2);
        Console.WriteLine("offset:{0}", offset);
        int __result = new CatchTheBeat().maxCatched(n, x0, y0, a, b, c, d, mod1, mod2, offset);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int x0 = 0;
        Console.WriteLine("x0:{0}", x0);
        int y0 = 0;
        Console.WriteLine("y0:{0}", y0);
        int a = 1;
        Console.WriteLine("a:{0}", a);
        int b = 1;
        Console.WriteLine("b:{0}", b);
        int c = 1;
        Console.WriteLine("c:{0}", c);
        int d = 1;
        Console.WriteLine("d:{0}", d);
        int mod1 = 100;
        Console.WriteLine("mod1:{0}", mod1);
        int mod2 = 100;
        Console.WriteLine("mod2:{0}", mod2);
        int offset = 1;
        Console.WriteLine("offset:{0}", offset);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CatchTheBeat().maxCatched(n, x0, y0, a, b, c, d, mod1, mod2, offset);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 1;
        Console.WriteLine("n:{0}", n);
        int x0 = 0;
        Console.WriteLine("x0:{0}", x0);
        int y0 = 1234;
        Console.WriteLine("y0:{0}", y0);
        int a = 0;
        Console.WriteLine("a:{0}", a);
        int b = 0;
        Console.WriteLine("b:{0}", b);
        int c = 0;
        Console.WriteLine("c:{0}", c);
        int d = 0;
        Console.WriteLine("d:{0}", d);
        int mod1 = 1000000000;
        Console.WriteLine("mod1:{0}", mod1);
        int mod2 = 1000000000;
        Console.WriteLine("mod2:{0}", mod2);
        int offset = 1000;
        Console.WriteLine("offset:{0}", offset);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CatchTheBeat().maxCatched(n, x0, y0, a, b, c, d, mod1, mod2, offset);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 1;
        Console.WriteLine("n:{0}", n);
        int x0 = 0;
        Console.WriteLine("x0:{0}", x0);
        int y0 = 999;
        Console.WriteLine("y0:{0}", y0);
        int a = 0;
        Console.WriteLine("a:{0}", a);
        int b = 0;
        Console.WriteLine("b:{0}", b);
        int c = 0;
        Console.WriteLine("c:{0}", c);
        int d = 0;
        Console.WriteLine("d:{0}", d);
        int mod1 = 1000000000;
        Console.WriteLine("mod1:{0}", mod1);
        int mod2 = 1000000000;
        Console.WriteLine("mod2:{0}", mod2);
        int offset = 1000;
        Console.WriteLine("offset:{0}", offset);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CatchTheBeat().maxCatched(n, x0, y0, a, b, c, d, mod1, mod2, offset);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 100;
        Console.WriteLine("n:{0}", n);
        int x0 = 0;
        Console.WriteLine("x0:{0}", x0);
        int y0 = 0;
        Console.WriteLine("y0:{0}", y0);
        int a = 1;
        Console.WriteLine("a:{0}", a);
        int b = 1;
        Console.WriteLine("b:{0}", b);
        int c = 1;
        Console.WriteLine("c:{0}", c);
        int d = 1;
        Console.WriteLine("d:{0}", d);
        int mod1 = 3;
        Console.WriteLine("mod1:{0}", mod1);
        int mod2 = 58585858;
        Console.WriteLine("mod2:{0}", mod2);
        int offset = 1;
        Console.WriteLine("offset:{0}", offset);
        int __expected = 66;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CatchTheBeat().maxCatched(n, x0, y0, a, b, c, d, mod1, mod2, offset);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 500000;
        Console.WriteLine("n:{0}", n);
        int x0 = 123456;
        Console.WriteLine("x0:{0}", x0);
        int y0 = 0;
        Console.WriteLine("y0:{0}", y0);
        int a = 1;
        Console.WriteLine("a:{0}", a);
        int b = 0;
        Console.WriteLine("b:{0}", b);
        int c = 1;
        Console.WriteLine("c:{0}", c);
        int d = 1;
        Console.WriteLine("d:{0}", d);
        int mod1 = 1000000000;
        Console.WriteLine("mod1:{0}", mod1);
        int mod2 = 1000000000;
        Console.WriteLine("mod2:{0}", mod2);
        int offset = 0;
        Console.WriteLine("offset:{0}", offset);
        int __expected = 376544;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CatchTheBeat().maxCatched(n, x0, y0, a, b, c, d, mod1, mod2, offset);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int n = 500000;
        Console.WriteLine("n:{0}", n);
        int x0 = 0;
        Console.WriteLine("x0:{0}", x0);
        int y0 = 0;
        Console.WriteLine("y0:{0}", y0);
        int a = 0;
        Console.WriteLine("a:{0}", a);
        int b = 0;
        Console.WriteLine("b:{0}", b);
        int c = 0;
        Console.WriteLine("c:{0}", c);
        int d = 0;
        Console.WriteLine("d:{0}", d);
        int mod1 = 1;
        Console.WriteLine("mod1:{0}", mod1);
        int mod2 = 1;
        Console.WriteLine("mod2:{0}", mod2);
        int offset = 0;
        Console.WriteLine("offset:{0}", offset);
        int __expected = 500000;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CatchTheBeat().maxCatched(n, x0, y0, a, b, c, d, mod1, mod2, offset);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int n = 10;
        Console.WriteLine("n:{0}", n);
        int x0 = 999999957;
        Console.WriteLine("x0:{0}", x0);
        int y0 = 79;
        Console.WriteLine("y0:{0}", y0);
        int a = 993948167;
        Console.WriteLine("a:{0}", a);
        int b = 24597383;
        Console.WriteLine("b:{0}", b);
        int c = 212151897;
        Console.WriteLine("c:{0}", c);
        int d = 999940854;
        Console.WriteLine("d:{0}", d);
        int mod1 = 999999986;
        Console.WriteLine("mod1:{0}", mod1);
        int mod2 = 999940855;
        Console.WriteLine("mod2:{0}", mod2);
        int offset = 3404;
        Console.WriteLine("offset:{0}", offset);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CatchTheBeat().maxCatched(n, x0, y0, a, b, c, d, mod1, mod2, offset);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
