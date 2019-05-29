using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assignment1;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RectangleTest
{
    [TestFixture]
    public class RectangleTest
    {
        [Test]
        public void GetLength_Input5and0_Returns5()
        {

            //Arrange
            int length = 5;
            int width = 0;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            int actualResult = testRectangle.GetLength();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetWidth_Input4and0_Returns4()
        {

            //Arrange
            int length = 0;
            int width = 4;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            int actualResult = testRectangle.GetWidth();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void SetLength_Input4and3asInitialDimensionsAndSetLengthAs_Returns5()
        {
            //Arrange
            int len = 4;
            int wid = 3;
            int testlength = 5;
            int expectedResult = testlength;
            Rectangle testRectangle = new Rectangle(len, wid);

            //Act
            int actualResult = testRectangle.SetLength(testlength);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        public void SetWidth_Input2and3asInitialDimensionsAndSetLengthAs_Returns7()
        {
            //Arrange
            int len = 2;
            int wid = 3;
            int testlength = 7;
            int expectedResult = testlength;
            Rectangle testRectangle = new Rectangle(len, wid);

            //Act
            int actualResult = testRectangle.SetWidth(testlength);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input_Length2And_Width3_Returns10()
        {

            //Arrange
            int length = 2;
            int width = 3;

            int expectedResult = 2 * (length + width);

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            int actualResult = testRectangle.GetPerimeter();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input_Length6And_Width6_Returns36()
        {

            //Arrange
            int length = 6;
            int width = 6;

            int expectedResult = (length * width);

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            int actualResult = testRectangle.GetArea();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
