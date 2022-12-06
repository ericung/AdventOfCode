using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem03Tests
    {
        [TestMethod]
        public void FindPriorityInput()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem03input.txt");
            
            List<string> list = new List<string>();

            foreach (string s in strings)
            {
                if (s != String.Empty)
                {
                    list.Add(s);
                }
            }

            Problem03 problem03= new Problem03();
            #endregion

            #region Act
            var score = problem03.FindPriority(list);
            #endregion

            #region Assert
            Assert.AreEqual(7811, score);
            #endregion

        }

        [TestMethod]
        public void FindPriorityElfGroupInput()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem03input.txt");
            
            List<string> list = new List<string>();

            foreach (string s in strings)
            {
                if (s != String.Empty)
                {
                    list.Add(s);
                }
            }

            Problem03 problem03= new Problem03();
            #endregion

            #region Act
            var score = problem03.FindPriorityGroup(list);
            #endregion

            #region Assert
            Assert.AreEqual(2639, score);
            #endregion

        }
    }
}
