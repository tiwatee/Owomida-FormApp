using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OwomidaForm;

namespace OwomidaTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Implementing multiple test cases based on the formula
        /// </summary>
        /// <param name="trip"></param>
        /// <param name="fee"></param>
        /// <param name="membership"></param>
        /// <param name="expectedFee"></param>
        [TestMethod]
        [DataRow(2,100,0.7d,140)]
        [DataRow(1,50,1d,50)]
        [DataRow(10,200, 0.7d,1400)]
        [DataRow(10,30, 1d,300)]
        [DataRow(10, 30, 0.7d, 210)]
        public void TollFee(int trip, double fee, double membership, double expectedFee)
        {
            var toll = new Owomida();
            double amount = toll.TollFee(trip, fee, membership);
            Assert.AreEqual(expectedFee, amount);
        }
    }
}
