using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class mRNASplicingTest
{
    [TestMethod]
    public void Example0()
    {
        string s = "AUG";
        Console.WriteLine("s:{0}",s);
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new mRNASplicing().count(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string s = "AAUUGG";
        Console.WriteLine("s:{0}",s);
        int __expected = 12;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new mRNASplicing().count(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string s = "GCCGUCCUAACCGGGCCGUUCCUUU";
        Console.WriteLine("s:{0}",s);
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new mRNASplicing().count(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string s = "CAGUUGCAUGCAGUGAUCGUCAUGGCAUUGCAUGGCAUGCUAGGUCAGUGCUAGUGGCAUGCUAGCU";
        Console.WriteLine("s:{0}",s);
        int __expected = 231666967;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new mRNASplicing().count(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
