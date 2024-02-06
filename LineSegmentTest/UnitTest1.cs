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
            var LineSegment = new LineSegment (1,8);

            //Act
            string result = LineSegment.ToString();

            //Assert
            Assert.AreEqual("1..8",result);
        }
    }
}