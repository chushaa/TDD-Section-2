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

            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }

        [TestMethod]
        public void RooterValueRangeTest()
        {
            Rooter rooter = new Rooter();

            for (double expected = 1e-8; expected < 1e+8; expected *= 3.2) {
                RooterOneValue(rooter, expected);
            }
        }

        public void RooterOneValue(Rooter rooter, double expectedResult)
        {
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);

            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 1000);
        }

        [TestMethod]
        public void RooterNegativeInputTest()
        {
            Rooter rooter = new Rooter();

            try
            {
                rooter.SquareRoot(-10);
            }
            catch (System.ArgumentOutOfRangeException) {
                return;
            }


            Assert.Fail();
        }
    }
}
