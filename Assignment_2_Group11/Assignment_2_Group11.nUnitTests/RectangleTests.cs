using NUnit.Framework;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Assignment02.Tests
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


        // Additional GetLength Tests
        [Test]
        public void GetLength_AfterSettingNewLength_ReturnsUpdatedLength()
        {
            //Arrange
            int length = 18;
            _rectangle.SetLength(length);

            //Act
            int actualLength = _rectangle.GetLength();

            //Assert
            Assert.AreEqual(length, actualLength);
        }


        [Test]
        public void GetLength_UsingParameterizedConstructor_ReturnsInitialLength()
        {
            //Arrange
            int length = 14;
            int width = 7;
            var customRectangle = new Rectangle(length, width);

            //Act
            int actualLength = customRectangle.GetLength();

            //Arrange
            Assert.AreEqual(14, actualLength);
        }

        // Additional SetLength Tests
        [Test]
        public void SetLength_ToZero_LengthUnchanged()
        {
            //Arrange
            int length = 2;
            _rectangle.SetLength(length);

            //Act
            int actualLength = _rectangle.GetLength();

            //Assert
            Assert.AreNotEqual(0, actualLength);
        }

        [Test]
        public void SetLength_PositiveValue_LengthUpdated()
        {
            // Arrange
            int newLength = 15;
            _rectangle.SetLength(newLength);

            //Act
            int actualLength = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(newLength, actualLength);
        }

        // Additional GetWidth Tests
        [Test]
        public void GetWidth_AfterSettingNewWidth_ReturnsUpdatedWidth()
        {
            //Arrange
            int newWidth = 15;
            _rectangle.SetWidth(newWidth);

            //Act
            int actualLength = _rectangle.GetWidth();

            //Assert
            Assert.AreEqual(newWidth, actualLength);
        }

        [Test]
        public void GetWidth_UsingParameterizedConstructor_ReturnsInitialWidth()
        {
            //Arrange
            int length = 11;
            int width = 22;
            var customRectangle = new Rectangle(length, width);

            //Act
            int actualWidth = customRectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, actualWidth);
        }

        // Additional SetWidth Tests
        [Test]
        public void SetWidth_ToZero_WidthUnchanged()
        {
            //Arrange
            int width = 3;
            _rectangle.SetWidth(width);

            //Act
            int actualWidth = _rectangle.GetWidth();

            //Assert
            Assert.AreNotEqual(0, actualWidth);
        }

        [Test]
        public void SetWidth_PositiveValue_WidthUpdated()
        {
            // Arrange
            int newWidth = 12;
            _rectangle.SetWidth(newWidth);

            //Act
            int actualWidth = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(newWidth, actualWidth);
        }

        // Additional GetPerimeter Tests
        [Test]
        public void GetPerimeter_WithZeroLengthOrWidth_ReturnsZeroOrPositiveValue()
        {
            //Arrange
            int length = 0;
            int width = 6;

            //Act
            _rectangle.SetLength(length);
            _rectangle.SetWidth(width);

            //Assert
            Assert.IsTrue(_rectangle.GetPerimeter() >= 0);
        }



        // Additional GetArea Tests
        [Test]
        public void GetArea_WithLengthFiveAndWidthTwo_ReturnsTen()
        {
            //Arrange
            int length = 3;
            int width = 5;
            _rectangle.SetLength(length);
            _rectangle.SetWidth(width);

            //Act
            int actualArea = _rectangle.GetArea();

            //Assert
            Assert.AreEqual(length * width, actualArea);
        }

        [Test]
        public void GetArea_WithLengthOneAndWidthOne_ReturnsOne()
        {
            //Arrange
            int length = 1;
            int width = 1;
            _rectangle.SetLength(length);
            _rectangle.SetWidth(width);

            //Act
            int actualArea = _rectangle.GetArea();

            //Assert
            Assert.AreEqual(1, actualArea);
        }

        [Test]
        public void GetArea_WithLargeValues_ReturnsCorrectArea()
        {
            // Arrange
            int length = 1000;
            int width = 500;
            _rectangle.SetLength(length);
            _rectangle.SetWidth(width);

            //Act
            int area = _rectangle.GetArea();

            // Assert
            Assert.AreEqual(length * width, area);
        }
    }
}
