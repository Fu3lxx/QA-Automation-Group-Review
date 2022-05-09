using System;
using NUnit.Framework;
using Summator;

namespace TestSummator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test_Summator_Sum_ОnePositiveNumber()
        {
            var actual = Summator.Summator.Sum(new int[] { 1 });


            Assert.AreEqual(actual, 1);
        }

        [Test]
        public void Test_Summator_Sum_TwoPositiveNumbers()
        {
            var actual = Summator.Summator.Sum(new int[] { 1, 2 });


            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void Test_Summator_Sum_ОneNegativeNumber()
        {
            var actual = Summator.Summator.Sum(new int[] { -1 });


            Assert.AreEqual(actual, -1);
        }
        [Test]
        public void Test_Summator_Sum_TwoNegativeNumbers()
        {
            var actual = Summator.Summator.Sum(new int[] { -1, -2 });


            Assert.AreEqual(actual, -3);
        }
        [Test]
        public void Test_Summator_Sum_emptyArr()
        {
            var actual = Summator.Summator.Sum(new int[] { });


            Assert.AreEqual(actual, 0);
        }
        [Test]
        public void Test_Summator_Sum_BigValue()
        {
            var actual = Summator.Summator.Sum(new int[] { 1073741823, 1073741823 });


            Assert.AreEqual(actual, 2147483646);
        }

        ///////
        [Test]
        public void Test_Summator_АVG_ОneNumber()
        {

            Assert.Throws<ArgumentException>(() => Summator.Summator.Average(new int[] { 5 }));
        }

        [Test]
        public void Test_Summator_AVG_TwoPositiveNumbers()
        {
            double actual = Summator.Summator.Average(new int[] { 5, 6 });


            Assert.AreEqual(actual, 5.5);
        }

        [Test]
        public void Test_Summator_AVG_TwoNegativeNumbers()
        {
            var actual = Summator.Summator.Average(new int[] { -5, -6 });


            Assert.AreEqual(actual, -5.5);
        }
        [Test]
        public void Test_Summator_АVG_EmptyArray()
        {

            Assert.Throws<ArgumentException>(() => Summator.Summator.Average(new int[] {  }));
        }

        [Test]
        public void Test_Summator_AVG_TenPositiveNumbers()
        {
            double actual = Summator.Summator.Average(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 });


            Assert.AreEqual(actual, 10);
        }
    }
}