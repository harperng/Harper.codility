using Microsoft.VisualStudio.TestTools.UnitTesting;
using Harper.Codiliy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harper.Codiliy.Tests
{
    [TestClass()]
    public class BinaryGapTests
    {
        [TestMethod()]
        public void SolutionTest_0()
        {
            var solution = new BinaryGap();

            int N = 0;

            int expected =0;
            int actual = solution.Solution(N);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_1()
        {
            var solution = new BinaryGap();

            int N = 1;

            int expected = 0;
            int actual = solution.Solution(N);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_1041()
        {
            var solution = new BinaryGap();

            int N = 1041;

            int expected = 5;
            int actual = solution.Solution(N);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_32()
        {
            var solution = new BinaryGap();

            int N = 32;
            int expected = 0;
            int actual = solution.Solution(N);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SolutionTest_15()
        {
            var solution = new BinaryGap();

            int N = 15;

            int expected = 0;
            int actual = solution.Solution(N);

            Assert.AreEqual(expected, actual);
        }
    }
}