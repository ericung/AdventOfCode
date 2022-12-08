using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem08Tests
    {
        [TestMethod]
        public void VisibleTreesTest1()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem08test1.txt");
            List<IList<int>> list = new List<IList<int>>();

            foreach(string s in strings)
            {
                List<int> line = new List<int>();
                foreach(char c in s)
                {
                    line.Add(Convert.ToInt32(c));
                }
                list.Add(line);
            }
            Problem08 problem = new Problem08();
            #endregion

            #region Act
            int sum = problem.VisibleTrees(list);
            #endregion

            #region Assert
            Assert.AreEqual(21, sum);
            #endregion
        }

        [TestMethod]
        public void VisibleTreesInput()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem08input.txt");
            List<IList<int>> list = new List<IList<int>>();

            foreach(string s in strings)
            {
                if (s != String.Empty)
                {
                    List<int> line = new List<int>();
                    foreach(char c in s)
                    {
                        line.Add(Convert.ToInt32(c));
                    }
                    list.Add(line);
                }
            }
            Problem08 problem = new Problem08();
            #endregion

            #region Act
            int sum = problem.VisibleTrees(list);
            #endregion

            #region Assert
            Assert.AreEqual(1829, sum);
            #endregion
        }

        [TestMethod]
        public void ScenicScoreTest1()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem08test1.txt");
            List<IList<int>> list = new List<IList<int>>();

            foreach(string s in strings)
            {
                List<int> line = new List<int>();
                foreach(char c in s)
                {
                    line.Add(Convert.ToInt32(c));
                }
                list.Add(line);
            }
            Problem08 problem = new Problem08();
            #endregion

            #region Act
            int sum = problem.ScenicScore(list);
            #endregion

            #region Assert
            Assert.AreEqual(8, sum);
            #endregion
        }

        [TestMethod]
        public void ScenicScoreInput()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem08input.txt");
            List<IList<int>> list = new List<IList<int>>();

            foreach(string s in strings)
            {
                if (s != String.Empty)
                {
                    List<int> line = new List<int>();
                    foreach(char c in s)
                    {
                        line.Add(Convert.ToInt32(c));
                    }
                    list.Add(line);
                }
            }
            Problem08 problem = new Problem08();
            #endregion

            #region Act
            int sum = problem.ScenicScore(list);
            #endregion

            #region Assert
            Assert.AreEqual(291840, sum);
            #endregion
        }

    }
}
