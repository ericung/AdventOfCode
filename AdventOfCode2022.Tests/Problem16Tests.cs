using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem16Tests
    {
        [TestMethod]
        public void MaxFlowTest1()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem16test1.txt");
            List<string> list = new List<string>();

            foreach(string s in strings)
            {
                if (s != string.Empty)
                {
                    list.Add(s);
                }
            }

            Problem16 problem16 = new Problem16();
            #endregion

            #region Act
            var sum = problem16.MaxFlow(list);
            #endregion

            #region Assert
            Assert.AreEqual(1651, sum);
            #endregion

        }

        [TestMethod]
        public void MaxFlowInput()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem16input.txt");
            List<string> list = new List<string>();

            foreach(string s in strings)
            {
                if (s != string.Empty)
                {
                    list.Add(s);
                }
            }

            Problem16 problem16 = new Problem16();
            #endregion

            #region Act
            var sum = problem16.MaxFlow(list);
            #endregion

            #region Assert
            Assert.AreEqual(1947, sum);
            #endregion

        }

        [TestMethod]
        public void MaxFlowElephantTest1()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem16test1.txt");
            List<string> list = new List<string>();

            foreach(string s in strings)
            {
                if (s != string.Empty)
                {
                    list.Add(s);
                }
            }

            Problem16 problem16 = new Problem16();
            #endregion

            #region Act
            var sum = problem16.MaxFlowElephant(list);
            #endregion

            #region Assert
            Assert.AreEqual(1707, sum);
            #endregion

        }

        [TestMethod]
        public void MaxFlowElephantInput()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem16input.txt");
            List<string> list = new List<string>();

            foreach(string s in strings)
            {
                if (s != string.Empty)
                {
                    list.Add(s);
                }
            }

            Problem16 problem16 = new Problem16();
            #endregion

            #region Act
            var sum = problem16.MaxFlowElephant(list);
            #endregion

            #region Assert
            Assert.AreEqual(2556, sum);
            #endregion

        }
    }
}
