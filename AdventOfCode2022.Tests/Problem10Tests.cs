using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem10Tests
    {
        [TestMethod]
        public void SignalStrengthTest1()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem10test1.txt");
            List<string[]> list = new List<string[]>();

            foreach (string s in strings)
            {
                if (s != string.Empty)
                {
                    string[] line = s.Split(' ');
                    list.Add(line);
                }
                else
                {
                    break;
                }
            }

            Problem10 problem10 = new Problem10();
            #endregion

            #region Act
            var strength = problem10.SignalStrength(list);
            #endregion

            #region Assert
            Assert.AreEqual(-720, strength);
            #endregion
        }

        [TestMethod]
        public void SignalStrengthTest2()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem10test2.txt");
            List<string[]> list = new List<string[]>();

            foreach (string s in strings)
            {
                if (s != string.Empty)
                {
                    string[] line = s.Split(' ');
                    list.Add(line);
                }
                else
                {
                    break;
                }
            }

            Problem10 problem10 = new Problem10();
            #endregion

            #region Act
            var strength = problem10.SignalStrength(list);
            #endregion

            #region Assert
            Assert.AreEqual(13140, strength);
            #endregion
        }

        [TestMethod]
        public void SignalStrengthInput()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem10input.txt");
            List<string[]> list = new List<string[]>();

            foreach (string s in strings)
            {
                if (s != string.Empty)
                {
                    string[] line = s.Split(' ');
                    list.Add(line);
                }
                else
                {
                    break;
                }
            }

            Problem10 problem10 = new Problem10();
            #endregion

            #region Act
            var strength = problem10.SignalStrength(list);
            #endregion

            #region Assert
            Assert.AreEqual(11720, strength);
            #endregion
        }

        [TestMethod]
        public void RenderTest2()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem10test2.txt");
            List<string[]> list = new List<string[]>();

            foreach (string s in strings)
            {
                if (s != string.Empty)
                {
                    string[] line = s.Split(' ');
                    list.Add(line);
                }
                else
                {
                    break;
                }
            }

            Problem10 problem10 = new Problem10();
            #endregion

            #region Act
            var screen = problem10.Render(list);
            #endregion

            #region Assert
            Assert.AreEqual("##..##..##..##..##..##..##..##..##..##..\r\n###...###...###...###...###...###...###.\r\n####....####....####....####....####....\r\n#####.....#####.....#####.....#####.....\r\n######......######......######......####\r\n#######.......#######.......#######.....", 
                screen);
            #endregion
        }

        [TestMethod]
        public void RenderInput()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem10input.txt");
            List<string[]> list = new List<string[]>();

            foreach (string s in strings)
            {
                if (s != string.Empty)
                {
                    string[] line = s.Split(' ');
                    list.Add(line);
                }
                else
                {
                    break;
                }
            }

            Problem10 problem10 = new Problem10();
            #endregion

            #region Act
            var screen = problem10.Render(list);
            #endregion

            #region Assert
            Assert.AreEqual("####.###...##..###..####.###...##....##.\r\n#....#..#.#..#.#..#.#....#..#.#..#....#.\r\n###..#..#.#....#..#.###..#..#.#.......#.\r\n#....###..#....###..#....###..#.......#.\r\n#....#.#..#..#.#.#..#....#....#..#.#..#.\r\n####.#..#..##..#..#.####.#.....##...##..", 
                screen);
            #endregion
        }
    }
}
