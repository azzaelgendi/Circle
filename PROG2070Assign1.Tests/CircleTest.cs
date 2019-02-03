/*Prog 2070-Quality Assurance 
 * Winter 2019
 * Assignment 1
 * Revision History :Azza Elgendy
 * January 27,2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PROG2070Assign1;
/// <summary>
/// unit test of the circle class
/// </summary>
namespace PROG2070Assign1.Tests
{   [TestFixture]
    public class CircleTest
    {
        /// <summary>
        /// the test check if the circle defult radius is one
        /// </summary>
        [Test]
        public void GetRadiusTest()
        {
            Circle circle = new Circle();
            Assert.AreEqual(1, circle.GetRadius());
        }
        /// <summary>
        /// the test check if setting the cirlcle works
        /// given radius 3
        /// </summary>
        [Test]
        public void SetRadiusTest()
        {
            Circle circle = new Circle();
            circle.SetRadius(3);
            Assert.AreEqual(3, circle.GetRadius());

        }
        /// <summary>
        /// the test check the circle GetCircumference method
        /// </summary>
        [Test]
        public void GetCircumferenceTest()
        {
            Circle circle = new Circle();
            Assert.AreEqual((Math.PI * 2) * circle.GetRadius(), circle.GetCircumference());
        }
        /// <summary>
        /// the test check the circle GetArea
        /// </summary>
        [Test]
        public void GetAreaTest()
        {
            Circle circle = new Circle();
            Assert.AreEqual(Math.PI * circle.GetRadius() * circle.GetRadius(), circle.GetArea());
        }
    }
}
