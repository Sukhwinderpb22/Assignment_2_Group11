using NUnit.Framework;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Assignment_2_Group11.Tests
{

    public class RectangleTest
    {
        private Rectangle _rectangle = null;

        [SetUp]
        public void Setup()
        {
            _rectangle = new Rectangle();
        }

        [Test]
        public void DefaultConstructor_LengthAndWidthSetToOne()
        {
            // Arrange
            int length = 1;
            int width = 1;
            var rectangle = new Rectangle();

            //Act
            int actualLength = rectangle.GetLength();
            int actualWidth = rectangle.GetWidth();

            // Assert
            Assert.AreEqual(length, actualLength);
            Assert.AreEqual(width, actualWidth);
        }

        
    }
}
