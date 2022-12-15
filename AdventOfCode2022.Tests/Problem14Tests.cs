using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem14Tests
    {
        [TestMethod]
        public void NumberOfSandUnitsTest1()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem14test1.txt");
            List<string> list = new List<string>();

            foreach(string s in strings)
            {
                if (s != string.Empty)
                {
                    list.Add(s);
                }
            }

            Problem14 problem14 = new Problem14();
            #endregion

            #region Act
            var sum = problem14.NumberOfSandUnits(list);
            #endregion

            #region Assert
            Assert.AreEqual(24, sum);
            #endregion
        }

        [TestMethod]
        public void NumberOfSandUnitsInput()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem14input.txt");
            List<string> list = new List<string>();

            foreach(string s in strings)
            {
                if (s != string.Empty)
                {
                    list.Add(s);
                }
            }

            Problem14 problem14 = new Problem14();
            #endregion

            #region Act
            var sum = problem14.NumberOfSandUnits(list);
            #endregion

            #region Assert
            Assert.AreEqual(592, sum);
            #endregion
        }

        [TestMethod]
        public void NumberOfSandUnits2Test1()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem14test1.txt");
            List<string> list = new List<string>();

            foreach(string s in strings)
            {
                if (s != string.Empty)
                {
                    list.Add(s);
                }
            }

            Problem14 problem14 = new Problem14();
            #endregion

            #region Act
            var sum = problem14.NumberOfSandUnits2(list);
            #endregion

            #region Assert
            Assert.AreEqual(93, sum);
            #endregion
        }

        [TestMethod]
        public void NumberOfSandUnits2Input()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem14input.txt");
            List<string> list = new List<string>();

            foreach(string s in strings)
            {
                if (s != string.Empty)
                {
                    list.Add(s);
                }
            }

            Problem14 problem14 = new Problem14();
            #endregion

            #region Act
            var sum = problem14.NumberOfSandUnits2(list);
            #endregion

            #region Assert
            Assert.AreEqual(30367, sum);
            #endregion
        }
    }
}
