using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;

namespace MathTests
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void BasicRooterTest()
        {
            Rooter rooter = new Rooter();
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);
            Assert.AreEqual(expectedResult, actualResult,delta: expectedResult/100);
        }
    }
}
