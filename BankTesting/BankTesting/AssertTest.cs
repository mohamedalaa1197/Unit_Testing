using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTesting
{
    [TestClass]
    public class AssertTest
    {
        [TestMethod]
        public void Assert_Inconclusive()
        {
            //Arrange

            //Act

            //Assert
            Assert.Inconclusive(); // this indicates that the function still in progress (not finished implemented) 
        }

        [TestMethod]
        public void Assert_Containes()
        {
            //Arrange
            string superString = "ABCDEFGH";
            string subString = "CD";
            //Act

            //Assert
            StringAssert.Contains(superString, subString, $"{superString} DOESN'T Contain {subString}");
        }

        [TestMethod]
        public void Test_AreEqual_Passes()
        {
            //Arrange

            List<string> expected = new List<string> { "A", "B", "C", "D" };

            List<string> actual = new List<string> { "A", "B", "C", "D" };

            //Act

            //Assert
            // it consider the arrange
            CollectionAssert.AreEqual(expected, actual, "Not the same");
        }

        [TestMethod]
        public void Test_ListsSubSet_Passes()
        {
            //Arrange

            List<string> superList = new List<string> { "A", "B", "C", "D" };

            List<string> setList = new List<string> { "A", "B", "C" };

            //Act

            //Assert
            // it consider the arrange
            CollectionAssert.IsSubsetOf(setList, superList, "Doesn't contain");
        }
    }
}
