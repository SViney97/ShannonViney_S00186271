using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShannonViney_S00186271;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IncreasePrice_Test()
        {
            //ARRANGE
            Phone P1 = new Phone();
            decimal percent = 0.20m;          
            decimal expected = 0m;

            //ACT
            P1.IncreasePrice(percent);

            //ASSERT
            Assert.AreEqual(expected, P1.Price);
        }
    }
}
