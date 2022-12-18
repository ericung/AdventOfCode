using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem15Tests
    {
        [TestMethod]
        public void IntersectTest1()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem15test1.txt");
            List<string> list = new List<string>();

            foreach(string s in strings)
            {
                if (s != string.Empty)
                {
                    list.Add(s);
                }
            }

            Problem15 problem15 = new Problem15();
            #endregion

            #region Act
            var sum = problem15.Intersect(list, 10);
            #endregion

            #region Assert
            Assert.AreEqual(26, sum);
            #endregion

        }

        [TestMethod]
        public void IntersectInput()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem15input.txt");
            List<string> list = new List<string>();

            foreach(string s in strings)
            {
                if (s != string.Empty)
                {
                    list.Add(s);
                }
            }

            Problem15 problem15 = new Problem15();
            #endregion

            #region Act
            var sum = problem15.Intersect(list, 2000000);
            #endregion

            #region Assert
            Assert.AreEqual(4951427, sum);
            #endregion

        }

        [TestMethod]
        public void TuningSignalTest1()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem15test1.txt");
            List<string> list = new List<string>();

            foreach(string s in strings)
            {
                if (s != string.Empty)
                {
                    list.Add(s);
                }
            }

            Problem15 problem15 = new Problem15();
            #endregion

            #region Act
            var sum = problem15.TuningSignal(list, 20);
            #endregion

            #region Assert
            Assert.AreEqual(56000011, sum);
            #endregion

        }

        [TestMethod]
        public void TuningSignalInput()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem15input.txt");
            List<string> list = new List<string>();

            foreach(string s in strings)
            {
                if (s != string.Empty)
                {
                    list.Add(s);
                }
            }

            Problem15 problem15 = new Problem15();
            #endregion

            #region Act
            var sum = problem15.TuningSignal(list, 4000000);
            #endregion

            #region Assert
            Assert.AreEqual(13029714573243, sum);
            #endregion

        }
    }
}
