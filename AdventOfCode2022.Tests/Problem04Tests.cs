using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem04Tests
    {
        [TestMethod]
        public void OverlappingPairsTest()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem04input.txt");
            
            List<IList<int>> list = new List<IList<int>>();

            foreach (string s in strings)
            {
                if (s != String.Empty)
                {
                    string[] pairs = s.Split(',');
                    List<int> newList = new List<int>();
                    foreach (string pair in pairs)
                    {
                        string[] pairNum = pair.Split('-');
                        newList.Add(Convert.ToInt32(pairNum[0]));
                        newList.Add(Convert.ToInt32(pairNum[1]));
                    }
                    list.Add(newList);
                }
            }

            Problem04 problem04= new Problem04();
            #endregion

            #region Act
            var score = problem04.OverlappingPairs(list);
            #endregion

            #region Assert
            Assert.AreEqual(542, score);
            #endregion

        }

        [TestMethod]
        public void OverlappingPairs2Test()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem04input.txt");
            
            List<IList<int>> list = new List<IList<int>>();

            foreach (string s in strings)
            {
                if (s != String.Empty)
                {
                    string[] pairs = s.Split(',');
                    List<int> newList = new List<int>();
                    foreach (string pair in pairs)
                    {
                        string[] pairNum = pair.Split('-');
                        newList.Add(Convert.ToInt32(pairNum[0]));
                        newList.Add(Convert.ToInt32(pairNum[1]));
                    }
                    list.Add(newList);
                }
            }

            Problem04 problem04= new Problem04();
            #endregion

            #region Act
            var score = problem04.OverlappingPairs2(list);
            #endregion

            #region Assert
            Assert.AreEqual(900, score);
            #endregion

        }
    }
}
