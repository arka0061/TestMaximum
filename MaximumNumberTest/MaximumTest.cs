using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestMaximum;
using Assert = NUnit.Framework.Assert;

namespace MaximumNumberTest
{
    public class Tests
    {
        [Test]
        ///TC 1.1
        public static void GivenMaxNumFirstPosition_whenFindMaxNum_shouldReturnsMaxFirst()
        {
            Generics<int> MaxValue = new Generics<int>(400, 200, 240);
            int max = MaxValue.MaxMethod();
            Assert.AreEqual(400,max);
        }
        [Test]
        ///TC 1.2
        public void GivenMaxNumSecondPosition_whenFindMaxNum_shouldReturnsMaxSecond()
        {
            Generics<int> MaxValue = new Generics<int>(200, 300, 240);
            int max = MaxValue.MaxMethod();
            Assert.AreEqual(300, max);
        }
        [Test]
        ///TC 1.3
        public void GivenMaxNumThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            Generics<int> MaxValue = new Generics<int>(420, 200, 440);
            int max = MaxValue.MaxMethod();
            Assert.AreEqual(440, max);
        }


        [Test]
        ///TC 2.1
        public void GivenFloatNumFirstPostion_whenFindMax_shouldReturnsMaxFirst()
        {
            Generics<float> MaxValue = new Generics<float>(20, 40, 24);
            float max = MaxValue.MaxMethod();
            Assert.AreEqual(40.0, max);
        }

        [Test]
        ///TC 2.2
        public void GivenFloatNumSecondPostion_whenFindMax_shouldReturnsMaxSecondPosition()
        {
            Generics<float> MaxValue = new Generics<float>(40, 20, 44);
            float max = MaxValue.MaxMethod();
            Assert.AreEqual(43.0, max);
        }

        [Test]
        ///TC 2.3
        public void GivenFloatNumThirdPostion_whenFindMax_shouldReturnsMaxThirdPosition()
        {
            Generics<float> MaxValue = new Generics<float>(40, 20, 24);
            float max = MaxValue.MaxMethod();
            Assert.AreEqual(40.0, max);
        }
      
        /// TC 3.1    
        [Test]
        public void GivenMaxStringFirstPositon_whenFindMax_shouldReturnsMaxFirstPosition()
        {
            Generics<string> MaxValue = new Generics<string>("Ball", "Car", "Apple");
            string max = MaxValue.MaxMethod();
            Assert.AreEqual("Car", max);
        }
        /// TC 3.2
        [Test]
        public void GivenMaxStringSecondPositon_whenFindMax_shouldReturnsMaxSecondPosition()
        {
            Generics<string> MaxValue = new Generics<string>("Ball", "Car", "Apple");
            string max = MaxValue.MaxMethod();
            Assert.AreEqual("Car", max);
        }     
        /// TC 3.3
        [Test]
        public void GivenMaxStringThirdPositon_whenFindMax_shouldReturnsMaxThirdPosition()
        {
            Generics<string> MaxValue = new Generics<string>("Ball", "Apple","Car" );
            string max = MaxValue.MaxMethod();
            Assert.AreEqual("Car", max);
        }
    }
}