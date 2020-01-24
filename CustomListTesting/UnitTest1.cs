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
            Assert.AreEqual(expected, customList.Capacity);
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
            Assert.AreEqual(expected, customList.Capacity);
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
            Assert.AreEqual(expected, customList.Capacity);
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
            Assert.AreEqual(expected, customList.Capacity);
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
            Assert.AreEqual(value, customList[0]);
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
            Assert.AreEqual(expectedValue, customList[4]);
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
            Assert.AreEqual(expectedValue, customList[5]);
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
            Assert.AreEqual(expectedValue, customList.Count);
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
            Assert.AreEqual(expectedValue, customList.Count);
        }
        //First Section of Remove method: Ensure status of remove is correct if list 
        [TestMethod]
        public void RemoveOneInt_CheckIfRemoved_CheckIfTrue()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 2;
            int thirdValue = 3;
            bool value;
            bool expectedValue = true;

            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            value = customList.Remove(secondValue);

            //Assert
            Assert.AreEqual(expectedValue, value);
        }
        [TestMethod]
        public void RemoveOneInt_CheckIfRemoved_CheckIfFalse()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 2;
            int thirdValue = 3;
            bool value;
            bool expectedValue = false;

            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            value = customList.Remove(5);

            //Assert
            Assert.AreEqual(expectedValue, value);
        }
        //Second Section of Remove method: Check other integers to see if they have shifted spot as intended if removal successful
        [TestMethod]
        public void RemoveOneInt_CheckIndexOne_ReturnIntended()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 2;
            int thirdValue = 3;
            int expectedValue = 3;
            int actualValue;

            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Remove(secondValue);
            actualValue = customList[1];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void RemoveOneInt_CheckIndexZero_ReturnIntended()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 2;
            int thirdValue = 3;
            int expectedValue = 1;
            int actualValue;

            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Remove(secondValue);
            actualValue = customList[0];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        //Third Section of Remove method: Checking to see if newly empty spot goes back to throw exception as intended as well as negative figures
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveOneInt_CheckIndexTwo_ThrowException()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 2;
            int thirdValue = 3;
            int actualValue;

            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Remove(secondValue);
            actualValue = customList[2];

            //Assert
            //No assert, right?
           
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckIneligibleIndex_CheckNegativeIndex_ThrowException()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
           
            int actualValue;

            //Act
            customList.Add(3);
            customList.Add(1);
            customList.Add(2);
            customList.Remove(2);
            actualValue = customList[-1];

            //Assert
            //No assert, right?

        }
        //Fourth Section of Remove method: Checking to see that count changes with remove
        [TestMethod]
        public void RemoveOneInt_CheckIfRemoved_ReturnCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 2;
            int thirdValue = 3;
            int expectedValue = 2;
            int value;
            

            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Remove(firstValue);
            value = customList.Count;

            //Assert
            Assert.AreEqual(expectedValue, value);
        }
        [TestMethod]
        public void RemoveOneInt_TwoIntsAreTheSame_ReturnCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 2;
            int thirdValue = 2;
            int fourthValue = 3;
            int expectedValue = 3;
            int value;


            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Add(fourthValue);
            customList.Remove(secondValue);
            value = customList.Count;

            //Assert
            Assert.AreEqual(expectedValue, value);
        }
        [TestMethod]
        public void RemoveOneInt_ValueNotInArray_ReturnCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 2;
            int thirdValue = 3;
            int expectedValue = 3;
            int value;

            //Act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Remove(5);
            value = customList.Count;

            //Assert
            Assert.AreEqual(expectedValue, value);
        }
        [TestMethod]
        public void ToStringStringList_ReturnString()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string expectedValue = "Abe";
            string actual;
            //Act
            customList.Add("A");
            customList.Add("b");
            customList.Add("e");
            actual = customList.ToString();

            //Assert
            Assert.AreEqual(expectedValue, actual);
        }
        [TestMethod]
        public void ToStringIntList_ReturnString()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            string expectedValue = "123";
            string actual;
            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            actual = customList.ToString();

            //Assert
            Assert.AreEqual(expectedValue, actual);
        }
        [TestMethod]
        public void TestMethodTemplate()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
