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
            int[] array = {400, 100, 50, 300 };
            Generics<int> MaxValue = new Generics<int>(array);
            int max = MaxValue.MaxMethod();
            Assert.AreEqual(400,max);
        }
        [Test]
        ///TC 1.2
        public void GivenMaxNumSecondPosition_whenFindMaxNum_shouldReturnsMaxSecond()
        {
            int[] array = { 200, 300, 20, 240 };
            Generics<int> MaxValue = new Generics<int>(array);
            int max = MaxValue.MaxMethod();
            Assert.AreEqual(300, max);
        }
        [Test]
        ///TC 1.3
        public void GivenMaxNumThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            int[] array = { 400, 100, 500,150 };
            Generics<int> MaxValue = new Generics<int>(array);
            int max = MaxValue.MaxMethod();
            Assert.AreEqual(500, max);
        }


        [Test]
        ///TC 2.1
        public void GivenFloatNumFirstPostion_whenFindMax_shouldReturnsMaxFirst()
        {
            float[] array= { 400, 100, 50, 300 };
            Generics<float> MaxValue = new Generics<float>(array);
            float max = MaxValue.MaxMethod();
            Assert.AreEqual(400, max);
        }

        [Test]
        ///TC 2.2
        public void GivenFloatNumSecondPostion_whenFindMax_shouldReturnsMaxSecondPosition()
        {
            float[] array = { 400, 500, 100,  300 };
            Generics<float> MaxValue = new Generics<float>(array);
            float max = MaxValue.MaxMethod();
            Assert.AreEqual(500, max);
        }

        [Test]
        ///TC 2.3
        public void GivenFloatNumFourthPostion_whenFindMax_shouldReturnsMaxThirdPosition()
        {
            float[] array = { 400, 200, 100, 600 };
            Generics<float> MaxValue = new Generics<float>(array);
            float max = MaxValue.MaxMethod();
            Assert.AreEqual(600, max);
        }
      
        /// TC 3.1    
        [Test]
        public void GivenMaxStringFirstPositon_whenFindMax_shouldReturnsMaxFirstPosition()
        {
            string[] array = { "Car","Bat","Ball", "Apple" };
            Generics<string> MaxValue = new Generics<string>(array);
            string max = MaxValue.MaxMethod();
            Assert.AreEqual("Car", max);
        }
        /// TC 3.2
        [Test]
        public void GivenMaxStringSecondPositon_whenFindMax_shouldReturnsMaxSecondPosition()
        {
            string[] array = { "Ball", "Car","Bat", "Apple" };
            Generics<string> MaxValue = new Generics<string>(array);
            string max = MaxValue.MaxMethod();
            Assert.AreEqual("Car", max);
        }     
        /// TC 3.3
        [Test]
        public void GivenMaxStringFourthPositon_whenFindMax_shouldReturnsMaxThirdPosition()
        {
            string[] array = { "Apple", "Ball" ,"Bat" ,"Car" };
            Generics<string> MaxValue = new Generics<string>(array);
            string max = MaxValue.MaxMethod();
            Assert.AreEqual("Car", max);
        }
    }
}