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
            TriangleTest result = new TriangleTest();
            Assert.AreEqual(true, result.Triangle(2, 2, 2));
        }

          [Test]
        public void twoSidesAreEqualIsTrue()
        {
            TriangleTest result = new TriangleTest();
            Assert.AreEqual(true, result.Triangle(2, 6, 6));
        }
        
        [Test]
        public void UsualSidesIsTrue()
        {
            TriangleTest result = new TriangleTest();
            Assert.AreEqual(true, result.Triangle(3, 4, 5));
        }

        [Test]
        public void UsualSidesIsTrue()
        {
            TriangleTest result = new TriangleTest();
            Assert.AreEqual(true, result.Triangle(3, 4, 5));
        }
 
          [Test]
        public void twoSidesAreEqualIsTrue()
        {
            TriangleTest result = new TriangleTest();
            Assert.AreEqual(true, result.Triangle(2, 6, 6));
        }

        [Test]
        public void NegativeSideIsFalse()
        {
            TriangleTest result = new TriangleTest();
            Assert.AreEqual(true, result.Triangle(-2, 2, 2));
        }

           [Test]
        public void TwoSidesIsNegativeIsFalse()
        {
            TriangleTest result = new TriangleTest();
            Assert.AreEqual(true, result.Triangle(-2, -2, 6));
        }
      
        [Test]
        public void OneSideEqualSumOfTwoIsFalse()
        {
            TriangleTest result = new TriangleTest();
            Assert.AreEqual(true, result.Triangle(2, 2, 4));
        }

        [Test]
        public void OneSideBiggerThanSumOfTwoIsFalse()
        {
            TriangleTest result = new TriangleTest();
            Assert.AreEqual(true, result.Triangle(2, 2, 6));
        }


        [Test]
        public void OneSideDoesntExistIsFalse()
        {
            TriangleTest result = new TriangleTest();
            Assert.AreEqual(true, result.Triangle(0, 2, 6));
        }

            [Test]
        public void TriangleDoesentExistIsFalse()
        {
            TriangleTest result = new TriangleTest();
            Assert.AreEqual(true, result.Triangle(0, 0, 0));
        }
     
        [Test]
        public void TwoSidesDoesntExistIsFalse()
        {
            TriangleTest result = new TriangleTest();
            Assert.AreEqual(true, esult.Triangle(0, 0, 6));
        }
    }
}
