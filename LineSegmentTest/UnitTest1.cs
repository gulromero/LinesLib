using System.Security.Cryptography.X509Certificates;
using LinesLib;
namespace LineSegmentTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToStringTest()
        {
            //Arrange
            var LineSegment = new LineSegment(1, 8);

            //Act
            string result = LineSegment.ToString();

            //Assert
            Assert.AreEqual("1..8", result);
        }

        [TestMethod]
        public void bool ContainsTest()
        {
            //Arrange
            int punkt = 0;

            //Act
            var result = LineSegment.ContainsTest();
            Assert.IsTrue(LineSegment.Contains(pointWithin),"Point should be within the line segment");

            //Assert
            int pointOutside = -1;
            Assert.IsFalse(LineSegment.Contains(pointOutside), "Point should be outside the line segment.");
        }
    }
}