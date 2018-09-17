using System;
using mathlib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mathlibTest
{
    [TestClass]
    public class mathlibTest
    {
        HejMatematik m = new HejMatematik();
        [TestMethod]
        public void addTest()
        {
        

            Assert.IsTrue(m.Add(2, 3) == 5);
        }
        [TestMethod]
        public void addTestNegativeNumber()

        {
            
            Assert.AreEqual(m.Add(-3, -4), -7);
        }
    }

}
