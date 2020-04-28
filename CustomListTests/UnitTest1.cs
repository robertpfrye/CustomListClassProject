using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest1_AddOneValue_AddedValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTest2_AddThreeValuesToEmptyCustomList_WhatValueGoesToIndexTwo()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 10;
            int itemToAdd2 = 20;
            int itemToAdd3 = 30;
            int expected = 30;
            int actual;
            // act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            actual = testList[2];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTest3_AddOneValue_CountOfList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTest4_AddingMultipleValues_CountOfList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 10;
            int itemToAdd2 = 20;
            int itemToAdd3 = 30;
            int expected = 3;
            int actual;

            // act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }



        //Remove Tests

        [TestMethod]
        public void RemoveTest1_StartWithFourValuesRemoveOne_CheckingIndex1()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 10;
            int itemToAdd2 = 20;
            int itemToAdd3 = 30;
            int itemToAdd4 = 40;
            int expected = 30;
            int actual;

            // act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            testList.Add(itemToAdd4);
            testList.Remove(itemToAdd2);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveTest2_StartWithFourValuesRemoveOne_CehckCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 10;
            int itemToAdd2 = 20;
            int itemToAdd3 = 30;
            int itemToAdd4 = 40;
            int expected = 30;
            int actual;

            // act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            testList.Add(itemToAdd4);
            testList.Remove(itemToAdd2);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveTest3_StartWithFourValuesRemoveValue20_CheckIndex1()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 10;
            int itemToAdd2 = 20;
            int itemToAdd3 = 30;
            int itemToAdd4 = 40;
            int expected = 30;
            int actual;

            // act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            testList.Add(itemToAdd4);
            testList.Remove(20);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveTest4_StartWithFourValuesRemoveOne_CheckingIndex1()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 10;
            int itemToAdd2 = 20;
            int itemToAdd3 = 30;
            int itemToAdd4 = 40;
            int expected = 30;
            int actual;

            // act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            testList.Add(itemToAdd4);
            testList.Remove(itemToAdd2);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveTest5_StartWithOneVariableAndRemoveIt_WhatIsTheValueOfIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToRemove1 = 10;
            int expected = 0;
            int actual;

            // act
            testList.Add(itemToRemove1);
            testList.Remove(itemToRemove1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }


        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        // what happens to the last-added item?
        // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?

    }
}
