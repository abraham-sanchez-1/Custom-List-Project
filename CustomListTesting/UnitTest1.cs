using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List;

namespace CustomListTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddOneInt_CheckZeroIndex_ReturnIndex0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 3;

            //Act
            customList.Add(value);

            //Assert
            Assert.AreEqual(value, customList[0]);
        }
        [TestMethod]
        public void AddOneInt_CheckCapacity_ReturnCapacity()
        {
            //Arrange Check to see that list is empty
            CustomList<int> customList = new CustomList<int>();
            int value = 1;
            int expected = 5;
            //Act
            customList.Add(value);

            //Assert
            Assert.AreEqual(expected, customList.Capacity());
        }
        [TestMethod]
        public void AddFourInt_CheckCapacity_ReturnCapacity()
        {
            //Arrange Check to see that list is empty
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int fourthValue = 7;
            int expected = 5;
            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Add(fourthValue);

            //Assert
            Assert.AreEqual(expected, customList.Capacity());
        }
        [TestMethod]
        public void AddFiveInt_CheckCapacity_ReturnCapacity()
        {
            //Arrange Check to see that list is empty
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int fourthValue = 7;
            int fifthValue = 9;
            int expected = 10;
            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Add(fourthValue);
            customList.Add(fifthValue);

            //Assert
            Assert.AreEqual(expected, customList.Capacity());
        }
        [TestMethod]
        public void AddTwoInt_CheckIndexOne_ReturnIndexOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 3;
            int expectedValue = 3;

            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);

            //Assert
            Assert.AreEqual(expectedValue, customList[1]);
        }
        [TestMethod]
        public void AddThreeInt_CheckIndexOne_ReturnIndexOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int expectedValue = 3;

            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);

            //Assert
            Assert.AreEqual(expectedValue, customList[1]);
        }
        [TestMethod]
        public void AddThreeInt_CheckIndexTwo_ReturnIndexTwo()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int expectedValue = 5;

            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);

            //Assert
            Assert.AreEqual(expectedValue, customList[2]);
        }

        [TestMethod]
        public void AddTwoInt_CheckCount_ReturnCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 3;
            int expectedValue = 1;
            //Act
            customList.Add(value);

            //Assert
            Assert.AreEqual(expectedValue, customList.Count);
        }
        [TestMethod]
        public void AddTwoInt_CheckCount_ReturnCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 5;
            int expectedValue = 2;
            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);

            //Assert
            Assert.AreEqual(expectedValue, customList.Count);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange

            //Act

            //Assert
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
