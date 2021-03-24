using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 3;
            double b = 4;
            double results = ConsoleApp1.Program.Hipotenus(a,b);
            double results1 = ConsoleApp1.Program.Per(a, b, results);
            Assert.AreEqual(5, results);
            Assert.AreEqual(12, results1);
        }
    }
}
