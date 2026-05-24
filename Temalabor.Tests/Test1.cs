namespace Temalabor.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class Test1
{
    [TestMethod]
    public void Test_Pelda1()
    {
        
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void Test_Pelda2()
    {
      
        int a = 2;
        int b = 3;
        Assert.AreEqual(5, a + b);
    }
}