using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem06Tests
    {
        [TestMethod]
        public void FindFirstMarkerSuccessTest1()
        {

            #region Arrange
            string[] strings = Helper.GetText("problem06test1.txt");
            #endregion

            #region Act
            var results = Problem06.FindFirstMarker(strings[0]);
            #endregion

            #region Assert
            Assert.AreEqual(7, results);
            #endregion
        }

        [TestMethod]
        public void FindFirstMarkerSuccessTest2()
        {

            #region Arrange
            string[] strings = Helper.GetText("problem06test2.txt");
            #endregion

            #region Act
            var results = Problem06.FindFirstMarker(strings[0]);
            #endregion

            #region Assert
            Assert.AreEqual(5, results);
            #endregion
        }

        [TestMethod]
        public void FindFirstMarkerSuccessTest3()
        {

            #region Arrange
            string[] strings = Helper.GetText("problem06test3.txt");
            #endregion

            #region Act
            var results = Problem06.FindFirstMarker(strings[0]);
            #endregion

            #region Assert
            Assert.AreEqual(6, results);
            #endregion
        }

        [TestMethod]
        public void FindFirstMarkerSuccessTest4()
        {

            #region Arrange
            string[] strings = Helper.GetText("problem06test4.txt");
            #endregion

            #region Act
            var results = Problem06.FindFirstMarker(strings[0]);
            #endregion

            #region Assert
            Assert.AreEqual(10, results);
            #endregion
        }

        [TestMethod]
        public void FindFirstMarkerSuccessTest5()
        {

            #region Arrange
            string[] strings = Helper.GetText("problem06test5.txt");
            #endregion

            #region Act
            var results = Problem06.FindFirstMarker(strings[0]);
            #endregion

            #region Assert
            Assert.AreEqual(11, results);
            #endregion
        }

        [TestMethod]
        public void FindFirstMarkerSuccessTestInput()
        {

            #region Arrange
            string[] strings = Helper.GetText("problem06input.txt");
            #endregion

            #region Act
            var results = Problem06.FindFirstMarker(strings[0]);
            #endregion

            #region Assert
            Assert.AreEqual(1282, results);
            #endregion
        }

        [TestMethod]
        public void FindFirstMarkerSuccessTest6()
        {

            #region Arrange
            string[] strings = Helper.GetText("problem06test6.txt");
            #endregion

            #region Act
            var results = Problem06.FindFirstMarkerWithMessage(strings[0]);
            #endregion

            #region Assert
            Assert.AreEqual(19, results);
            #endregion
        }

        [TestMethod]
        public void FindFirstMarkerSuccessTest7()
        {

            #region Arrange
            string[] strings = Helper.GetText("problem06test7.txt");
            #endregion

            #region Act
            var results = Problem06.FindFirstMarkerWithMessage(strings[0]);
            #endregion

            #region Assert
            Assert.AreEqual(23, results);
            #endregion
        }

        [TestMethod]
        public void FindFirstMarkerSuccessTest8()
        {

            #region Arrange
            string[] strings = Helper.GetText("problem06test8.txt");
            #endregion

            #region Act
            var results = Problem06.FindFirstMarkerWithMessage(strings[0]);
            #endregion

            #region Assert
            Assert.AreEqual(23, results);
            #endregion
        }

        [TestMethod]
        public void FindFirstMarkerSuccessTest9()
        {

            #region Arrange
            string[] strings = Helper.GetText("problem06test9.txt");
            #endregion

            #region Act
            var results = Problem06.FindFirstMarkerWithMessage(strings[0]);
            #endregion

            #region Assert
            Assert.AreEqual(29, results);
            #endregion
        }

        [TestMethod]
        public void FindFirstMarkerSuccessTest10()
        {

            #region Arrange
            string[] strings = Helper.GetText("problem06test10.txt");
            #endregion

            #region Act
            var results = Problem06.FindFirstMarkerWithMessage(strings[0]);
            #endregion

            #region Assert
            Assert.AreEqual(26, results);
            #endregion
        }

        [TestMethod]
        public void FindFirstMarkerWithMessageInput()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem06input.txt");
            #endregion

            #region Act
            var results = Problem06.FindFirstMarkerWithMessage(strings[0]);
            #endregion

            #region Assert
            Assert.AreEqual(3513, results);
            #endregion

        }
    }
}
