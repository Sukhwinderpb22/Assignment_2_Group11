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

        [Test]
        public void ParameterizedConstructor_LengthAndWidthSetCorrectly()
        {

            // Arrange
            int length = 7;
            int width = 10;
            var rectangle = new Rectangle(length, width);

            //Act
            int actualLength = rectangle.GetLength();
            int actualWidth = rectangle.GetWidth();

            // Assert
            Assert.AreEqual(length, actualLength);
            Assert.AreEqual(width, actualWidth);
        }

        [Test]
        public void SetLength_ValidValue_LengthUpdated()
        {

            //Arrange
            int newLength = 12;
            _rectangle.SetLength(newLength);

            //Act
            int actualLength = _rectangle.GetLength();

            //Assert
            Assert.AreEqual(newLength, actualLength);
        }

        [Test]
        public void SetWidth_ValidValue_WidthUpdated()
        {
            // Arrange
            int newWidth = 6;
            _rectangle.SetWidth(newWidth);

            //Act
            int actualLength = _rectangle.GetWidth();

            //Assert
            Assert.AreEqual(newWidth, actualLength);
        }

        [Test]
        public void GetPerimeter_ValidValues_CorrectPerimeterCalculated()
        {
            //Arrange
            int length = 5;
            int width = 8;
            _rectangle.SetLength(length);
            _rectangle.SetWidth(width);

            //Act
            int actualPerimeter = _rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(2 * (length + width), actualPerimeter);
        }

        [Test]
        public void GetArea_ValidValues_CorrectAreaCalculated()
        {
            // Arrange
            int length = 4;
            int width = 9;
            _rectangle.SetLength(length);
            _rectangle.SetWidth(width);

            // Act
            int actualArea = _rectangle.GetArea();

            // Assert
            Assert.AreEqual(length * width, actualArea);
        }


    }
}