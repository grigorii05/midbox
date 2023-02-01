using NUnit.Framework;
using System;
using MyLib;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Circle()
        {
            // arrange
            double radius = 5;
            const double pi = 3.14;
            double expected = radius * radius * pi;

            // act
            Circle c = new Circle(5);
            double actual = c.CalculateSquare();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Triangle()
        {
            // arrange
            double a = 3, b = 3, c = 3;
            double P = (a + b + c) / 2;
            double expected = Math.Sqrt(P * (P - a) * (P - b) * (P - c));

            // act
            Triangle t = new Triangle(3, 3, 3);
            double actual = t.CalculateSquare();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CheckTriangle()
        {
            // arrange
            int a = 5, b = 4, c = 3;
            bool expected = true;
            // act
            Triangle t = new Triangle(3, 5, 4);
            bool actual = t.isRightTriangle();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}