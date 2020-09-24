using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;
using System;

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
        public void RooterValueChange()
        {
            Rooter rooter = new Rooter();

            for (double expected = 1e-8; expected < 1e+8; expected *= 3.2)
            {
                RooterOneValue(rooter, expected);
            }
        }

        private void RooterOneValue(Rooter rooter, double expectedResult)
        {
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);

            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }

        [TestMethod]
        public void RooterTestNegativeInputs()
        {
            Rooter rooter = new Rooter();

            try
            {
                rooter.SquareRoot(-10);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }

            Assert.Fail();
        }
    }
}
