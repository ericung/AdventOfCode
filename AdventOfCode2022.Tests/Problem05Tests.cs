using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem05Tests
    {
        [TestMethod]
        public void MoveCratesSuccess()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem05input.txt");
            
            List<Stack<char>> stacks = new List<Stack<char>>();
            int i = 0;
            
            while (strings[i] != String.Empty)
            {
                i++;
            }

            string[] stackStr = strings[i - 1].Split(" ");

            foreach(string s in stackStr)
            {
                if (s != string.Empty)
                {
                    stacks.Add(new Stack<char>());
                }
            }

            for (int k = i - 2; k >= 0; k--)
            {
                for (int j = 1, s = 0; j < strings[k].Length; j+=4, s++)
                {
                    if (strings[k][j] != ' ')
                    {
                        stacks[s].Push(strings[k][j]);
                    }
                }
            }

            i++;
            List<IList<int>> moves = new List<IList<int>>();
            for (int k = i; k < strings.Length; k++)
            {
                if (strings[k] == String.Empty)
                {
                    break;
                }

                List<int> move = new List<int>();
                var nums = strings[k].Split(" ");
                move.Add(Convert.ToInt32(nums[1]));
                move.Add(Convert.ToInt32(nums[3]));
                move.Add(Convert.ToInt32(nums[5]));
                moves.Add(move);
            }
            #endregion

            #region Act
            var results = Problem05.MoveCrates(stacks, moves);
            #endregion

            #region Assert
            Assert.AreEqual(results, new string("VRWBSFZWM"));
            #endregion
        }

        [TestMethod]
        public void MoveCrates9001Success()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem05input.txt");
            
            List<Stack<char>> stacks = new List<Stack<char>>();
            int i = 0;
            
            while (strings[i] != String.Empty)
            {
                i++;
            }

            string[] stackStr = strings[i - 1].Split(" ");

            foreach(string s in stackStr)
            {
                if (s != string.Empty)
                {
                    stacks.Add(new Stack<char>());
                }
            }

            for (int k = i - 2; k >= 0; k--)
            {
                for (int j = 1, s = 0; j < strings[k].Length; j+=4, s++)
                {
                    if (strings[k][j] != ' ')
                    {
                        stacks[s].Push(strings[k][j]);
                    }
                }
            }

            i++;
            List<IList<int>> moves = new List<IList<int>>();
            for (int k = i; k < strings.Length; k++)
            {
                if (strings[k] == String.Empty)
                {
                    break;
                }

                List<int> move = new List<int>();
                var nums = strings[k].Split(" ");
                move.Add(Convert.ToInt32(nums[1]));
                move.Add(Convert.ToInt32(nums[3]));
                move.Add(Convert.ToInt32(nums[5]));
                moves.Add(move);
            }
            #endregion

            #region Act
            var results = Problem05.MoveCrates9001(stacks, moves);
            #endregion

            #region Assert
            Assert.AreEqual(results, new string("RBTWJWMCF"));
            #endregion
        }

    }
}
