using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List;

namespace CustomListTesting
{
    [TestClass]
    public class UnitTest1
    {  
        //First section of Add method: Checks capacity changes, once you add the sixth item, capacity increases by 5
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
            Assert.AreEqual(expected, customList.capacity);
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
            Assert.AreEqual(expected, customList.capacity);
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
            Assert.AreEqual(expected, customList.capacity);
        }
        [TestMethod]
        public void AddSixInt_CheckCapacity_ReturnCapacity()
        {
            //Arrange Check to see that list is empty
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int fourthValue = 7;
            int fifthValue = 9;
            int sixthValue = 11;
            int expected = 10;
            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Add(fourthValue);
            customList.Add(fifthValue);
            customList.Add(sixthValue);

            //Assert
            Assert.AreEqual(expected, customList.capacity);
        }
        //Second section of Add method: Checks that each index holds correct number based on qty of ints added
        [TestMethod]
        public void AddOneInt_CheckZeroIndex_ReturnIndexZero()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 3;

            //Act
            customList.Add(3);

            //Assert
            Assert.AreEqual(value, customList.array[0]);
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
            Assert.AreEqual(expectedValue, customList.array[1]);
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
            Assert.AreEqual(expectedValue, customList.array[1]);
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
            Assert.AreEqual(expectedValue, customList.array[2]);
        }
        [TestMethod]
        public void AddSixInt_CheckIndexFour_ReturnIndexFour()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int fourthValue = 7;
            int fifthValue = 9;
            int sixthValue = 11;
            int expectedValue = 9;

            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Add(fourthValue);
            customList.Add(fifthValue);
            customList.Add(sixthValue);

            //Assert
            Assert.AreEqual(expectedValue, customList.array[4]);
        }
        [TestMethod]
        public void AddSixInt_CheckIndexFive_ReturnIndexFive()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int fourthValue = 7;
            int fifthValue = 9;
            int sixthValue = 11;
            int expectedValue = 11;

            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Add(fourthValue);
            customList.Add(fifthValue);
            customList.Add(sixthValue);

            //Assert
            Assert.AreEqual(expectedValue, customList.array[5]);
        }
        //Third seciton of Add method: Checks that count is being accurate regardless of how many pieces of data are added
        [TestMethod]
        public void AddOneInt_CheckCount_ReturnCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 3;
            int expectedValue = 1;
            //Act
            customList.Add(value);

            //Assert
            Assert.AreEqual(expectedValue, customList.count);
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
            Assert.AreEqual(expectedValue, customList.count);
        }
        [TestMethod]
        public void AddFiveInt_CheckCount_ReturnCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int fourthValue = 7;
            int fifthValue = 9;
            int expectedValue = 5;
            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Add(fourthValue);
            customList.Add(fifthValue);

            //Assert
            Assert.AreEqual(expectedValue, customList.count);
        }
        [TestMethod]
        public void AddSixInt_CheckCount_ReturnCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int fourthValue = 7;
            int fifthValue = 9;
            int sixthValue = 11;
            int expectedValue = 6;
            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Add(fourthValue);
            customList.Add(fifthValue);
            customList.Add(sixthValue);

            //Assert
            Assert.AreEqual(expectedValue, customList.count);
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
