using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace MaximumNumberTest
{
    public class Tests
    {
        [Test]
        ///TC 1.1
        public static void GivenMaxNumFirstPosition_whenFindMaxNum_shouldReturnsMaxFirst()
        {
            int max = MaximumNumber.CheckNumberInteger(100, 80, 60);
            Assert.AreEqual(100, max);
        }
        [Test]
        ///TC 1.2
        public void GivenMaxNumSecondPosition_whenFindMaxNum_shouldReturnsMaxSecond()
        {
            int max = MaximumNumber.CheckNumberInteger(200, 300, 150);
            Assert.AreEqual(300, max);
        }
        [Test]
        ///TC 1.3
        public void GivenMaxNumThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            int max = MaximumNumber.CheckNumberInteger(550,600,1000);
            Assert.AreEqual(1000,max);
        }


        [Test]
        ///TC 2.1
        public void GivenFloatNumFirstPostion_whenFindMax_shouldReturnsMaxFirst()
        {
            double max = MaximumNumber.CheckNumberFloat(30.7, 17.8, 14.6);
            Assert.AreEqual(30.7, max);
        }

        [Test]
        ///TC 2.2
        public void GivenFloatNumSecondPostion_whenFindMax_shouldReturnsMaxSecondPosition()
        {
            double max = MaximumNumber.CheckNumberFloat(40.7, 80.2, 20.5);
            Assert.AreEqual(80.2, max);
        }

        [Test]
        ///TC 2.3
        public void GivenFloatNumThirdPostion_whenFindMax_shouldReturnsMaxThirdPosition()
        {
            double max = MaximumNumber.CheckNumberFloat(78.6, 27.5, 80.2);
            Assert.AreEqual(80.2, max);
        }
    }
}