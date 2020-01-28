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
            bool value;
            bool expectedValue = true;

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            value = customList.Remove(2);

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
            int expectedValue = 3;
            int actualValue;

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Remove(2);
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
            int actualValue;

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Remove(2);
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
        //First Section of ToString method: Check to make sure list made of strings and integers concatenates properly
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
        //First Section of plus operator override: Check to make sure new list contains int list 123456
        [TestMethod]
        public void AddTwoIntLists_ReturnConcatenatedList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            
            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3); 
            customList2.Add(4);
            customList2.Add(5);
            customList2.Add(6);
            expectedList.Add(1);
            expectedList.Add(2);
            expectedList.Add(3);
            expectedList.Add(4);
            expectedList.Add(5);
            expectedList.Add(6);

            newList = customList + customList2;

            //Assert
            Assert.AreEqual(expectedList.ToString(), newList.ToString());
        }
        //Second Section of plus operator override: When adding two lists of unequal size, make sure to return correct tostring()
        [TestMethod]
        public void AddTwoIntLists_ListAreNotEqualInSize_ReturnConcatenatedList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();

            //Act
            customList.Add(1);
            customList.Add(2);
            customList2.Add(4);
            customList2.Add(5);
            customList2.Add(6);
            expectedList.Add(1);
            expectedList.Add(2);
            expectedList.Add(4);
            expectedList.Add(5);
            expectedList.Add(6);

            newList = customList + customList2;

            //Assert
            Assert.AreEqual(expectedList.ToString(), newList.ToString());
        }
        //Third Section of plus operator override: When adding two lists of unequal size, make sure to return correct count
        [TestMethod]
        public void AddTwoIntLists_ListAreNotEqualInSize_ReturnCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();

            //Act
            customList.Add(1);
            customList.Add(2);
            customList2.Add(4);
            customList2.Add(5);
            customList2.Add(6);
            expectedList.Add(1);
            expectedList.Add(2);
            expectedList.Add(4);
            expectedList.Add(5);
            expectedList.Add(6);

            newList = customList + customList2;

            //Assert
            Assert.AreEqual(expectedList.Count, newList.Count);
        }
        //Fourth Section of plus operator override: Throw exception when index is not in use
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddTwoIntLists_CheckSpotOutideOfList_ThrowException()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList2.Add(4);
            customList2.Add(5);
            customList2.Add(6);

            newList = customList + customList2;
            Console.WriteLine(newList[6]);
        }
        //First Section of subtract operator override: Ensure whole list changed adequately after removal
        [TestMethod]
        public void SubtractListTwoFromListOne_ReturnList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();

            //Act
            customList.Add(1); customList.Add(2); customList.Add(3); customList.Add(4); customList.Add(5); customList.Add(6);
            customList2.Add(10); customList2.Add(3); customList2.Add(12);
            expectedList.Add(1);
            expectedList.Add(2);
            expectedList.Add(4);
            expectedList.Add(5);
            expectedList.Add(6);

            newList = customList - customList2;

            //Assert
            Assert.AreEqual(expectedList.ToString(), newList.ToString());
        }
        //Second Section of subtract operator override: Ensure spot where removal takes place and return adjusted count
        [TestMethod]
        public void SubtractListTwoFromListOne_ReturnCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            //Act
            customList.Add(1); customList.Add(2); customList.Add(3); customList.Add(4); customList.Add(5); customList.Add(6);
            customList2.Add(10); customList2.Add(3); customList2.Add(12);

            newList = customList - customList2;

            //Assert
            Assert.AreEqual(5, newList.Count);
        }
        //Third Section of subtract operator override: Removal of more than one figure to make sure removal takes place on multiple figures
        [TestMethod]
        public void SubtractListTwoFromListOne_TwoValuesToBeRemoved_ReturnList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();

            //Act
            customList.Add(1); customList.Add(2); customList.Add(3); customList.Add(4); customList.Add(5); customList.Add(6);
            customList2.Add(2); customList2.Add(3);
            expectedList.Add(1);
            expectedList.Add(4);
            expectedList.Add(5);
            expectedList.Add(6);

            newList = customList - customList2;

            //Assert
            Assert.AreEqual(expectedList.ToString(), newList.ToString());
        }
        //Fourth Section of subtract operator override: Removal of value that appears twice in list
        [TestMethod]
        public void SubtractListTwoFromListOne_TwoValuesToBeRemoveAreTheSame_ReturnList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 5,3,3,3,4,3,5,6};
            CustomList<int> customList2 = new CustomList<int>() { 2,3};
            CustomList<int> newList = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>() { 5,4,5,6};

            //Act
            newList = customList - customList2;

            //Assert
            Assert.AreEqual(expectedList.ToString(), newList.ToString());
        }
        //Fifth Section of subtract operator override: Removal of non-matching figures, list should come back the same
        [TestMethod]
        public void SubtractTwoList_NoValuesMatch_ReturnList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 1,2,3,4,5,6};
            CustomList<int> customList2 = new CustomList<int>() { 10,20,12};
            CustomList<int> newList = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>() { 1,2,3,4,5,6};

            //Act
            newList = customList - customList2;

            //Assert
            Assert.AreEqual(expectedList.ToString(), newList.ToString());
        }
        //First Section of Zip method:First and second list zip, checking to see 
        [TestMethod]
        public void ZipTwoLists_TwoListZip_ReturnNewList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 3, 5};
            CustomList<int> customList2 = new CustomList<int>() { 2,4,6 };
            
            CustomList<int> expectedList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

            //Act
            customList.Zip(customList2);

            //Assert
            Assert.AreEqual(expectedList.ToString(), customList.ToString());
        }
        //Second Section of Zip method:Ensure count has adequately changed after zip 
        [TestMethod]
        public void ZipTwoLists_TwoListZip_ReturnCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 4, 6 };

            CustomList<int> expectedList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

            //Act
            customList.Zip(customList2);

            //Assert
            Assert.AreEqual(expectedList.Count, customList.Count);
        }
        //Second Section of Zip method:Ensure count has adequately changed after zip 
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ZipTwoLists_SelectOutOfRange_ThrowException()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 4, 6 };

            CustomList<int> expectedList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

            //Act
            customList.Zip(customList2);
            Console.WriteLine(customList[6]);
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
