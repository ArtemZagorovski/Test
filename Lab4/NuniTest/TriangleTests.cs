using NUnit.Framework;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MyClassTests

{
    [TestFixture]
    public class Test
    {
        [Test]
        public void EqualSidesIsTrue()
        {
            bool expected = true;

            TriangleTest result = new TriangleTest();

            int actual = result.Triangle(2, 2, 2);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void NegativeSideIsFalse()
        {
            bool expected = true;

            TriangleTest result = new TriangleTest();

            int actual = result.Triangle(-2, 2, 2);
            Assert.AreEqual(expected, actual);
        }
      
        [Test]
        public void OneSideEqualSumOfTwoIsFalse()
        {
            bool expected = true;

            TriangleTest result = new TriangleTest();

            int actual = result.Triangle(2, 2, 4);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void UsualSidesIsTrue()
        {
            bool expected = true;

            TriangleTest result = new TriangleTest();

            int actual = result.Triangle(3, 4, 5);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OneSideBiggerThanSumOfTwoIsFalse()
        {
            bool expected = true;

            TriangleTest result = new TriangleTest();

            int actual = result.Triangle(2, 2, 6);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OneSideDoesntExistIsFalse()
        {
            bool expected = true;

            TriangleTest result = new TriangleTest();

            int actual = result.Triangle(0, 2, 6);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void twoSidesAreEqualIsTrue()
        {
            bool expected = true;

            TriangleTest result = new TriangleTest();

            int actual = result.Triangle(2, 6, 6);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TriangleDoesentExistIsFalse()
        {
            bool expected = true;

            TriangleTest result = new TriangleTest();

            int actual = result.Triangle(0, 0, 0);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TwoSidesIsNegativeIsFalse()
        {
            bool expected = true;

            TriangleTest result = new TriangleTest();

            int actual = result.Triangle(-2, -2, 6);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TwoSidesDoesntExistIsFalse()
        {
            bool expected = true;

            TriangleTest result = new TriangleTest();

            int actual = result.Triangle(0, 0, 6);
            Assert.AreEqual(expected, actual);
        }
    }

}
