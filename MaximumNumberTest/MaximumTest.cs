using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace MaximumNumberTest
{
    public class Tests
    {
        [Test]
        public static void GivenMaxNumFirstPosition_whenFindMaxNum_shouldReturnsMaxFirst()
        {
            int max = MaximumNumber.CheckNumber(100, 80, 60);
            Assert.AreEqual(100, max);
        }
        [Test]
        public void GivenMaxNumSecondPosition_whenFindMaxNum_shouldReturnsMaxSecond()
        {
            int max = MaximumNumber.CheckNumber(200, 300, 150);
            Assert.AreEqual(300, max);
        }
        [Test]
        public void GivenMaxNumThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            int max = MaximumNumber.CheckNumber(550,600,1000);
            Assert.AreEqual(1000,max);
        }
    }
}